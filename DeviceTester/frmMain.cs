using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using Be.Windows.Forms;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
        enum ConsoleMode { HEX, DOS, ASCII, Python }
        enum ConnectionType { TCPIPStandard, TCPIPConnected, UDP, ComPort, Python }

        // TCPConnection t = new TCPConnection("10.0.0.242", 4001);
        string _consoleHelpText = string.Empty;
        string _currentXMLPath = string.Empty;
        string _currentCellValue = string.Empty;

        public string _delimiter = " ";

        int _pingTimeOut = 1000;

        ConsoleMode _consoleMode = ConsoleMode.DOS;
        ConnectionType _currentConnectionType = ConnectionType.TCPIPStandard;
        TcpClient _tcpClient = new TcpClient();
        NetworkStream _stream;

        private void SetConnectionType(ConnectionType connectionType)
        {
            _currentConnectionType = connectionType;
            lblConnectionType.Text = "Connection Type:" + connectionType.ToString();
            cbConnectionType.Text = connectionType.ToString();
        }

        private void GetActiveTCPConnections()
        {
            System.Net.NetworkInformation.IPGlobalProperties properties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
            System.Net.NetworkInformation.TcpConnectionInformation[] tcpInfoList = properties.GetActiveTcpConnections();

            for (int i = 0; i < tcpInfoList.Length; i++)
            {
                lblActiveTCPConnections.Items.Add(tcpInfoList[i].LocalEndPoint.ToString() + " - " + tcpInfoList[i].RemoteEndPoint.ToString());
            }
        }

        public bool CheckNetworkConnection(string IP, int timeout)
        {
            if (string.IsNullOrEmpty(IP)) return false;
            try
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IP);
                System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply reply;
                reply = pinger.Send(ipAddress, timeout);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;

            }
        }

        //private byte[] GetBytesFromRow(DataGridViewRow row)
        //{
        //    if (row != null)
        //        row.Cells["InstructionBytes"].Value.ToString();

        //    if (row != null)
        //    {
        //        byte[] bytesToSend;

        //        if (chkCommandIsASCII.Checked)
        //            bytesToSend = ASCIIEncoding.ASCII.GetBytes(row.Cells["InstructionBytes"].Value.ToString() + "\r");
        //        else
        //            bytesToSend = GetBytesToSend(row.Cells["InstructionBytes"].Value.ToString());

        //        return bytesToSend;
        //    }
        //    else return null;
        //}

        private void WriteMessage(string message)
        {
            txtConsole.Text = txtConsole.Text.Insert(0, message + Environment.NewLine);
            tsbErrorMessageClear.Image = Properties.Resources.red_light;
            //tbcTools.SelectedIndex = 3;
        }

        public frmMain()
        {
            InitializeComponent();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("ShellControl Demo");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("*******************************************");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("Commands Available");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(1) All DOS commands that operate on a single line");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(2) prompt - Changes prompt. Usage (prompt=<desired_prompt>");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(3) history - prints history of entered commands");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(4) cls - Clears the screen");
            stringBuilder.Append(System.Environment.NewLine);

            _consoleHelpText = stringBuilder.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GetBuildDate();

            SetConnectionType(ConnectionType.TCPIPStandard);

            LoadParameters(); //IP, port, ComPort params from Start.ini

            LoadPythonFiles();

            tbcDevice.SelectedIndex = 0;
            //tsbErrorMessageClear.Image = 
        }

        private void tsbSendBytesToDevice_Click(object sender, EventArgs e)
        {
            if (tbcDevice.SelectedIndex == 0)
            {
                if (dgvInstructions.CurrentRow != null)
                    SendBytesToDevice(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString());
                else MessageBox.Show("Select a row.");
            }

            if (tbcDevice.SelectedIndex == 2)
            {
                SendBytesToDevice(GetWorkbenchCurrentLineBytes());
            }
        }

        private void tsbSendFromWorkbench_Click(object sender, EventArgs e)
        {
            SendBytesToDevice(GetWorkbenchCurrentLineBytes());
        }

        private void tsbSendViaPython_Click(object sender, EventArgs e)
        {
            string pythonFilename = cbPythonSenders.Text;
            if (string.IsNullOrEmpty(pythonFilename)) pythonFilename = "python_socket.py";

            if (tbcDevice.SelectedIndex == 0)
            {
                if (dgvInstructions.CurrentRow != null)
                    SendViaPython(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString(), pythonFilename);
                else MessageBox.Show("Select a row.");
            }

            if (tbcDevice.SelectedIndex == 2)
            {
                SendViaPython(GetWorkbenchCurrentLineBytes(), pythonFilename);
            }
        }

        private void cbPythonSenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPythonSenders.Text == "python_visa.py") chkCommandIsASCII.Checked = true;
            else chkCommandIsASCII.Checked = false;
        }

        #region XML RELATED METHODS

        private void LoadDeviceXML(string xmlFilename)
        {
            string xmlPath = string.Empty;

            xmlPath = xmlFilename;

            if (System.IO.File.Exists(xmlPath))
            {
                _currentXMLPath = xmlPath;

                XMLOperations x = new XMLOperations(xmlPath);

                DeviceInfo di = x.GetDeviceInfo();
                txtCurrentIP.Text = di.DeviceIP;
                txtCurrentPort.Text = di.DevicePort;
                txtDeviceName.Text = di.DeviceName;
                txtDeviceExplanation.Text = di.DeviceExplanation;
                tpDeviceCommands.Text = di.DeviceName;

                txtDeviceExplanation.Text = di.DeviceExplanation;
                txtCheckSumType.Text = di.CheckSumType;
                txtInstructionStructure.Text = di.InstructionStructure;

                dgvInstructions.DataSource = x.GetXMLNodes("DeviceInstructions/Instruction");

                WorkbenchData wbd = x.GetWorkbenchData();
                txtWorkbench.Text = wbd.Instructions;
                FormatInstructionsGrid();
                dgvInstructions.ClearSelection();
                lblCurrentXML.Text = xmlFilename;
            }
            else MessageBox.Show(xmlPath + " file does not exist.");
        }

        private void tsbLoadDeviceXML_Click(object sender, EventArgs e)
        {
            frmDeviceXMLs x = new frmDeviceXMLs();
            if (x.ShowDialog() == DialogResult.OK)
            {
                LoadDeviceXML(x.DeviceXMLFilePath);
            }
        }

        private void btnOpenXMLLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\devicexmls");
        }

        private void btnOpenXMLFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentXMLPath)) MessageBox.Show("Select device XML file");
            else
                System.Diagnostics.Process.Start(_currentXMLPath);
        }

        private void btnCreateNewDeviceFile_Click(object sender, EventArgs e)
        {
            frmNewFilename x = new frmNewFilename();
            if (x.ShowDialog() == DialogResult.OK)
            {
                string fileName = Application.StartupPath + "\\DeviceXMLs\\" + x.Filename + ".xml";
                XMLOperations xo = new XMLOperations(fileName);
                if (xo.CreateNewDeviceXML(fileName)) LoadDeviceXML(fileName);
            }
        }

        private void lnkUpdateDeviceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.StartNode = "/DeviceInstructions/DeviceInfo";
            string currentDeviceName = tbcDevice.TabPages[0].Text;

            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "Explanation", txtDeviceExplanation.Text);
            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "CheckSumType", txtCheckSumType.Text);
            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "InstructionStructure", txtInstructionStructure.Text);
            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "DeviceName", txtDeviceName.Text);
            tpDeviceCommands.Text = txtDeviceName.Text;

            MessageBox.Show("Saved new device info.");


            //<DeviceName>SWC 100</DeviceName>
            //<Explanation>Switch</Explanation>
            //<IP>10.0.0.211</IP>
            //<Port>4001</Port>
            //<CheckSumType>EXOR</CheckSumType>
            //<InstructionStructure>123,Addres,Command Length,Parameters,125,CheckSum</InstructionStructure>
        }

        #endregion

        #region MAIN COMMUNICATION METHODS
        /*
        byte[] GetBytes(string byteStringWithComma)
        {
            try
            {
                string[] bytes = byteStringWithComma.Split(',');

                byte[] bytesToSend = new byte[bytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    int k = Convert.ToInt16(bytes[i]);
                    bytesToSend[i] = (byte)k;
                }

                return bytesToSend;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                return null;
            }
        }

        byte[] GetBytes(string byteStringWithComma, char splitChar)
        {
            try
            {
                string[] bytes = byteStringWithComma.Split(splitChar);

                byte[] bytesToSend = new byte[bytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    //int k = splitChar == ',' ? Convert.ToInt16(bytes[i]) : Convert.ToInt32(bytes[i], 16);
                    bytesToSend[i] = Convert.ToByte(bytes[i]);
                }

                return bytesToSend;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                return null;
            }
        }*/

        byte[] GetHexBytes(string byteStringWithComma, char splitChar)
        {
            try
            {
                string[] bytes = byteStringWithComma.Split(splitChar);
                byte[] bytesToSend = new byte[bytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    //int k = splitChar == ',' ? Convert.ToInt16(bytes[i]) : Convert.ToInt32(bytes[i], 16);
                    bytesToSend[i] = byte.Parse(bytes[i], System.Globalization.NumberStyles.HexNumber);
                }
                return bytesToSend;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                return null;
            }
        }

        private string ShowBytesInTextBoxes(byte[] bytesToShow)
        {
            dgvIncomingBytes.Rows.Clear();

            Convertor c = new Convertor();
            int readSize = 100;

            try
            {
                readSize = Convert.ToUInt16(txtReadBufferSize.Text);
            }
            catch (Exception exc)
            {
                WriteMessage(exc.ToString());
            }

            txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(bytesToShow);

            DynamicByteProvider b = new DynamicByteProvider(bytesToShow);
            hexReceivedBytes.ByteProvider = b;

            string bytesInHex = string.Empty;

            if (bytesToShow.Length < readSize) readSize = bytesToShow.Length;

            for (int i = 0; i < readSize; i++)
            {
                //  txtReceivedBytesASCII.Text += bytesToShow[i].ToString() + _delimiter;
                bytesInHex += bytesToShow[i].ToString() + " ";
                dgvIncomingBytes.Rows.Add(i.ToString(), bytesToShow[i].ToString(), (char)bytesToShow[i], c.DecimalToHex(bytesToShow[i].ToString()));
            }

            if (chkSaveLog.Checked) SaveInstructionLog(txtSentCommand.Text, bytesInHex, txtReceivedBytesASCII.Text);

            return txtReceivedBytesASCII.Text;
        }

        private void SaveLog(string logText)
        {
            string logsFolder = Application.StartupPath + "\\Logs\\";
            if (!Directory.Exists(logsFolder)) Directory.CreateDirectory(logsFolder);

            using (StreamWriter sw = File.AppendText(logsFolder + txtDeviceName.Text + "Logs.xml"))
            {
                StringBuilder xmlLog = new StringBuilder();
                xmlLog.Append("<log>");
                xmlLog.Append("<datetime>" + DateTime.Now + "</datetime>");
                xmlLog.Append("<Instruction>This is error log.</Instruction>");
                xmlLog.Append("<ReceivedDataInHEX>" + logText + "</ReceivedDataInHEX>");
                xmlLog.Append("<ReceivedDataInASCII></ReceivedDataInASCII>");
                xmlLog.Append("</log>");
                sw.WriteLine(logText);
            }
        }

        private void SaveInstructionLog(string instruction, string bytesInHex, string bytesInASCII)
        {
            string logsFolder = Application.StartupPath + "\\Logs\\";
            if (!Directory.Exists(logsFolder)) Directory.CreateDirectory(logsFolder);

            using (StreamWriter sw = File.AppendText(logsFolder + txtDeviceName.Text + "Logs.xml"))
            {
                StringBuilder xmlLog = new StringBuilder();
                xmlLog.Append("<log>");
                xmlLog.Append("<datetime>" + DateTime.Now + "</datetime>");
                xmlLog.Append("<Instruction>" + instruction + "</Instruction>");
                xmlLog.Append("<ReceivedDataInHEX>" + bytesInHex + "</ReceivedDataInHEX>");
                xmlLog.Append("<ReceivedDataInASCII>" + bytesInASCII + "</ReceivedDataInASCII>");
                xmlLog.Append("</log>");
                sw.WriteLine(xmlLog.ToString());
            }
        }

        #endregion MAIN COMMUNICATION METHODS

        #region ON LOAD METHODS
        private void GetBuildDate()
        {
            DateTime d = Common.RetrieveLinkerTimestamp();
            lblBuildDate.Text += d.ToShortDateString() + "," + d.ToShortTimeString();
        }

        private void LoadParameters()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\Start.ini";
            if (File.Exists(path))
            {
                txtCurrentIP.Text = Ini.IniFile.GetValue("TCPSettings", "IP");
                txtCurrentPort.Text = Ini.IniFile.GetValue("TCPSettings", "Port");

                try
                {
                    SetSerialPortParameters(Ini.IniFile.GetValue("ComportSettings", "Comport"),
                    Convert.ToInt32(Ini.IniFile.GetValue("ComportSettings", "BaudRate")),
                    Ini.IniFile.GetValue("ComportSettings", "Parity"),
                    Convert.ToByte(Ini.IniFile.GetValue("ComportSettings", "DataBits")),
                    Ini.IniFile.GetValue("ComportSettings", "StopBits"));
                }
                catch (Exception exc)
                {
                    WriteMessage(exc.ToString());
                    lblComPortInfo.Text = "Error in com port parameters at Start.ini";
                }

            }
        }

        private void LoadPythonFiles()
        {
            string path = Application.StartupPath + "\\PythonFiles";
            if (Directory.Exists(path))
            {
                lbPyFiles.Items.Clear();
                foreach (var item in Directory.GetFiles(path, "*.py"))
                    lbPyFiles.Items.Add(Path.GetFileName(item));
            }
        }

        #endregion

        #region INSTRUCTIONS GRID METHODS

        private void FormatInstructionsGrid()
        {
            dgvInstructions.Columns["ID"].Visible = false;
            dgvInstructions.Columns["OrderNo"].Visible = false;
            dgvInstructions.Columns["InstructionBytes"].Width = 250;
            dgvInstructions.Columns["CheckSum"].Visible = false;
            dgvInstructions.Columns["CheckSum"].Width = 50;
            dgvInstructions.Columns["CheckSum"].HeaderText = "CHK";
            dgvInstructions.Columns["Explanation"].Width = 230;

            dgvInstructions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 243, 244);
            dgvInstructions.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvInstructions.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void UpdateGridNode(DataGridView sender, string targetFieldName, string targetFieldValue)
        {
            string nodeID = sender.CurrentRow.Cells["ID"].Value.ToString();
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.UpdateNodeByID(nodeID, targetFieldName, targetFieldValue);
        }

        private void dgvInstructions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string nodeID = dgvInstructions.CurrentRow.Cells["ID"].Value.ToString();
            XMLHelper x = new XMLHelper(_currentXMLPath);

            if (e.ColumnIndex == 2)
            {
                string s = string.Empty;
                if (dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value != null) s = dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                x.UpdateNodeByID(nodeID, "InstructionBytes", s);
            }

            if (e.ColumnIndex == 4)
            {
                string s = string.Empty;
                if (dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value != null) s = dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                x.UpdateNodeByID(nodeID, "Explanation", s);
            }
        }

        private void dgvInstructions_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value != null)
                _currentCellValue = dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
        }

        private void dgvInstructions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
                if (dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value != null)
                    if (dgvInstructions.CurrentRow.Cells["Explanation"].Value != null)
                    {
                        txtSentCommand.Text = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString() + "," +
                         dgvInstructions.CurrentRow.Cells["Explanation"].Value.ToString();
                    }
        }

        private void SelectLastRow(DataGridView dataGridView)
        {
            //if(dgvInstructions.SelectedRows.Count>0)
            //dgvInstructions.SelectedRows.Clear();
            dataGridView.Rows[0].Selected = false;
            dataGridView.Rows[dataGridView.Rows.Count - 1].Selected = true;
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["InstructionBytes"];
            dataGridView.BeginEdit(true);
        }

        private void AddNewRow()
        {
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.AddNewNode("");
            LoadDeviceXML(lblCurrentXML.Text);
            SelectLastRow(dgvInstructions);
        }

        private void CloneCurrentRow()
        {
            if (dgvInstructions.Rows.Count > 0)
            {
                DataGridViewRow dr;
                if (dgvInstructions.CurrentRow == null) dr = dgvInstructions.Rows[0];
                else dr = dgvInstructions.CurrentRow;

                string bytes = dr.Cells["InstructionBytes"].Value.ToString();
                XMLHelper x = new XMLHelper(_currentXMLPath);
                x.AddNewNode(bytes);
                LoadDeviceXML(lblCurrentXML.Text);
                SelectLastRow(dgvInstructions);
            }

        }

        private void tsbCloneRow_Click(object sender, EventArgs e)
        {
            CloneCurrentRow();
        }

        private void tsbNewRow_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        //From Instructions Grid To Checksum Calculator
        private void SendToTools()
        {
            if (dgvInstructions.CurrentRow != null)
            {
                txtHEXBytesInCHKCalculator.Text = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString();

                Convertor c = new Convertor();
                c.HexToAsciiIntoTextBox(txtHEXBytesInCHKCalculator, txtASCIIBytesInCHKCalculator);
                c.AsciiToDecimalIntoTextBox(txtASCIIBytesInCHKCalculator, txtDecimalBytesInCHKCalculator);

                tbcTools.SelectedIndex = 1;
            }

        }

        private void tsbSendToTools_Click(object sender, EventArgs e)
        {
            SendToTools();
        }

        #region CalculateCheckSumOnInstructionsGrid()
        private void CalculateCheckSumOnInstructionsGrid()
        {
            if (dgvInstructions.CurrentRow != null)
            {
                if (string.IsNullOrEmpty(cbCheckSumTypes.Text))
                {
                    MessageBox.Show("Select a checksum type.");
                }
                else
                {
                    string bytes = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString();
                    string checksumBytes = CalculateCheckSum(bytes);
                    /*dgvInstructions.CurrentRow.Cells["CheckSum"].Value = checksumBytes;
                    UpdateGridNode(dgvInstructions, "CheckSum", checksumBytes);*/
                    dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = bytes.Trim() + " " + checksumBytes;
                    UpdateGridNode(dgvInstructions, "InstructionBytes", bytes.Trim() + " " + checksumBytes);
                }
            }

        }

        private void cmiCalculateCheckSum_Click(object sender, EventArgs e)
        {
            CalculateCheckSumOnInstructionsGrid();
        }

        private void tsbCalculateCheckSum_Click(object sender, EventArgs e)
        {
            CalculateCheckSumOnInstructionsGrid();
        }

        #endregion



        #endregion

        #region CONNECTION RELATED METHODS

        private void tsbConnectToIP_Click(object sender, EventArgs e)
        {
            if (tsbConnectToIP.Text == "Connect")
            {
                if (CheckNetworkConnection(txtCurrentIP.Text, _pingTimeOut))
                {
                    try
                    {
                        if (_tcpClient == null) _tcpClient = new TcpClient();
                        //Console.WriteLine("Connecting.....");
                        if (_tcpClient.Connected)
                        {
                            MessageBox.Show("Already connected");
                        }
                        else
                        {
                            _tcpClient.Connect(txtCurrentIP.Text, Convert.ToUInt16(txtCurrentPort.Text)); // use the ipaddress as in the server program
                            _stream = _tcpClient.GetStream();

                            SetConnectionType(ConnectionType.TCPIPConnected);

                            lblStatus.Text = "Connected";
                            tsbConnectToIP.Text = "Disconnect";
                            tsbConnectToIP.Image = Properties.Resources.green_light;
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Error:" + exp.StackTrace + " > " + exp.Message);
                    }
                }
                else MessageBox.Show("IP problem. Check network connection.");
            }
            else if (tsbConnectToIP.Text == "Disconnect")
            {

                _tcpClient.Close();
                _stream.Close();

                _tcpClient = null;
                _stream = null;

                SetConnectionType(ConnectionType.TCPIPStandard);

                tsbConnectToIP.Image = Properties.Resources.red_light;
                lblStatus.Text = "";
                tsbConnectToIP.Text = "Connect";

            }
        }

        private void cbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbConnectionType.Text)
            {
                case "ComPort": SetConnectionType(ConnectionType.ComPort); break;
                case "TCPIPConnected": SetConnectionType(ConnectionType.TCPIPConnected); break;
                case "TCPIPStandard": SetConnectionType(ConnectionType.TCPIPStandard); break;
                case "UDP": SetConnectionType(ConnectionType.UDP); break;
            }
        }

        private void tsbSaveIPPort_Click(object sender, EventArgs e)
        {
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.StartNode = "/DeviceInstructions/DeviceInfo";
            string currentDeviceName = tbcDevice.TabPages[0].Text;

            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "IP", txtCurrentIP.Text);
            x.UpdateNodeByRefField("DeviceName", currentDeviceName, "Port", txtCurrentPort.Text);
            MessageBox.Show("Saved IP and Port.");

            Ini.IniFile ini = new Ini.IniFile();
            ini.IniWriteValue("TCPSettings", "IP", txtCurrentIP.Text);
            ini.IniWriteValue("TCPSettings", "Port", txtCurrentPort.Text);
        }

        private void tsbPing_Click(object sender, EventArgs e)
        {
            if (CheckNetworkConnection(txtCurrentIP.Text, _pingTimeOut)) MessageBox.Show("OK"); else MessageBox.Show("Not OK.");
        }

        private void tsbPingPort_Click(object sender, EventArgs e)
        {
            TcpClientWithTimeout c = new TcpClientWithTimeout(txtCurrentIP.Text, Convert.ToInt16(txtCurrentPort.Text), 100);

            if (c.TestPort()) MessageBox.Show("Connecion via Port is OK"); else MessageBox.Show("Connection Via port is not OK.");

        }

        #endregion

        #region CONTEXT MENU STRIP METHODS

        private void cmiSendBytesToConsole_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow == null)
                MessageBox.Show("Select a row");
            else
            {
                shellControl1.SetCommand(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString());
                tbcDevice.SelectedIndex = 2;
            }
        }

        private void cmiCloneCurrentRow_Click(object sender, EventArgs e)
        {
            CloneCurrentRow();
        }

        private void cmiSendToTools_Click(object sender, EventArgs e)
        {
            SendToTools();
        }

        private void cmiSendToBytesGrid_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                byte[] bytesToShow = GetBytes(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString());
                for (int i = 0; i < bytesToShow.Length; i++)
                {
                    dgvIncomingBytes.Rows.Add(i.ToString(), bytesToShow[i].ToString(), "", String.Format("{0:X}", Convert.ToInt32(bytesToShow[i])));
                    tbcTools.SelectedIndex = 0;
                    tbcIncomingBytes.SelectedIndex = 1;
                }
            }
        }

        private void cmiSendBytesToDevice_Click(object sender, EventArgs e)
        {
            tsbSendBytesToDevice_Click(null, null);
        }

        #endregion

        #region GENERIC TEXTBOX METHODS

        public int GetFirstCharIndexOfCurrentLine(TextBox target)
        {
            int col = target.GetFirstCharIndexFromLine(GetCurrentLineNo(target));
            return col;
        }

        public int GetCurrentLineNo(TextBox target)
        {
            return target.GetLineFromCharIndex(target.SelectionStart);
        }

        public int GetLastLineNo(TextBox target)
        {
            return target.Lines.Length - 1;
        }

        private void AddToLastLine(TextBox target, string value)
        {
            string[] lines = target.Lines;
            lines[target.Lines.Length - 1] += value;
            target.Lines = lines;
        }

        public void GoTo(TextBox target, int line, int column)
        {
            if (line < 1 || column < 1 || target.Lines.Length < line)
                return;

            target.SelectionStart = target.GetFirstCharIndexFromLine(line - 1) + column - 1;
            target.SelectionLength = 0;
        }

        private void SetCurrentLineText(TextBox target, string value)
        {
            int currentLineNo = target.GetLineFromCharIndex(target.SelectionStart);
            if (currentLineNo > -1)
            {
                string[] lines = target.Lines;
                lines[currentLineNo] += value;
                target.Lines = lines;
            }
        }
        #endregion CONSOLE OPERATIONS

        #region CHECKSUM CALCULATOR METHODS

        private string CalculateCheckSumInBSV(string blankSeparatedValue)
        {
            //byte[] byteArray = Common.GetBytes(blankSeparatedValue, ' ');
            byte[] byteArray = Common.ConvertHexStringToByteArray(blankSeparatedValue);

            CRCType ctype = new CRCType();
            switch (cbCheckSumTypes.SelectedIndex)
            {
                case 0: ctype = CRCType.SUM; break;
                case 1: ctype = CRCType.XOR; break;
                case 2: ctype = CRCType.Mod95; break;
                case 3: ctype = CRCType.CRC16; break;
                case 4: ctype = CRCType.CRC_CCITT_Kermit; break;
                case 5: ctype = CRCType.CRC32; break;
                case 6: ctype = CRCType.MODBUS; break;
                default: break;
            }

            //ctype = (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true);

            return GetCRC.CalculateCheckSum(byteArray, ctype).HexString;
        }

        private string CalculateCheckSum(string hexValue)
        {
            byte[] byteArray = GetBytes(hexValue);

            CRCType ctype = new CRCType();
            switch (cbCheckSumTypes.SelectedIndex)
            {
                case 0: ctype = CRCType.SUM; break;
                case 1: ctype = CRCType.XOR; break;
                case 2: ctype = CRCType.Mod95; break;
                case 3: ctype = CRCType.CRC16; break;
                case 4: ctype = CRCType.CRC_CCITT_Kermit; break;
                case 5: ctype = CRCType.CRC32; break;
                case 6: ctype = CRCType.MODBUS; break;
                default: break;
            }

            CheckSumRV c = GetCRC.CalculateCheckSum(byteArray, ctype);

            //ctype = (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true);

            return c.HexString;
        }

        //private string CalculateCheckSumInByteString(string byteString)
        //{
        //    byte[] byteArray = GetBytes(byteString);
        //    CRCType ctype = new CRCType();
        //    switch (cbCheckSumTypes.SelectedIndex)
        //    {
        //        case 0: ctype = CRCType.Mod95; break;
        //        case 1: ctype = CRCType.XOR; break;
        //        case 2: ctype = CRCType.CRC16; break;
        //        case 3: ctype = CRCType.CRC_CCITT_Kermit; break;
        //        case 4: ctype = CRCType.CRC32; break;
        //        case 5: ctype = CRCType.SUM; break;
        //        case 6: ctype = CRCType.MODBUS; break;
        //        default: break;
        //    }

        //    //ctype = (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true);

        //    return GetCRC.CalculateCheckSum(byteArray, ctype).HexString;
        //}

        private void lnkCalculateCRC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecimalBytesInCHKCalculator.Text))
            { MessageBox.Show("Enter bytes."); }
            else
            {
                string checkSum = CalculateCheckSum(txtHEXBytesInCHKCalculator.Text.Trim());
                txtHEXBytesInCHKCalculator.Text += " " + checkSum;
            }

            Convertor c = new Convertor();
            c.HexToAsciiIntoTextBox(txtHEXBytesInCHKCalculator, txtDecimalBytesInCHKCalculator);
        }

        private void lnkDelOneHexByte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHEXBytesInCHKCalculator.Text))
            {
                string s = txtHEXBytesInCHKCalculator.Text.Trim();
                if (s.Length % 2 == 0)
                    txtHEXBytesInCHKCalculator.Text = s.Substring(0, s.Length - 2);
                else
                    txtHEXBytesInCHKCalculator.Text = s.Substring(0, s.Length - 3);
            }
        }

        private void dgvCheckSums_DoubleClick(object sender, EventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text += " " + dgvCheckSums.CurrentRow.Cells["ChecksumValue"].Value.ToString();
        }

        private void DisplayCRCValuesInGrid()
        {
            byte[] byteArray = GetBytes(txtHEXBytesInCHKCalculator.Text);
            if (byteArray != null)
            {
                dgvCheckSums.Rows.Clear();

                dgvCheckSums.Rows.Add("SUM", GetCRC.Sum(byteArray).HexString);
                dgvCheckSums.Rows.Add("MOD95", GetCRC.Mod95(byteArray).HexString);
                dgvCheckSums.Rows.Add("XOR", GetCRC.XOR(byteArray).HexString);
                dgvCheckSums.Rows.Add("CRC CCITT Kermit", GetCRC.CRC_CCITT_Kermit(byteArray).HexString);
                dgvCheckSums.Rows.Add("CRC CCITT XModem", GetCRC.CRC_CCITT_XModem(byteArray).HexString);
                dgvCheckSums.Rows.Add("CRC 16", GetCRC.CRC16(byteArray).HexString);
                dgvCheckSums.Rows.Add("MODBUS", GetCRC.ModBus(byteArray).HexString);
                dgvCheckSums.Rows.Add("Sum C.", GetCRC.SumComplement(byteArray).HexString);

                //CRC16 x = new CRC16();
                //dgvCheckSums.Rows.Add("CRC 16", BitConverter.ToString(x.ComputeChecksumBytes(byteArray)));

                Crc16Ccitt y = new Crc16Ccitt(InitialCrcValue.NonZero1);
                dgvCheckSums.Rows.Add("CRC CCITT(0xFFFF)", BitConverter.ToString(y.ComputeChecksumBytes(byteArray)));
                y = new Crc16Ccitt(InitialCrcValue.NonZero2);
                dgvCheckSums.Rows.Add("CRC CCITT(0x1DFF)", BitConverter.ToString(y.ComputeChecksumBytes(byteArray)));
                y = new Crc16Ccitt(InitialCrcValue.Zeros);
                dgvCheckSums.Rows.Add("CRC CCITT(XModem)", BitConverter.ToString(y.ComputeChecksumBytes(byteArray)));
                //Crc32 z = new Crc32();
                //dgvCheckSums.Rows.Add("CRC 32", BitConverter.ToString(z.ComputeChecksumBytes(byteArray)));
                dgvCheckSums.Rows.Add("CRC 32", GetCRC.GetCRC32CheckSum(byteArray).HexString);
            }
        }

        private void btnCalculateCRCInHex_Click(object sender, EventArgs e)
        {
            DisplayCRCValuesInGrid();
            // txtHEXBytes.Text +=GetCRC.CalculateCheckSum(byteArray,  (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true));
        }

        private void lnkClearHexBytes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHEXBytesInCHKCalculator.Clear();
        }

        private void lnkSendToGrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                if (!string.IsNullOrEmpty(txtHEXBytesInCHKCalculator.Text))
                {
                    dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = txtHEXBytesInCHKCalculator.Text;
                    UpdateGridNode(dgvInstructions, "InstructionBytes", txtHEXBytesInCHKCalculator.Text);
                }
            }
        }



        #endregion

        #region ASCII HEX TEXTBOX DECIMAL CONVERSIONS

        private void txtHEXBytes_TextChanged(object sender, EventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text = Common.RemoveNonHexChars(txtHEXBytesInCHKCalculator.Text);
            if (txtHEXBytesInCHKCalculator.Focused)
            {
                try
                {
                    DisplayCRCValuesInGrid();
                    Convertor c = new Convertor();
                    c.HexToAsciiIntoTextBox((sender as TextBox), txtASCIIBytesInCHKCalculator);
                    c.AsciiToDecimalIntoTextBox(txtASCIIBytesInCHKCalculator, txtDecimalBytesInCHKCalculator);
                }
                catch (Exception exc)
                {
                    WriteMessage(System.Reflection.MethodBase.GetCurrentMethod().Name + " > " + exc.ToString());
                }
            }
        }

        private void txtASCIIBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtASCIIBytesInCHKCalculator.Focused)
            {

                Convertor c = new Convertor();
                c.AsciiToDecimalIntoTextBox((sender as TextBox), txtDecimalBytesInCHKCalculator);
                c.DecimalToHexIntoTextBox(txtDecimalBytesInCHKCalculator, txtHEXBytesInCHKCalculator);
                DisplayCRCValuesInGrid();
            }
        }

        private void txtDecimalBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtDecimalBytesInCHKCalculator.Focused)
            {
                Convertor c = new Convertor();
                c.DecimalToHexIntoTextBox((sender as TextBox), txtHEXBytesInCHKCalculator);
                c.HexToAsciiIntoTextBox(txtHEXBytesInCHKCalculator, txtASCIIBytesInCHKCalculator);
                DisplayCRCValuesInGrid();
            }
        }



        private void txtDecimalBytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
                e.Handled = true;
        }
        #endregion

        #region SERIAL PORT METHODS

        string RxString;

        private void SetSerialPortParameters(string comPort, int baudRate, string parity, byte dataBits, string stopBits)
        {
            try
            {
                serialPort1.PortName = comPort;
                serialPort1.BaudRate = baudRate;
                serialPort1.DataBits = dataBits;

                serialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity, true);
                serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopBits, true);

                lblComPortInfo.Text = serialPort1.PortName + "," + serialPort1.BaudRate + "," + serialPort1.Parity + "," + serialPort1.DataBits + "," + serialPort1.StopBits;
            }
            catch (Exception)
            {
                lblComPortInfo.Text = "Error in com port parameters.";
            }


            //if (parity == "None") serialPort1.Parity = System.IO.Ports.Parity.None;
            //if (parity == "Odd") serialPort1.Parity = System.IO.Ports.Parity.Odd;
            //if (parity == "Even") serialPort1.Parity = System.IO.Ports.Parity.Even;
            //if (parity == "Mark") serialPort1.Parity = System.IO.Ports.Parity.Mark;
            //if (parity == "Space") serialPort1.Parity = System.IO.Ports.Parity.Space;

            //if (stopBits == "None") serialPort1.StopBits = System.IO.Ports.StopBits.None;
            //if (stopBits == "One") serialPort1.StopBits = System.IO.Ports.StopBits.One;
            //if (stopBits == "Two") serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            //if (stopBits == "OnePointFive") serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;


        }

        private void tsbComPortSettings_Click(object sender, EventArgs e)
        {
            frmComPortSettings x = new frmComPortSettings();
            if (x.ShowDialog() == DialogResult.OK)
            {
                SetSerialPortParameters(x.ComPort, x.BaudRate, x.Parity, x.DataBits, x.StopBits);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDelayTime.Text))
                System.Threading.Thread.Sleep(Convert.ToInt32(txtDelayTime.Text));

            RxString = serialPort1.ReadExisting();
            //System.Threading.Thread x = new System.Threading.Thread(new System.Threading.ThreadStart(DisplayText));
            //this.Invoke(new EventHandler(DisplayText));
            //x.Start();
            DisplayText();

            if (chkSaveLog.Checked)
            {
                //System.Threading.Thread.Sleep(1000);
                SaveLog(txtReceivedBytesASCII.Text.Trim());

            }
        }

        private delegate void DisplayTextDelegate();

        private void DisplayText()
        {
            if (this.InvokeRequired)
            {
                DisplayTextDelegate d = new DisplayTextDelegate(DisplayText);
                this.Invoke(d);
            }
            else
            {
                txtReceivedBytesASCII.Text = txtReceivedBytesASCII.Text.Insert(0, RxString);
                DynamicByteProvider b = new DynamicByteProvider(Encoding.ASCII.GetBytes(RxString));
                hexReceivedBytes.ByteProvider = b;
            }
        }

        private void tsbSendToComPort_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                string bytes = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString();
                byte[] bytesToSend = GetBytes(bytes);
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
            }
        }

        private void tsbConnectToComPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                tsbConnectToComPort.Text = "Connect";
                tsbConnectToComPort.Image = Properties.Resources.red_light;
                SetConnectionType(ConnectionType.TCPIPStandard);
            }
            else
            {
                try
                {
                    serialPort1.Open();
                    tsbConnectToComPort.Text = "Disconnect";
                    tsbConnectToComPort.Image = Properties.Resources.green_light;
                    SetConnectionType(ConnectionType.ComPort);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }

            }
        }

        #endregion

        #region COMMAND CONSOLE RELATED METHODS       

        private void tsbChangeMainConsoleStyle_Click(object sender, EventArgs e)
        {
            txtReceivedBytesASCII.ForeColor = Color.White;
            txtReceivedBytesASCII.BackColor = Color.Black;

        }

        private void lnkSelectDOSCommand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkCommands x = new frmNetworkCommands();
            if (x.ShowDialog() == DialogResult.OK)
            {
                shellControl1.SetCommand(x.DOSCommand);
                shellControl1.Focus();
            }
        }

        private void rbDeviceMode_CheckedChanged(object sender, EventArgs e)
        {
            SetConsoleMode();
        }

        private void rbDosMode_CheckedChanged(object sender, EventArgs e)
        {
            SetConsoleMode();
        }

        private void tsbClearIncomingBytes_Click(object sender, EventArgs e)
        {
            txtSentCommand.Clear();
            txtReceivedBytesASCII.Clear();
            hexReceivedBytes.ByteProvider = new DynamicByteProvider(new byte[] { });
            dgvIncomingBytes.Rows.Clear();
            bitDisplay1.Clear();


        }

        private void shellControl1_CommandEntered(object sender, CommandEnteredEventArgs e)
        {
            if (!ProcessInternalCommand(e.Command))
            {
                if (_consoleMode == ConsoleMode.DOS)
                {
                    string s = DOSPrompt.CMDAutomate(e.Command);
                    shellControl1.WriteText(s);
                    //txtLastOutput.Text = s;
                }

                if (_consoleMode == ConsoleMode.ASCII)
                {
                    byte[] r = Common.SendBytes(txtCurrentIP.Text, txtCurrentPort.Text, ASCIIEncoding.ASCII.GetBytes(e.Command));
                    shellControl1.WriteText(ASCIIEncoding.ASCII.GetString(r));
                }

                if (_consoleMode == ConsoleMode.HEX)
                {
                    byte[] receivedBytes = Common.SendBytes(txtCurrentIP.Text, txtCurrentPort.Text, GetBytes(Common.VerifyHexFormat(e.Command)));
                    if (receivedBytes == null)
                    {
                        shellControl1.WriteText("returns null.");
                    }
                    else
                    {
                        string hex = BitConverter.ToString(receivedBytes).Replace("-", " ");
                        shellControl1.WriteText(hex);
                        ShowBytesInTextBoxes(receivedBytes);
                    }
                }

                if (_consoleMode == ConsoleMode.Python)
                {
                    string pythonFilename = cbPythonSenders.Text;
                    if (string.IsNullOrEmpty(pythonFilename)) pythonFilename = "python_socket.py";
                    string pythonPath = Ini.IniFile.GetValue("Python", "ExePath");
                    try
                    {
                        var stopWatch = new System.Diagnostics.Stopwatch();
                        stopWatch.Start();
                        string incomingHexPacket = DOSPrompt.RunPythonFile(pythonFilename, "\"" + e.Command + "\"");
                        stopWatch.Stop();
                        lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";

                        if (incomingHexPacket.IndexOf("error") > -1) WriteMessage(incomingHexPacket);
                        else shellControl1.WriteText(incomingHexPacket);
                    }
                    catch (Exception exc)
                    {
                        WriteMessage(exc.ToString());
                        SaveLog(exc.ToString());
                    }
                }
            }

            //}
        }

        #endregion

        #region WORKBENCH RELATED METHODS
        private string GetWorkbenchCurrentLineBytes()
        {
            int currentLineIndex = txtWorkbench.GetLineFromCharIndex(txtWorkbench.GetFirstCharIndexOfCurrentLine());
            if (currentLineIndex < txtWorkbench.Lines.Length)
            {
                string s = txtWorkbench.Lines[currentLineIndex];
                txtSentCommand.Text = s;
                string[] c = s.Split(',');
                return c[0];
            }
            else return string.Empty;
        }

        private void txtWorkbench_MouseClick(object sender, MouseEventArgs e)
        {
            txtWorkbenchCurrentCommand.Text = GetWorkbenchCurrentLineBytes();
        }

        private void tsbSaveWorkbenchText_Click(object sender, EventArgs e)
        {
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.StartNode = "/DeviceInstructions/WorkbenchData";
            x.UpdateNodeByID("1", "Instructions", txtWorkbench.Text);
            MessageBox.Show("Saved text.");
        }

        private void tsbCalculateWorkbenchChk_Click(object sender, EventArgs e)
        {
            string bytes = GetWorkbenchCurrentLineBytes();
            if (!string.IsNullOrEmpty(bytes))
            {
                // string checkSum = CalculateCheckSumInBSV(bytes);

                string checkSum = CalculateCheckSum(bytes);
                bytes += " " + checkSum;

                int charIndex = txtWorkbench.GetFirstCharIndexOfCurrentLine();
                string s = txtWorkbench.Lines[txtWorkbench.GetLineFromCharIndex(charIndex)];
                int commaIndex = s.IndexOf(',');
                if (commaIndex > 0)
                {
                    txtWorkbench.Text = txtWorkbench.Text.Remove(charIndex, commaIndex);
                    txtWorkbench.Text = txtWorkbench.Text.Insert(charIndex, bytes);
                }
            }
        }

        private void tsbSendToGrid_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                string bytes = GetWorkbenchCurrentLineBytes();

                dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = bytes;
                tbcDevice.SelectedIndex = 0;
            }
            else MessageBox.Show("Select a row in instructions grid.");
        }

        private void tsbSendFromWorkbenchToTools_Click(object sender, EventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text = txtWorkbenchCurrentCommand.Text;
            tbcTools.SelectedIndex = 1;
        }


        #endregion

        #region TIMER RELATED METHODS

        int _tmrRequestTickCount = 0;
        List<byte[]> timerCommandList = new List<byte[]>();
        int timerCommandNo = 0;

        private void tsbStartTimer_Click(object sender, EventArgs e)
        {
            StartTimers();

            /*
            if (dgvTimerInstructions.Rows.Count > 0)
            {
                timerCommandList.Clear();
                foreach (DataGridViewRow dr in dgvTimerInstructions.Rows)
                {
                    if(dr!=null)
                    timerCommandList.Add(GetBytesFromRow(dr));
                }
                timerCommandNo = 0;
                tmrRequest.Interval = Convert.ToInt32(txtTimerInterval.Text);
                tmrRequest.Enabled = true;
            }*/
        }

        private void tsbAddToTimerList_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvInstructions.SelectedRows)
                {
                    dgvTimerInstructions.Rows.Add(r.Cells["InstructionBytes"].Value.ToString(), r.Cells["Explanation"].Value.ToString());
                }
            }
        }

        private void tsbRemoveTimerCommand_Click(object sender, EventArgs e)
        {
            if (dgvTimerInstructions.CurrentRow != null)
            {
                dgvTimerInstructions.Rows.Remove(dgvTimerInstructions.CurrentRow);
            }
        }

        private void tsbStopTimer2_Click(object sender, EventArgs e)
        {
            tmrCounter.Enabled = tmrRequest.Enabled = false;
            chronometer1.Stop();
        }

        private void tsbSetTimerInterval_Click(object sender, EventArgs e)
        {
            tmrRequest.Interval = Convert.ToInt32(txtTimerInterval.Text);
            chronometer1.Reset();
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            _tmrRequestTickCount++;
            //   sevenSegmentArray1.Value = _tmrRequestTickCount.ToString();
        }

        private void tsbToogleCounterTimerInterval_Click(object sender, EventArgs e)
        {
            if (tmrCounter.Interval == 1000) tmrCounter.Interval = 1; else tmrCounter.Interval = 1000;
        }

        private void StartTimers()
        {
            _tmrRequestTickCount = 0;
            timerCommandNo = 0;
            tmrRequest.Enabled = true;
            tmrCounter.Enabled = true;
            tmrRequest.Interval = Convert.ToInt32(txtTimerInterval.Text);
            tmrCounter.Interval = 1000;
            dgvTimerInstructions.Rows[timerCommandNo].Selected = true;
            chronometer1.Start();
        }

        private void tmrRequest_Tick(object sender, EventArgs e)
        {
            _tmrRequestTickCount = 0;
            chronometer1.Reset();

            if (dgvTimerInstructions.Rows.Count > 0)
            {
                sevenSegmentArray2.Value = (timerCommandNo + 1).ToString();

                foreach (DataGridViewRow dr in dgvTimerInstructions.SelectedRows) dr.Selected = false;

                dgvTimerInstructions.Rows[timerCommandNo].Selected = true;

                string hexBytePacket = dgvTimerInstructions.Rows[timerCommandNo].Cells["InstructionBytes"].Value.ToString();
                txtSentCommand.Text = hexBytePacket;
                SendBytesToDevice(hexBytePacket);

                timerCommandNo++;
                if (timerCommandNo == dgvTimerInstructions.Rows.Count - 1) timerCommandNo = 0;
            }
        }

        private void tsbStopTimer_Click(object sender, EventArgs e)
        {
            tmrRequest.Enabled = false;
            timerCommandNo = 0;
            timerCommandList.Clear();
        }

        #endregion

        #region CONVERTOR RELATED METHODS

        private void txtIntNumberToConvert_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIntNumberToConvert.Text))
            {
                try
                {
                    if (rbInt16.Checked)
                    {
                        UInt16 value = Convert.ToUInt16(txtIntNumberToConvert.Text);
                        byte[] array = BitConverter.GetBytes(value);
                        txtConvertedBytes.Text = BitConverter.ToString(array).Replace("-", " ");
                    }

                    if (rbInt32.Checked)
                    {
                        UInt32 value = Convert.ToUInt32(txtIntNumberToConvert.Text);
                        byte[] array = BitConverter.GetBytes(value);
                        txtConvertedBytes.Text = BitConverter.ToString(array).Replace("-", " ");
                    }

                    if (rbDouble.Checked)
                    {
                        Double value = Convert.ToDouble(txtIntNumberToConvert.Text);
                        byte[] array = BitConverter.GetBytes(value);
                        txtConvertedBytes.Text = BitConverter.ToString(array).Replace("-", " ");
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtConvertedBytes_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConvertedBytes.Text))
            {
                try
                {
                    if (rbInt16.Checked)
                    {
                        Int16 i = BitConverter.ToInt16(GetBytes(txtConvertedBytes.Text), 0);
                        txtIntNumberToConvert.Text = i.ToString();
                    }
                    if (rbInt32.Checked)
                    {
                        Int32 i = BitConverter.ToInt32(GetBytes(txtConvertedBytes.Text), 0);
                        txtIntNumberToConvert.Text = i.ToString();
                    }
                    if (rbDouble.Checked)
                    {
                        double i = BitConverter.ToDouble(GetBytes(txtConvertedBytes.Text), 0);
                        txtIntNumberToConvert.Text = i.ToString();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        #endregion

        #region TOP MENU METHODS


        private void miHTTPTester_Click(object sender, EventArgs e)
        {
            frmHTTPTester x = new frmHTTPTester();
            x.ShowDialog();
        }

        private void miNetworkTools_Click(object sender, EventArgs e)
        {
            frmNetworkTools x = new frmNetworkTools();
            x.ShowDialog();
        }

        private void miSSHTester_Click(object sender, EventArgs e)
        {
            frmSSH x = new frmSSH();
            x.ShowDialog();
        }

        private void miSuperConsole_Click(object sender, EventArgs e)
        {
            frmSuperConsole x = new frmSuperConsole();
            x.ShowDialog();

        }

        private void miHelp_Click(object sender, EventArgs e)
        {
            frmHelp x = new frmHelp();
            x.ShowDialog();
        }
        #endregion

        #region PYTHON RELATED METODS

        private void miPythonConsole_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\PythonDude.exe");
        }

        private void lnkApplyPython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lmkEditPythonCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbPyFiles.SelectedIndex > -1)
            {
                string file = lbPyFiles.Text;
                System.Diagnostics.Process.Start(Application.StartupPath + "\\PythonDude.exe", file);
            }
        }

        private void btnApplyPythonCode_Click(object sender, EventArgs e)
        {
            string rv = DOSPrompt.RunPythonFile(lbPyFiles.Text, "\"" + txtHEXBytesInCHKCalculator.Text + "\"");
            if (rv.IndexOf("error") > -1)
                WriteMessage(rv);
            else txtHEXBytesInCHKCalculator.Text = rv;
        }

        private void lnkReloadPythonFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPythonFiles();
        }

        #endregion

        #region ANALYZE RECEIVED BYTES

        private void GetBitsInHexBoxByte()
        {
            if ((hexReceivedBytes.ByteProvider != null) && (hexReceivedBytes.CurrentPositionInLine >= 0))
            {
                long position = (hexReceivedBytes.CurrentLine - 1) * 16 + hexReceivedBytes.CurrentPositionInLine - 1;
                if (position < hexReceivedBytes.ByteProvider.Length)
                {
                    byte b = hexReceivedBytes.ByteProvider.ReadByte(position);

                    lblByteNo.Text = "Byte No " + position.ToString() + "> " + b.ToString();

                    bitDisplay1.ShowBitsOfByte(b);
                }
            }
        }

        private void hexBox_MouseClick(object sender, MouseEventArgs e)
        {
            GetBitsInHexBoxByte();
        }

        private void dgvIncomingBytes_SelectionChanged(object sender, EventArgs e)
        {
            byte b = Convert.ToByte(dgvIncomingBytes.CurrentRow.Cells["Decimal"].Value);
            bitDisplay2.ShowBitsOfByte(b);
        }

        #endregion

        #region MAY BE REMOVED LATER

        private void tsbConvertToHex_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                Convertor c = new Convertor();
                string[] bytes = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString().Split(',');
                string s = string.Empty;
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string decimalByteValue = Convert.ToInt32(bytes[i]).ToString();
                    s += c.DecimalToHex(decimalByteValue) + " ";
                }
                dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = s.Remove(s.Length - 1, 1);
            }
        }

        private void lnkApplyBCIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("10", "10 EF");
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("02", "10 FD");
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("03", "10 FC");
            txtHEXBytesInCHKCalculator.Text = "02 " + txtHEXBytesInCHKCalculator.Text + " " + dgvCheckSums.Rows[2].Cells[1].Value.ToString() + " 03";
        }

        private void lnkGetComplement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Convertor c = new Convertor();
            byte[] byteArray = GetBytes(txtHEXBytesInCHKCalculator.Text);
            txtHEXBytesInCHKCalculator.Clear();
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)(0xFF ^ byteArray[i]);
                string decimalByteValue = Convert.ToInt32(byteArray[i]).ToString();
                txtHEXBytesInCHKCalculator.Text += c.DecimalToHex(decimalByteValue);
            }
        }








        #endregion

        //private void btnSNMPSend_Click(object sender, EventArgs e)
        //{

        //}

        //private void tsbSNMPSet_Click(object sender, EventArgs e)
        //{

        //}

        private void tsbErrorMessageClear_Click(object sender, EventArgs e)
        {
            tsbErrorMessageClear.Image = Properties.Resources.grey_dot;
            tbcTools.SelectedIndex = 3;
        }

        private void tsbClearErrorMessages_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void tsbMoveTimerRowUp_Click(object sender, EventArgs e)
        {
            if (dgvTimerInstructions.SelectedRows[0].Index != 0)
            {
                for (int j = 0; j < this.dgvTimerInstructions.Columns.Count; j++)
                {
                    object tmp = this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index].Value;
                    this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index].Value = this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index - 1].Value;
                    this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index - 1].Value = tmp;
                }
                int a = dgvTimerInstructions.SelectedRows[0].Index;
                dgvTimerInstructions.ClearSelection();
                this.dgvTimerInstructions.Rows[a - 1].Selected = true;
            }


        }

        private void tsbMoveTimerRowDown_Click(object sender, EventArgs e)
        {
            if (dgvTimerInstructions.SelectedRows[0].Index != dgvTimerInstructions.Rows.Count - 2)
            {
                for (int j = 0; j < this.dgvTimerInstructions.Columns.Count; j++)
                {
                    object tmp = this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index].Value;
                    this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index].Value = this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index + 1].Value;
                    this.dgvTimerInstructions[j, dgvTimerInstructions.SelectedRows[0].Index + 1].Value = tmp;
                }
                int i = dgvTimerInstructions.SelectedRows[0].Index;
                dgvTimerInstructions.ClearSelection();
                this.dgvTimerInstructions.Rows[i + 1].Selected = true;
            }
        }

        private void tsbShowLogs_Click(object sender, EventArgs e)
        {
            frmShowLogs x = new frmShowLogs();
            x.Show();
        }

        private void miCopyHexBoxToClipboard_Click(object sender, EventArgs e)
        {
            hexReceivedBytes.CopyHex();
        }
    }
}
