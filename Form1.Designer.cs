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
            btnProcess.Location = new Point(24, 518);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(305, 68);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "Añadir Procesos";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // NumProcess
            // 
            NumProcess.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumProcess.Location = new Point(347, 532);
            NumProcess.Name = "NumProcess";
            NumProcess.Size = new Size(150, 51);
            NumProcess.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoSO;
            ClientSize = new Size(1491, 642);
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
    }
}
