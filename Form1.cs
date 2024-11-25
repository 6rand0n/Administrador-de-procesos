using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOProyecto
{
    public partial class Form1 : Form
    {
        static public int RAT, RBT, RCT;
        public Form1()
        {
            InitializeComponent();
            RAT = 16;
            RBT = 8;
            RCT = 12;
            lbA.Text = Convert.ToString(RAT);
            lbB.Text = Convert.ToString(RBT);
            lbC.Text = Convert.ToString(RCT);
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
                }
                lbA.Text = Convert.ToString(RAT);
                lbB.Text = Convert.ToString(RBT);
                lbC.Text = Convert.ToString(RCT);
                NumProcess.Value = 0;
                this.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un numero de procesos valido!");
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
    }
}
