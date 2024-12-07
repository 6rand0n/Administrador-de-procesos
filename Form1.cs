using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOProyecto.Program;
using System.Timers;

namespace SOProyecto
{
    public partial class Form1 : Form
    {
        static public int RAT, RBT, RCT;
        private List<Proceso> procesos = new List<Proceso>();
        private System.Timers.Timer ejecucionTimer;
        private int tiempoDeVida = 10;
        private int procesoIndex = 0;
        private int tiempoTerminado = 5;
        static int tiempoCambioEstado = 1;

        public Form1()
        {
            InitializeComponent();
            lbA.Text = Convert.ToString(RAT);
            lbB.Text = Convert.ToString(RBT);
            lbC.Text = Convert.ToString(RCT);

 
            ejecucionTimer = new System.Timers.Timer(1000);
            ejecucionTimer.Elapsed += OnTimedEvent;
            ejecucionTimer.AutoReset = true;


            btnResumeSimulation.Enabled = false;//solo se habilita cuando esta detenida la simulacion
            btnClearProcesses.Enabled = false;


            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            lblSpeed.Text = trackBarSpeed.Value.ToString() + " ms";
        }


        public class Proceso
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Memoria { get; set; }
            public int CPU { get; set; }
            public int TiempoEjecucion { get; set; }
            public string Estado { get; set; }
            public string Swap { get; set; }
            public int TiempoRestante { get; set; }
            public int TiempoTerminado { get; set; }
            public int TiempoEnAmarillo { get; set; }

            public Proceso(int id, string nombre, int memoria, int cpu, int tiempoEjecucion)
            {
                this.ID = id;
                this.Nombre = nombre;
                this.Memoria = memoria;
                this.CPU = cpu;
                this.TiempoEjecucion = tiempoEjecucion;
                this.Estado = "En espera";
                this.Swap = "Desconocido";
                this.TiempoRestante = tiempoEjecucion;
                this.TiempoTerminado = 0;
                this.TiempoEnAmarillo = tiempoCambioEstado;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int num = (int)NumProcess.Value;
            if (num > 0)
            {
                this.Hide();

                Procesos procesosV = new Procesos(num);
                procesosV.ShowDialog();
                for (int i = 0; i < num; i++)
                {
                    Proceso nuevoProceso = new Proceso(
                        Form1.RAT,
                        "Proceso " + (i + 1),
                        10,
                        5,
                        10
                    );
                    AgregarProceso(nuevoProceso);
                }
                lbA.Text = Convert.ToString(RAT);
                lbB.Text = Convert.ToString(RBT);
                lbC.Text = Convert.ToString(RCT);

                NumProcess.Value = 0;
                this.Show();
                MostrarProceso();
                ejecucionTimer.Start();

                ActualizarContador();
                btnResumeSimulation.Enabled = false; // Deshabilitar el boton de reanudar al iniciar la simulación
                btnClearProcesses.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecciona un numero de procesos valido!");
            }
        }

        private void OnTimedEvent(System.Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < procesos.Count;)
                {
                    var proceso = procesos[i];

                    if (proceso.TiempoEnAmarillo > 0)
                    {
                        proceso.Estado = "Inicializando";
                        proceso.TiempoEnAmarillo--;
                        MostrarProceso();
                    }
                    else if (proceso.Estado == "Inicializando" && proceso.TiempoEnAmarillo == 0)
                    {
                        proceso.Estado = "Ejecutando";
                        proceso.TiempoRestante--;
                        proceso.TiempoEjecucion--;
                        MostrarProceso();
                    }

                    if (proceso.Estado == "Ejecutando" && proceso.TiempoRestante > 0)
                    {
                        proceso.TiempoRestante--;
                        proceso.TiempoEjecucion--;
                        MostrarProceso();
                    }

                    if (proceso.TiempoRestante == 0 && proceso.Estado != "Terminado")
                    {
                        proceso.Estado = "Terminado";
                        proceso.TiempoTerminado = tiempoTerminado;
                        MostrarProceso();
                    }

                    if (proceso.Estado == "Terminado" && proceso.TiempoTerminado > 0)
                    {
                        proceso.TiempoTerminado--;
                        MostrarProceso();

                        if (proceso.TiempoTerminado == 0)
                        {
                            procesos.RemoveAt(i);
                            ActualizarContador();
                        }
                        else
                        {
                            i++;
                        }
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
            int intervalo = trackBarSpeed.Value;
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
    }
}
