using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ModbusTCP;
using System.Linq;
using DarkUI.Forms;

namespace Modbus_Erik
{
    public partial class ModbusClient : DarkForm
    {
        private ModbusTCP.Master MBmaster;
        private ModbusTCP.Master MBmasterVisu;
        public byte[] dataCoils;
        public byte[] newdataCoils;
        public byte[] dataInputs;
        public byte[] newdataInputs;
        public byte[] dataInputRegisters;
        public byte[] newdataInputRegisters;
        public byte[] dataHoldingRegisters;
        public byte[] newdataHoldingRegisters;
        public byte[] dataVisu;
        public byte[] newdataVisu;
        public bool connected;
        public bool addressChanged;
        public bool addressChangedVisu;
        public ushort startAddress;
        public ushort startVisuAddress;

        public ModbusClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                // Set standard format byte
                DateTime hora = DateTime.Now;
                toolStripStatusLabel_Hora.Text = hora.ToLongTimeString();
                dataCoils = new byte[0];   
                newdataCoils = new byte[0];
                dataInputs = new byte[0];
                newdataInputs = new byte[0];
                dataInputRegisters = new byte[0];
                newdataInputRegisters = new byte[0];
                dataHoldingRegisters = new byte[0];
                newdataHoldingRegisters = new byte[0];
                dataVisu = new byte[0];
                newdataVisu = new byte[0];
                timer_Clock.Interval = 1000;
                timer_Clock.Start();
                darkGroupBox_DataExchange.Visible = false;
                darkGroupBox_Data.Visible = false;
                ucTextBoxEx_IP.InputText = "127.0.0.1";
                ucTextBoxEx_Port.InputText = "502";
                ucCheckBox_Localhost.Checked = true;
                ucCheckBox_DefaultPort.Checked = true;
                darkComboBox_Interval.SelectedIndex = 3;
                darkButton_Disconnect.Enabled = false;
                timerPolling.Enabled = false;
                timer_Visu.Enabled = false;
                toolStripStatusLabel_Estado.Text = "Desconectado";
                toolStripProgressBar_Cicle.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar_Cicle.MarqueeAnimationSpeed = 0;
            }
        }

        public bool CheckIPValid(String strIP)
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

        private void ucTextBoxEx_IP_Leave(object sender, EventArgs e)
        {
            bool ipValida;
            ipValida = CheckIPValid(ucTextBoxEx_IP.InputText);

            if (!ipValida && ucTextBoxEx_IP.InputText != "")
            {
                ucTextBoxEx_IP.FillColor = Color.Red;
                DarkMessageBox.ShowError($"La dirección IP {ucTextBoxEx_IP.InputText} no es válida", "Error");
            }
            else
            {
                ucTextBoxEx_IP.FillColor = Color.LightGreen;
            }
            if (ucTextBoxEx_IP.InputText == "") { ucTextBoxEx_IP.FillColor = Color.DimGray; }
        }

        private void ucTextBoxEx_IP_TextChanged(object sender, EventArgs e)
        {
            if (ucTextBoxEx_IP.InputText == "") { ucTextBoxEx_IP.FillColor = Color.DimGray; }
        }

        private void ucCheckBox_Localhost_CheckedChangeEvent(object sender, EventArgs e)
        {
            if (ucCheckBox_Localhost.Checked == true)
            {
                ucTextBoxEx_IP.InputText = "127.0.0.1";
                ucTextBoxEx_IP.Enabled = false;
                ucTextBoxEx_IP.FillColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));  //60; 63; 65
            }
            else
            {
                ucTextBoxEx_IP.Enabled = true;
                ucTextBoxEx_IP.FillColor = Color.DimGray;
            }
        }

        private void ucCheckBox_DefaultPort_CheckedChangeEvent(object sender, EventArgs e)
        {
            if (ucCheckBox_DefaultPort.Checked == true)
            {
                ucTextBoxEx_Port.InputText = "502";
                ucTextBoxEx_Port.Enabled = false;
                ucTextBoxEx_Port.FillColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));  //60; 63; 65

            }
            else
            {
                ucTextBoxEx_Port.Enabled = true;
                ucTextBoxEx_Port.FillColor = Color.DimGray;
            }
        }

        private void darkButton_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new modbus master and add event functions
                MBmaster = new Master(ucTextBoxEx_IP.InputText, Convert.ToUInt16(ucTextBoxEx_Port.InputText));

                if (MBmaster != null) { connected = true; }
                if (connected == true)
                {
                    toolStripStatusLabel_Estado.Text = "Conexión Establecida";
                    darkButton_Disconnect.Enabled = true;
                    ucTextBoxEx_IP.Enabled = false;
                    ucTextBoxEx_Port.Enabled = false;
                    ucCheckBox_DefaultPort.Enabled = false;
                    ucCheckBox_Localhost.Enabled = false;
                    darkGroupBox_DataExchange.Visible = true;
                    darkGroupBox_Data.Visible = true;

                    timerPolling.Enabled = true;
                    timerPolling.Interval = Convert.ToInt32(darkComboBox_Interval.Text);
                    timerPolling.Start();

                    timer_Visu.Enabled = true;
                    timer_Visu.Interval = Convert.ToInt32(darkComboBox_Interval.Text);

                    toolStripProgressBar_Cicle.Style = ProgressBarStyle.Marquee;
                    toolStripProgressBar_Cicle.MarqueeAnimationSpeed = timerPolling.Interval/45;
                    darkButton_Connect.Enabled = false;
                }                
            }
            catch (SystemException error)
            {
                MessageBox.Show(error.Message);
                toolStripProgressBar_Cicle.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar_Cicle.MarqueeAnimationSpeed = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MBmaster != null)
            {
                MBmaster.Dispose();
                MBmaster = null;
            }
            Application.Exit();
        }

        private void darkButton_Disconnect_Click(object sender, EventArgs e)
        {
            timerPolling.Stop();
            if (MBmaster != null)
            {
                MBmaster.Dispose();
                MBmaster = null;

                toolStripStatusLabel_Estado.Text = "Desconectado";
                darkGroupBox_DataExchange.Visible = false;
                darkGroupBox_Data.Visible = false;
                darkButton_Disconnect.Enabled = false;
                timerPolling.Enabled = false;
                darkButton_Connect.Enabled = true;
                darkButton_Disconnect.Enabled = false;
                ucTextBoxEx_IP.Enabled = true;
                ucTextBoxEx_Port.Enabled = true;
                ucCheckBox_DefaultPort.Enabled = true;
                ucCheckBox_Localhost.Enabled = true;
                connected = false;
                toolStripProgressBar_Cicle.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar_Cicle.MarqueeAnimationSpeed = 0;

            }
        }

        private void timerPolling_Tick(object sender, EventArgs e)
        {
           
            try
            {
                ushort size = Convert.ToUInt16(ucTextBoxEx_Size.InputText);
                ushort startAddress = Convert.ToUInt16(ucTextBoxEx_StartAddress.InputText);
                //DISCRETE INPUTS
                MBmaster.ReadDiscreteInputs(1, 0, startAddress, size, ref newdataInputs);

                if (dataInputs.SequenceEqual<byte>(newdataInputs) == false || addressChanged)
                {
                    listBox_DiscreteInputs.BeginUpdate();
                    listBox_DiscreteInputs.Items.Clear();
                    BitArray bitArray = new BitArray(newdataInputs);
                    bool[] bits = new bool[bitArray.Count];
                    bitArray.CopyTo(bits, 0);

                    for (int x = 0; x < size; x++)
                    {
                        listBox_DiscreteInputs.Items.Add((x + 1 + startAddress) + "\t - " + bits[x].ToString());
                    }
                    listBox_DiscreteInputs.EndUpdate();
                    dataInputs = newdataInputs;
                }

                //COILS
                MBmaster.ReadCoils(2, 0, startAddress, size, ref newdataCoils);

                if (dataCoils.SequenceEqual<byte>(newdataCoils) == false|| addressChanged)
                {
                    listBox_Coils.BeginUpdate();
                    listBox_Coils.Items.Clear();
                    BitArray bitArray = new BitArray(newdataCoils);
                    bool[] bits = new bool[bitArray.Count];
                    bitArray.CopyTo(bits, 0);

                    for (int x = 0; x < size; x++)
                    {
                        listBox_Coils.Items.Add((x + 1 + startAddress) + "\t - " + bits[x].ToString());
                    }
                    listBox_Coils.EndUpdate();
                    dataCoils = newdataCoils;
                }

                //INPUT REGISTERS              
                MBmaster.ReadInputRegister(3, 0, startAddress, size, ref newdataInputRegisters);
                if (dataInputRegisters.SequenceEqual<byte>(newdataInputRegisters) == false || addressChanged)
                {
                    listBox_InputRegisters.BeginUpdate();
                    listBox_InputRegisters.Items.Clear();
                    int i = 1;
                    for (int x = 0; x < newdataInputRegisters.Length - 1; x += 2)
                    {

                        listBox_InputRegisters.Items.Add((i + startAddress) + "\t - " + (newdataInputRegisters[x] * 256 +
                                                                newdataInputRegisters[x + 1]).ToString());
                        i++;
                    }
                    listBox_InputRegisters.EndUpdate();
                    dataInputRegisters = newdataInputRegisters;
                }

                //HOLDING REGISTERS              
                MBmaster.ReadHoldingRegister(4, 0, startAddress, size, ref newdataHoldingRegisters);
                if (dataHoldingRegisters.SequenceEqual<byte>(newdataHoldingRegisters) == false || addressChanged)
                {
                    listBox_HoldingRegisters.BeginUpdate();
                    listBox_HoldingRegisters.Items.Clear();
                    int i = 1;
                    for (int x = 0; x < newdataHoldingRegisters.Length - 1; x += 2)
                    {

                        listBox_HoldingRegisters.Items.Add((i + startAddress) + "\t - " + (newdataHoldingRegisters[x] * 256 + 
                                                                newdataHoldingRegisters[x + 1]).ToString());
                        i++;
                    }
                    listBox_HoldingRegisters.EndUpdate();
                    dataHoldingRegisters = newdataHoldingRegisters;
                }
                addressChanged = false;

                MBmaster.ReadHoldingRegister(4, 0, startAddress, size, ref newdataHoldingRegisters);
                if (dataHoldingRegisters.SequenceEqual<byte>(newdataHoldingRegisters) == false || addressChanged)
                {
                    listBox_HoldingRegisters.BeginUpdate();
                    listBox_HoldingRegisters.Items.Clear();
                    int i = 1;
                    for (int x = 0; x < newdataHoldingRegisters.Length - 1; x += 2)
                    {

                        listBox_HoldingRegisters.Items.Add((i + startAddress) + "\t - " + (newdataHoldingRegisters[x] * 256 +
                                                                newdataHoldingRegisters[x + 1]).ToString());
                        i++;
                    }
                    listBox_HoldingRegisters.EndUpdate();
                    dataHoldingRegisters = newdataHoldingRegisters;
                }
                addressChanged = false;

            }
            catch (Exception ex)
            {
                timerPolling.Stop();
                DarkMessageBox.ShowWarning(ex.Message.ToString() + "\nDesconectando Sesión", "Warning!");                
                //darkButton_Disconnect.PerformClick();
                newdataCoils = new byte[0];
                newdataInputs = new byte[0];
                newdataInputRegisters = new byte[0];
                newdataHoldingRegisters = new byte[0];
                addressChanged = false;
                ucTextBoxEx_Size.InputText = "1";
                timerPolling.Start();
            }       

        }

        private void darkButton_WriteSingleCoil_Click(object sender, EventArgs e)
        {
            try
            {
                ushort ID = 5;
                UInt16 address = (ushort)(Convert.ToUInt16(ucTextBoxEx_CoilAddress.InputText) - 1);

                MBmaster.WriteSingleCoils(ID, 0, address, ucSwitch_CoilValue.Checked);
            }catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message.ToString(), "Error!");
            }
        }

        private void darkButton_WriteSingleRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ushort ID = 7;
                UInt16 address = (ushort)(Convert.ToUInt16(ucTextBoxEx_RegisterAddress.InputText) - 1);
                int data = Convert.ToInt32(ucTextBoxEx_RegisterValue.InputText);
                byte[] databyte = BitConverter.GetBytes(data);
                MBmaster.WriteSingleRegister(ID, 0, address, new byte[] { databyte[1], databyte[0] });
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message.ToString(), "Error!");
            }
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            toolStripStatusLabel_Hora.Text = hora.ToLongTimeString();
        }

        private void darkComboBox_Interval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timerPolling.Enabled == true)
            {
                timerPolling.Stop();
            }
            timerPolling.Stop();
            timerPolling.Interval = Convert.ToInt32(darkComboBox_Interval.Text);
            timerPolling.Start();
            toolStripProgressBar_Cicle.MarqueeAnimationSpeed = timerPolling.Interval/45;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DarkMessageBox.ShowInformation("¿Quieres salir de la aplicación?", "Información", DarkDialogButton.OkCancel);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ucTextBoxEx_StartAddress_Leave(object sender, EventArgs e)
        {
            try
            {
                ushort newAddress = Convert.ToUInt16(ucTextBoxEx_StartAddress.InputText);
                if (startAddress != newAddress || startAddress == 0)
                {
                    addressChanged = true;
                }
            }catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message.ToString(), "Error");
                ucTextBoxEx_StartAddress.InputText = "0";
            }            
        }

        private void darkContextMenuVisu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

             using ( Dialog_Visu visualdialog = new Dialog_Visu(e))
            {
                if (visualdialog.ShowDialog() == DialogResult.OK)
                {
                    switch (e.ClickedItem.Name)
                    {
                        case "_Degree":
                            ucMeter_Visu.MeterDegrees = Convert.ToInt32(visualdialog.PropertyValue);
                            break;
                        case "_Divisions":
                            ucMeter_Visu.SplitCount = Convert.ToInt32(visualdialog.PropertyValue);
                            break;
                        case "_MinValue":
                            ucMeter_Visu.MinValue = Convert.ToInt32(visualdialog.PropertyValue);
                            break;
                        case "_MaxValue":
                            ucMeter_Visu.MaxValue= Convert.ToInt32(visualdialog.PropertyValue);
                            break;
                        case "_TagName":
                            ucMeter_Visu.FixedText = visualdialog.PropertyValue;
                            break;
                    }
                }
            }
        }

        private void ucMeter_Visu_Click(object sender, EventArgs e)
        {
           darkContextMenuVisu.Show(Cursor.Position);
        }

        private void ucSwitch_StartVisu_CheckedChanged(object sender, EventArgs e)
        {
            if(ucSwitch_StartVisu.Checked == true)
            {
                timer_Visu.Start();
            }
            else
            {
                timer_Visu.Stop();
                ucMeter_Visu.Value = 0;
            }
            
        }

        private void timer_Visu_Tick(object sender, EventArgs e)
        {
            try
            
            {
                ushort size = 1;
                ushort startAddress = Convert.ToUInt16(ucTextBoxEx_VisuAddress.InputText);
                if ( MBmaster != null)
                {
                    if (startAddress == 0) { startAddress = 1; }
                        MBmaster.ReadHoldingRegister(5, 0, (ushort)(startAddress - 1), size, ref newdataVisu);

                    if (dataVisu.SequenceEqual<byte>(newdataVisu) == false || addressChangedVisu)
                    {
                        ucMeter_Visu.Value = (int)Convert.ToUInt32(newdataVisu[0] * 256 + newdataVisu[1]);
                        dataVisu = newdataVisu;
                    }
                    addressChangedVisu = false;
                }
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message.ToString(), "Error!");
            }

        }

        private void ucTextBoxEx_VisuAddress_Leave(object sender, EventArgs e)
        {
            try
            {
                ushort newAddress = Convert.ToUInt16(ucTextBoxEx_VisuAddress.InputText);
                if (startVisuAddress != newAddress || startVisuAddress == 0)
                {
                    addressChangedVisu = true;
                }
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError(ex.Message.ToString(), "Error");
                ucTextBoxEx_VisuAddress.InputText = "0";
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = ucTextBoxEx_IP.InputText;
            Properties.Settings.Default.Port = ucTextBoxEx_Port.InputText;
            Properties.Settings.Default.VisuMaxValue = (int)ucMeter_Visu.MaxValue;
            Properties.Settings.Default.VisuMinValue = (int)ucMeter_Visu.MinValue;
            Properties.Settings.Default.VisuDegrees = (int)ucMeter_Visu.MeterDegrees;
            Properties.Settings.Default.VisuDivisions = (int)ucMeter_Visu.SplitCount;
            Properties.Settings.Default.VisuName = ucMeter_Visu.FixedText;
            Properties.Settings.Default.Save();
            DarkMessageBox.ShowInformation("Propiedades Guardadas", "Guardar");
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = ucTextBoxEx_IP.InputText;
            Properties.Settings.Default.Port = ucTextBoxEx_Port.InputText;
            Properties.Settings.Default.VisuMaxValue = (int)ucMeter_Visu.MaxValue;
            Properties.Settings.Default.VisuMinValue = (int)ucMeter_Visu.MinValue;
            Properties.Settings.Default.VisuDegrees = (int)ucMeter_Visu.MeterDegrees;
            Properties.Settings.Default.VisuDivisions = (int)ucMeter_Visu.SplitCount;
            Properties.Settings.Default.VisuName = ucMeter_Visu.FixedText;
            Properties.Settings.Default.Interval = darkComboBox_Interval.SelectedIndex;
            Properties.Settings.Default.Save();
            DarkMessageBox.ShowInformation("Propiedades Guardadas", "Guardar");
        }

        private void ToolStripMenuItem_Load_Click(object sender, EventArgs e)
        {
            ucTextBoxEx_IP.InputText = Properties.Settings.Default.IP;
            ucTextBoxEx_Port.InputText = Properties.Settings.Default.Port;
            ucMeter_Visu.MaxValue = Properties.Settings.Default.VisuMaxValue;
            ucMeter_Visu.MinValue = Properties.Settings.Default.VisuMinValue;
            ucMeter_Visu.MeterDegrees = Properties.Settings.Default.VisuDegrees;
            ucMeter_Visu.SplitCount = Properties.Settings.Default.VisuDivisions;
            ucMeter_Visu.FixedText = Properties.Settings.Default.VisuName;
            darkComboBox_Interval.SelectedIndex = Properties.Settings.Default.Interval;
            DarkMessageBox.ShowInformation("Propiedades Cargadas", "Cargar");
        }
    }
}

