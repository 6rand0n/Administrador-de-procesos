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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbC = new Label();
            lbB = new Label();
            lbA = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Memoria = new DataGridViewTextBoxColumn();
            CPU = new DataGridViewTextBoxColumn();
            TiempoEjecucion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Swap = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblProcesoCount = new Label();
            trackBarSpeed = new TrackBar();
            label7 = new Label();
            lblSpeed = new Label();
            btnStopSimulation = new Button();
            btnClearProcesses = new Button();
            btnResumeSimulation = new Button();
            ((System.ComponentModel.ISupportInitialize)NumProcess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 28);
            label1.TabIndex = 0;
            label1.Text = "PapuAdministrador de Papuprocesos Bv";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.Silver;
            btnProcess.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProcess.ForeColor = SystemColors.MenuText;
            btnProcess.Location = new Point(21, 252);
            btnProcess.Margin = new Padding(3, 2, 3, 2);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(264, 40);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "Añadir Procesos";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // NumProcess
            // 
            NumProcess.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumProcess.Location = new Point(305, 254);
            NumProcess.Margin = new Padding(3, 2, 3, 2);
            NumProcess.Name = "NumProcess";
            NumProcess.Size = new Size(131, 42);
            NumProcess.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(186, 157);
            label3.Name = "label3";
            label3.Size = new Size(27, 30);
            label3.TabIndex = 4;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(281, 157);
            label4.Name = "label4";
            label4.Size = new Size(27, 30);
            label4.TabIndex = 5;
            label4.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(138, 106);
            label5.Name = "label5";
            label5.Size = new Size(104, 30);
            label5.TabIndex = 6;
            label5.Text = "Recursos";
            // 
            // lbC
            // 
            lbC.AutoSize = true;
            lbC.BackColor = Color.Transparent;
            lbC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbC.ForeColor = SystemColors.ActiveCaption;
            lbC.Location = new Point(281, 220);
            lbC.Name = "lbC";
            lbC.Size = new Size(23, 25);
            lbC.TabIndex = 10;
            lbC.Text = "0";
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.BackColor = Color.Transparent;
            lbB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbB.ForeColor = SystemColors.ActiveCaption;
            lbB.Location = new Point(186, 220);
            lbB.Name = "lbB";
            lbB.Size = new Size(23, 25);
            lbB.TabIndex = 11;
            lbB.Text = "0";
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.BackColor = Color.Transparent;
            lbA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbA.ForeColor = SystemColors.ActiveCaption;
            lbA.Location = new Point(80, 220);
            lbA.Name = "lbA";
            lbA.Size = new Size(23, 25);
            lbA.TabIndex = 12;
            lbA.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1275, 22);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 13;
            label6.Text = "En ejecucion";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Memoria, CPU, TiempoEjecucion, Estado, Swap });
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(442, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 395);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Memoria
            // 
            Memoria.HeaderText = "Memoria";
            Memoria.MinimumWidth = 6;
            Memoria.Name = "Memoria";
            Memoria.Width = 125;
            // 
            // CPU
            // 
            CPU.HeaderText = "CPU";
            CPU.MinimumWidth = 6;
            CPU.Name = "CPU";
            CPU.Width = 125;
            // 
            // TiempoEjecucion
            // 
            TiempoEjecucion.HeaderText = "Tiempo de ejecucion";
            TiempoEjecucion.MinimumWidth = 6;
            TiempoEjecucion.Name = "TiempoEjecucion";
            TiempoEjecucion.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Swap
            // 
            Swap.HeaderText = "DD?";
            Swap.MinimumWidth = 6;
            Swap.Name = "Swap";
            Swap.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(80, 157);
            label2.Name = "label2";
            label2.Size = new Size(28, 30);
            label2.TabIndex = 18;
            label2.Text = "A";
            // 
            // lblProcesoCount
            // 
            lblProcesoCount.AutoSize = true;
            lblProcesoCount.BackColor = Color.Transparent;
            lblProcesoCount.BorderStyle = BorderStyle.Fixed3D;
            lblProcesoCount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcesoCount.ForeColor = SystemColors.Control;
            lblProcesoCount.Location = new Point(1275, 67);
            lblProcesoCount.Name = "lblProcesoCount";
            lblProcesoCount.Size = new Size(27, 28);
            lblProcesoCount.TabIndex = 20;
            lblProcesoCount.Text = "0";
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.BackColor = Color.Black;
            trackBarSpeed.Cursor = Cursors.SizeWE;
            trackBarSpeed.Dock = DockStyle.Bottom;
            trackBarSpeed.Location = new Point(0, 437);
            trackBarSpeed.Maximum = 5000;
            trackBarSpeed.Minimum = 100;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(1494, 45);
            trackBarSpeed.TabIndex = 21;
            trackBarSpeed.Value = 1000;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(12, 371);
            label7.Name = "label7";
            label7.Size = new Size(193, 28);
            label7.TabIndex = 22;
            label7.Text = "Velocidad Actual";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.BackColor = Color.Transparent;
            lblSpeed.BorderStyle = BorderStyle.Fixed3D;
            lblSpeed.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpeed.ForeColor = SystemColors.Control;
            lblSpeed.Location = new Point(45, 406);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(27, 28);
            lblSpeed.TabIndex = 23;
            lblSpeed.Text = "0";
            // 
            // btnStopSimulation
            // 
            btnStopSimulation.BackColor = Color.IndianRed;
            btnStopSimulation.Cursor = Cursors.Hand;
            btnStopSimulation.FlatStyle = FlatStyle.Popup;
            btnStopSimulation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStopSimulation.ForeColor = SystemColors.MenuText;
            btnStopSimulation.Location = new Point(1275, 238);
            btnStopSimulation.Margin = new Padding(0);
            btnStopSimulation.Name = "btnStopSimulation";
            btnStopSimulation.Size = new Size(193, 40);
            btnStopSimulation.TabIndex = 24;
            btnStopSimulation.Text = "Detener Simulacion";
            btnStopSimulation.UseVisualStyleBackColor = false;
            btnStopSimulation.Click += btnStopSimulation_Click;
            // 
            // btnClearProcesses
            // 
            btnClearProcesses.BackColor = Color.Gold;
            btnClearProcesses.Cursor = Cursors.Hand;
            btnClearProcesses.FlatStyle = FlatStyle.Popup;
            btnClearProcesses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClearProcesses.ForeColor = SystemColors.MenuText;
            btnClearProcesses.Location = new Point(1275, 290);
            btnClearProcesses.Margin = new Padding(0);
            btnClearProcesses.Name = "btnClearProcesses";
            btnClearProcesses.Size = new Size(193, 40);
            btnClearProcesses.TabIndex = 25;
            btnClearProcesses.Text = "Limpiar Procesos";
            btnClearProcesses.UseVisualStyleBackColor = false;
            btnClearProcesses.Click += btnClearProcesses_Click;
            // 
            // btnResumeSimulation
            // 
            btnResumeSimulation.BackColor = Color.LawnGreen;
            btnResumeSimulation.Cursor = Cursors.Hand;
            btnResumeSimulation.FlatStyle = FlatStyle.Popup;
            btnResumeSimulation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResumeSimulation.ForeColor = SystemColors.InfoText;
            btnResumeSimulation.Location = new Point(1275, 343);
            btnResumeSimulation.Margin = new Padding(0);
            btnResumeSimulation.Name = "btnResumeSimulation";
            btnResumeSimulation.Size = new Size(193, 40);
            btnResumeSimulation.TabIndex = 26;
            btnResumeSimulation.Text = "Continuar Simulacion";
            btnResumeSimulation.UseVisualStyleBackColor = false;
            btnResumeSimulation.Click += btnResumeSimulation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.FondoSO;
            ClientSize = new Size(1494, 482);
            Controls.Add(btnResumeSimulation);
            Controls.Add(btnClearProcesses);
            Controls.Add(btnStopSimulation);
            Controls.Add(lblSpeed);
            Controls.Add(label7);
            Controls.Add(trackBarSpeed);
            Controls.Add(lblProcesoCount);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(lbA);
            Controls.Add(lbB);
            Controls.Add(lbC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NumProcess);
            Controls.Add(btnProcess);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Administrador de procesos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumProcess).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProcess;
        private NumericUpDown NumProcess;
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Memoria;
        private DataGridViewTextBoxColumn CPU;
        private DataGridViewTextBoxColumn TiempoEjecucion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Swap;
        private Label label2;
        private Label lblProcesoCount;
        private TrackBar trackBarSpeed;
        private Label label7;
        private Label lblSpeed;
        private Button btnStopSimulation;
        private Button btnClearProcesses;
        private Button btnResumeSimulation;
    }
}
