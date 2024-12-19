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
        static public int tiempoCambioEstado = 1;
        int contador = 0, procesamiento = 1000, maxProce = 5000, memoriaMax = 512;
        private AsignadorMemoria asignador;
        int i = 0;


        private decimal totalTimepoEnAtencion = 0; //suma total para el tiempo de ejecucion
        private int totalDeProcesosAtendidos = 0; //suma total de los procesos que fueron atendidos

        public Form1()
        {
            InitializeComponent();
            AgregarRegistroLog("[0, 4096, 0]");
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
            lblSpeed.Text = "x " + trackBarSpeed.Value.ToString();
        }
        private string ObtenerEstadoMemoria()
        {
            StringBuilder sb = new StringBuilder();
            int j = 0;
            foreach (var bloque in asignador.ObtenerBloquesMemoria())
            {
                if (bloque.EstaLibre)
                {
                    // Si el bloque está libre, representarlo como [0, tamaño, 0]
                    sb.Append($"[0,{bloque.Tamaño},0]");
                }
                else
                {
                    // Si el bloque está ocupado, buscar el proceso que lo ocupa y obtener su ID y tiempo de ejecución
                    var proceso = procesos.FirstOrDefault(p => p.ID == bloque.ProcesoID);
                    if (proceso != null)
                    {
                        sb.Append($"[{proceso.ID},{bloque.Tamaño},{proceso.TiempoEjecucion}]");
                    }
                }

                j++;
                if (j > 10)
                {
                    sb.Append("...");
                    break;
                }
            }

            // Regresar la cadena con todos los bloques en una sola línea
            return sb.ToString();
        }
        // Una lista para mantener los últimos 8 registros del log
        private List<string> registrosLog = new List<string>();

        // Método para agregar un nuevo registro al log
        private void AgregarRegistroLog(string nuevoRegistro)
        {
            // Si hay más de 8 elementos en el log, eliminamos el más antiguo (primer elemento)
            if (registrosLog.Count >= 10)
            {
                registrosLog.RemoveAt(0); // Elimina el primer elemento
            }

            // Agregar el nuevo registro al final de la lista
            registrosLog.Add(nuevoRegistro);

            // Actualizar el control de texto del log para mostrar solo los últimos 8 registros
            ActualizarLog();
        }

        // Método para actualizar el control de texto del log
        private void ActualizarLog()
        {
            Log.Text = string.Join("\n", registrosLog);
        }



        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (procesos.Count == 0 || procesos.Count <= 4)
                {
                    // Generación de procesos aleatorios (con control de frecuencia)
                    if (procesos.Count < 8)  // No generar más de 8 procesos por vez
                    {
                        Proceso nuevoProceso = GeneracionDeProcesos();

                        // Asignar memoria al nuevo proceso
                        if (asignador.AsignarMemoria(nuevoProceso.ID, nuevoProceso.Memoria, nuevoProceso.TiempoEjecucion) && nuevoProceso.Memoria <= memoria)
                        {
                            AgregarProceso(nuevoProceso);
                            AgregarRegistroLog("-> " + ObtenerEstadoMemoria());

                            memoria -= nuevoProceso.Memoria;
                            lbMemoria.Text = memoria.ToString();
                        }
                    }
                }

                if (procesos.Count > 0)
                {
                    // Procesar el siguiente proceso de la lista (utilizando un enfoque más eficiente)
                    Proceso proceso = procesos[i];
                    bool procesoActualizado = false;

                    // Si el proceso está en estado "Ready", cambiar a "Running"
                    if (proceso.Estado == "Ready")
                    {
                        proceso.Estado = "Running";
                        foreach (var proceso2 in procesos)
                        {
                            if (proceso2.Estado == "Running" && proceso2.ID != proceso.ID)
                            {
                                proceso2.Estado = "Ready";
                            }
                        }
                        ActualizarSwap();
                        MostrarProceso();
                        procesoActualizado = true;
                    }

                    // Simulando la ejecución del proceso
                    if (proceso.Estado == "Running" && proceso.TiempoRestante > 0)
                    {
                        // Simular posible bloqueo del proceso con menos probabilidades
                        if (new Random().Next(0, 10) < 1) // Cambiar la probabilidad de bloqueo
                        {
                            proceso.Estado = "Blocked";
                        }

                        if (!proceso.TiempoInicio.HasValue)
                        {
                            proceso.TiempoInicio = DateTime.Now;
                        }

                        // Ejecutar el proceso
                        proceso.TiempoEjecucion -= trackBarSpeed.Value * proceso.Procesamiento;
                        proceso.TiempoRestante = proceso.TiempoEjecucion / trackBarSpeed.Value;
                        ActualizarSwap();
                        MostrarProceso();
                        procesoActualizado = true;
                    }

                    // Verificar si el proceso ha terminado
                    if (proceso.TiempoEjecucion <= 0)
                    {
                        proceso.Estado = "Terminado";
                        FinalizarProceso(proceso);
                        if (i >= procesos.Count) i = 0; // Ajustar el índice si es necesario
                    }
                    else if (proceso.Estado == "Blocked")
                    {
                        // Mover el proceso bloqueado al final de la lista
                        procesos.RemoveAt(i);
                        procesos.Add(proceso);
                        i = 0; // Ajustar el índice si es necesario
                    }
                    else if (proceso.Estado != "Running")
                    {
                        // Mover a "Ready" si no está en ejecución
                        proceso.Estado = "Ready";
                        procesos.RemoveAt(i);
                        procesos.Add(proceso);
                        if (i >= procesos.Count) i = 0; // Ajustar el índice si es necesario
                    }
                    else
                    {
                        // Avanzar al siguiente proceso en la lista
                        i = (i + 1) % procesos.Count;
                    }

                    // Actualizar los estados de los procesos bloqueados
                    foreach (var proceso2 in procesos)
                    {
                        if (proceso2.Estado == "Blocked")
                        {
                            if (new Random().Next(0, 10) > 7) // Mejorar la probabilidad de desbloqueo
                            {
                                proceso2.Estado = "Ready";
                                ActualizarSwap();
                            }
                        }
                    }

                    // Mostrar estadísticas y log
                    if (procesoActualizado)
                    {
                        MostrarEstadistica();
                        MostrarProceso();
                        AgregarRegistroLog("- " + ObtenerEstadoMemoria());
                    }
                }
            });
        }


        private void FinalizarProceso(Proceso proceso)
        {
            asignador.LiberarMemoria(proceso.ID); // Liberar memoria
            memoria += proceso.Memoria;
            lbMemoria.Text = memoria.ToString();


            if (proceso.TiempoInicio.HasValue)
            {
                TimeSpan tiempoDeAtencion = DateTime.Now - proceso.TiempoInicio.Value;
                totalTimepoEnAtencion += (decimal)tiempoDeAtencion.TotalSeconds;
                totalDeProcesosAtendidos++;
            }

            procesos.Remove(proceso); // Eliminar el proceso de la lista
            ActualizarContador();
            MostrarEstadistica();
        }


        private void ActualizarSwap()
        {
            foreach (var proceso in procesos)
            {
                Random random = new Random();

                if (proceso.Estado == "Running")
                {
                    proceso.Swap = "En memoria";
                }
                else if (proceso.Estado == "Ready")
                {
                    proceso.Swap = "En swap";
                }
                else if (proceso.Estado == "Blocked")
                {
                    proceso.Swap = "En swap Blocked";
                }
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

            foreach (var proceso in procesos)
            {
                int rowIndex = dataGridView1.Rows.Add(proceso.ID, proceso.Nombre, proceso.Memoria, proceso.CPU, proceso.TiempoEjecucion, proceso.Estado, proceso.Swap, proceso.TiempoRestante);

                if (proceso.Estado == "Inicializando")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (proceso.Estado == "Running")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (proceso.Estado == "Blocked")
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
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
            lblSpeed.Text = "x " + trackBarSpeed.Value.ToString();
            ejecucionTimer.Interval = 1000 / trackBarSpeed.Value;
        }


        private void btnStopSimulation_Click(object sender, EventArgs e)
        {

            if (procesos.Count > 0)
            {
                ejecucionTimer.Stop();
                btnResumeSimulation.Enabled = true;
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

            int tiempoEjecucion = random.Next(1000, maxProce);

            Proceso nuevoProceso = new Proceso(id, nombre, memoria, cpu, tiempoEjecucion, procesamiento);

            return nuevoProceso;
        }

        private void MostrarEstadistica()
        {
            //esta comparacion es para evitar que ocurra un error de dividir 0/0
            decimal tiempoMedia = totalDeProcesosAtendidos > 0 ? totalTimepoEnAtencion / totalDeProcesosAtendidos : 0; //sacamos la media del tiempo
            if (lblSpeed.Text == "x 5")
                tiempoMedia *= 5;
            lblTiempoMedi.Text = (tiempoMedia*1000).ToString("F2");
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

        private void lblTiempoMedi_Click(object sender, EventArgs e)
        {

        }
    }


}