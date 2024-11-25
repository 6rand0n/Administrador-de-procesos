namespace SOProyecto
{
    partial class Procesos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbProcess = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label1 = new Label();
            Crear = new Button();
            lbListo = new Label();
            SuspendLayout();
            // 
            // lbProcess
            // 
            lbProcess.AutoSize = true;
            lbProcess.BackColor = Color.Transparent;
            lbProcess.BorderStyle = BorderStyle.Fixed3D;
            lbProcess.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProcess.ForeColor = SystemColors.ActiveCaptionText;
            lbProcess.Location = new Point(12, 9);
            lbProcess.Name = "lbProcess";
            lbProcess.Size = new Size(131, 39);
            lbProcess.TabIndex = 15;
            lbProcess.Text = "Procesos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(190, 156);
            label2.Name = "label2";
            label2.Size = new Size(37, 38);
            label2.TabIndex = 16;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(190, 244);
            label3.Name = "label3";
            label3.Size = new Size(35, 38);
            label3.TabIndex = 17;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(190, 334);
            label4.Name = "label4";
            label4.Size = new Size(34, 38);
            label4.TabIndex = 18;
            label4.Text = "C";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtA.Location = new Point(373, 158);
            txtA.Name = "txtA";
            txtA.PlaceholderText = "0";
            txtA.Size = new Size(125, 38);
            txtA.TabIndex = 19;
            txtA.Text = "0";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtB.Location = new Point(373, 246);
            txtB.Name = "txtB";
            txtB.PlaceholderText = "0";
            txtB.Size = new Size(125, 38);
            txtB.TabIndex = 20;
            txtB.Text = "0";
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtC.Location = new Point(373, 334);
            txtC.Name = "txtC";
            txtC.PlaceholderText = "0";
            txtC.Size = new Size(125, 38);
            txtC.TabIndex = 21;
            txtC.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(77, 91);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 22;
            label1.Text = "A usar: ";
            // 
            // Crear
            // 
            Crear.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crear.Location = new Point(602, 376);
            Crear.Name = "Crear";
            Crear.Size = new Size(142, 62);
            Crear.TabIndex = 23;
            Crear.Text = "Crear";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            // 
            // lbListo
            // 
            lbListo.AutoSize = true;
            lbListo.BackColor = Color.Transparent;
            lbListo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbListo.ForeColor = SystemColors.WindowFrame;
            lbListo.Location = new Point(613, 323);
            lbListo.Name = "lbListo";
            lbListo.Size = new Size(0, 38);
            lbListo.TabIndex = 24;
            // 
            // Procesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo2SO;
            ClientSize = new Size(800, 450);
            Controls.Add(lbListo);
            Controls.Add(Crear);
            Controls.Add(label1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbProcess);
            Name = "Procesos";
            Text = "Añadir procesos";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProcess;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Button Crear;
        private Label lbListo;
    }
}