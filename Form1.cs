using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOProyecto
{
    public partial class Form1 : Form
    {
        static private int RAT, RBT, RCT;
        public Form1()
        {
            InitializeComponent();
            RAT = 16;
            RBT = 8;
            RCT = 12;
            txtRA.Text = Convert.ToString(RAT);
            txtRB.Text = Convert.ToString(RBT);
            txtRC.Text = Convert.ToString(RCT);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int num = (int)NumProcess.Value;
            if (num > 0)
            {
                this.Hide();
                for (int i = 0; i < num; i++)
                {
                    Procesos procesosV = new Procesos();
                    procesosV.ShowDialog();
                    // FALTA VERIFICACION U CUALQUIER METODO DE ADMINISTRACION A USAR
                    RAT -= Procesos.RA;
                    RBT -= Procesos.RB;
                    RCT -= Procesos.RC;
                    // FALTA CREAR OBJETO DE LA CLASE DEL PROCESO
                }
                txtRA.Text = Convert.ToString(RAT);
                txtRB.Text = Convert.ToString(RBT);
                txtRC.Text = Convert.ToString(RCT);
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
    }
}
