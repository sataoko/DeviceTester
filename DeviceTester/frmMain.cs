using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using SnmpSharpNet;
using System.Net;
using Be.Windows.Forms;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
        enum ConsoleMode { HEX, DOS, ASCII, Python }
        enum ConnectionType { TCPIPStandard, TCPIPConnected, UDP, ComPort }

        // TCPConnection t = new TCPConnection("10.0.0.242", 4001);
        string _consoleHelpText = string.Empty;
        string _currentXMLPath = string.Empty;
        string _currentCellValue = string.Empty;
        int _tmrRequestTickCount = 0;
        string _promptText = ">";

        public string _delimiter = " ";

        ConsoleMode _consoleMode = ConsoleMode.DOS;
        ConnectionType _currentConnectionType = ConnectionType.TCPIPStandard;
        TcpClient _tcpClient = new TcpClient();
        NetworkStream _stream;

        string RxString;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);

        List<byte[]> timerCommandList = new List<byte[]>();
        int timerCommandNo = 0;

        private void ChangeConnectionType(ConnectionType connectionType)
        {
            _currentConnectionType = connectionType;
            lblConnectionType.Text = "Connection Type:" + connectionType.ToString();

        }

        public bool CheckNetworkConnection(string IP)
        {
            if (string.IsNullOrEmpty(IP)) return false;
            try
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IP);
                System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply reply;
                reply = pinger.Send(ipAddress, 5);
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

        public byte[] GetBytesToSend(string byteString)
        {
            byte[] bytes;
            if (chkCommandIsASCII.Checked) bytes = ASCIIEncoding.ASCII.GetBytes(byteString);
            else
            {
                byteString = byteString.Replace(" ", string.Empty);
                byteString = byteString.Replace("  ", string.Empty);
                byteString = byteString.Replace("   ", string.Empty);

                if ((byteString.Length) % 2 != 0)
                {
                    txtReceivedBytesASCII.Text = "Check hex bytes. The length is not correct.";
                    return null;
                }

                bytes = GetBytesFromByteString(byteString);

                /*int i = byteString.IndexOf(' ');
                if (i > 0)
                    bytes = GetHexBytes(byteString, ' ');
                else
                {
                    if ((byteString.Length) % 2 != 0)
                    {
                        MessageBox.Show("check hex bytes.the length is not correct.");
                        return null;
                    }

                    bytes = GetBytesFromByteString(byteString);
                }*/
            }
            return bytes;
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

        private void FormatInstructionsGrid()
        {
            dgvInstructions.Columns["ID"].Visible = false;
            dgvInstructions.Columns["OrderNo"].Visible = false;
            dgvInstructions.Columns["InstructionBytes"].Width = 230;
            dgvInstructions.Columns["CheckSum"].Visible = false;
            dgvInstructions.Columns["CheckSum"].Width = 50;
            dgvInstructions.Columns["CheckSum"].HeaderText = "CHK";
            dgvInstructions.Columns["Explanation"].Width = 230;

        }

        private void LoadDeviceXML(string xmlFilename)
        {
            lblCurrentXML.Text = xmlFilename;
            string xmlPath = string.Empty;

            //if (addPath) xmlPath = Application.StartupPath + "\\DeviceXMLs\\" + xmlFilename;
            //else xmlPath = xmlFilename;

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
            }
            else MessageBox.Show(xmlPath + " file does not exist.");
        }

        #region MAIN COMMUNICATION METHODS
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
        }


        byte[] GetBytesFromByteString(string byteString)
        {
            byteString = byteString.Replace(" ", string.Empty);
            try
            {
                string[] bytes = new string[byteString.Length / 2];

                string s = string.Empty;
                int c = 0;
                for (int i = 0; i < byteString.Length; i++)
                {
                    s += byteString[i];

                    if (i % 2 != 0)
                    {
                        bytes[c++] = s;
                        s = string.Empty;
                    }
                }

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
            byte[] byteArray = GetBytesFromByteString(hexValue);

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

        private string CalculateCheckSumInByteString(string byteString)
        {
            byte[] byteArray = GetBytesFromByteString(byteString);
            CRCType ctype = new CRCType();
            switch (cbCheckSumTypes.SelectedIndex)
            {
                case 0: ctype = CRCType.Mod95; break;
                case 1: ctype = CRCType.XOR; break;
                case 2: ctype = CRCType.CRC16; break;
                case 3: ctype = CRCType.CRC_CCITT_Kermit; break;
                case 4: ctype = CRCType.CRC32; break;
                case 5: ctype = CRCType.SUM; break;
                case 6: ctype = CRCType.MODBUS; break;
                default: break;
            }

            //ctype = (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true);

            return GetCRC.CalculateCheckSum(byteArray, ctype).HexString;
        }

        private string ShowBytesInTextBoxes(byte[] bytesToShow)
        {
            dgvIncomingBytes.Rows.Clear();

            Convertor c = new Convertor();
            int readSize = 100;

            if (!string.IsNullOrEmpty(txtReadBufferSize.Text))
                readSize = Convert.ToInt16(txtReadBufferSize.Text);

            string bytesInHex = string.Empty;
            for (int i = 0; i < readSize; i++)
            {
                //  txtReceivedBytesASCII.Text += bytesToShow[i].ToString() + _delimiter;
                bytesInHex += bytesToShow[i].ToString() + " ";
                dgvIncomingBytes.Rows.Add(i.ToString(), bytesToShow[i].ToString(), "", c.DecimalToHex(bytesToShow[i].ToString()));
            }

            txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(bytesToShow);
            //c.DecimalToHexIntoTextBox(txtReceivedBytes, txtReceivedBytesHex);

            DynamicByteProvider b = new DynamicByteProvider(bytesToShow);
            hexReceivedBytes.ByteProvider = b;

            if (chkSaveLog.Checked) SaveLog(txtSentCommand.Text + "," + bytesInHex + "," + txtReceivedBytesASCII.Text);

            return txtReceivedBytesASCII.Text;
        }

        private void SaveLog(string data)
        {
            string logsFolder = Application.StartupPath + "\\Logs\\";
            if (!Directory.Exists(logsFolder)) Directory.CreateDirectory(logsFolder);

            using (StreamWriter sw = File.AppendText(logsFolder + txtDeviceName.Text + "Logs.txt"))
            {
                sw.WriteLine(DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "," + data);
            }

            //System.IO.FileInfo t = new System.IO.FileInfo(Application.StartupPath + "\\" + txtDeviceName.Text + ".txt");
            //System.IO.StreamWriter text = t.CreateText(true);
            //text.WriteLine(RxString);
            //text.Close();
        }

        #endregion MAIN COMMUNICATION METHODS

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime d = Common.RetrieveLinkerTimestamp();
            lblBuildDate.Text += d.ToShortDateString() + "," + d.ToShortTimeString();

            Image b = imageList1.Images[0];

            //Bitmap bm = new Bitmap("Picture.jpg");
            Bitmap bm = new Bitmap(b);
            IntPtr hBitmap = bm.GetHbitmap();

            tbcDevice.SelectedIndex = 0;

            //string promptText = txtIP.Text + ":" + txtPort.Text+">";
            //txtConsole.Text = promptText;

            ChangeConnectionType(ConnectionType.TCPIPStandard);

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Start.ini";
            if (System.IO.File.Exists(path))
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
                catch (Exception)
                {
                    lblComPortInfo.Text = "Error in com port parameters at Start.ini";
                }

            }

            dgvInstructions.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void tsbLoadDeviceXML_Click(object sender, EventArgs e)
        {
            frmDeviceXMLs x = new frmDeviceXMLs();
            if (x.ShowDialog() == DialogResult.OK)
            {
                LoadDeviceXML(x.DeviceXMLFilePath);
            }
        }

        private byte[] GetBytesFromRow(DataGridViewRow row)
        {
            if (row != null)
            {
                byte[] bytesToSend;

                if (chkCommandIsASCII.Checked) bytesToSend = ASCIIEncoding.ASCII.GetBytes(row.Cells["InstructionBytes"].Value.ToString() + "\r");
                else bytesToSend = GetBytesToSend(row.Cells["InstructionBytes"].Value.ToString());

                return bytesToSend;
            }
            else return null;
        }


        private void tsbBulkRequest_Click(object sender, EventArgs e)
        {

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
                x.UpdateNodeByID(nodeID, "InstructionBytes", dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            if (e.ColumnIndex == 3)
                x.UpdateNodeByID(nodeID, "CheckSum", dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            if (e.ColumnIndex == 4)
                x.UpdateNodeByID(nodeID, "Explanation", dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
        }

        private void dgvInstructions_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _currentCellValue = dgvInstructions.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
        }



        #region CONNECTED OPERATIONS

        private void btnConnectToIP_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        #endregion

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

        #region ASCII HEX DECIMAL CONVERSIONS
        private void txtASCIIBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtASCIIBytesInCHKCalculator.Focused)
            {
                // if (rbASCII.Checked)
                {

                    Convertor c = new Convertor();
                    c.AsciiToDecimalIntoTextBox((sender as TextBox), txtDecimalBytesInCHKCalculator);
                    c.DecimalToHexIntoTextBox(txtDecimalBytesInCHKCalculator, txtHEXBytesInCHKCalculator);
                    btnCalculateCRCInHex_Click(null, null);
                    //c.ConvertBytesIntoTextBox((sender as TextBox), txtDecimalBytes, "Decimal"); 
                    //c.ApplyConvertionsToTextBoxes( txtHEXBytes, "HEX");
                }
            }
        }

        private void txtDecimalBytes_TextChanged(object sender, EventArgs e)
        {
            //List<int> checkValues = new List<int> { 48,49,50,51,52,53,54,55,56,57};

            //char d = txtDecimalBytes.Text[txtDecimalBytes.Text.Length - 1];

            //if (!checkValues.Contains(d))
            //{
            //    txtDecimalBytes.Text = txtDecimalBytes.Text.Remove(txtDecimalBytes.Text.Length - 1, 1);
            //    return;
            //}

            // if (rbDecimal.Checked)
            //for (int i = 0; i < txtDecimalBytes.Text.Length; i++)
            //{
            //    char c =   txtDecimalBytes.Text[i];
            //    //if ((c != 48 || c != 49 || c != 50 || c != 51 || c != 52 || c != 53 || c != 54 || c != 55 || c != 56 || c != 57 || c != ','))

            //    if ((c < 48 || c > 57 && c == ','))
            //        return;
            //}

            if (txtDecimalBytesInCHKCalculator.Focused)
            {
                Convertor c = new Convertor();
                c.DecimalToHexIntoTextBox((sender as TextBox), txtHEXBytesInCHKCalculator);
                c.HexToAsciiIntoTextBox(txtHEXBytesInCHKCalculator, txtASCIIBytesInCHKCalculator);
                btnCalculateCRCInHex_Click(null, null);
                //c.ConvertBytesIntoTextBox((sender as TextBox), txtHEXBytes, "HEX"); 
                //c.ApplyConvertionsToTextBoxes((sender as TextBox), txtASCIIBytes, "ASCII", txtHEXBytes, "HEX");   
            }

        }

        private void txtHEXBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtHEXBytesInCHKCalculator.Focused)
            //if (rbHEX.Checked)
            {
                btnCalculateCRCInHex_Click(null, null);

                Convertor c = new Convertor();
                c.HexToAsciiIntoTextBox((sender as TextBox), txtASCIIBytesInCHKCalculator);
                c.AsciiToDecimalIntoTextBox(txtASCIIBytesInCHKCalculator, txtDecimalBytesInCHKCalculator);
                //c.ConvertBytesIntoTextBox((sender as TextBox), txtASCIIBytes, "ASCII"); 
            }

        }

        private void txtDecimalBytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
                e.Handled = true;
        }
        #endregion

        private void dgvIncomingBytes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        #region CONTEXT MENU STRIP METHODS



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

        private void txtDecimalBytes_KeyDown(object sender, KeyEventArgs e)
        {
            // if (!IsNumberKey(e.KeyCode)) e.Handled=true;

            //if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 || e.KeyCode == Keys.Oemcomma)
            //{
            //    e.Handled = true;
            //}
        }

        private void tsbCloneRow_Click(object sender, EventArgs e)
        {
            CloneCurrentRow();
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

        private void btnActiveTCPConnections_Click(object sender, EventArgs e)
        {
            string a = "ABCÇ";
            for (int i = 0; i < a.Length; i++)
            {
                txtIntNumberToConvert.Text += Convert.ToByte(a[i]) + ",";
                txtConvertedBytes.Text += a[i].ToString() + ",";
            }

            this.Text = ASCIIEncoding.ASCII.GetString(new byte[] { 65, 56, 65 });

            //GetActiveTCPConnections();
        }

        private void tsbConnectToIP_Click(object sender, EventArgs e)
        {
            if (tsbConnectToIP.Text == "Connect")
            {
                if (CheckNetworkConnection(txtCurrentIP.Text))
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

                            SetCurrentConnectionType(ConnectionType.TCPIPConnected);

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

                SetCurrentConnectionType(ConnectionType.TCPIPStandard);

                tsbConnectToIP.Image = Properties.Resources.red_light;
                lblStatus.Text = "";
                tsbConnectToIP.Text = "Connect";

            }
        }

        private void SetCurrentConnectionType(ConnectionType connectionType)
        {
            _currentConnectionType = connectionType;
            lblConnectionType.Text = _currentConnectionType.ToString();
            cbCommunicationType.Text = connectionType.ToString();
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

        #region SERIAL PORT METHODS

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
                if (chkUseCheckSum.Checked) bytes += "," + dgvInstructions.CurrentRow.Cells["CheckSum"].Value.ToString();
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
                SetCurrentConnectionType(ConnectionType.TCPIPStandard);
            }
            else
            {
                try
                {
                    serialPort1.Open();
                    tsbConnectToComPort.Text = "Disconnect";
                    tsbConnectToComPort.Image = Properties.Resources.green_light;
                    SetCurrentConnectionType(ConnectionType.ComPort);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }

            }
        }

        #endregion

        private void miHelp_Click(object sender, EventArgs e)
        {
            frmHelp x = new frmHelp();
            x.ShowDialog();
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

        private void tbcDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tbcDevice.SelectedIndex == 2) { }//txtConsole.Focus(); GoTo(txtConsole, 0,2); 
        }

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

        private void tsbNewRow_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        #region WORKBENCH METHODS
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

        #endregion

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

                byte[] bytesToSend = GetBytesFromRow(dgvTimerInstructions.Rows[timerCommandNo]);
                txtSentCommand.Text = dgvTimerInstructions.Rows[timerCommandNo].Cells["InstructionBytes"].Value.ToString();
                if (bytesToSend == null) txtSentCommand.Text = "bytes to send > null.";
                else SendBytesToDevice(bytesToSend);

                timerCommandNo++;
                if (timerCommandNo == dgvTimerInstructions.Rows.Count - 1) timerCommandNo = 0;
            }

            //if (timerCommandList.Count > 0)
            //{
            //    txtSentCommand.Text = dgvTimerInstructions.Rows[timerCommandNo].Cells["Instruction"].Value.ToString();

            //    SendBytesToDevice(timerCommandList[timerCommandNo]);
            //    
            //    if (timerCommandNo >= timerCommandList.Count) timerCommandNo = 0;
            //}
        }

        private void tsbStopTimer_Click(object sender, EventArgs e)
        {
            tmrRequest.Enabled = false;
            timerCommandNo = 0;
            timerCommandList.Clear();
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

        private void sendSetCommand(string OID, string parameters)
        {
            //tmrRequest.Enabled = false;


            UdpTarget target = new UdpTarget((IPAddress)new IpAddress(txtCurrentIP.Text));
            Pdu pdu = new Pdu(PduType.Set);

            pdu.VbList.Add(new Oid(OID), new OctetString(parameters));

            AgentParameters aparam = new AgentParameters(SnmpVersion.Ver2, new OctetString("private"));
            // Response packet
            SnmpV2Packet response;
            try
            {
                // Send request and wait for response
                response = target.Request(pdu, aparam) as SnmpV2Packet;
            }
            catch (Exception ex)
            {
                // If exception happens, it will be returned here
                //txtConsole.Text = String.Format("Request failed with exception: {0}", ex.Message);
                target.Close();
                return;
            }

            //tmrRequest.Enabled = true;
        }

        private void btnSNMPSend_Click(object sender, EventArgs e)
        {
            try
            {
                OctetString community = new OctetString("public");
                AgentParameters param = new AgentParameters(community);
                param.Version = SnmpVersion.Ver2;
                IpAddress agent = new IpAddress(txtCurrentIP.Text);

                UdpTarget target = new UdpTarget((System.Net.IPAddress)agent, 161, 2000, 1);

                // Pdu class used for all requests
                Pdu pdu = new Pdu(PduType.Get);


                foreach (DataGridViewRow dr in dgvInstructions.SelectedRows)
                {
                    pdu.VbList.Add(dr.Cells["InstructionBytes"].Value.ToString());
                }

                // Make SNMP request
                SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);

                // If result is null then agent didn't reply or we couldn't parse the reply.
                if (result != null)
                {
                    // ErrorStatus other then 0 is an error returned by 
                    // the Agent - see SnmpConstants for error definitions
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        // agent reported an error with the request
                        txtReceivedBytesASCII.Text = String.Format("Error in SNMP reply. Error {0} index {1}",
                            result.Pdu.ErrorStatus,
                            result.Pdu.ErrorIndex);
                    }
                    else
                    {
                        // Reply variables are returned in the same order as they were added
                        //  to the VbList
                        for (int i = 0; i < result.Pdu.VbList.Count; i++)
                        {
                            txtReceivedBytesASCII.Text += result.Pdu.VbList[i].Oid.ToString() + ", " + SnmpConstants.GetTypeName(result.Pdu.VbList[i].Value.Type) + ", " +
                                result.Pdu.VbList[i].Value.ToString() + ", " + dgvInstructions.SelectedRows[i].Cells["Explanation"].Value.ToString() + Environment.NewLine;
                        }

                    }
                }
                else
                {
                    //txtConsole.Text = String.Format("No response received from SNMP agent.");
                }
                target.Close();

            }
            catch (Exception exp)
            {
                txtReceivedBytesASCII.Text = exp.ToString();

            }
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

        private void tsbChangeMainConsoleStyle_Click(object sender, EventArgs e)
        {
            txtReceivedBytesASCII.ForeColor = Color.White;
            txtReceivedBytesASCII.BackColor = Color.Black;

        }

        private void tsbSNMPSet_Click(object sender, EventArgs e)
        {
            frmInputBox x = new frmInputBox();
            if (x.ShowDialog() == DialogResult.OK)
            {
                sendSetCommand(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString(), x.Value);
            }
        }

        private void tsbPing_Click(object sender, EventArgs e)
        {
            if (CheckNetworkConnection(txtCurrentIP.Text)) MessageBox.Show("OK"); else MessageBox.Show("Not OK.");
        }

        private void tsbPingPort_Click(object sender, EventArgs e)
        {
            TcpClientWithTimeout c = new TcpClientWithTimeout(txtCurrentIP.Text, Convert.ToInt16(txtCurrentPort.Text), 100);

            if (c.TestPort()) MessageBox.Show("Connecion via Port is OK"); else MessageBox.Show("Connection Via port is not OK.");

        }

        private void cbCommunicationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCommunicationType.Text)
            {
                case "ComPort": SetCurrentConnectionType(ConnectionType.ComPort); break;
                case "TCPIPConnected": SetCurrentConnectionType(ConnectionType.TCPIPConnected); break;
                case "TCPIPStandard": SetCurrentConnectionType(ConnectionType.TCPIPStandard); break;
                case "UDP": SetCurrentConnectionType(ConnectionType.UDP); break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string start = chkAddZeroToHexKeyboard.Checked ? "0" : string.Empty;
            txtHEXBytesInCHKCalculator.Text += start + (sender as Button).Text + " ";
        }

        private void btnCalculateCRCInHex_Click(object sender, EventArgs e)
        {
            byte[] byteArray = GetBytesFromByteString(txtHEXBytesInCHKCalculator.Text);

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

            // txtHEXBytes.Text +=GetCRC.CalculateCheckSum(byteArray,  (CRCType)Enum.Parse(typeof(CRCType), cbCheckSumTypes.Text, true));
        }

        private void lnkClearHexBytes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHEXBytesInCHKCalculator.Clear();
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

        private void txtIntNumberToConvert_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIntNumberToConvert.Text))
            {
                try
                {
                    UInt16 value = Convert.ToUInt16(txtIntNumberToConvert.Text);
                    byte[] array = BitConverter.GetBytes(value);
                    txtConvertedBytes.Text = BitConverter.ToString(array).Replace("-", " ");
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
                    Int16 i = BitConverter.ToInt16(GetBytesToSend(txtConvertedBytes.Text), 0);
                    txtIntNumberToConvert.Text = i.ToString();
                }
                catch (Exception)
                {
                }
            }
        }

        private void tsbSendFromWorkbenchToTools_Click(object sender, EventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text = txtWorkbenchCurrentCommand.Text;
            tbcTools.SelectedIndex = 1;
        }

        #region TIMER METHODS

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

        #endregion

        private void GetBitsInHexBoxByte()
        {
            if (hexReceivedBytes.CurrentPositionInLine >= 0)
            {
                long position = (hexReceivedBytes.CurrentLine - 1) * 16 + hexReceivedBytes.CurrentPositionInLine - 1;
                byte b = hexReceivedBytes.ByteProvider.ReadByte(position);

                lblByteNo.Text = "Byte No " + position.ToString() + "> " + b.ToString();

                bitDisplay1.ShowBitsOfByte(b);
            }
        }

        private void hexBox_MouseClick(object sender, MouseEventArgs e)
        {
            GetBitsInHexBoxByte();
        }



        private void lnkToggleSelectedBit_LinkClicked(object sender, EventArgs e)
        {

        }

        private void dgvIncomingBytes_SelectionChanged(object sender, EventArgs e)
        {
            byte b = Convert.ToByte(dgvIncomingBytes.CurrentRow.Cells["Decimal"].Value);
            bitDisplay2.ShowBitsOfByte(b);
        }

        private void dgvCheckSums_DoubleClick(object sender, EventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text += " " + dgvCheckSums.CurrentRow.Cells["ChecksumValue"].Value.ToString();
        }

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

        private void lnkGetComplement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Convertor c = new Convertor();
            byte[] byteArray = GetBytesFromByteString(txtHEXBytesInCHKCalculator.Text);
            txtHEXBytesInCHKCalculator.Clear();
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)(0xFF ^ byteArray[i]);
                string decimalByteValue = Convert.ToInt32(byteArray[i]).ToString();
                txtHEXBytesInCHKCalculator.Text += c.DecimalToHex(decimalByteValue);
            }
        }

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

        private void lnkApplyBCIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("10", "10 EF");
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("02", "10 FD");
            txtHEXBytesInCHKCalculator.Text = txtHEXBytesInCHKCalculator.Text.Replace("03", "10 FC");
            txtHEXBytesInCHKCalculator.Text = "02 " + txtHEXBytesInCHKCalculator.Text + " " + dgvCheckSums.Rows[2].Cells[1].Value.ToString() + " 03";
        }

        #region SENDER METHODS

        private void tsbSendFromWorkbench_Click(object sender, EventArgs e)
        {
            byte[] bytesToSend = GetBytesToSend(GetWorkbenchCurrentLineBytes());
            if (bytesToSend != null) SendBytesToDevice(bytesToSend);
        }

        private void tsbSendBytesToDevice_Click(object sender, EventArgs e)
        {
            ///SEND BYTES TO DEVICE !!!!!

            byte[] bytesToSend = GetBytesFromRow(dgvInstructions.CurrentRow);
            if (bytesToSend == null) MessageBox.Show("Select row.");
            else SendBytesToDevice(bytesToSend);
        }

        #endregion

        private void dgvInstructions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
                txtSentCommand.Text = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString() + "," +
                     dgvInstructions.CurrentRow.Cells["Explanation"].Value.ToString();
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
                    byte[] r = Common.SendBytes(txtCurrentIP.Text, txtCurrentPort.Text, Common.GetHexBytes(e.Command));
                    shellControl1.WriteText(ASCIIEncoding.ASCII.GetString(r));
                }

                if (_consoleMode == ConsoleMode.Python)
                {
                    string s = DOSPrompt.CMDAutomate("C:\\python3.5\\test.py", "C:\\python3.5\\python.exe");
                    shellControl1.WriteText(s);
                }
            }

            //}
        }

        private void tsbCalculateConsoleCheckSum_Click(object sender, EventArgs e)
        {

        }

        private void lnkToggleSelectedBit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void miPythonConsole_Click(object sender, EventArgs e)
        {
            frmPython x = new frmPython();
            x.Show();
        }

        private void lnkApplyPython_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           txtHEXBytesInCHKCalculator.Text= DOSPrompt.RunPythonFile(lbPyFiles.Text, "\""+ txtHEXBytesInCHKCalculator.Text+"\"");
        }


        //private void tsbCalculateConsoleCheckSum_Click(object sender, EventArgs e)
        //{

        //}

    }
}
