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

        public Form1()
        {

            InitializeComponent();
            Log.Text = "[0, 4096, 0]";

            lbMemoria.Text = Convert.ToString(memoria);


            ejecucionTimer = new System.Timers.Timer(1000);
            ejecucionTimer.Elapsed += OnTimedEvent;
            ejecucionTimer.AutoReset = true;
            ejecucionTimer.Start();

            btnResumeSimulation.Enabled = false;//solo se habilita cuando esta detenida la simulacion
            btnClearProcesses.Enabled = false;


            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            lblSpeed.Text = trackBarSpeed.Value.ToString() + " ms";
        }



        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void OnTimedEvent(System.Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                //ponemos para generar un proceso aleatorio
                Proceso nuevoProceso = GeneracionDeProcesos();//guardamos el procesos que nos de la generacion de procesos
                AgregarProceso(nuevoProceso);
                Log.Text += "\n[0, 4096, 0]"; // Ejemplo

                for (int i = 0; i < procesos.Count;)
                {
                    var proceso = procesos[i];

                    ActualizarSwap(proceso);

                    if (proceso.TiempoEnAmarillo > 0)
                    {
                        proceso.Estado = "Inicializando";
                        proceso.TiempoEnAmarillo--;
                        MostrarProceso();
                    }
                    else if (proceso.Estado == "Inicializando" && proceso.TiempoEnAmarillo == 0)
                    {
                        proceso.Estado = "Ejecutando";
                        MostrarProceso();
                    }

                    if (proceso.Estado == "Ejecutando" && proceso.TiempoRestante > 0)
                    {
                        proceso.TiempoEjecucion -= intervalo * proceso.Procesamiento;
                        proceso.TiempoRestante = proceso.TiempoEjecucion / intervalo;
                        MostrarProceso();
                    }

                    if (proceso.TiempoEjecucion <= 0 && proceso.Estado != "Terminado")
                    {
                        proceso.Estado = "Terminado";
                        proceso.TiempoTerminado = tiempoTerminado;
                        procesos.RemoveAt(i);
                        ActualizarContador();
                    }

                    else if (proceso.Estado != "Terminado")
                    {
                        i++;
                    }
                }

                if (procesos.Count == 0)
                {
                    ejecucionTimer.Stop();
                    btnResumeSimulation.Enabled = false;
                    btnClearProcesses.Enabled = false;
                }

                MostrarProceso();
            });
        }

        private void ActualizarSwap(Proceso proceso)
        {
            Random random = new Random();

            if (proceso.Estado == "Ejecutando")
            {
                if (random.Next(0, 10) < 3) //30% de probabilidad que ocurra esto
                {
                    proceso.Swap = "En swap";
                }
                else
                {
                    proceso.Swap = "En memoria";
                }
            }
            else if (proceso.Estado == "Inicializando")
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
            intervalo = trackBarSpeed.Value;
            ejecucionTimer.Interval = intervalo;
            lblSpeed.Text = intervalo.ToString() + " ms";
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

            int tiempoEjecucion = random.Next(1000, maxProce);

            Proceso nuevoProceso = new Proceso(id, nombre, memoria, cpu, tiempoEjecucion, procesamiento);


            return nuevoProceso;
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