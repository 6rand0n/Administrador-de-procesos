using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOProyecto.Program;
using System.Timers;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;
using System;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
using System.Text;

namespace SOProyecto
{

    public partial class Form1 : Form
    {

        static public int memoria = 4096;
        private List<Proceso> procesos = new List<Proceso>();
        private System.Timers.Timer ejecucionTimer;
        private int tiempoDeVida = 10;
        private int procesoIndex = 0;
        private int tiempoTerminado = 5;
        static public int tiempoCambioEstado = 1;
        int contador = 0, procesamiento = 1000, maxProce = 5000, memoriaMax = 512;
        int intervalo = 1;
        private AsignadorMemoria asignador;


        private decimal totalTimepoEnAtencion = 0; //suma total para el tiempo de ejecucion
        private int totalDeProcesosAtendidos = 0; //suma total de los procesos que fueron atendidos

        public Form1()
        {
            InitializeComponent();
            Log.Text = "[0, 4096, 0]";
            asignador = new AsignadorMemoria(4096);
            lbMemoria.Text = Convert.ToString(memoria);

            // Inicializamos el timer con un intervalo base
            ejecucionTimer = new System.Timers.Timer(1000);
            ejecucionTimer.Elapsed += OnTimedEvent;
            ejecucionTimer.AutoReset = true;
            ejecucionTimer.Start();

            btnResumeSimulation.Enabled = false; // Solo se habilita cuando está detenida la simulación
            btnClearProcesses.Enabled = false;

            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            lblSpeed.Text = "Velocidad: x" + trackBarSpeed.Value.ToString();
        }



      
        private string ObtenerEstadoMemoria()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var bloque in asignador.ObtenerBloquesMemoria())
            {
                string estado = bloque.EstaLibre ? "[0," : $"[{bloque.ProcesoID},";
                sb.Append($"{estado}{bloque.Tamaño},{bloque.EstaLibre}]");
            }
            return sb.ToString();
        }



        private void OnTimedEvent(System.Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Generación de procesos aleatorios
                Proceso nuevoProceso = GeneracionDeProcesos();
                AgregarProceso(nuevoProceso);

                // Asignar memoria al nuevo proceso
                if (asignador.AsignarMemoria(nuevoProceso.ID, nuevoProceso.Memoria, nuevoProceso.TiempoEjecucion))
                {
                    Log.Text += ObtenerEstadoMemoria();
                    memoria -= nuevoProceso.Memoria;
                    lbMemoria.Text = memoria.ToString();
                }

                // Ejecutar un solo proceso a la vez
                if (procesos.Count > 0)
                {
                    // Seleccionar el primer proceso de la lista para ejecutarlo (Round Robin)
                    var proceso = procesos[0];
                    ActualizarSwap(proceso);

                    // Cambiar estado del proceso de forma aleatoria
                    Random random = new Random();
                    int estadoAleatorio = random.Next(0, 3); // 0 = Ready, 1 = Running, 2 = Blocked

                    if (estadoAleatorio == 0)
                        proceso.Estado = "Ready";
                    else if (estadoAleatorio == 1)
                        proceso.Estado = "Running";
                    else
                        proceso.Estado = "Blocked";

                    MostrarProceso();

                    if (proceso.Estado == "Running" && proceso.TiempoRestante > 0)
                    {
                        Log.Text += $"\nAtendiendo proceso [{proceso.ID},{proceso.Memoria},{proceso.TiempoRestante}]\n";

                        if (!proceso.TiempoInicio.HasValue)
                        {
                            proceso.TiempoInicio = DateTime.Now;
                        }

                        proceso.TiempoEjecucion -= trackBarSpeed.Value * proceso.Procesamiento;
                        proceso.TiempoRestante = proceso.TiempoEjecucion / trackBarSpeed.Value;
                        MostrarProceso();
                    }

                    if (proceso.TiempoEjecucion <= 0 && proceso.Estado != "Terminado")
                    {
                        proceso.Estado = "Terminado";
                        proceso.TiempoTerminado = tiempoTerminado;

                        asignador.liberarMemoria(proceso.ID);
                        memoria += proceso.Memoria;
                        lbMemoria.Text = memoria.ToString();

                        if (proceso.TiempoInicio.HasValue)
                        {
                            TimeSpan tiempoDeAtencion = DateTime.Now - proceso.TiempoInicio.Value;
                            totalTimepoEnAtencion += (decimal)tiempoDeAtencion.TotalSeconds;
                            totalDeProcesosAtendidos++;
                        }

                        procesos.RemoveAt(0); // Eliminar el proceso ejecutado
                        ActualizarContador();
                    }
                }

                if (procesos.Count == 0)
                {
                    ejecucionTimer.Stop();
                    btnResumeSimulation.Enabled = false;
                    btnClearProcesses.Enabled = false;
                }

                MostrarEstadistica();
                MostrarProceso();

                Log.Text += "\nImpresión final de ciclo:\n";
                Log.Text += ObtenerEstadoMemoria() + "\n";
            });
        }




        private void ActualizarSwap(Proceso proceso)
        {
            Random random = new Random();

            if (proceso.Estado == "Running")
            {
                if (random.Next(0, 10) < 3) // 30% de probabilidad que ocurra esto
                {
                    proceso.Swap = "En swap";
                }
                else
                {
                    proceso.Swap = "En memoria";
                }
            }
            else if (proceso.Estado == "Ready")
            {
                proceso.Swap = "En espera";
            }
            else if (proceso.Estado == "Blocked")
            {
                proceso.Swap = "En espera";
            }
            else if (proceso.Estado == "Terminado")
            {
                proceso.Swap = "Finalizado";
            }
        }

        private void MostrarProceso()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(MostrarProceso));
                return;
            }

            dataGridView1.Rows.Clear();
            if (procesos.Count == 0)
            {
                MessageBox.Show("No hay procesos para mostrar.");
                return;
            }

            foreach (var proceso in procesos)
            {
                int rowIndex = dataGridView1.Rows.Add(proceso.ID, proceso.Nombre, proceso.Memoria, proceso.CPU, proceso.TiempoEjecucion, proceso.Estado, proceso.Swap, proceso.TiempoRestante);

                if (proceso.Estado == "Inicializando")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (proceso.Estado == "Ejecutando")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (proceso.Estado == "Terminado")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        public void AgregarProceso(Proceso nuevoProceso)
        {
            procesos.Add(nuevoProceso);
            ActualizarContador();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Columns.Add("ID", "ID");
            this.dataGridView1.Columns.Add("Nombre", "Nombre");
            this.dataGridView1.Columns.Add("Memoria", "Memoria");
            this.dataGridView1.Columns.Add("CPU", "CPU");
            this.dataGridView1.Columns.Add("TiempoEjecucion", "Tiempo de Ejecución");
            this.dataGridView1.Columns.Add("Estado", "Estado");
            this.dataGridView1.Columns.Add("Swap", "Swap");
            this.dataGridView1.Columns.Add("TiempoRestante", "Tiempo Restante");
        }

        private void ActualizarContador()
        {
            lblProcesoCount.Text = procesos.Count.ToString() + " Procesos";
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "Velocidad: x" + trackBarSpeed.Value.ToString();
            ejecucionTimer.Interval = 1000 / trackBarSpeed.Value;
        }


        private void btnStopSimulation_Click(object sender, EventArgs e)
        {

            if (procesos.Count > 0)
            {
                ejecucionTimer.Stop();
                btnResumeSimulation.Enabled = true;
                btnClearProcesses.Enabled = true;
                MessageBox.Show("Simulacion detenida.");
            }
            else
            {
                MessageBox.Show("No hay procesos para detener.");
            }
        }

        private void btnClearProcesses_Click(object sender, EventArgs e)
        {

            if (btnClearProcesses.Enabled)
            {
                if (procesos.Count > 0)
                {
                    procesos.Clear();

                    ActualizarContador();

                    MostrarProceso();

                }
                else
                {
                    MessageBox.Show("No hay procesos para borrar.");
                }
                btnClearProcesses.Enabled = false;
            }
        }

        private void btnResumeSimulation_Click(object sender, EventArgs e)
        {
            if (!ejecucionTimer.Enabled)
            {
                ejecucionTimer.Start();
                btnResumeSimulation.Enabled = false;
                MessageBox.Show("Simulacion reanudada.");
            }
        }

        private Proceso GeneracionDeProcesos()
        {
            int id = contador++;

            string nombre = "Proceso " + id; //generamos el proceso con el id 

            Random random = new Random();   //creamos una variable para datos aleatorios 

            int memoria = random.Next(1, memoriaMax);
            memoria = (int)(Math.Round((double)memoria / 32) * 32);

            int cpu = random.Next(1, 15); //1 a 15% del procesador

            int tiempoEjecucion = random.Next(1000, maxProce) / trackBarSpeed.Value; // Ajustar según la velocidad

            Proceso nuevoProceso = new Proceso(id, nombre, memoria, cpu, tiempoEjecucion, procesamiento);

            return nuevoProceso;
        }

        private void MostrarEstadistica()
        {



            //esta comparacion es para evitar que ocurra un error de dividir 0/0
            decimal tiempoMedia = totalDeProcesosAtendidos > 0 ? totalTimepoEnAtencion / totalDeProcesosAtendidos : 0; //sacamos la media del tiempo
            lblTiempoMedi.Text = tiempoMedia.ToString("F2");
            lblTotalProcesosAtendidos.Text = totalDeProcesosAtendidos.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtProcesamiento_TextChanged()
        {
            if (int.Parse(txtProcesamiento.Text) > int.Parse(txtMaxProce.Text))
            {
                MessageBox.Show("Error. El tiempo de procesamiento no puede ser mayor al tiempo maximo!");
                txtProcesamiento.Text = procesamiento.ToString();
            }
            else if (int.Parse(txtProcesamiento.Text) < 0)
            {
                MessageBox.Show("Error. El tiempo de procesamiento no puede ser menor a 0!");
                txtProcesamiento.Text = procesamiento.ToString();
            }
            else
            {
                procesamiento = int.Parse(txtProcesamiento.Text);
            }
        }

        private void txtMemMax_TextChanged()
        {
            if (int.Parse(txtMemMax.Text) > 4096)
            {
                MessageBox.Show("Error. El maximo de memoria por proceso no puede superar el total maximo (4mb)!");
                txtMemMax.Text = memoriaMax.ToString();
            }
            else if (int.Parse(txtMemMax.Text) < 0)
            {
                MessageBox.Show("Error. La memoria maxima no puede ser menor a 0!");
                txtMemMax.Text = memoriaMax.ToString();
            }
            else
            {
                memoriaMax = int.Parse(txtMemMax.Text);
            }
        }

        private void txtMaxProce_TextChanged()
        {
            if (int.Parse(txtMaxProce.Text) < 1000)
            {
                MessageBox.Show("Error. El maximo de procesamiento no puede ser menor a 1000!");
                txtMaxProce.Text = maxProce.ToString();
            }
            else
            {
                maxProce = int.Parse(txtMaxProce.Text);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSpeed_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            txtMaxProce_TextChanged();
            txtMemMax_TextChanged();
            txtProcesamiento_TextChanged();
        }

        



    }


}