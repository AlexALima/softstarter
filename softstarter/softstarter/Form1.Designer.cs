namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PORTA = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.t_d = new System.Windows.Forms.Label();
            this.t_ac = new System.Windows.Forms.Label();
            this.alfa_m = new System.Windows.Forms.Label();
            this.alfa_i = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lig_lab = new System.Windows.Forms.Label();
            this.conect_lab = new System.Windows.Forms.Label();
            this.config_lab = new System.Windows.Forms.Label();
            this.desliga = new System.Windows.Forms.Button();
            this.liga = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.tensao_real = new System.Windows.Forms.Label();
            this.alfa_real = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.i_motor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.v_motor = new System.Windows.Forms.Label();
            this.alfa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testarConexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoDeÂnguloInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alemãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PORTA
            // 
            this.PORTA.PortName = "COM16";
            this.PORTA.ReadBufferSize = 100;
            this.PORTA.ReadTimeout = 1;
            this.PORTA.ReceivedBytesThreshold = 7;
            this.PORTA.WriteTimeout = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 24);
            this.progressBar1.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(176, 158);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tempo de desaceleração (s):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Configurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(176, 119);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(149, 77);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleDescription = "";
            this.numericUpDown1.AccessibleName = "";
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(149, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempo de acionamento (s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alfa mínimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alfa inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lig_lab);
            this.groupBox2.Controls.Add(this.conect_lab);
            this.groupBox2.Controls.Add(this.config_lab);
            this.groupBox2.Controls.Add(this.desliga);
            this.groupBox2.Controls.Add(this.liga);
            this.groupBox2.Location = new System.Drawing.Point(260, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispositivo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(205, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 66);
            this.button2.TabIndex = 14;
            this.button2.Text = "Notfall";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.t_d);
            this.groupBox4.Controls.Add(this.t_ac);
            this.groupBox4.Controls.Add(this.alfa_m);
            this.groupBox4.Controls.Add(this.alfa_i);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(127, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 84);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurado";
            this.groupBox4.Visible = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // t_d
            // 
            this.t_d.AutoSize = true;
            this.t_d.Location = new System.Drawing.Point(143, 64);
            this.t_d.Name = "t_d";
            this.t_d.Size = new System.Drawing.Size(41, 13);
            this.t_d.TabIndex = 7;
            this.t_d.Text = "label12";
            // 
            // t_ac
            // 
            this.t_ac.AutoSize = true;
            this.t_ac.Location = new System.Drawing.Point(134, 48);
            this.t_ac.Name = "t_ac";
            this.t_ac.Size = new System.Drawing.Size(41, 13);
            this.t_ac.TabIndex = 6;
            this.t_ac.Text = "label12";
            // 
            // alfa_m
            // 
            this.alfa_m.AutoSize = true;
            this.alfa_m.Location = new System.Drawing.Point(78, 32);
            this.alfa_m.Name = "alfa_m";
            this.alfa_m.Size = new System.Drawing.Size(41, 13);
            this.alfa_m.TabIndex = 5;
            this.alfa_m.Text = "label12";
            // 
            // alfa_i
            // 
            this.alfa_i.AutoSize = true;
            this.alfa_i.Location = new System.Drawing.Point(69, 16);
            this.alfa_i.Name = "alfa_i";
            this.alfa_i.Size = new System.Drawing.Size(41, 13);
            this.alfa_i.TabIndex = 4;
            this.alfa_i.Text = "label12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tempo de desaceleração:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tempo de acionamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alfa máximo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alfa inicial:";
            // 
            // lig_lab
            // 
            this.lig_lab.AutoSize = true;
            this.lig_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lig_lab.ForeColor = System.Drawing.Color.Red;
            this.lig_lab.Location = new System.Drawing.Point(16, 74);
            this.lig_lab.Name = "lig_lab";
            this.lig_lab.Size = new System.Drawing.Size(71, 13);
            this.lig_lab.TabIndex = 4;
            this.lig_lab.Text = "Desativado";
            // 
            // conect_lab
            // 
            this.conect_lab.AutoSize = true;
            this.conect_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conect_lab.ForeColor = System.Drawing.Color.Red;
            this.conect_lab.Location = new System.Drawing.Point(16, 28);
            this.conect_lab.Name = "conect_lab";
            this.conect_lab.Size = new System.Drawing.Size(89, 13);
            this.conect_lab.TabIndex = 3;
            this.conect_lab.Text = "Desconectado";
            // 
            // config_lab
            // 
            this.config_lab.AutoSize = true;
            this.config_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_lab.ForeColor = System.Drawing.Color.Red;
            this.config_lab.Location = new System.Drawing.Point(16, 51);
            this.config_lab.Name = "config_lab";
            this.config_lab.Size = new System.Drawing.Size(96, 13);
            this.config_lab.TabIndex = 2;
            this.config_lab.Text = "Desconfigurado";
            // 
            // desliga
            // 
            this.desliga.BackColor = System.Drawing.Color.Red;
            this.desliga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.desliga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desliga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desliga.Location = new System.Drawing.Point(99, 113);
            this.desliga.Name = "desliga";
            this.desliga.Size = new System.Drawing.Size(100, 66);
            this.desliga.TabIndex = 1;
            this.desliga.Text = "Deaktivieren";
            this.desliga.UseVisualStyleBackColor = false;
            this.desliga.Click += new System.EventHandler(this.desliga_Click);
            // 
            // liga
            // 
            this.liga.BackColor = System.Drawing.Color.Lime;
            this.liga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.liga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.liga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liga.Location = new System.Drawing.Point(7, 113);
            this.liga.Name = "liga";
            this.liga.Size = new System.Drawing.Size(86, 66);
            this.liga.TabIndex = 0;
            this.liga.Text = "Starten";
            this.liga.UseVisualStyleBackColor = false;
            this.liga.Click += new System.EventHandler(this.liga_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tensao_real);
            this.groupBox3.Controls.Add(this.alfa_real);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.i_motor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(260, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 101);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Análise do dispositivo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(214, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Corrente";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(62, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Tensão";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(168, 62);
            this.progressBar3.Maximum = 1024;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(147, 17);
            this.progressBar3.TabIndex = 19;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(7, 62);
            this.progressBar2.Maximum = 22000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(147, 17);
            this.progressBar2.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(96, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Tensão no motor (Vrms):";
            // 
            // tensao_real
            // 
            this.tensao_real.AutoSize = true;
            this.tensao_real.Location = new System.Drawing.Point(221, 40);
            this.tensao_real.Name = "tensao_real";
            this.tensao_real.Size = new System.Drawing.Size(25, 13);
            this.tensao_real.TabIndex = 16;
            this.tensao_real.Text = "???";
            // 
            // alfa_real
            // 
            this.alfa_real.AutoSize = true;
            this.alfa_real.Location = new System.Drawing.Point(45, 40);
            this.alfa_real.Name = "alfa_real";
            this.alfa_real.Size = new System.Drawing.Size(25, 13);
            this.alfa_real.TabIndex = 15;
            this.alfa_real.Text = "???";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Alfa:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Location = new System.Drawing.Point(214, 19);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(54, 13);
            this.status.TabIndex = 13;
            this.status.Text = "Desligado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Status:";
            // 
            // i_motor
            // 
            this.i_motor.AutoSize = true;
            this.i_motor.Location = new System.Drawing.Point(111, 19);
            this.i_motor.Name = "i_motor";
            this.i_motor.Size = new System.Drawing.Size(25, 13);
            this.i_motor.TabIndex = 6;
            this.i_motor.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Corrente no motor:";
            // 
            // v_motor
            // 
            this.v_motor.AutoSize = true;
            this.v_motor.Location = new System.Drawing.Point(158, 201);
            this.v_motor.Name = "v_motor";
            this.v_motor.Size = new System.Drawing.Size(25, 13);
            this.v_motor.TabIndex = 10;
            this.v_motor.Text = "???";
            // 
            // alfa
            // 
            this.alfa.AutoSize = true;
            this.alfa.Location = new System.Drawing.Point(42, 201);
            this.alfa.Name = "alfa";
            this.alfa.Size = new System.Drawing.Size(25, 13);
            this.alfa.TabIndex = 9;
            this.alfa.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tensão (Vrms):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alfa:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoManualToolStripMenuItem,
            this.testarConexãoToolStripMenuItem,
            this.cálculoDeÂnguloInicialToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoManualToolStripMenuItem
            // 
            this.modoManualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.automáticoToolStripMenuItem});
            this.modoManualToolStripMenuItem.Name = "modoManualToolStripMenuItem";
            this.modoManualToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.modoManualToolStripMenuItem.Text = "Modo";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.CheckOnClick = true;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // automáticoToolStripMenuItem
            // 
            this.automáticoToolStripMenuItem.Checked = true;
            this.automáticoToolStripMenuItem.CheckOnClick = true;
            this.automáticoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automáticoToolStripMenuItem.Name = "automáticoToolStripMenuItem";
            this.automáticoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.automáticoToolStripMenuItem.Text = "Automático";
            this.automáticoToolStripMenuItem.Click += new System.EventHandler(this.automáticoToolStripMenuItem_Click);
            // 
            // testarConexãoToolStripMenuItem
            // 
            this.testarConexãoToolStripMenuItem.Name = "testarConexãoToolStripMenuItem";
            this.testarConexãoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.testarConexãoToolStripMenuItem.Text = "Testar conexão";
            this.testarConexãoToolStripMenuItem.Click += new System.EventHandler(this.testarConexãoToolStripMenuItem_Click);
            // 
            // cálculoDeÂnguloInicialToolStripMenuItem
            // 
            this.cálculoDeÂnguloInicialToolStripMenuItem.Name = "cálculoDeÂnguloInicialToolStripMenuItem";
            this.cálculoDeÂnguloInicialToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cálculoDeÂnguloInicialToolStripMenuItem.Text = "Cálculo de ângulo";
            this.cálculoDeÂnguloInicialToolStripMenuItem.Click += new System.EventHandler(this.cálculoDeÂnguloInicialToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portuguêsToolStripMenuItem,
            this.inglêsToolStripMenuItem,
            this.alemãoToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // portuguêsToolStripMenuItem
            // 
            this.portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            this.portuguêsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.portuguêsToolStripMenuItem.Text = "Português";
            this.portuguêsToolStripMenuItem.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click);
            // 
            // inglêsToolStripMenuItem
            // 
            this.inglêsToolStripMenuItem.Name = "inglêsToolStripMenuItem";
            this.inglêsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.inglêsToolStripMenuItem.Text = "Inglês";
            this.inglêsToolStripMenuItem.Click += new System.EventHandler(this.inglêsToolStripMenuItem_Click);
            // 
            // alemãoToolStripMenuItem
            // 
            this.alemãoToolStripMenuItem.Name = "alemãoToolStripMenuItem";
            this.alemãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alemãoToolStripMenuItem.Text = "Alemão";
            this.alemãoToolStripMenuItem.Click += new System.EventHandler(this.alemãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.numericUpDown5);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(675, 122);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cálculo do ângulo inicial";
            this.groupBox5.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(319, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 97);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado";
            this.groupBox6.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(126, 63);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 28);
            this.button8.TabIndex = 5;
            this.button8.Text = "Alfa mínimo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(118, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tensão calculada:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "Alfa inicial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(118, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Alfa:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(131, 52);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown5.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tensão (Vrms):";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.trackBar1);
            this.groupBox7.Controls.Add(this.v_motor);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.alfa);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(587, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 295);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Modo manual";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 125);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(6, 149);
            this.trackBar1.Maximum = 18000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 18000;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(107, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 65);
            this.button7.TabIndex = 15;
            this.button7.Text = "Deaktivieren";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 65);
            this.button6.TabIndex = 15;
            this.button6.Text = "Starten";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(813, 332);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soft Starter - Alexandre Lima, Leonardo Paz e Lucas Leal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button liga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label i_motor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lig_lab;
        private System.Windows.Forms.Label conect_lab;
        private System.Windows.Forms.Label config_lab;
        private System.Windows.Forms.Label v_motor;
        private System.Windows.Forms.Label alfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label t_d;
        private System.Windows.Forms.Label t_ac;
        private System.Windows.Forms.Label alfa_m;
        private System.Windows.Forms.Label alfa_i;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testarConexãoToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort PORTA;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alemãoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem cálculoDeÂnguloInicialToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button desliga;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label tensao_real;
        private System.Windows.Forms.Label alfa_real;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripMenuItem modoManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automáticoToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}

