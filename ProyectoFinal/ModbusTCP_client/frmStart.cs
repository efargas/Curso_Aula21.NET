using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ModbusTCP;


namespace Modbus
{
    public class frmStart : System.Windows.Forms.Form
	{
		
		private GroupBox grpData;
		private Label label1;
        internal Button btnConnect;
        private TextBox txtIP;
		private Label label3;
		private TextBox txtSize;
		private Label label2;
		private TextBox txtStartAdress;
		private GroupBox grpStart;
		private GroupBox grpExchange;
		private Button btnWriteSingleCoil;
		private Button btnWriteSingleReg;
		private Label label5;
		private TextBox txtPort;
		private Timer TimerPolling;
        private ListBox listHoldingRegisters;
        private Label label4;
        private TextBox txtRegAdress;
        private Label label8;
        private Label label9;
        private TextBox txtCoilAdress;
        private Label label7;
        private TextBox txtRegValue;
        private CheckBox chckCoilValue;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox lstDiscreteInputs;
        private TabPage tabPage2;
        private ListBox lstCoils;
        private TabPage tabPage3;
        private ListBox lstInputRegisters;
        private TabPage tabPage4;
        private CheckBox chkDefaultPort;
        internal Button btnDisconnect;
        private BackgroundWorker backgroundWorker1;
        private System.IO.Ports.SerialPort serialPort1;
        private CheckBox chkLocalhost;
        private Label label6;
        private SaveFileDialog saveFileDialog1;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx1;
        private IContainer components;

		public frmStart()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucTextBoxEx1 = new HZH_Controls.Controls.UCTextBoxEx();
            this.lstDiscreteInputs = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstCoils = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstInputRegisters = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listHoldingRegisters = new System.Windows.Forms.ListBox();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkLocalhost = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.chkDefaultPort = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.grpExchange = new System.Windows.Forms.GroupBox();
            this.chckCoilValue = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCoilAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegAdress = new System.Windows.Forms.TextBox();
            this.btnWriteSingleCoil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWriteSingleReg = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAdress = new System.Windows.Forms.TextBox();
            this.TimerPolling = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpStart.SuspendLayout();
            this.grpExchange.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.tabControl1);
            this.grpData.Location = new System.Drawing.Point(7, 187);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(827, 278);
            this.grpData.TabIndex = 9;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            this.grpData.Visible = false;
            this.grpData.Enter += new System.EventHandler(this.grpData_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 253);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucTextBoxEx1);
            this.tabPage1.Controls.Add(this.lstDiscreteInputs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Discrete Inputs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTextBoxEx1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucTextBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx1.ConerRadius = 30;
            this.ucTextBoxEx1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx1.DecLength = 2;
            this.ucTextBoxEx1.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxEx1.FocusBorderColor = System.Drawing.Color.DarkOrange;
            this.ucTextBoxEx1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.InputText = "";
            this.ucTextBoxEx1.InputType = HZH_Controls.TextInputType.Regex;
            this.ucTextBoxEx1.IsFocusColor = true;
            this.ucTextBoxEx1.IsRadius = true;
            this.ucTextBoxEx1.IsShowClearBtn = true;
            this.ucTextBoxEx1.IsShowKeyboard = false;
            this.ucTextBoxEx1.IsShowRect = true;
            this.ucTextBoxEx1.IsShowSearchBtn = false;
            this.ucTextBoxEx1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(450, 58);
            this.ucTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx1.PasswordChar = '\0';
            this.ucTextBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx1.PromptFont = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.PromptText = "IP Address";
            this.ucTextBoxEx1.RectColor = System.Drawing.Color.Red;
            this.ucTextBoxEx1.RectWidth = 1;
            this.ucTextBoxEx1.RegexPattern = "";
            this.ucTextBoxEx1.Size = new System.Drawing.Size(322, 42);
            this.ucTextBoxEx1.TabIndex = 4;
            this.ucTextBoxEx1.TextChanged += new System.EventHandler(this.ucTextBoxEx1_TextChanged);
            this.ucTextBoxEx1.Leave += new System.EventHandler(this.ucTextBoxEx1_Leave_1);
            // 
            // lstDiscreteInputs
            // 
            this.lstDiscreteInputs.FormattingEnabled = true;
            this.lstDiscreteInputs.Location = new System.Drawing.Point(6, 6);
            this.lstDiscreteInputs.MultiColumn = true;
            this.lstDiscreteInputs.Name = "lstDiscreteInputs";
            this.lstDiscreteInputs.ScrollAlwaysVisible = true;
            this.lstDiscreteInputs.Size = new System.Drawing.Size(383, 212);
            this.lstDiscreteInputs.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstCoils);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coils";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstCoils
            // 
            this.lstCoils.FormattingEnabled = true;
            this.lstCoils.Location = new System.Drawing.Point(6, 9);
            this.lstCoils.MultiColumn = true;
            this.lstCoils.Name = "lstCoils";
            this.lstCoils.ScrollAlwaysVisible = true;
            this.lstCoils.Size = new System.Drawing.Size(383, 212);
            this.lstCoils.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstInputRegisters);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(807, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Input Registers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstInputRegisters
            // 
            this.lstInputRegisters.FormattingEnabled = true;
            this.lstInputRegisters.Location = new System.Drawing.Point(6, 9);
            this.lstInputRegisters.MultiColumn = true;
            this.lstInputRegisters.Name = "lstInputRegisters";
            this.lstInputRegisters.ScrollAlwaysVisible = true;
            this.lstInputRegisters.Size = new System.Drawing.Size(383, 212);
            this.lstInputRegisters.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listHoldingRegisters);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(807, 227);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Holding Registers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listHoldingRegisters
            // 
            this.listHoldingRegisters.FormattingEnabled = true;
            this.listHoldingRegisters.Location = new System.Drawing.Point(6, 9);
            this.listHoldingRegisters.MultiColumn = true;
            this.listHoldingRegisters.Name = "listHoldingRegisters";
            this.listHoldingRegisters.ScrollAlwaysVisible = true;
            this.listHoldingRegisters.Size = new System.Drawing.Size(383, 212);
            this.listHoldingRegisters.TabIndex = 2;
            // 
            // grpStart
            // 
            this.grpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStart.Controls.Add(this.label6);
            this.grpStart.Controls.Add(this.chkLocalhost);
            this.grpStart.Controls.Add(this.label5);
            this.grpStart.Controls.Add(this.txtPort);
            this.grpStart.Controls.Add(this.chkDefaultPort);
            this.grpStart.Controls.Add(this.label1);
            this.grpStart.Controls.Add(this.btnDisconnect);
            this.grpStart.Controls.Add(this.btnConnect);
            this.grpStart.Controls.Add(this.txtIP);
            this.grpStart.Location = new System.Drawing.Point(7, 0);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(827, 62);
            this.grpStart.TabIndex = 11;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Start communication";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // chkLocalhost
            // 
            this.chkLocalhost.AutoSize = true;
            this.chkLocalhost.Location = new System.Drawing.Point(196, 27);
            this.chkLocalhost.Name = "chkLocalhost";
            this.chkLocalhost.Size = new System.Drawing.Size(72, 17);
            this.chkLocalhost.TabIndex = 10;
            this.chkLocalhost.Text = "Localhost";
            this.chkLocalhost.UseVisualStyleBackColor = true;
            this.chkLocalhost.CheckedChanged += new System.EventHandler(this.chkLocalhost_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(279, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(315, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 20);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkDefaultPort
            // 
            this.chkDefaultPort.AutoSize = true;
            this.chkDefaultPort.Location = new System.Drawing.Point(369, 27);
            this.chkDefaultPort.Name = "chkDefaultPort";
            this.chkDefaultPort.Size = new System.Drawing.Size(60, 17);
            this.chkDefaultPort.TabIndex = 6;
            this.chkDefaultPort.Text = "Default";
            this.chkDefaultPort.UseVisualStyleBackColor = true;
            this.chkDefaultPort.CheckedChanged += new System.EventHandler(this.chkDefaultPort_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(600, 21);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(86, 28);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(492, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(93, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(87, 20);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged_1);
            this.txtIP.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // grpExchange
            // 
            this.grpExchange.Controls.Add(this.chckCoilValue);
            this.grpExchange.Controls.Add(this.label8);
            this.grpExchange.Controls.Add(this.label9);
            this.grpExchange.Controls.Add(this.txtCoilAdress);
            this.grpExchange.Controls.Add(this.label7);
            this.grpExchange.Controls.Add(this.txtRegValue);
            this.grpExchange.Controls.Add(this.label4);
            this.grpExchange.Controls.Add(this.txtRegAdress);
            this.grpExchange.Controls.Add(this.btnWriteSingleCoil);
            this.grpExchange.Controls.Add(this.label3);
            this.grpExchange.Controls.Add(this.btnWriteSingleReg);
            this.grpExchange.Controls.Add(this.txtSize);
            this.grpExchange.Controls.Add(this.label2);
            this.grpExchange.Controls.Add(this.txtStartAdress);
            this.grpExchange.Location = new System.Drawing.Point(7, 69);
            this.grpExchange.Name = "grpExchange";
            this.grpExchange.Size = new System.Drawing.Size(827, 112);
            this.grpExchange.TabIndex = 12;
            this.grpExchange.TabStop = false;
            this.grpExchange.Text = "Data exhange";
            this.grpExchange.Visible = false;
            // 
            // chckCoilValue
            // 
            this.chckCoilValue.AutoSize = true;
            this.chckCoilValue.Location = new System.Drawing.Point(511, 81);
            this.chckCoilValue.Name = "chckCoilValue";
            this.chckCoilValue.Size = new System.Drawing.Size(48, 17);
            this.chckCoilValue.TabIndex = 30;
            this.chckCoilValue.Text = "True";
            this.chckCoilValue.UseVisualStyleBackColor = true;
            this.chckCoilValue.CheckedChanged += new System.EventHandler(this.chckCoilValue_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(457, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Value";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(351, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address";
            // 
            // txtCoilAdress
            // 
            this.txtCoilAdress.Location = new System.Drawing.Point(405, 75);
            this.txtCoilAdress.Name = "txtCoilAdress";
            this.txtCoilAdress.Size = new System.Drawing.Size(32, 20);
            this.txtCoilAdress.TabIndex = 26;
            this.txtCoilAdress.Text = "1";
            this.txtCoilAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(457, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Value";
            // 
            // txtRegValue
            // 
            this.txtRegValue.Location = new System.Drawing.Point(511, 28);
            this.txtRegValue.Name = "txtRegValue";
            this.txtRegValue.Size = new System.Drawing.Size(32, 20);
            this.txtRegValue.TabIndex = 24;
            this.txtRegValue.Text = "0";
            this.txtRegValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(351, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address";
            // 
            // txtRegAdress
            // 
            this.txtRegAdress.Location = new System.Drawing.Point(405, 28);
            this.txtRegAdress.Name = "txtRegAdress";
            this.txtRegAdress.Size = new System.Drawing.Size(32, 20);
            this.txtRegAdress.TabIndex = 22;
            this.txtRegAdress.Text = "1";
            this.txtRegAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnWriteSingleCoil
            // 
            this.btnWriteSingleCoil.Location = new System.Drawing.Point(219, 66);
            this.btnWriteSingleCoil.Name = "btnWriteSingleCoil";
            this.btnWriteSingleCoil.Size = new System.Drawing.Size(115, 42);
            this.btnWriteSingleCoil.TabIndex = 19;
            this.btnWriteSingleCoil.Text = "Write single coil";
            this.btnWriteSingleCoil.Click += new System.EventHandler(this.btnWriteSingleCoil_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Size";
            // 
            // btnWriteSingleReg
            // 
            this.btnWriteSingleReg.Location = new System.Drawing.Point(219, 16);
            this.btnWriteSingleReg.Name = "btnWriteSingleReg";
            this.btnWriteSingleReg.Size = new System.Drawing.Size(115, 44);
            this.btnWriteSingleReg.TabIndex = 21;
            this.btnWriteSingleReg.Text = "Write single register";
            this.btnWriteSingleReg.Click += new System.EventHandler(this.btnWriteSingleReg_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(87, 78);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 14;
            this.txtSize.Text = "20";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Address";
            // 
            // txtStartAdress
            // 
            this.txtStartAdress.Location = new System.Drawing.Point(87, 51);
            this.txtStartAdress.Name = "txtStartAdress";
            this.txtStartAdress.Size = new System.Drawing.Size(50, 20);
            this.txtStartAdress.TabIndex = 12;
            this.txtStartAdress.Text = "0";
            this.txtStartAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerPolling
            // 
            this.TimerPolling.Tick += new System.EventHandler(this.TimerPolling_Tick);
            // 
            // frmStart
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(841, 471);
            this.Controls.Add(this.grpExchange);
            this.Controls.Add(this.grpStart);
            this.Controls.Add(this.grpData);
            this.KeyPreview = true;
            this.Name = "frmStart";
            this.Text = "ModbusTCP Client";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmStart_Closing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.grpData.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.grpStart.ResumeLayout(false);
            this.grpStart.PerformLayout();
            this.grpExchange.ResumeLayout(false);
            this.grpExchange.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new frmStart());
		}

        //GLOBAL VARS
        private ModbusTCP.Master MBmaster;
        public byte[] data;
        Regex ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
        

        // ------------------------------------------------------------------------
        // Programm start
        // ------------------------------------------------------------------------
        private void frmStart_Load(object sender, System.EventArgs e)
		{
			// Set standard format byte, make some textboxes

			data = new byte[0];
            //ucTextBoxEx1.RegexPattern = ip;
        }

		// ------------------------------------------------------------------------
		// Programm stop
		// ------------------------------------------------------------------------
		private void frmStart_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MBmaster != null) 
			{
				MBmaster.Dispose();
				MBmaster = null;
			}	
			Application.Exit();
		}

        // ------------------------------------------------------------------------
        // Button connect
        // ------------------------------------------------------------------------
        private void btnConnect_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Create new modbus master and add event functions
				MBmaster = new Master(txtIP.Text, Convert.ToUInt16( txtPort.Text));
				
                TimerPolling.Interval = 3000;
				TimerPolling.Start();

                grpExchange.Visible		= true;
				grpData.Visible			= true;	
			}
			catch(SystemException error)
			{
				MessageBox.Show(error.Message);
			}
		}

		
		// ------------------------------------------------------------------------
		// Button write single coil
		// ------------------------------------------------------------------------
		private void btnWriteSingleCoil_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 5;
            UInt16 address =(ushort)(Convert.ToUInt16(txtCoilAdress.Text) - 1);

            MBmaster.WriteSingleCoils(ID,0,address, chckCoilValue.Checked);
		}


		// ------------------------------------------------------------------------
		// Button write single register
		// ------------------------------------------------------------------------
		private void btnWriteSingleReg_Click(object sender, System.EventArgs e)
		{
            ushort ID = 7;
            UInt16 address = (ushort)(Convert.ToUInt16(txtRegAdress.Text) - 1);
            MBmaster.WriteSingleRegister(ID, 0,address, new byte[] { 0,Convert.ToByte(txtRegValue.Text) });
		}
		
		

        private void TimerPolling_Tick(object sender, EventArgs e)
        {
            ushort size =Convert.ToUInt16(txtSize.Text);
            ushort startAddress = Convert.ToUInt16(txtStartAdress.Text);

            try
            {

                //COILS
                MBmaster.ReadCoils(1, 0, startAddress, size, ref data);

                lstCoils.BeginUpdate();

                lstCoils.Items.Clear();
                BitArray bitArray = new BitArray(data);
                bool[] bits = new bool[bitArray.Count];
                bitArray.CopyTo(bits, 0);

                for (int x = 0; x < size; x++)
                {
                    lstCoils.Items.Add((x + 1 + startAddress) + "\t - " + bits[x].ToString());
                }

                lstCoils.EndUpdate();

                //HOLDING
                
                MBmaster.ReadHoldingRegister(2, 0, startAddress, size, ref data);

                listHoldingRegisters.BeginUpdate();

                listHoldingRegisters.Items.Clear();
                int i = 1;
                for (int x = 0; x < data.Length-1; x += 2)
                {

                    listHoldingRegisters.Items.Add((i + startAddress) + "\t - " + (data[x] * 256 + data[x + 1]).ToString());
                    i++;
                }


                listHoldingRegisters.EndUpdate();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message.ToString(),"Warning!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TimerPolling.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chkDefaultPort_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDefaultPort.Checked == true)
            {
                txtPort.Text = "502";
                txtPort.Enabled = false;

            }
            else
            {
                txtPort.Enabled = true;
            }

        }

        private void chkLocalhost_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLocalhost.Checked == true)
            {
                txtIP.Text = "127.0.0.1";
                txtIP.Enabled = false;

            }
            else
            {
                txtIP.Enabled = true;
            }
        }

        private void grpData_Enter(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            //a little regex to check if the texbox contains a valid ip adress (ipv4 only).
            //This way you limit the number of useless calls to ping.
            Regex rgx = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
            var tb = (TextBox)sender;
            if (!rgx.IsMatch(tb.Text))
            {
                MessageBox.Show("inválid IP Adress");
            }
        }


        public Boolean CheckIPValid(String strIP)
        {
            var IpRegEx = @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$";  // 355.168.0.1 = No Match (Correct)

            //  Split string by ".", check that array length is 4
            string[] arrOctets = strIP.Split('.');
            if (arrOctets.Length != 4)
                return false;

            //Check each substring checking that parses to byte
            byte obyte = 0;
            foreach (string strOctet in arrOctets)
                if (!byte.TryParse(strOctet, out obyte))
                    return false;

            var match = Regex.Match(strIP, IpRegEx);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            bool ipValida;
            ipValida = CheckIPValid(txtIP.Text);

            if (!ipValida) { 
                MessageBox.Show($"La dirección IP {txtIP.Text} no es válida","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIP.Text = "127.0.0.1";
            }
            
        }


        private void ucTextBoxEx1_Leave(object sender, EventArgs e)
        {
            bool ipValida;
            ipValida = CheckIPValid(ucTextBoxEx1.InputText);

            if (!ipValida)
            {
                MessageBox.Show($"La dirección IP {ucTextBoxEx1.InputText} no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucTextBoxEx1.RectColor = System.Drawing.Color.Red;
            }
            else
            {
                ucTextBoxEx1.RectColor = System.Drawing.Color.LightGreen;
            }
        }

        private void ucTextBoxEx1_Leave_1(object sender, EventArgs e)
        {
            bool ipValida;
            ipValida = CheckIPValid(ucTextBoxEx1.InputText);

            if (!ipValida)
            {
                ucTextBoxEx1.FillColor = System.Drawing.Color.LightPink;
            }
            else
            {
                ucTextBoxEx1.FillColor = System.Drawing.Color.LightGreen;
            }
            if (ucTextBoxEx1.InputText == "") { ucTextBoxEx1.FillColor = System.Drawing.Color.White; }

        }

        private void ucTextBoxEx1_TextChanged(object sender, EventArgs e)
        {
            if (ucTextBoxEx1.InputText == "") { ucTextBoxEx1.FillColor = System.Drawing.Color.White; }
        }

        private void txtIP_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void chckCoilValue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
