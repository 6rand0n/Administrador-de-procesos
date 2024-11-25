namespace SOProyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnProcess = new Button();
            NumProcess = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRA = new TextBox();
            txtRB = new TextBox();
            txtRC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumProcess).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(401, 39);
            label1.TabIndex = 0;
            label1.Text = "Administrador de procesos Bv";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.Silver;
            btnProcess.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProcess.ForeColor = SystemColors.MenuText;
            btnProcess.Location = new Point(24, 532);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(302, 54);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "Añadir Procesos";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // NumProcess
            // 
            NumProcess.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumProcess.Location = new Point(349, 535);
            NumProcess.Name = "NumProcess";
            NumProcess.Size = new Size(150, 51);
            NumProcess.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(92, 209);
            label2.Name = "label2";
            label2.Size = new Size(30, 31);
            label2.TabIndex = 3;
            label2.Text = "A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(212, 209);
            label3.Name = "label3";
            label3.Size = new Size(29, 31);
            label3.TabIndex = 4;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(321, 209);
            label4.Name = "label4";
            label4.Size = new Size(28, 31);
            label4.TabIndex = 5;
            label4.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(158, 142);
            label5.Name = "label5";
            label5.Size = new Size(131, 38);
            label5.TabIndex = 6;
            label5.Text = "Recursos";
            // 
            // txtRA
            // 
            txtRA.Enabled = false;
            txtRA.Location = new Point(75, 294);
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(59, 27);
            txtRA.TabIndex = 7;
            // 
            // txtRB
            // 
            txtRB.Enabled = false;
            txtRB.Location = new Point(197, 294);
            txtRB.Name = "txtRB";
            txtRB.Size = new Size(59, 27);
            txtRB.TabIndex = 8;
            // 
            // txtRC
            // 
            txtRC.Enabled = false;
            txtRC.Location = new Point(305, 294);
            txtRC.Name = "txtRC";
            txtRC.Size = new Size(59, 27);
            txtRC.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoSO;
            ClientSize = new Size(1491, 642);
            Controls.Add(txtRC);
            Controls.Add(txtRB);
            Controls.Add(txtRA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumProcess);
            Controls.Add(btnProcess);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumProcess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProcess;
        private NumericUpDown NumProcess;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRA;
        private TextBox txtRB;
        private TextBox txtRC;
    }
}
