using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOProyecto
{
    public partial class Procesos : Form
    {
        private int indice, num, RA, RB, RC;
        public Procesos()
        {
            InitializeComponent();
        }
        public Procesos(int i)
        {
            indice = i;
            num = 1; //para saber el numero del proceso
            InitializeComponent();
            lbProcess.Text = $"Proceso {num}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            RA = Convert.ToInt32(txtA.Text);
            RB = Convert.ToInt32(txtB.Text);
            RC = Convert.ToInt32(txtC.Text);
            if (RA >= 0 && RB >= 0 && RC >= 0 && (RA + RB + RC) > 0)
            {
                Form1.RAT -= RA;
                Form1.RBT -= RB;
                Form1.RCT -= RC;
                lbListo.Text = "Añadido!";
                indice--;
                num++;
                lbProcess.Text = $"Proceso {num}"; 
            }
            else
            {
                MessageBox.Show("Inserta valores validos!");
            }

            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "0";

            if (indice == 0)
            {
                this.Close();
            }
        }

        private void lbProcess_Click(object sender, EventArgs e)
        {

        }
    }
}