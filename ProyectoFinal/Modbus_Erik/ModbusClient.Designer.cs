
namespace Modbus_Erik
{
    partial class ModbusClient
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel_Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_Cicle = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
            this.darkGroupBox_Comunication = new DarkUI.Controls.DarkGroupBox();
            this.darkButton_Disconnect = new DarkUI.Controls.DarkButton();
            this.darkButton_Connect = new DarkUI.Controls.DarkButton();
            this.darkLabel_Interval = new DarkUI.Controls.DarkLabel();
            this.darkComboBox_Interval = new DarkUI.Controls.DarkComboBox();
            this.ucCheckBox_DefaultPort = new HZH_Controls.Controls.UCCheckBox();
            this.ucCheckBox_Localhost = new HZH_Controls.Controls.UCCheckBox();
            this.ucTextBoxEx_Port = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucTextBoxEx_IP = new HZH_Controls.Controls.UCTextBoxEx();
            this.darkGroupBox_DataExchange = new DarkUI.Controls.DarkGroupBox();
            this.ucSwitch_CoilValue = new HZH_Controls.Controls.UCSwitch();
            this.ucTextBoxEx_CoilAddress = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucTextBoxEx_Size = new HZH_Controls.Controls.UCTextBoxEx();
            this.darkButton_WriteSingleCoil = new DarkUI.Controls.DarkButton();
            this.ucTextBoxEx_RegisterValue = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucTextBoxEx_RegisterAddress = new HZH_Controls.Controls.UCTextBoxEx();
            this.darkButton_WriteSingleRegister = new DarkUI.Controls.DarkButton();
            this.ucTextBoxEx_StartAddress = new HZH_Controls.Controls.UCTextBoxEx();
            this.darkLabel_CoilValue = new DarkUI.Controls.DarkLabel();
            this.darkLabel_RegisterValue = new DarkUI.Controls.DarkLabel();
            this.darkLabel_CoilAddress = new DarkUI.Controls.DarkLabel();
            this.darkLabel_RegisterAddress = new DarkUI.Controls.DarkLabel();
            this.darkLabel_Size = new DarkUI.Controls.DarkLabel();
            this.darkLabel_StartAddress = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox_Data = new DarkUI.Controls.DarkGroupBox();
            this.ucSwitch_StartVisu = new HZH_Controls.Controls.UCSwitch();
            this.ucMeter_Visu = new HZH_Controls.Controls.UCMeter();
            this.darkContextMenuVisu = new DarkUI.Controls.DarkContextMenu();
            this._Degree = new System.Windows.Forms.ToolStripMenuItem();
            this._Divisions = new System.Windows.Forms.ToolStripMenuItem();
            this._MaxValue = new System.Windows.Forms.ToolStripMenuItem();
            this._TagName = new System.Windows.Forms.ToolStripMenuItem();
            this.ucSplitLine_V1 = new HZH_Controls.Controls.UCSplitLine_V();
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox_DiscreteInputs = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox_Coils = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox_InputRegisters = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_HoldingRegisters = new System.Windows.Forms.ListBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.ucTextBoxEx_VisuAddress = new HZH_Controls.Controls.UCTextBoxEx();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.timerPolling = new System.Windows.Forms.Timer(this.components);
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.timer_Visu = new System.Windows.Forms.Timer(this.components);
            this._MinValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.darkStatusStrip1.SuspendLayout();
            this.darkMenuStrip1.SuspendLayout();
            this.darkGroupBox_Comunication.SuspendLayout();
            this.darkGroupBox_DataExchange.SuspendLayout();
            this.darkGroupBox_Data.SuspendLayout();
            this.darkContextMenuVisu.SuspendLayout();
            this.tabControlExt1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Estado,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar_Cicle,
            this.toolStripStatusLabel_Hora});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 713);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1136, 32);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel_Estado
            // 
            this.toolStripStatusLabel_Estado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.toolStripStatusLabel_Estado.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_Estado.Name = "toolStripStatusLabel_Estado";
            this.toolStripStatusLabel_Estado.Size = new System.Drawing.Size(112, 19);
            this.toolStripStatusLabel_Estado.Text = "Estado Conexión";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(844, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 19);
            this.toolStripStatusLabel2.Text = "Ciclo";
            // 
            // toolStripProgressBar_Cicle
            // 
            this.toolStripProgressBar_Cicle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar_Cicle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.toolStripProgressBar_Cicle.Name = "toolStripProgressBar_Cicle";
            this.toolStripProgressBar_Cicle.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBar_Cicle.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // toolStripStatusLabel_Hora
            // 
            this.toolStripStatusLabel_Hora.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.toolStripStatusLabel_Hora.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_Hora.Name = "toolStripStatusLabel_Hora";
            this.toolStripStatusLabel_Hora.Size = new System.Drawing.Size(39, 19);
            this.toolStripStatusLabel_Hora.Text = "Hora";
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.darkMenuStrip1.TabIndex = 1;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Load,
            this.ToolStripMenuItem_Save,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripMenuItem_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_Save.Text = "Guardar Configuración";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // darkDockPanel1
            // 
            this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkDockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkDockPanel1.Location = new System.Drawing.Point(0, 24);
            this.darkDockPanel1.Name = "darkDockPanel1";
            this.darkDockPanel1.Size = new System.Drawing.Size(1136, 689);
            this.darkDockPanel1.TabIndex = 2;
            // 
            // darkGroupBox_Comunication
            // 
            this.darkGroupBox_Comunication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox_Comunication.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_Comunication.Controls.Add(this.darkButton_Disconnect);
            this.darkGroupBox_Comunication.Controls.Add(this.darkButton_Connect);
            this.darkGroupBox_Comunication.Controls.Add(this.darkLabel_Interval);
            this.darkGroupBox_Comunication.Controls.Add(this.darkComboBox_Interval);
            this.darkGroupBox_Comunication.Controls.Add(this.ucCheckBox_DefaultPort);
            this.darkGroupBox_Comunication.Controls.Add(this.ucCheckBox_Localhost);
            this.darkGroupBox_Comunication.Controls.Add(this.ucTextBoxEx_Port);
            this.darkGroupBox_Comunication.Controls.Add(this.ucTextBoxEx_IP);
            this.darkGroupBox_Comunication.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.darkGroupBox_Comunication.Location = new System.Drawing.Point(12, 27);
            this.darkGroupBox_Comunication.Name = "darkGroupBox_Comunication";
            this.darkGroupBox_Comunication.Size = new System.Drawing.Size(1112, 81);
            this.darkGroupBox_Comunication.TabIndex = 3;
            this.darkGroupBox_Comunication.TabStop = false;
            this.darkGroupBox_Comunication.Text = "Comunicación";
            // 
            // darkButton_Disconnect
            // 
            this.darkButton_Disconnect.ForeColor = System.Drawing.Color.White;
            this.darkButton_Disconnect.Location = new System.Drawing.Point(983, 31);
            this.darkButton_Disconnect.Name = "darkButton_Disconnect";
            this.darkButton_Disconnect.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_Disconnect.Size = new System.Drawing.Size(108, 27);
            this.darkButton_Disconnect.TabIndex = 7;
            this.darkButton_Disconnect.Text = "Desconectar";
            this.darkButton_Disconnect.Click += new System.EventHandler(this.darkButton_Disconnect_Click);
            // 
            // darkButton_Connect
            // 
            this.darkButton_Connect.ForeColor = System.Drawing.Color.White;
            this.darkButton_Connect.Location = new System.Drawing.Point(861, 31);
            this.darkButton_Connect.Name = "darkButton_Connect";
            this.darkButton_Connect.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_Connect.Size = new System.Drawing.Size(108, 27);
            this.darkButton_Connect.TabIndex = 7;
            this.darkButton_Connect.Text = "Conectar";
            this.darkButton_Connect.Click += new System.EventHandler(this.darkButton_Connect_Click);
            // 
            // darkLabel_Interval
            // 
            this.darkLabel_Interval.AutoSize = true;
            this.darkLabel_Interval.ForeColor = System.Drawing.Color.White;
            this.darkLabel_Interval.Location = new System.Drawing.Point(549, 35);
            this.darkLabel_Interval.Name = "darkLabel_Interval";
            this.darkLabel_Interval.Size = new System.Drawing.Size(149, 19);
            this.darkLabel_Interval.TabIndex = 5;
            this.darkLabel_Interval.Text = "Intervalos Lectura (ms)";
            // 
            // darkComboBox_Interval
            // 
            this.darkComboBox_Interval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBox_Interval.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.darkComboBox_Interval.FormatString = "N0";
            this.darkComboBox_Interval.FormattingEnabled = true;
            this.darkComboBox_Interval.Items.AddRange(new object[] {
            "100",
            "1000",
            "2000",
            "3000"});
            this.darkComboBox_Interval.Location = new System.Drawing.Point(716, 30);
            this.darkComboBox_Interval.Name = "darkComboBox_Interval";
            this.darkComboBox_Interval.Size = new System.Drawing.Size(126, 28);
            this.darkComboBox_Interval.TabIndex = 6;
            this.darkComboBox_Interval.SelectedIndexChanged += new System.EventHandler(this.darkComboBox_Interval_SelectedIndexChanged);
            // 
            // ucCheckBox_DefaultPort
            // 
            this.ucCheckBox_DefaultPort.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox_DefaultPort.Checked = false;
            this.ucCheckBox_DefaultPort.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.ucCheckBox_DefaultPort.ForeColor = System.Drawing.Color.White;
            this.ucCheckBox_DefaultPort.Location = new System.Drawing.Point(420, 31);
            this.ucCheckBox_DefaultPort.Name = "ucCheckBox_DefaultPort";
            this.ucCheckBox_DefaultPort.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox_DefaultPort.Size = new System.Drawing.Size(110, 27);
            this.ucCheckBox_DefaultPort.TabIndex = 3;
            this.ucCheckBox_DefaultPort.TextValue = "Por defecto";
            this.ucCheckBox_DefaultPort.CheckedChangeEvent += new System.EventHandler(this.ucCheckBox_DefaultPort_CheckedChangeEvent);
            // 
            // ucCheckBox_Localhost
            // 
            this.ucCheckBox_Localhost.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox_Localhost.Checked = false;
            this.ucCheckBox_Localhost.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.ucCheckBox_Localhost.ForeColor = System.Drawing.Color.White;
            this.ucCheckBox_Localhost.Location = new System.Drawing.Point(204, 31);
            this.ucCheckBox_Localhost.Name = "ucCheckBox_Localhost";
            this.ucCheckBox_Localhost.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox_Localhost.Size = new System.Drawing.Size(102, 27);
            this.ucCheckBox_Localhost.TabIndex = 1;
            this.ucCheckBox_Localhost.TextValue = "Localhost";
            this.ucCheckBox_Localhost.CheckedChangeEvent += new System.EventHandler(this.ucCheckBox_Localhost_CheckedChangeEvent);
            // 
            // ucTextBoxEx_Port
            // 
            this.ucTextBoxEx_Port.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_Port.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_Port.ConerRadius = 20;
            this.ucTextBoxEx_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_Port.DecLength = 0;
            this.ucTextBoxEx_Port.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_Port.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_Port.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_Port.ForeColor = System.Drawing.Color.White;
            this.ucTextBoxEx_Port.InputText = "";
            this.ucTextBoxEx_Port.InputType = HZH_Controls.TextInputType.Number;
            this.ucTextBoxEx_Port.IsFocusColor = true;
            this.ucTextBoxEx_Port.IsRadius = true;
            this.ucTextBoxEx_Port.IsShowClearBtn = true;
            this.ucTextBoxEx_Port.IsShowKeyboard = false;
            this.ucTextBoxEx_Port.IsShowRect = true;
            this.ucTextBoxEx_Port.IsShowSearchBtn = false;
            this.ucTextBoxEx_Port.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_Port.Location = new System.Drawing.Point(312, 31);
            this.ucTextBoxEx_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_Port.MaxValue = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ucTextBoxEx_Port.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_Port.Name = "ucTextBoxEx_Port";
            this.ucTextBoxEx_Port.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_Port.PasswordChar = '\0';
            this.ucTextBoxEx_Port.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_Port.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_Port.PromptText = "Puerto";
            this.ucTextBoxEx_Port.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_Port.RectWidth = 1;
            this.ucTextBoxEx_Port.RegexPattern = "";
            this.ucTextBoxEx_Port.Size = new System.Drawing.Size(101, 27);
            this.ucTextBoxEx_Port.TabIndex = 2;
            // 
            // ucTextBoxEx_IP
            // 
            this.ucTextBoxEx_IP.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_IP.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_IP.ConerRadius = 20;
            this.ucTextBoxEx_IP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_IP.DecLength = 0;
            this.ucTextBoxEx_IP.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_IP.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_IP.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_IP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_IP.InputText = "";
            this.ucTextBoxEx_IP.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx_IP.IsFocusColor = true;
            this.ucTextBoxEx_IP.IsRadius = true;
            this.ucTextBoxEx_IP.IsShowClearBtn = true;
            this.ucTextBoxEx_IP.IsShowKeyboard = false;
            this.ucTextBoxEx_IP.IsShowRect = true;
            this.ucTextBoxEx_IP.IsShowSearchBtn = false;
            this.ucTextBoxEx_IP.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_IP.Location = new System.Drawing.Point(31, 31);
            this.ucTextBoxEx_IP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_IP.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_IP.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_IP.Name = "ucTextBoxEx_IP";
            this.ucTextBoxEx_IP.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_IP.PasswordChar = '\0';
            this.ucTextBoxEx_IP.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_IP.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_IP.PromptText = "Dirección IP";
            this.ucTextBoxEx_IP.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_IP.RectWidth = 1;
            this.ucTextBoxEx_IP.RegexPattern = "";
            this.ucTextBoxEx_IP.Size = new System.Drawing.Size(166, 27);
            this.ucTextBoxEx_IP.TabIndex = 0;
            this.ucTextBoxEx_IP.TextChanged += new System.EventHandler(this.ucTextBoxEx_IP_TextChanged);
            this.ucTextBoxEx_IP.Leave += new System.EventHandler(this.ucTextBoxEx_IP_Leave);
            // 
            // darkGroupBox_DataExchange
            // 
            this.darkGroupBox_DataExchange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox_DataExchange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_DataExchange.Controls.Add(this.ucSwitch_CoilValue);
            this.darkGroupBox_DataExchange.Controls.Add(this.ucTextBoxEx_CoilAddress);
            this.darkGroupBox_DataExchange.Controls.Add(this.ucTextBoxEx_Size);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkButton_WriteSingleCoil);
            this.darkGroupBox_DataExchange.Controls.Add(this.ucTextBoxEx_RegisterValue);
            this.darkGroupBox_DataExchange.Controls.Add(this.ucTextBoxEx_RegisterAddress);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkButton_WriteSingleRegister);
            this.darkGroupBox_DataExchange.Controls.Add(this.ucTextBoxEx_StartAddress);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_CoilValue);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_RegisterValue);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_CoilAddress);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_RegisterAddress);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_Size);
            this.darkGroupBox_DataExchange.Controls.Add(this.darkLabel_StartAddress);
            this.darkGroupBox_DataExchange.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.darkGroupBox_DataExchange.Location = new System.Drawing.Point(12, 114);
            this.darkGroupBox_DataExchange.Name = "darkGroupBox_DataExchange";
            this.darkGroupBox_DataExchange.Size = new System.Drawing.Size(1112, 138);
            this.darkGroupBox_DataExchange.TabIndex = 3;
            this.darkGroupBox_DataExchange.TabStop = false;
            this.darkGroupBox_DataExchange.Text = "Intercambio de Datos";
            // 
            // ucSwitch_CoilValue
            // 
            this.ucSwitch_CoilValue.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch_CoilValue.Checked = false;
            this.ucSwitch_CoilValue.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch_CoilValue.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitch_CoilValue.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSwitch_CoilValue.Location = new System.Drawing.Point(692, 77);
            this.ucSwitch_CoilValue.Name = "ucSwitch_CoilValue";
            this.ucSwitch_CoilValue.Size = new System.Drawing.Size(84, 27);
            this.ucSwitch_CoilValue.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitch_CoilValue.TabIndex = 2;
            this.ucSwitch_CoilValue.Texts = new string[] {
        "True",
        "False"};
            this.ucSwitch_CoilValue.TrueColor = System.Drawing.Color.LimeGreen;
            this.ucSwitch_CoilValue.TrueTextColr = System.Drawing.Color.White;
            // 
            // ucTextBoxEx_CoilAddress
            // 
            this.ucTextBoxEx_CoilAddress.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_CoilAddress.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_CoilAddress.ConerRadius = 20;
            this.ucTextBoxEx_CoilAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_CoilAddress.DecLength = 0;
            this.ucTextBoxEx_CoilAddress.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_CoilAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_CoilAddress.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_CoilAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_CoilAddress.InputText = "1";
            this.ucTextBoxEx_CoilAddress.InputType = HZH_Controls.TextInputType.Integer;
            this.ucTextBoxEx_CoilAddress.IsFocusColor = true;
            this.ucTextBoxEx_CoilAddress.IsRadius = true;
            this.ucTextBoxEx_CoilAddress.IsShowClearBtn = false;
            this.ucTextBoxEx_CoilAddress.IsShowKeyboard = false;
            this.ucTextBoxEx_CoilAddress.IsShowRect = true;
            this.ucTextBoxEx_CoilAddress.IsShowSearchBtn = false;
            this.ucTextBoxEx_CoilAddress.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_CoilAddress.Location = new System.Drawing.Point(518, 77);
            this.ucTextBoxEx_CoilAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_CoilAddress.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_CoilAddress.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_CoilAddress.Name = "ucTextBoxEx_CoilAddress";
            this.ucTextBoxEx_CoilAddress.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_CoilAddress.PasswordChar = '\0';
            this.ucTextBoxEx_CoilAddress.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_CoilAddress.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_CoilAddress.PromptText = "0";
            this.ucTextBoxEx_CoilAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_CoilAddress.RectWidth = 1;
            this.ucTextBoxEx_CoilAddress.RegexPattern = "";
            this.ucTextBoxEx_CoilAddress.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_CoilAddress.TabIndex = 0;
            // 
            // ucTextBoxEx_Size
            // 
            this.ucTextBoxEx_Size.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_Size.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_Size.ConerRadius = 20;
            this.ucTextBoxEx_Size.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_Size.DecLength = 0;
            this.ucTextBoxEx_Size.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_Size.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_Size.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_Size.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_Size.InputText = "20";
            this.ucTextBoxEx_Size.InputType = HZH_Controls.TextInputType.Integer;
            this.ucTextBoxEx_Size.IsFocusColor = true;
            this.ucTextBoxEx_Size.IsRadius = true;
            this.ucTextBoxEx_Size.IsShowClearBtn = false;
            this.ucTextBoxEx_Size.IsShowKeyboard = false;
            this.ucTextBoxEx_Size.IsShowRect = true;
            this.ucTextBoxEx_Size.IsShowSearchBtn = false;
            this.ucTextBoxEx_Size.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_Size.Location = new System.Drawing.Point(105, 77);
            this.ucTextBoxEx_Size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_Size.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_Size.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_Size.Name = "ucTextBoxEx_Size";
            this.ucTextBoxEx_Size.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_Size.PasswordChar = '\0';
            this.ucTextBoxEx_Size.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_Size.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_Size.PromptText = "0";
            this.ucTextBoxEx_Size.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_Size.RectWidth = 1;
            this.ucTextBoxEx_Size.RegexPattern = "";
            this.ucTextBoxEx_Size.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_Size.TabIndex = 0;
            // 
            // darkButton_WriteSingleCoil
            // 
            this.darkButton_WriteSingleCoil.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton_WriteSingleCoil.ForeColor = System.Drawing.Color.White;
            this.darkButton_WriteSingleCoil.Location = new System.Drawing.Point(267, 77);
            this.darkButton_WriteSingleCoil.Name = "darkButton_WriteSingleCoil";
            this.darkButton_WriteSingleCoil.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_WriteSingleCoil.Size = new System.Drawing.Size(158, 27);
            this.darkButton_WriteSingleCoil.TabIndex = 7;
            this.darkButton_WriteSingleCoil.Text = "Escribir en Bobina\r\n";
            this.darkButton_WriteSingleCoil.Click += new System.EventHandler(this.darkButton_WriteSingleCoil_Click);
            // 
            // ucTextBoxEx_RegisterValue
            // 
            this.ucTextBoxEx_RegisterValue.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_RegisterValue.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_RegisterValue.ConerRadius = 20;
            this.ucTextBoxEx_RegisterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_RegisterValue.DecLength = 0;
            this.ucTextBoxEx_RegisterValue.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_RegisterValue.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_RegisterValue.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_RegisterValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_RegisterValue.InputText = "0";
            this.ucTextBoxEx_RegisterValue.InputType = HZH_Controls.TextInputType.Integer;
            this.ucTextBoxEx_RegisterValue.IsFocusColor = true;
            this.ucTextBoxEx_RegisterValue.IsRadius = true;
            this.ucTextBoxEx_RegisterValue.IsShowClearBtn = false;
            this.ucTextBoxEx_RegisterValue.IsShowKeyboard = false;
            this.ucTextBoxEx_RegisterValue.IsShowRect = true;
            this.ucTextBoxEx_RegisterValue.IsShowSearchBtn = false;
            this.ucTextBoxEx_RegisterValue.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_RegisterValue.Location = new System.Drawing.Point(692, 40);
            this.ucTextBoxEx_RegisterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_RegisterValue.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_RegisterValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_RegisterValue.Name = "ucTextBoxEx_RegisterValue";
            this.ucTextBoxEx_RegisterValue.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_RegisterValue.PasswordChar = '\0';
            this.ucTextBoxEx_RegisterValue.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_RegisterValue.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_RegisterValue.PromptText = "0";
            this.ucTextBoxEx_RegisterValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_RegisterValue.RectWidth = 1;
            this.ucTextBoxEx_RegisterValue.RegexPattern = "";
            this.ucTextBoxEx_RegisterValue.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_RegisterValue.TabIndex = 0;
            // 
            // ucTextBoxEx_RegisterAddress
            // 
            this.ucTextBoxEx_RegisterAddress.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_RegisterAddress.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_RegisterAddress.ConerRadius = 20;
            this.ucTextBoxEx_RegisterAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_RegisterAddress.DecLength = 0;
            this.ucTextBoxEx_RegisterAddress.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_RegisterAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_RegisterAddress.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_RegisterAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_RegisterAddress.InputText = "1";
            this.ucTextBoxEx_RegisterAddress.InputType = HZH_Controls.TextInputType.Integer;
            this.ucTextBoxEx_RegisterAddress.IsFocusColor = true;
            this.ucTextBoxEx_RegisterAddress.IsRadius = true;
            this.ucTextBoxEx_RegisterAddress.IsShowClearBtn = false;
            this.ucTextBoxEx_RegisterAddress.IsShowKeyboard = false;
            this.ucTextBoxEx_RegisterAddress.IsShowRect = true;
            this.ucTextBoxEx_RegisterAddress.IsShowSearchBtn = false;
            this.ucTextBoxEx_RegisterAddress.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_RegisterAddress.Location = new System.Drawing.Point(518, 40);
            this.ucTextBoxEx_RegisterAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_RegisterAddress.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_RegisterAddress.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_RegisterAddress.Name = "ucTextBoxEx_RegisterAddress";
            this.ucTextBoxEx_RegisterAddress.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_RegisterAddress.PasswordChar = '\0';
            this.ucTextBoxEx_RegisterAddress.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_RegisterAddress.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_RegisterAddress.PromptText = "0";
            this.ucTextBoxEx_RegisterAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_RegisterAddress.RectWidth = 1;
            this.ucTextBoxEx_RegisterAddress.RegexPattern = "";
            this.ucTextBoxEx_RegisterAddress.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_RegisterAddress.TabIndex = 0;
            // 
            // darkButton_WriteSingleRegister
            // 
            this.darkButton_WriteSingleRegister.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkButton_WriteSingleRegister.ForeColor = System.Drawing.Color.White;
            this.darkButton_WriteSingleRegister.Location = new System.Drawing.Point(267, 40);
            this.darkButton_WriteSingleRegister.Name = "darkButton_WriteSingleRegister";
            this.darkButton_WriteSingleRegister.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton_WriteSingleRegister.Size = new System.Drawing.Size(158, 27);
            this.darkButton_WriteSingleRegister.TabIndex = 7;
            this.darkButton_WriteSingleRegister.Text = "Escribir en Registro";
            this.darkButton_WriteSingleRegister.Click += new System.EventHandler(this.darkButton_WriteSingleRegister_Click);
            // 
            // ucTextBoxEx_StartAddress
            // 
            this.ucTextBoxEx_StartAddress.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_StartAddress.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_StartAddress.ConerRadius = 20;
            this.ucTextBoxEx_StartAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_StartAddress.DecLength = 0;
            this.ucTextBoxEx_StartAddress.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_StartAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_StartAddress.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_StartAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_StartAddress.InputText = "0";
            this.ucTextBoxEx_StartAddress.InputType = HZH_Controls.TextInputType.Integer;
            this.ucTextBoxEx_StartAddress.IsFocusColor = true;
            this.ucTextBoxEx_StartAddress.IsRadius = true;
            this.ucTextBoxEx_StartAddress.IsShowClearBtn = false;
            this.ucTextBoxEx_StartAddress.IsShowKeyboard = false;
            this.ucTextBoxEx_StartAddress.IsShowRect = true;
            this.ucTextBoxEx_StartAddress.IsShowSearchBtn = false;
            this.ucTextBoxEx_StartAddress.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_StartAddress.Location = new System.Drawing.Point(105, 40);
            this.ucTextBoxEx_StartAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_StartAddress.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_StartAddress.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_StartAddress.Name = "ucTextBoxEx_StartAddress";
            this.ucTextBoxEx_StartAddress.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_StartAddress.PasswordChar = '\0';
            this.ucTextBoxEx_StartAddress.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_StartAddress.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_StartAddress.PromptText = "0";
            this.ucTextBoxEx_StartAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_StartAddress.RectWidth = 1;
            this.ucTextBoxEx_StartAddress.RegexPattern = "";
            this.ucTextBoxEx_StartAddress.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_StartAddress.TabIndex = 0;
            this.ucTextBoxEx_StartAddress.Leave += new System.EventHandler(this.ucTextBoxEx_StartAddress_Leave);
            // 
            // darkLabel_CoilValue
            // 
            this.darkLabel_CoilValue.AutoSize = true;
            this.darkLabel_CoilValue.ForeColor = System.Drawing.Color.White;
            this.darkLabel_CoilValue.Location = new System.Drawing.Point(643, 81);
            this.darkLabel_CoilValue.Name = "darkLabel_CoilValue";
            this.darkLabel_CoilValue.Size = new System.Drawing.Size(41, 19);
            this.darkLabel_CoilValue.TabIndex = 5;
            this.darkLabel_CoilValue.Text = "Valor";
            // 
            // darkLabel_RegisterValue
            // 
            this.darkLabel_RegisterValue.AutoSize = true;
            this.darkLabel_RegisterValue.ForeColor = System.Drawing.Color.White;
            this.darkLabel_RegisterValue.Location = new System.Drawing.Point(643, 44);
            this.darkLabel_RegisterValue.Name = "darkLabel_RegisterValue";
            this.darkLabel_RegisterValue.Size = new System.Drawing.Size(41, 19);
            this.darkLabel_RegisterValue.TabIndex = 5;
            this.darkLabel_RegisterValue.Text = "Valor";
            // 
            // darkLabel_CoilAddress
            // 
            this.darkLabel_CoilAddress.AutoSize = true;
            this.darkLabel_CoilAddress.ForeColor = System.Drawing.Color.White;
            this.darkLabel_CoilAddress.Location = new System.Drawing.Point(445, 81);
            this.darkLabel_CoilAddress.Name = "darkLabel_CoilAddress";
            this.darkLabel_CoilAddress.Size = new System.Drawing.Size(67, 19);
            this.darkLabel_CoilAddress.TabIndex = 5;
            this.darkLabel_CoilAddress.Text = "Dirección";
            // 
            // darkLabel_RegisterAddress
            // 
            this.darkLabel_RegisterAddress.AutoSize = true;
            this.darkLabel_RegisterAddress.ForeColor = System.Drawing.Color.White;
            this.darkLabel_RegisterAddress.Location = new System.Drawing.Point(445, 44);
            this.darkLabel_RegisterAddress.Name = "darkLabel_RegisterAddress";
            this.darkLabel_RegisterAddress.Size = new System.Drawing.Size(67, 19);
            this.darkLabel_RegisterAddress.TabIndex = 5;
            this.darkLabel_RegisterAddress.Text = "Dirección";
            // 
            // darkLabel_Size
            // 
            this.darkLabel_Size.AutoSize = true;
            this.darkLabel_Size.ForeColor = System.Drawing.Color.White;
            this.darkLabel_Size.Location = new System.Drawing.Point(27, 81);
            this.darkLabel_Size.Name = "darkLabel_Size";
            this.darkLabel_Size.Size = new System.Drawing.Size(58, 19);
            this.darkLabel_Size.TabIndex = 5;
            this.darkLabel_Size.Text = "Tamaño";
            // 
            // darkLabel_StartAddress
            // 
            this.darkLabel_StartAddress.AutoSize = true;
            this.darkLabel_StartAddress.ForeColor = System.Drawing.Color.White;
            this.darkLabel_StartAddress.Location = new System.Drawing.Point(27, 44);
            this.darkLabel_StartAddress.Name = "darkLabel_StartAddress";
            this.darkLabel_StartAddress.Size = new System.Drawing.Size(42, 19);
            this.darkLabel_StartAddress.TabIndex = 5;
            this.darkLabel_StartAddress.Text = "Inicio";
            // 
            // darkGroupBox_Data
            // 
            this.darkGroupBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox_Data.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox_Data.Controls.Add(this.ucSwitch_StartVisu);
            this.darkGroupBox_Data.Controls.Add(this.ucMeter_Visu);
            this.darkGroupBox_Data.Controls.Add(this.ucSplitLine_V1);
            this.darkGroupBox_Data.Controls.Add(this.tabControlExt1);
            this.darkGroupBox_Data.Controls.Add(this.darkLabel1);
            this.darkGroupBox_Data.Controls.Add(this.ucTextBoxEx_VisuAddress);
            this.darkGroupBox_Data.Controls.Add(this.darkLabel2);
            this.darkGroupBox_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkGroupBox_Data.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.darkGroupBox_Data.Location = new System.Drawing.Point(12, 258);
            this.darkGroupBox_Data.Name = "darkGroupBox_Data";
            this.darkGroupBox_Data.Size = new System.Drawing.Size(1112, 452);
            this.darkGroupBox_Data.TabIndex = 3;
            this.darkGroupBox_Data.TabStop = false;
            this.darkGroupBox_Data.Text = "Datos";
            // 
            // ucSwitch_StartVisu
            // 
            this.ucSwitch_StartVisu.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch_StartVisu.Checked = false;
            this.ucSwitch_StartVisu.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch_StartVisu.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitch_StartVisu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSwitch_StartVisu.Location = new System.Drawing.Point(936, 72);
            this.ucSwitch_StartVisu.Name = "ucSwitch_StartVisu";
            this.ucSwitch_StartVisu.Size = new System.Drawing.Size(84, 27);
            this.ucSwitch_StartVisu.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitch_StartVisu.TabIndex = 2;
            this.ucSwitch_StartVisu.Texts = new string[] {
        "ON",
        "OFF"};
            this.ucSwitch_StartVisu.TrueColor = System.Drawing.Color.LimeGreen;
            this.ucSwitch_StartVisu.TrueTextColr = System.Drawing.Color.White;
            this.ucSwitch_StartVisu.CheckedChanged += new System.EventHandler(this.ucSwitch_StartVisu_CheckedChanged);
            // 
            // ucMeter_Visu
            // 
            this.ucMeter_Visu.BoundaryLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.ContextMenuStrip = this.darkContextMenuVisu;
            this.ucMeter_Visu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMeter_Visu.ExternalRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.FixedText = "";
            this.ucMeter_Visu.InsideRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.Location = new System.Drawing.Point(710, 107);
            this.ucMeter_Visu.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ucMeter_Visu.MeterDegrees = 300;
            this.ucMeter_Visu.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucMeter_Visu.Name = "ucMeter_Visu";
            this.ucMeter_Visu.PointerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.ScaleValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.Size = new System.Drawing.Size(350, 334);
            this.ucMeter_Visu.SplitCount = 25;
            this.ucMeter_Visu.TabIndex = 2;
            this.ucMeter_Visu.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucMeter_Visu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMeter_Visu.TextLocation = HZH_Controls.Controls.MeterTextLocation.Top;
            this.ucMeter_Visu.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucMeter_Visu.Click += new System.EventHandler(this.ucMeter_Visu_Click);
            // 
            // darkContextMenuVisu
            // 
            this.darkContextMenuVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenuVisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenuVisu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Degree,
            this._Divisions,
            this._MinValue,
            this._MaxValue,
            this._TagName});
            this.darkContextMenuVisu.Name = "darkContextMenuVisu";
            this.darkContextMenuVisu.Size = new System.Drawing.Size(179, 114);
            this.darkContextMenuVisu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.darkContextMenuVisu_ItemClicked);
            // 
            // _Degree
            // 
            this._Degree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._Degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._Degree.Name = "_Degree";
            this._Degree.Size = new System.Drawing.Size(178, 22);
            this._Degree.Text = "Ángulo";
            // 
            // _Divisions
            // 
            this._Divisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._Divisions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._Divisions.Name = "_Divisions";
            this._Divisions.Size = new System.Drawing.Size(178, 22);
            this._Divisions.Text = "Divisiones";
            // 
            // _MaxValue
            // 
            this._MaxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._MaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._MaxValue.Name = "_MaxValue";
            this._MaxValue.Size = new System.Drawing.Size(178, 22);
            this._MaxValue.Text = "Valor Máximo";
            // 
            // _TagName
            // 
            this._TagName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._TagName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._TagName.Name = "_TagName";
            this._TagName.Size = new System.Drawing.Size(178, 22);
            this._TagName.Text = "Nombre de Variable";
            // 
            // ucSplitLine_V1
            // 
            this.ucSplitLine_V1.BackColor = System.Drawing.Color.DimGray;
            this.ucSplitLine_V1.Location = new System.Drawing.Point(638, 16);
            this.ucSplitLine_V1.Name = "ucSplitLine_V1";
            this.ucSplitLine_V1.Size = new System.Drawing.Size(1, 429);
            this.ucSplitLine_V1.TabIndex = 1;
            this.ucSplitLine_V1.TabStop = false;
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlExt1.BackColor = System.Drawing.Color.Transparent;
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.tabControlExt1.Controls.Add(this.tabPage3);
            this.tabControlExt1.Controls.Add(this.tabPage4);
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlExt1.HeaderBackColor = System.Drawing.Color.DimGray;
            this.tabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.tabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(7, 24);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.Padding = new System.Drawing.Point(20, 3);
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(618, 428);
            this.tabControlExt1.TabIndex = 0;
            this.tabControlExt1.UncloseTabIndexs = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage3.Controls.Add(this.listBox_DiscreteInputs);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(610, 370);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Discrete Inputs";
            // 
            // listBox_DiscreteInputs
            // 
            this.listBox_DiscreteInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.listBox_DiscreteInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_DiscreteInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_DiscreteInputs.ForeColor = System.Drawing.Color.White;
            this.listBox_DiscreteInputs.FormattingEnabled = true;
            this.listBox_DiscreteInputs.ItemHeight = 19;
            this.listBox_DiscreteInputs.Location = new System.Drawing.Point(3, 3);
            this.listBox_DiscreteInputs.MultiColumn = true;
            this.listBox_DiscreteInputs.Name = "listBox_DiscreteInputs";
            this.listBox_DiscreteInputs.Size = new System.Drawing.Size(604, 364);
            this.listBox_DiscreteInputs.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage4.Controls.Add(this.listBox_Coils);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(610, 370);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Coils";
            // 
            // listBox_Coils
            // 
            this.listBox_Coils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.listBox_Coils.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Coils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Coils.ForeColor = System.Drawing.Color.White;
            this.listBox_Coils.FormattingEnabled = true;
            this.listBox_Coils.ItemHeight = 19;
            this.listBox_Coils.Location = new System.Drawing.Point(3, 3);
            this.listBox_Coils.MultiColumn = true;
            this.listBox_Coils.Name = "listBox_Coils";
            this.listBox_Coils.Size = new System.Drawing.Size(604, 364);
            this.listBox_Coils.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage1.Controls.Add(this.listBox_InputRegisters);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 370);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Input Registers";
            // 
            // listBox_InputRegisters
            // 
            this.listBox_InputRegisters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.listBox_InputRegisters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_InputRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_InputRegisters.ForeColor = System.Drawing.Color.White;
            this.listBox_InputRegisters.FormattingEnabled = true;
            this.listBox_InputRegisters.ItemHeight = 19;
            this.listBox_InputRegisters.Location = new System.Drawing.Point(3, 3);
            this.listBox_InputRegisters.MultiColumn = true;
            this.listBox_InputRegisters.Name = "listBox_InputRegisters";
            this.listBox_InputRegisters.Size = new System.Drawing.Size(604, 364);
            this.listBox_InputRegisters.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabPage2.Controls.Add(this.listBox_HoldingRegisters);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 370);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Holding Registers";
            // 
            // listBox_HoldingRegisters
            // 
            this.listBox_HoldingRegisters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.listBox_HoldingRegisters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_HoldingRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_HoldingRegisters.ForeColor = System.Drawing.Color.White;
            this.listBox_HoldingRegisters.FormattingEnabled = true;
            this.listBox_HoldingRegisters.ItemHeight = 19;
            this.listBox_HoldingRegisters.Location = new System.Drawing.Point(3, 3);
            this.listBox_HoldingRegisters.MultiColumn = true;
            this.listBox_HoldingRegisters.Name = "listBox_HoldingRegisters";
            this.listBox_HoldingRegisters.Size = new System.Drawing.Size(604, 364);
            this.listBox_HoldingRegisters.TabIndex = 1;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.White;
            this.darkLabel1.Location = new System.Drawing.Point(802, 31);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(166, 19);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Visualización de Registros";
            // 
            // ucTextBoxEx_VisuAddress
            // 
            this.ucTextBoxEx_VisuAddress.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx_VisuAddress.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx_VisuAddress.ConerRadius = 20;
            this.ucTextBoxEx_VisuAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx_VisuAddress.DecLength = 0;
            this.ucTextBoxEx_VisuAddress.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx_VisuAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx_VisuAddress.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_VisuAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTextBoxEx_VisuAddress.InputText = "1";
            this.ucTextBoxEx_VisuAddress.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx_VisuAddress.IsFocusColor = true;
            this.ucTextBoxEx_VisuAddress.IsRadius = true;
            this.ucTextBoxEx_VisuAddress.IsShowClearBtn = false;
            this.ucTextBoxEx_VisuAddress.IsShowKeyboard = false;
            this.ucTextBoxEx_VisuAddress.IsShowRect = true;
            this.ucTextBoxEx_VisuAddress.IsShowSearchBtn = false;
            this.ucTextBoxEx_VisuAddress.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx_VisuAddress.Location = new System.Drawing.Point(814, 72);
            this.ucTextBoxEx_VisuAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx_VisuAddress.MaxValue = new decimal(new int[] {
            1852184791,
            59,
            0,
            0});
            this.ucTextBoxEx_VisuAddress.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucTextBoxEx_VisuAddress.Name = "ucTextBoxEx_VisuAddress";
            this.ucTextBoxEx_VisuAddress.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx_VisuAddress.PasswordChar = '\0';
            this.ucTextBoxEx_VisuAddress.PromptColor = System.Drawing.Color.White;
            this.ucTextBoxEx_VisuAddress.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx_VisuAddress.PromptText = "0";
            this.ucTextBoxEx_VisuAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx_VisuAddress.RectWidth = 1;
            this.ucTextBoxEx_VisuAddress.RegexPattern = "";
            this.ucTextBoxEx_VisuAddress.Size = new System.Drawing.Size(92, 27);
            this.ucTextBoxEx_VisuAddress.TabIndex = 0;
            this.ucTextBoxEx_VisuAddress.Leave += new System.EventHandler(this.ucTextBoxEx_VisuAddress_Leave);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.White;
            this.darkLabel2.Location = new System.Drawing.Point(741, 76);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(67, 19);
            this.darkLabel2.TabIndex = 5;
            this.darkLabel2.Text = "Dirección";
            // 
            // timerPolling
            // 
            this.timerPolling.Tick += new System.EventHandler(this.timerPolling_Tick);
            // 
            // timer_Clock
            // 
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // timer_Visu
            // 
            this.timer_Visu.Tick += new System.EventHandler(this.timer_Visu_Tick);
            // 
            // _MinValue
            // 
            this._MinValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this._MinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this._MinValue.Name = "_MinValue";
            this._MinValue.Size = new System.Drawing.Size(178, 22);
            this._MinValue.Text = "Valor Mínimo";
            // 
            // ToolStripMenuItem_Load
            // 
            this.ToolStripMenuItem_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripMenuItem_Load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripMenuItem_Load.Name = "ToolStripMenuItem_Load";
            this.ToolStripMenuItem_Load.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItem_Load.Text = "Cargar Configuración";
            this.ToolStripMenuItem_Load.Click += new System.EventHandler(this.ToolStripMenuItem_Load_Click);
            // 
            // ModbusClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1136, 745);
            this.Controls.Add(this.darkGroupBox_Data);
            this.Controls.Add(this.darkGroupBox_DataExchange);
            this.Controls.Add(this.darkGroupBox_Comunication);
            this.Controls.Add(this.darkDockPanel1);
            this.Controls.Add(this.darkStatusStrip1);
            this.Controls.Add(this.darkMenuStrip1);
            this.MainMenuStrip = this.darkMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "ModbusClient";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.darkGroupBox_Comunication.ResumeLayout(false);
            this.darkGroupBox_Comunication.PerformLayout();
            this.darkGroupBox_DataExchange.ResumeLayout(false);
            this.darkGroupBox_DataExchange.PerformLayout();
            this.darkGroupBox_Data.ResumeLayout(false);
            this.darkGroupBox_Data.PerformLayout();
            this.darkContextMenuVisu.ResumeLayout(false);
            this.tabControlExt1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private DarkUI.Docking.DarkDockPanel darkDockPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Estado;
        private DarkUI.Controls.DarkGroupBox darkGroupBox_Comunication;
        private HZH_Controls.Controls.UCCheckBox ucCheckBox_DefaultPort;
        private HZH_Controls.Controls.UCCheckBox ucCheckBox_Localhost;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_Port;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_IP;
        private DarkUI.Controls.DarkLabel darkLabel_Interval;
        private DarkUI.Controls.DarkComboBox darkComboBox_Interval;
        private DarkUI.Controls.DarkButton darkButton_Connect;
        private DarkUI.Controls.DarkGroupBox darkGroupBox_DataExchange;
        private DarkUI.Controls.DarkGroupBox darkGroupBox_Data;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DarkUI.Controls.DarkButton darkButton_Disconnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Cicle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Hora;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_Size;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_StartAddress;
        private DarkUI.Controls.DarkLabel darkLabel_Size;
        private DarkUI.Controls.DarkLabel darkLabel_StartAddress;
        private HZH_Controls.Controls.UCSplitLine_V ucSplitLine_V1;
        private DarkUI.Controls.DarkButton darkButton_WriteSingleRegister;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_CoilAddress;
        private DarkUI.Controls.DarkButton darkButton_WriteSingleCoil;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_RegisterValue;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_RegisterAddress;
        private DarkUI.Controls.DarkLabel darkLabel_CoilAddress;
        private DarkUI.Controls.DarkLabel darkLabel_RegisterAddress;
        private DarkUI.Controls.DarkLabel darkLabel_CoilValue;
        private DarkUI.Controls.DarkLabel darkLabel_RegisterValue;
        private HZH_Controls.Controls.UCSwitch ucSwitch_CoilValue;
        private System.Windows.Forms.Timer timerPolling;
        private System.Windows.Forms.ListBox listBox_Coils;
        private System.Windows.Forms.ListBox listBox_DiscreteInputs;
        private System.Windows.Forms.ListBox listBox_InputRegisters;
        private System.Windows.Forms.ListBox listBox_HoldingRegisters;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private HZH_Controls.Controls.UCMeter ucMeter_Visu;
        private DarkUI.Controls.DarkContextMenu darkContextMenuVisu;
        private System.Windows.Forms.ToolStripMenuItem _Degree;
        private System.Windows.Forms.ToolStripMenuItem _Divisions;
        private System.Windows.Forms.ToolStripMenuItem _MaxValue;
        private HZH_Controls.Controls.UCSwitch ucSwitch_StartVisu;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx_VisuAddress;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private System.Windows.Forms.ToolStripMenuItem _TagName;
        private System.Windows.Forms.Timer timer_Visu;
        private System.Windows.Forms.ToolStripMenuItem _MinValue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Load;
    }
}

