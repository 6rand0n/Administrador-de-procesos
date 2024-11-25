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
            lbC = new Label();
            lbB = new Label();
            lbA = new Label();
            label6 = new Label();
            label7 = new Label();
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
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(92, 209);
            label2.Name = "label2";
            label2.Size = new Size(37, 38);
            label2.TabIndex = 3;
            label2.Text = "A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(212, 209);
            label3.Name = "label3";
            label3.Size = new Size(35, 38);
            label3.TabIndex = 4;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(321, 209);
            label4.Name = "label4";
            label4.Size = new Size(34, 38);
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
            // lbC
            // 
            lbC.AutoSize = true;
            lbC.BackColor = Color.Transparent;
            lbC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbC.ForeColor = SystemColors.ActiveCaption;
            lbC.Location = new Point(321, 294);
            lbC.Name = "lbC";
            lbC.Size = new Size(27, 31);
            lbC.TabIndex = 10;
            lbC.Text = "0";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.BackColor = Color.Transparent;
            lbB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbB.ForeColor = SystemColors.ActiveCaption;
            lbB.Location = new Point(212, 294);
            lbB.Name = "lbB";
            lbB.Size = new Size(27, 31);
            lbB.TabIndex = 11;
            lbB.Text = "0";
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.BackColor = Color.Transparent;
            lbA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbA.ForeColor = SystemColors.ActiveCaption;
            lbA.Location = new Point(92, 294);
            lbA.Name = "lbA";
            lbA.Size = new Size(27, 31);
            lbA.TabIndex = 12;
            lbA.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1030, 76);
            label6.Name = "label6";
            label6.Size = new Size(176, 39);
            label6.TabIndex = 13;
            label6.Text = "En ejecucion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1048, 294);
            label7.Name = "label7";
            label7.Size = new Size(131, 39);
            label7.TabIndex = 14;
            label7.Text = "Procesos";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.FondoSO;
            ClientSize = new Size(1491, 642);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lbA);
            Controls.Add(lbB);
            Controls.Add(lbC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumProcess);
            Controls.Add(btnProcess);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Administrador de procesos";
            Load += Form1_Load;
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
        private Label lbC;
        private Label lbB;
        private Label lbA;
        private Label label6;
        private Label label7;
    }
}
