using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Windows.Forms;
using static SOProyecto.Program;

namespace SOProyecto
{
    public partial class Form1 : Form
    {



        static public int RAT, RBT, RCT;
        private List<Proceso> procesos = new List<Proceso>();//almacena procesos 
        public Form1()
        {
            InitializeComponent();
            lbA.Text = Convert.ToString(RAT);
            lbB.Text = Convert.ToString(RBT);
            lbC.Text = Convert.ToString(RCT);
        }

        public class Proceso
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Memoria { get; set; }  // Recursos que usa la memoria
            public int CPU { get; set; }      // Recursos que usa la CPU
            public int TiempoEjecucion { get; set; } // el tiempo que se esta ejecutando
            public string Estado { get; set; } // Que proceso se encuentra

            public string Swap { get; set; } //Donde esta el proceso en memoria principal o en disco duro

            // Constructor del proceso
            public Proceso(int id, string nombre, int memoria, int cpu, int tiempoEjecucion)
            {
                this.ID = id;
                this.Nombre = nombre;
                this.Memoria = memoria;
                this.CPU = cpu;
                this.TiempoEjecucion = tiempoEjecucion;
                this.Estado = "En espera";
                this.Swap = "Desconocido";
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
                    // - A quien le toque la insercion de procesos:

                    // Aqui deberan usar un vector/matriz static para traerse la info de los procesos, esto para hacer la tabla y el objeto de cada uno
                    // Con el bucle crean los objetos 
                    // FALTA VERIFICACION U CUALQUIER METODO DE ADMINISTRACION A USAR - Esto en el Form 2 
                    // FALTA CREAR OBJETO DE LA CLASE DEL PROCESO - Esto aqui
                    // Crear el proceso con los valores obtenidos
                    Proceso nuevoProceso = new Proceso(
                        Form1.RAT, // Asumiendo que RAT es un valor del formulario
                        "Proceso " + (i + 1),
                        10,  // Ejemplo de valor para Memoria
                        5,   // Ejemplo de valor para CPU
                        100  // Ejemplo de valor para TiempoEjecucion
                    );
                    AgregarProceso(nuevoProceso);
                }
                lbA.Text = Convert.ToString(RAT);
                lbB.Text = Convert.ToString(RBT);
                lbC.Text = Convert.ToString(RCT);
                NumProcess.Value = 0;
                this.Show();
                MostrarProceso();//llamo a la funcion
            }
            else
            {
                MessageBox.Show("Selecciona un numero de procesos valido!");
            }
            
        }


        public void AgregarProceso(Proceso nuevoProceso)
        {
            procesos.Add(nuevoProceso);
        }

        private void MostrarProceso()
        {
            dataGridView1.Rows.Clear(); //limpia el data grid

            if (procesos.Count == 0)
            {
                MessageBox.Show("No hay procesos para mostrar.");
                return;
            }

            foreach (var proceso in procesos)
            {
                dataGridView1.Rows.Add(proceso.ID, proceso.Nombre, proceso.Memoria, proceso.CPU, proceso.TiempoEjecucion, proceso.Estado, proceso.Swap);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Columns.Add("ID", "ID");
            this.dataGridView1.Columns.Add("Nombre", "Nombre");
            this.dataGridView1.Columns.Add("Memoria", "Memoria");
            this.dataGridView1.Columns.Add("CPU", "CPU");
            this.dataGridView1.Columns.Add("TiempoEjecucion", "Tiempo de Ejecución");
            this.dataGridView1.Columns.Add("Estado", "Estado");
        }
    }
}
