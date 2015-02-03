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

namespace TCPDeviceTester
{
    public partial class frmMain : Form
    {
        enum ConsoleMode { Device, DOS }
        enum ConnectionType { TCPIPStandard, TCPIPConnected, UDP, ComPort }

        // TCPConnection t = new TCPConnection("10.0.0.242", 4001);

        string _currentXMLPath = string.Empty;
        string _currentCellValue = string.Empty;

        string _promptText = ">";

        public string _delimiter = " ";

        ConsoleMode _consoleMode = ConsoleMode.Device;
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
                int i = byteString.IndexOf(' ');
                if (i > 0)
                    bytes = GetHexBytes(byteString, ' ');
                else
                {
                    if ((byteString.Length) % 2 != 0)
                    {
                        MessageBox.Show("check hex bytes.the length is not correct.");
                        return null;
                    }

                    bytes = GetHexBytes(byteString);
                }
            }
            return bytes;
        }

        public frmMain()
        {
            InitializeComponent();
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


        //private void LoadDeviceXML()
        //{
        //    string xmlPath = Application.StartupPath + "\\SWC100.xml";
        //    XMLOperations x = new XMLOperations(xmlPath);


        //    DeviceInfo di = x.GetDeviceInfo();
        //    txtCurrentIP.Text = di.DeviceIP;
        //    txtCurrentPort.Text = di.DevicePort;
        //    txtDeviceName.Text = di.DeviceName;
        //    txtDeviceExplanation.Text = di.DeviceExplanation;

        //    tpDeviceCommands.Text = di.DeviceName + " Commands";

        //    dgvInstructions.DataSource = x.GetXMLNodes("DeviceInstructions/Instruction");
        //    FormatInstructionsGrid();
        //}

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


        byte[] GetHexBytes(string byteString)
        {
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

        private string CalculateCheckSumInBSV(string blankSeperatedValue)
        {
            byte[] byteArray = Common.GetBytes(blankSeperatedValue, ' ');
            CRCType ctype = new CRCType();
            switch (cbCheckSumTypes.SelectedIndex)
            {
                case 0: ctype = CRCType.Mod95; break;
                case 1: ctype = CRCType.XOR; break;
                case 2: ctype = CRCType.CRC16; break;
                case 3: ctype = CRCType.CRC_CCITT_Kermit; break;
                case 4: ctype = CRCType.CRC32; break;
                case 5: ctype = CRCType.SUM; break;
                default: break;
            }
            return CRC.CalculateCheckSum(byteArray, ctype);
        }

        private string SendBytesToDevice(byte[] bytesToSend)
        {
            if (bytesToSend == null) return "Error:bytesToSend is null.";

            if (tsbClearBeforeSend.Checked)
            {
                txtReceivedBytes.Clear();
                txtReceivedBytesASCII.Clear();
                txtReceivedBytesHex.Clear();
            }

            var stopWatch = new System.Diagnostics.Stopwatch();

            switch (_currentConnectionType)
            {
                case ConnectionType.TCPIPStandard:

                    if (CheckNetworkConnection(txtCurrentIP.Text))
                    {
                        stopWatch.Start();

                        TCPConnection t = new TCPConnection(txtCurrentIP.Text, Convert.ToUInt16(txtCurrentPort.Text));

                        t.ConditionalReading = chkConditionalReading.Checked;
                        t.EndByte = Convert.ToByte(txtEndByte.Text);
                        t.Delay = Convert.ToInt16(txtDelayTime.Text == string.Empty ? "0" : txtDelayTime.Text);

                        t.CommunicationTimeOut = Convert.ToInt16(txtTCPClientCommunicationTimeOut.Text);
                        t.ReadBufferSize = Convert.ToInt16(txtReadBufferSize.Text);

                        byte[] receivedBytes = new byte[t.ReadBufferSize];
                        receivedBytes = t.RequestData(bytesToSend);

                        stopWatch.Stop();
                        lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";

                        if (receivedBytes == null)
                        {
                            txtReceivedBytes.Text = "error";
                            txtReceivedBytesASCII.Clear();
                            txtReceivedBytesHex.Clear();
                            return "error";
                        }
                        else return ShowBytesInTextBoxes(receivedBytes);
                    }
                    else
                    {
                        txtReceivedBytes.Text = "IP problem.Check IP address.";
                        return "IP problem";
                    }

                case ConnectionType.TCPIPConnected:

                    if (CheckNetworkConnection(txtCurrentIP.Text))
                    {

                        try
                        {
                            stopWatch.Start();

                            byte[] incomingByteArray = new byte[_tcpClient.ReceiveBufferSize];

                            if (_stream.CanWrite)
                            {
                                _stream.Write(bytesToSend, 0, bytesToSend.Length);
                            }

                            if (_stream.CanRead)
                            {
                                _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);
                            }

                            stopWatch.Stop();
                            lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";


                            if (incomingByteArray == null)
                            {
                                txtReceivedBytes.Text = "error";
                                txtReceivedBytesASCII.Clear();
                                txtReceivedBytesHex.Clear();
                                return "error";
                            }
                            else return ShowBytesInTextBoxes(incomingByteArray);

                        }
                        catch (Exception exp)
                        {
                            //System.Windows.Forms.MessageBox.Show(exp.ToString());
                            return null;
                        }
                    }
                    else
                    {
                        txtReceivedBytes.Text = "IP problem.Check IP address.";
                        return "IP problem";
                    }; break;

                case ConnectionType.ComPort:

                    if (!serialPort1.IsOpen) serialPort1.Open();
                    serialPort1.Write(bytesToSend, 0, bytesToSend.Length);


                    //byte[] buffer = new byte[256];
                    //using (SerialPort sp = new SerialPort("COM1", 19200))
                    //{
                    //    sp.Open();
                    //    //read directly
                    //    sp.Read(buffer, 0, (int)buffer.Length);
                    //    //read using a Stream
                    //    sp.BaseStream.Read(buffer, 0, (int)buffer.Length);
                    //}

                    return "nothing."; break;
                case ConnectionType.UDP:
                    if (CheckNetworkConnection(txtCurrentIP.Text))
                    {

                        try
                        {
                            stopWatch.Start();
                            var client = new UdpClient();
                            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(txtCurrentIP.Text), Convert.ToInt16(txtCurrentPort.Text)); // endpoint where server is listening
                            client.Connect(ep);

                            // send data
                            client.Send(bytesToSend, bytesToSend.Length);
                            System.Threading.Thread.Sleep(Convert.ToInt16(txtDelayTime.Text));
                            // then receive data
                            byte[] receivedData = client.Receive(ref ep);

                            stopWatch.Stop();
                            lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";

                            if (receivedData == null)
                            {
                                txtReceivedBytes.Text = "error";
                                txtReceivedBytesASCII.Clear();
                                txtReceivedBytesHex.Clear();
                                return "error";
                            }
                            else
                            {
                                Convertor c = new Convertor();
                                for (int i = 0; i < receivedData.Length; i++)
                                {
                                    txtReceivedBytes.Text += receivedData[i].ToString() + _delimiter;
                                    dgvIncomingBytes.Rows.Add(i.ToString(), receivedData[i].ToString(), "", c.DecimalToHex(receivedData[i].ToString()));
                                }

                                txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(receivedData);
                                c.DecimalToHexIntoTextBox(txtReceivedBytes, txtReceivedBytesHex);
                                return txtReceivedBytes.Text;
                            }

                        }
                        catch (Exception exp)
                        {
                            //System.Windows.Forms.MessageBox.Show(exp.ToString());
                            return null;
                        }
                    }
                    else
                    {
                        txtReceivedBytes.Text = "IP problem.Check IP address.";
                        return "IP problem";
                    }

                    break;
                default: return "Connection type not specified."; break;
            }



        }

        private string ShowBytesInTextBoxes(byte[] bytesToShow)
        {

            dgvIncomingBytes.Rows.Clear();

            Convertor c = new Convertor();
            int readSize = 100;

            if (!string.IsNullOrEmpty(txtReadBufferSize.Text))
                readSize = Convert.ToInt16(txtReadBufferSize.Text);


            for (int i = 0; i < readSize; i++)
            {
                txtReceivedBytes.Text += bytesToShow[i].ToString() + _delimiter;
                dgvIncomingBytes.Rows.Add(i.ToString(), bytesToShow[i].ToString(), "", c.DecimalToHex(bytesToShow[i].ToString()));
            }

            txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(bytesToShow);

            if (chkSaveLog.Checked)
            {
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + txtDeviceName.Text + ".txt"))
                {
                    sw.WriteLine(ASCIIEncoding.ASCII.GetString(bytesToShow));
                }
               
                //System.IO.FileInfo t = new System.IO.FileInfo(Application.StartupPath + "\\" + txtDeviceName.Text + ".txt");
                //System.IO.StreamWriter text = t.CreateText(true);
                //text.WriteLine(ASCIIEncoding.ASCII.GetString(bytesToShow));
                //text.Close();
            }
            c.DecimalToHexIntoTextBox(txtReceivedBytes, txtReceivedBytesHex);

            /*
            XMLHelper x = new XMLHelper();

             * save log
             * 
            */
            return txtReceivedBytes.Text;
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

            CreateCaret(txtConsole.Handle, hBitmap, 5, txtConsole.Height);
            ShowCaret(txtConsole.Handle);

            tbcDevice.SelectedIndex = 0;

            //string promptText = txtIP.Text + ":" + txtPort.Text+">";
            //txtConsole.Text = promptText;

            ChangeConnectionType(ConnectionType.TCPIPStandard);

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Start.ini";
            if (System.IO.File.Exists(path))
            {
                txtCurrentIP.Text = Ini.IniFile.GetValue("TCPSettings", "IP");
                txtCurrentPort.Text = Ini.IniFile.GetValue("TCPSettings", "Port");

                SetSerialPortParameters(Ini.IniFile.GetValue("ComportSettings", "Comport"),
                    Convert.ToInt32(Ini.IniFile.GetValue("ComportSettings", "BaudRate")),
                    Ini.IniFile.GetValue("ComportSettings", "Parity"),
                    Convert.ToByte(Ini.IniFile.GetValue("ComportSettings", "DataBits")),
                    Ini.IniFile.GetValue("ComportSettings", "StopBits"));
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

        private void tsbSendBytesToDevice_Click(object sender, EventArgs e)
        {
            ///SEND BYTES TO DEVICE !!!!!
            byte[] bytesToSend = GetBytesFromRow(dgvInstructions.CurrentRow);
            if (bytesToSend == null) MessageBox.Show("Select row.");
            else SendBytesToDevice(bytesToSend);

            if ((chkTimerActive.Checked) && (dgvInstructions.SelectedRows.Count > 0))
            {
                foreach (DataGridViewRow dr in dgvInstructions.SelectedRows)
                {
                    timerCommandList.Add(GetBytesFromRow(dr));
                }
                timerCommandNo = 0;
                tmrRequest.Enabled = true;
            }
        }

        private void miPrepareCommand_Click(object sender, EventArgs e)
        {
            frmPrepareCommand x = new frmPrepareCommand();
            x.ShowDialog();
        }

        private void dgvInstructions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void miGenerateCommandList_Click(object sender, EventArgs e)
        {
            frmTryCommands x = new frmTryCommands();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] byteArray = Common.GetBytes(txtDecimalBytes.Text);

            if (string.IsNullOrEmpty(txtDecimalBytes.Text))
            { MessageBox.Show("Enter bytes."); }
            else
            {

                string checkSum = CalculateCheckSumInBSV(txtDecimalBytes.Text);
                txtDecimalBytes.Text += " " + checkSum;
            }

            Convertor c = new Convertor();
            c.DecimalToHexIntoTextBox(txtDecimalBytes, txtHEXBytes);

            //CRCType ctype = new CRCType();

            //if (rbXOR.Checked) ctype = CRCType.XOR;
            //else
            //    if (rbMod95.Checked) ctype = CRCType.Mod95;
            //    else
            //        if (rbCRC16.Checked) ctype = CRCType.CRC16;
            //        else
            //            if (rbCRC16Kermit.Checked) ctype = CRCType.CRC_CCITT_Kermit; else return;

            //switch (ctype)
            //{
            //    case CRCType.Mod95:
            //        int c = CRC.Mod95(byteArray);
            //        txtDecimalBytes.Text += _delimiter + c.ToString();
            //        break;
            //    case CRCType.XOR:
            //        int d = CRC.XOR(byteArray);
            //        txtDecimalBytes.Text += _delimiter + d.ToString();
            //        break;
            //    case CRCType.CRC16:
            //        int data = CRC.crc_mcl(byteArray);
            //        byte[] chk = new byte[2];
            //        chk[0] = (byte)(data & ('\x00FF'));
            //        chk[1] = (byte)(data >> 8);
            //        txtDecimalBytes.Text += _delimiter + chk[0].ToString() + _delimiter;
            //        txtDecimalBytes.Text += chk[1].ToString();
            //        break;
            //    case CRCType.CRC_CCITT_Kermit:

            //        int da = CRC.CRC_CCITTKermit(byteArray);
            //        byte[] a = new byte[2];
            //        a[1] = (byte)(da & ('\x00FF'));
            //        a[0] = (byte)(da >> 8);
            //        txtDecimalBytes.Text += _delimiter + a[0].ToString() + _delimiter;
            //        txtDecimalBytes.Text += a[1].ToString();

            //        break;
            //    default:
            //        break;
            //}

        }

        private void btnSendToGrid_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow != null)
            {
                if (rbSendToGridDecimal.Checked)
                {
                    if (!string.IsNullOrEmpty(txtDecimalBytes.Text))
                    {
                        dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = txtDecimalBytes.Text;
                    }
                }

                if (rbSendToGridHex.Checked)
                {
                    if (!string.IsNullOrEmpty(txtHEXBytes.Text))
                    {
                        dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value = txtHEXBytes.Text;
                        UpdateGridNode(dgvInstructions, "InstructionBytes", txtHEXBytes.Text);
                    }
                }
            }
        }

        private void tsbBulkRequest_Click(object sender, EventArgs e)
        {
            byte[] a = new byte[] { 1, 2, 3, 4 };

            MessageBox.Show(CRC.crc_mcl(a).ToString());



            return;
            /*
            TcpClient _tcpClient= new TcpClient("10.0.0.81",23);
            NetworkStream _stream=_tcpClient.GetStream();

            try
            {
                byte[] incomingByteArray = new byte[_tcpClient.ReceiveBufferSize];

                byte[] byteArrayToSend = new byte[10];
                byteArrayToSend[0] = 123; byteArrayToSend[1] = 123;
                byteArrayToSend[2] = 49; byteArrayToSend[3] = 49;
                byteArrayToSend[4] = 49; byteArrayToSend[5] = 49;
                byteArrayToSend[6] = 49; byteArrayToSend[7] = 125;
                byteArrayToSend[8] = 125;

                if (_stream.CanWrite)
                {
                    _stream.Write(byteArrayToSend, 0, byteArrayToSend.Length);
                }

                if (_stream.CanRead)
                {
                    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);

                    if (_stream.CanWrite)
                         _stream.Write(byteArrayToSend, 0, byteArrayToSend.Length);
                    
                    if (_stream.CanRead)               
                    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);

                }


                txtReceivedBytes.Clear();
                for (int i = 0; i < 100; i++)
                {
                    txtReceivedBytes.Text += incomingByteArray[i].ToString() + _delimiter;
                }

                txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(incomingByteArray);
                
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.ToString());
                throw;
            }

            finally
            {
                _tcpClient.Close();
                _stream.Close();
            }*/
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
                txtHEXBytes.Text = dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString();

                Convertor c = new Convertor();
                c.HexToAsciiIntoTextBox(txtHEXBytes, txtASCIIBytes);
                c.AsciiToDecimalIntoTextBox(txtASCIIBytes, txtDecimalBytes);

                tbcTools.SelectedIndex = 1;
            }

        }

        private void tsbSendToTools_Click(object sender, EventArgs e)
        {
            SendToTools();
        }

        #region ASCII HEX DECIMAL CONVERTIONS
        private void txtASCIIBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtASCIIBytes.Focused)
            {
                // if (rbASCII.Checked)
                {
                    Convertor c = new Convertor();
                    c.AsciiToDecimalIntoTextBox((sender as TextBox), txtDecimalBytes);
                    c.DecimalToHexIntoTextBox(txtDecimalBytes, txtHEXBytes);
                    //c.ConvertBytesIntoTextBox((sender as TextBox), txtDecimalBytes, "Decimal"); 
                    //c.ApplyConvertionsToTextBoxes( txtHEXBytes, "HEX");
                }
            }
        }

        private void txtDecimalBytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
                e.Handled = true;
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

            if (txtDecimalBytes.Focused)
            {
                Convertor c = new Convertor();
                c.DecimalToHexIntoTextBox((sender as TextBox), txtHEXBytes);
                c.HexToAsciiIntoTextBox(txtHEXBytes, txtASCIIBytes);
                //c.ConvertBytesIntoTextBox((sender as TextBox), txtHEXBytes, "HEX"); 
                //c.ApplyConvertionsToTextBoxes((sender as TextBox), txtASCIIBytes, "ASCII", txtHEXBytes, "HEX");   
            }

        }

        private void txtHEXBytes_TextChanged(object sender, EventArgs e)
        {
            if (txtHEXBytes.Focused)
            //if (rbHEX.Checked)
            {
                Convertor c = new Convertor();
                c.HexToAsciiIntoTextBox((sender as TextBox), txtASCIIBytes);
                c.AsciiToDecimalIntoTextBox(txtASCIIBytes, txtDecimalBytes);
                //c.ConvertBytesIntoTextBox((sender as TextBox), txtASCIIBytes, "ASCII"); 
            }

        }
        #endregion

        private void dgvIncomingBytes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte b = Convert.ToByte(dgvIncomingBytes.CurrentRow.Cells["Decimal"].Value);
            txtBits.Text = Common.GetBits(b);
            for (int i = 0; i < 8; i++)
            {
                dgvBits.Rows[0].Cells["Bit" + i.ToString()].Value = txtBits.Text[(7 - i)];
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

        #region CONSOLE OPERATIONS

        private void SetConsoleMode()
        {
            if (rbDeviceMode.Checked) _consoleMode = ConsoleMode.Device;
            if (rbDosMode.Checked) _consoleMode = ConsoleMode.DOS;
        }

        private void tsbCalculateConsoleCheckSum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbCheckSumTypes.Text))
            {
                MessageBox.Show("Select a checksum type.");
            }
            else
            {
                string s = GetLastLineText(txtConsole);
                s = s.Substring(1, s.Length - 1);
                string chk = CalculateCheckSumInBSV(s);
                //txtConsole.Lines[txtConsole.Lines.Length - 1] += chk;

                AddToLastLine(txtConsole, _delimiter + chk);
                //string s =  CalculateCheckSumInCSV(richTextBox1.Lines[richTextBox1.Lines.Length - 1]);
                //richTextBox1.Lines[richTextBox1.Lines.Length - 1] += s;
                //txtConsole.Lines[txtConsole.Lines.Length - 1] = 
            }
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            /*  int index = txtConsole.SelectionStart;
              Point p = txtConsole.GetPositionFromCharIndex(index);
              p.X = 0;
              //int col = index - txtConsole.GetCharIndexFromPosition(p);

              int col =txtConsole.GetFirstCharIndexFromLine(GetCurrentLineNo(txtConsole));

              int absoluteIndex = txtConsole.SelectionStart;
              int lineStartIndex = GetFirstCharIndexOfCurrentLine(txtConsole);

              lblCaretPosition.Text = absoluteIndex.ToString()+_delimiter+lineStartIndex.ToString();//"X:" + p.X.ToString()+", Y:"+p.Y.ToString()+ ",Col:"+col.ToString();*/


            string s1 = GetCurrentLineText(txtConsole);

            if (string.IsNullOrEmpty(s1))
            {
                // MessageBox.Show("empty line");
                SetCurrentLineText(txtConsole, ">");
                GoTo(txtConsole, txtConsole.Lines.Length, _promptText.Length + 1);
            }
            //return;

            //if (txtConsole.Text == string.Empty)
            //{
            //    //txtConsole.Text = _promptText;
            //    //GoTo(txtConsole, txtConsole.Lines.Length, _promptText.Length + 1);
            //}
            //else
            //{
            //    string s = GetCurrentLineText(txtConsole);

            //    //if current line in blank, put prompt char and move caret in front of the prompt char
            //    if (string.IsNullOrEmpty(s))
            //    {
            //        SetCurrentLineText(txtConsole, _promptText);
            //        GoTo(txtConsole, txtConsole.Lines.Length, _promptText.Length + 1);
            //    }
            //}
        }

        private void txtConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) e.SuppressKeyPress = true;
            if (GetLastLineNo(txtConsole) > GetCurrentLineNo(txtConsole)) e.SuppressKeyPress = true;//to disable upper lines.
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                //string s = GetLastLineText(txtConsole);
                string s = GetCurrentLineText(txtConsole);
                //s1 = s1.Substring(1, s1.Length - 1);
                s = s.Substring(1, s.Length - 1);
                // return;
                if (!string.IsNullOrEmpty(s))
                {
                    switch (_consoleMode)
                    {
                        case ConsoleMode.Device:
                            byte[] bytesToSend;
                            if (chkCommandIsASCII.Checked) bytesToSend = ASCIIEncoding.ASCII.GetBytes(s + Environment.NewLine);
                            else bytesToSend = GetHexBytes(s, ' ');

                            SendBytesToDevice(bytesToSend);
                            break;
                        case ConsoleMode.DOS:
                            DOSPrompt.CMDAutomate(s, txtReceivedBytes);
                            break;
                        default: break;
                    }
                }
                txtConsole.Text += "\r\n" + _promptText;
                GoTo(txtConsole, txtConsole.Lines.Length, _promptText.Length + 1);
            }
        }

        private void txtConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            int absoluteIndex = txtConsole.SelectionStart;
            int lineStartIndex = GetFirstCharIndexOfCurrentLine(txtConsole);


            if (e.KeyChar == (char)Keys.Back)
            {
                if ((absoluteIndex - 1) == lineStartIndex) e.Handled = true;
                // int line = txtConsole.GetLineFromCharIndex(index);
                //string s = GetLastLineText(txtConsole);
                //if (s.Length == 0) e.KeyChar = (char)0;
            }
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


        string GetLastLineText(TextBox target)
        {
            int lastLineNo = GetLastLineNo(txtConsole);
            if (lastLineNo > -1)
            {
                //string s = target.Lines[lastLineNo].Substring(1, target.Lines[lastLineNo].Length - _promptText.Length);
                string s = target.Lines[lastLineNo];
                return s;
            }
            else return string.Empty;
        }


        //Current line text is returned without prompt character
        string GetCurrentLineText(TextBox target)
        {
            int currentLineNo = GetCurrentLineNo(target);

            //if (currentLineNo == 0) return string.Empty;
            //{
            //    MessageBox.Show(target.Lines[currentLineNo]);
            //}

            if (currentLineNo > -1)
            {
                //remove prompt out of current line text
                if (target.Lines[currentLineNo].Length > 0)
                {
                    //string s = target.Lines[currentLineNo].Substring(1, target.Lines[currentLineNo].Length - _promptText.Length);
                    string s = target.Lines[currentLineNo];
                    return s;
                }
                else return string.Empty;
            }
            else return string.Empty;
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
            GetActiveTCPConnections();
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
                    string chk = CalculateCheckSumInBSV(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString());
                    dgvInstructions.CurrentRow.Cells["CheckSum"].Value = chk;
                    UpdateGridNode(dgvInstructions, "CheckSum", chk);
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
            serialPort1.PortName = comPort;
            serialPort1.BaudRate = baudRate;
            serialPort1.DataBits = dataBits;

            serialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity, true);
            serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopBits, true);
            //if (parity == "None") serialPort1.Parity = System.IO.Ports.Parity.None;
            //if (parity == "Odd") serialPort1.Parity = System.IO.Ports.Parity.Odd;
            //if (parity == "Even") serialPort1.Parity = System.IO.Ports.Parity.Even;
            //if (parity == "Mark") serialPort1.Parity = System.IO.Ports.Parity.Mark;
            //if (parity == "Space") serialPort1.Parity = System.IO.Ports.Parity.Space;

            //if (stopBits == "None") serialPort1.StopBits = System.IO.Ports.StopBits.None;
            //if (stopBits == "One") serialPort1.StopBits = System.IO.Ports.StopBits.One;
            //if (stopBits == "Two") serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            //if (stopBits == "OnePointFive") serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;

            lblComPortInfo.Text = serialPort1.PortName + "," + serialPort1.BaudRate + "," + serialPort1.Parity + "," + serialPort1.DataBits + "," + serialPort1.StopBits;
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
            this.Invoke(new EventHandler(DisplayText));
            if(txtReceivedBytesASCII.Text.Length>17)
            if (chkSaveLog.Checked)
            {
                //System.Threading.Thread.Sleep(1000);
                using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\" + txtDeviceName.Text + ".txt"))
                {
                    sw.WriteLine(txtReceivedBytesASCII.Text.Trim());                   
                }	

                //System.IO.FileInfo t = new System.IO.FileInfo(Application.StartupPath + "\\" + txtDeviceName.Text + ".txt");
                //System.IO.StreamWriter text = t.CreateText(true);
                //text.WriteLine(RxString);
                //text.Close();
            }
        }

        private void DisplayText(object sender, EventArgs e)
        {

            txtReceivedBytesASCII.Text += RxString;

            

            Convertor c = new Convertor();
            c.AsciiToDecimalIntoTextBox(txtReceivedBytesASCII, txtReceivedBytes);
            c.DecimalToHexIntoTextBox(txtDecimalBytes, txtHEXBytes);
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
            txtReceivedBytesASCII.Clear();
            txtReceivedBytes.Clear();
            txtReceivedBytesHex.Clear();

            dgvIncomingBytes.Rows.Clear();

            for (int i = 0; i < dgvBits.Columns.Count; i++)
            {
                dgvBits.Rows[0].Cells[i].Value = string.Empty;
            }


        }

        private void tbcDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tbcDevice.SelectedIndex == 2) { }//txtConsole.Focus(); GoTo(txtConsole, 0,2); 
        }

        private void tsbClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Text = ">";
            GoTo(txtConsole, 1, 2);
        }

        private void tsbChangeConsoleStyle_Click(object sender, EventArgs e)
        {
            txtConsole.BackColor = Color.White;
            txtConsole.ForeColor = Color.Black;
        }

        private void btnSendToConsole_Click(object sender, EventArgs e)
        {

        }

        private void cmiSendBytesToConsole_Click(object sender, EventArgs e)
        {
            if (dgvInstructions.CurrentRow == null)
                MessageBox.Show("Select a row");
            else
            {
                txtConsole.Text += "\r\n>" + dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString();
                tbcDevice.SelectedIndex = 2;
            }
        }

        private void tsbNewRow_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        private string GetWorkbenchCurrentLineBytes()
        {
            int currentLineIndex = txtWorkbench.GetLineFromCharIndex(txtWorkbench.GetFirstCharIndexOfCurrentLine());
            string s = txtWorkbench.Lines[currentLineIndex];
            string[] c = s.Split(',');
            return c[0];
        }

        private void tsbSendFromWorkbench_Click(object sender, EventArgs e)
        {
            byte[] bytesToSend = GetBytesToSend(GetWorkbenchCurrentLineBytes());
            if (bytesToSend != null) SendBytesToDevice(bytesToSend);
        }

        private void tsbSaveWorkbenchText_Click(object sender, EventArgs e)
        {
            XMLHelper x = new XMLHelper(_currentXMLPath);
            x.StartNode = "/DeviceInstructions/WorkbenchData";
            x.UpdateNodeByID("1", "Instructions", txtWorkbench.Text);
            MessageBox.Show("Saved text.");
        }

        private void tmrRequest_Tick(object sender, EventArgs e)
        {
            if (timerCommandList.Count > 0)
            {
                SendBytesToDevice(timerCommandList[timerCommandNo]);
                timerCommandNo++;
                if (timerCommandNo >= timerCommandList.Count) timerCommandNo = 0;
            }
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
            string checkSum = CalculateCheckSumInBSV(bytes);
            bytes += " " + checkSum;

            int i = txtWorkbench.GetFirstCharIndexOfCurrentLine();

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
                string s = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                s += @"
                <DeviceInstructions>
                  <DeviceInfo>
                    <DeviceName>Device Name</DeviceName>
                    <Explanation></Explanation>
                    <IP>192.168.1.161</IP>
                    <Port>4001</Port>
                    <CheckSumType>CheckSum,1 Byte</CheckSumType>
                    <InstructionStructure>xxx</InstructionStructure>
                  </DeviceInfo>
                  <Instruction>
                    <ID>1</ID>
                    <Order>2</Order>
                    <InstructionBytes>12 08 5A AA AA AA 72</InstructionBytes>
                    <Explanation>Read Serial Number</Explanation>
                    <CheckSum>1</CheckSum>
                  </Instruction>
                  <WorkbenchData>
                    <ID>1</ID>
                    <Instructions>
	                </Instructions>
                  </WorkbenchData>
                </DeviceInstructions>";

                TextWriter tw = File.CreateText(Application.StartupPath + "\\DeviceXMLs\\" + x.Filename + ".xml");
                tw.WriteLine(s);
                tw.Close();
                LoadDeviceXML(Application.StartupPath + "\\DeviceXMLs\\" + x.Filename + ".xml");
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
                txtConsole.Text = String.Format("Request failed with exception: {0}", ex.Message);
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
                        txtReceivedBytes.Text = String.Format("Error in SNMP reply. Error {0} index {1}",
                            result.Pdu.ErrorStatus,
                            result.Pdu.ErrorIndex);
                    }
                    else
                    {
                        // Reply variables are returned in the same order as they were added
                        //  to the VbList
                        for (int i = 0; i < result.Pdu.VbList.Count; i++)
                        {
                            txtReceivedBytes.Text += result.Pdu.VbList[i].Oid.ToString() + ", " + SnmpConstants.GetTypeName(result.Pdu.VbList[i].Value.Type) + ", " +
                                result.Pdu.VbList[i].Value.ToString() + ", " + dgvInstructions.SelectedRows[i].Cells["Explanation"].Value.ToString() + Environment.NewLine;
                        }

                    }
                }
                else
                {
                    txtConsole.Text = String.Format("No response received from SNMP agent.");
                }
                target.Close();

            }
            catch (Exception exp)
            {
                txtReceivedBytes.Text = exp.ToString();

            }
        }

        private void lnkSelectDOSCommand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkCommands x = new frmNetworkCommands();
            if (x.ShowDialog() == DialogResult.OK)
            {
                txtConsole.Text += x.DOSCommand;
            }
        }

        private void tsbChangeMainConsoleStyle_Click(object sender, EventArgs e)
        {
            txtReceivedBytes.ForeColor = Color.White;
            txtReceivedBytes.BackColor = Color.Black;

        }

        private void tsbSNMPSet_Click(object sender, EventArgs e)
        {
            frmInputBox x = new frmInputBox();
            if (x.ShowDialog() == DialogResult.OK)
            {
                sendSetCommand(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString(), x.Value);
            }
        }

        private void lnkSetTimerInterval_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tmrRequest.Interval = Convert.ToInt32(txtTimerInterval.Text);
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

        private void btnNetworkTools_Click(object sender, EventArgs e)
        {
            frmNetworkTools x = new frmNetworkTools();
            x.ShowDialog();
        }

        private void chkTimerActive_CheckedChanged(object sender, EventArgs e)
        {
            tmrRequest.Enabled = chkTimerActive.Checked;
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
    }
}
