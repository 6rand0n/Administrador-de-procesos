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
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Memoria = new DataGridViewTextBoxColumn();
            CPU = new DataGridViewTextBoxColumn();
            TiempoEjecucion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Swap = new DataGridViewTextBoxColumn();
            lblProcesoCount = new Label();
            trackBarSpeed = new TrackBar();
            label7 = new Label();
            lblSpeed = new Label();
            btnStopSimulation = new Button();
            btnClearProcesses = new Button();
            btnResumeSimulation = new Button();
            lbMemoria = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtProcesamiento = new TextBox();
            txtMemMax = new TextBox();
            txtMaxProce = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            btnAccept = new Button();
            Log = new RichTextBox();
            button1 = new Button();
            lblTiempoMedi = new Label();
            button2 = new Button();
            lblTotalProcesosAtendidos = new Label();
            label16 = new Label();
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
            label1.Location = new Point(0, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(443, 28);
            label1.TabIndex = 0;
            label1.Text = "PapuAdministrador de Papuprocesos Bv";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(147, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(202, 30);
            label5.TabIndex = 6;
            label5.Text = "Memoria Restante";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(1639, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
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
            dataGridView1.Location = new Point(568, 50);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1034, 553);
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
            // lblProcesoCount
            // 
            lblProcesoCount.AutoSize = true;
            lblProcesoCount.BackColor = Color.Transparent;
            lblProcesoCount.BorderStyle = BorderStyle.Fixed3D;
            lblProcesoCount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcesoCount.ForeColor = SystemColors.Control;
            lblProcesoCount.Location = new Point(1639, 94);
            lblProcesoCount.Margin = new Padding(4, 0, 4, 0);
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
            trackBarSpeed.Location = new Point(0, 976);
            trackBarSpeed.Margin = new Padding(4);
            trackBarSpeed.Maximum = 5;
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(1921, 45);
            trackBarSpeed.TabIndex = 21;
            trackBarSpeed.Value = 1;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(147, 301);
            label7.Margin = new Padding(4, 0, 4, 0);
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
            lblSpeed.Location = new Point(224, 353);
            lblSpeed.Margin = new Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(27, 28);
            lblSpeed.TabIndex = 23;
            lblSpeed.Text = "0";
            lblSpeed.TextAlign = ContentAlignment.MiddleCenter;
            lblSpeed.Click += lblSpeed_Click;
            // 
            // btnStopSimulation
            // 
            btnStopSimulation.BackColor = Color.IndianRed;
            btnStopSimulation.Cursor = Cursors.Hand;
            btnStopSimulation.FlatStyle = FlatStyle.Popup;
            btnStopSimulation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStopSimulation.ForeColor = SystemColors.MenuText;
            btnStopSimulation.Location = new Point(1639, 435);
            btnStopSimulation.Margin = new Padding(0);
            btnStopSimulation.Name = "btnStopSimulation";
            btnStopSimulation.Size = new Size(248, 56);
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
            btnClearProcesses.Location = new Point(1639, 491);
            btnClearProcesses.Margin = new Padding(0);
            btnClearProcesses.Name = "btnClearProcesses";
            btnClearProcesses.Size = new Size(248, 56);
            btnClearProcesses.TabIndex = 25;
            btnClearProcesses.Text = "Limpiar y Terminar";
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
            btnResumeSimulation.Location = new Point(1639, 547);
            btnResumeSimulation.Margin = new Padding(0);
            btnResumeSimulation.Name = "btnResumeSimulation";
            btnResumeSimulation.Size = new Size(248, 56);
            btnResumeSimulation.TabIndex = 26;
            btnResumeSimulation.Text = "Continuar Simulacion";
            btnResumeSimulation.UseVisualStyleBackColor = false;
            btnResumeSimulation.Click += btnResumeSimulation_Click;
            // 
            // lbMemoria
            // 
            lbMemoria.AutoSize = true;
            lbMemoria.BackColor = Color.Transparent;
            lbMemoria.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMemoria.ForeColor = SystemColors.ActiveCaption;
            lbMemoria.Location = new Point(199, 239);
            lbMemoria.Margin = new Padding(4, 0, 4, 0);
            lbMemoria.Name = "lbMemoria";
            lbMemoria.Size = new Size(26, 30);
            lbMemoria.TabIndex = 27;
            lbMemoria.Text = "0";
            lbMemoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(166, 575);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 28;
            label2.Text = "Configuracion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(60, 631);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(267, 30);
            label3.TabIndex = 29;
            label3.Text = "Procesamiento asignado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(35, 788);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(325, 30);
            label4.TabIndex = 30;
            label4.Text = "Memoria Maxima por proceso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(496, 631);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(289, 30);
            label8.TabIndex = 31;
            label8.Text = "Maximo de procesamiento";
            // 
            // txtProcesamiento
            // 
            txtProcesamiento.BackColor = Color.FromArgb(224, 224, 224);
            txtProcesamiento.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtProcesamiento.ForeColor = SystemColors.Highlight;
            txtProcesamiento.Location = new Point(138, 715);
            txtProcesamiento.Name = "txtProcesamiento";
            txtProcesamiento.Size = new Size(113, 36);
            txtProcesamiento.TabIndex = 32;
            txtProcesamiento.Text = "1000";
            txtProcesamiento.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMemMax
            // 
            txtMemMax.BackColor = Color.FromArgb(224, 224, 224);
            txtMemMax.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtMemMax.ForeColor = SystemColors.Highlight;
            txtMemMax.Location = new Point(140, 874);
            txtMemMax.Name = "txtMemMax";
            txtMemMax.Size = new Size(113, 36);
            txtMemMax.TabIndex = 33;
            txtMemMax.Text = "512";
            txtMemMax.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaxProce
            // 
            txtMaxProce.BackColor = Color.FromArgb(224, 224, 224);
            txtMaxProce.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txtMaxProce.ForeColor = SystemColors.Highlight;
            txtMaxProce.Location = new Point(581, 715);
            txtMaxProce.Name = "txtMaxProce";
            txtMaxProce.Size = new Size(113, 36);
            txtMaxProce.TabIndex = 34;
            txtMaxProce.Text = "5000";
            txtMaxProce.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(258, 720);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 30);
            label9.TabIndex = 35;
            label9.Text = "ms";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(701, 720);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 30);
            label10.TabIndex = 36;
            label10.Text = "ms";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(260, 876);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(39, 30);
            label11.TabIndex = 37;
            label11.Text = "kb";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(271, 241);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 30);
            label12.TabIndex = 38;
            label12.Text = "kb";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(239, 930);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(121, 30);
            label13.TabIndex = 39;
            label13.Text = "Velocidad:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(1391, 826);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(0, 30);
            label15.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(1242, 631);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(51, 30);
            label14.TabIndex = 42;
            label14.Text = "Log";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.ActiveCaption;
            btnAccept.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = SystemColors.ActiveCaptionText;
            btnAccept.Location = new Point(568, 839);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(138, 69);
            btnAccept.TabIndex = 43;
            btnAccept.Text = "Aplicar";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // Log
            // 
            Log.BackColor = SystemColors.Menu;
            Log.Font = new Font("Segoe UI Variable Small Semibol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log.Location = new Point(995, 676);
            Log.Name = "Log";
            Log.Size = new Size(543, 266);
            Log.TabIndex = 44;
            Log.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuText;
            button1.Location = new Point(1639, 146);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 45;
            button1.Text = "Tiempo Medio";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTiempoMedi
            // 
            lblTiempoMedi.AutoSize = true;
            lblTiempoMedi.BackColor = Color.Transparent;
            lblTiempoMedi.BorderStyle = BorderStyle.Fixed3D;
            lblTiempoMedi.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempoMedi.ForeColor = SystemColors.Control;
            lblTiempoMedi.Location = new Point(1763, 160);
            lblTiempoMedi.Margin = new Padding(4, 0, 4, 0);
            lblTiempoMedi.Name = "lblTiempoMedi";
            lblTiempoMedi.Size = new Size(27, 28);
            lblTiempoMedi.TabIndex = 46;
            lblTiempoMedi.Text = "0";
            lblTiempoMedi.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempoMedi.Click += lblTiempoMedi_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aqua;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.MenuText;
            button2.Location = new Point(1639, 284);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(248, 56);
            button2.TabIndex = 47;
            button2.Text = "Procesos Atendidos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // lblTotalProcesosAtendidos
            // 
            lblTotalProcesosAtendidos.AutoSize = true;
            lblTotalProcesosAtendidos.BackColor = Color.Transparent;
            lblTotalProcesosAtendidos.BorderStyle = BorderStyle.Fixed3D;
            lblTotalProcesosAtendidos.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProcesosAtendidos.ForeColor = SystemColors.Control;
            lblTotalProcesosAtendidos.Location = new Point(1830, 298);
            lblTotalProcesosAtendidos.Margin = new Padding(4, 0, 4, 0);
            lblTotalProcesosAtendidos.Name = "lblTotalProcesosAtendidos";
            lblTotalProcesosAtendidos.Size = new Size(27, 28);
            lblTotalProcesosAtendidos.TabIndex = 48;
            lblTotalProcesosAtendidos.Text = "0";
            lblTotalProcesosAtendidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaption;
            label16.Location = new Point(1863, 160);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(43, 30);
            label16.TabIndex = 49;
            label16.Text = "ms";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.FondoSO;
            ClientSize = new Size(1921, 1021);
            Controls.Add(label16);
            Controls.Add(lblTotalProcesosAtendidos);
            Controls.Add(button2);
            Controls.Add(lblTiempoMedi);
            Controls.Add(button1);
            Controls.Add(Log);
            Controls.Add(btnAccept);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMaxProce);
            Controls.Add(txtMemMax);
            Controls.Add(txtProcesamiento);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbMemoria);
            Controls.Add(btnResumeSimulation);
            Controls.Add(btnClearProcesses);
            Controls.Add(btnStopSimulation);
            Controls.Add(lblSpeed);
            Controls.Add(label7);
            Controls.Add(trackBarSpeed);
            Controls.Add(lblProcesoCount);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Administrador de procesos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox txtRA;
        private TextBox txtRB;
        private TextBox txtRC;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Memoria;
        private DataGridViewTextBoxColumn CPU;
        private DataGridViewTextBoxColumn TiempoEjecucion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Swap;
        private Label lblProcesoCount;
        private TrackBar trackBarSpeed;
        private Label label7;
        private Label lblSpeed;
        private Button btnStopSimulation;
        private Button btnClearProcesses;
        private Button btnResumeSimulation;
        private Label lbMemoria;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private TextBox txtProcesamiento;
        private TextBox txtMemMax;
        private TextBox txtMaxProce;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label14;
        private Button btnAccept;
        private RichTextBox Log;
        private Button button1;
        private Label lblTiempoMedi;
        private Button button2;
        private Label lblTotalProcesosAtendidos;
        private Label label16;
    }
}
