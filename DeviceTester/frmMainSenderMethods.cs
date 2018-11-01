using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using SnmpSharpNet;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
        byte[] GetBytes(string hexBytePacket)
        {
            if (chkCommandIsASCII.Checked) return ASCIIEncoding.ASCII.GetBytes(hexBytePacket + " 0D 0A");
            else
            {
                string byteString = Common.VerifyHexFormat(hexBytePacket);

                if (byteString == "error")
                {
                    WriteMessage("hex format error.");
                    return null;
                }
                else
                {
                    try
                    {
                        return Common.GetBytesFromHex(byteString);
                    }
                    catch (Exception exp)
                    {
                        WriteMessage(exp.ToString());
                        return null;
                    }

                }
            }
        }

        //private void SendBytesToDevice(byte[] bytesToSend)
        private void SendBytesToDevice(string hexBytePacket)
        {
            if (tsbClearBeforeSend.Checked) txtReceivedBytesASCII.Clear();

            switch (_currentConnectionType)
            {
                case ConnectionType.TCPIPStandard: SendViaTCPStandard(GetBytes(hexBytePacket)); break;
                case ConnectionType.TCPIPConnected: SendViaTCPConnected(GetBytes(hexBytePacket)); break;
                case ConnectionType.ComPort: SendViaSerialPort(GetBytes(hexBytePacket)); break;
                case ConnectionType.UDP: SendViaUDP(GetBytes(hexBytePacket)); break;

                default: txtReceivedBytesASCII.Text = "Connection type not specified."; break;
            }

            tbcTools.SelectedIndex = 0;
            tbcIncomingBytes.SelectedIndex = 0;
        }

        private void SendViaSerialPort(byte[] bytesToSend)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
            }
            catch (Exception exc)
            {
                txtReceivedBytesASCII.Text = exc.ToString();
            }

            stopWatch.Stop();
            lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void SendViaTCPConnected(byte[] bytesToSend)
        {
            if (CheckNetworkConnection(txtCurrentIP.Text,_pingTimeOut))
            {
                try
                {
                    var stopWatch = new System.Diagnostics.Stopwatch();
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
                        txtReceivedBytesASCII.Text = "error";
                    }
                    else ShowBytesInTextBoxes(incomingByteArray);

                }
                catch (Exception exc)
                {
                    SaveLog(exc.ToString());
                }
            }
            else
            {
                txtReceivedBytesASCII.Text = "IP problem.Check IP address.";
            }
        }

        private void SendViaTCPStandard(byte[] bytesToSend)
        {
            //if (CheckNetworkConnection(txtCurrentIP.Text,_pingTimeOut))
            //{
                try
                {
                    var stopWatch = new System.Diagnostics.Stopwatch();
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
                        txtReceivedBytesASCII.Text = "error";
                        hexReceivedBytes.ResetText();
                        SaveLog("received bytes null");
                    }
                    else ShowBytesInTextBoxes(receivedBytes);

                }
                catch (Exception exc)
                {
                    SaveLog(exc.ToString());
                }
            //}
            //else
            //{
            //    txtReceivedBytesASCII.Text = "IP problem. Check IP address.";
            //    SaveLog("IP Problem");
            //};
        }

        private void SendViaUDP(byte[] bytesToSend)
        {
            if (CheckNetworkConnection(txtCurrentIP.Text,_pingTimeOut))
            {
                try
                {
                    var stopWatch = new System.Diagnostics.Stopwatch();
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
                        txtReceivedBytesASCII.Text = "Error. receivedData==null";
                    }
                    else
                    {
                        Convertor c = new Convertor();
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            dgvIncomingBytes.Rows.Add(i.ToString(), receivedData[i].ToString(), "", c.DecimalToHex(receivedData[i].ToString()));
                        }

                        txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(receivedData);
                    }
                }
                catch (Exception exc)
                {
                    //System.Windows.Forms.MessageBox.Show(exp.ToString());
                    SaveLog(exc.ToString());
                }
            }
            else
            {
                txtReceivedBytesASCII.Text = "IP problem.Check IP address.";
            }
        }

        private void SendViaPython(string bytesToSend, string pythonFilename)
        {
            try
            {
                var stopWatch = new System.Diagnostics.Stopwatch();
                stopWatch.Start();
                //string incomingHexPacket = DOSPrompt.RunPythonFile("python_socket.py", "\"" + bytesToSend + "\"");
                string incomingHexPacket = DOSPrompt.RunPythonFile(pythonFilename, "\"" + bytesToSend + "\"");
                stopWatch.Stop();
                lblCommandExecutionTime.Text = "Send and Read Time:" + stopWatch.ElapsedMilliseconds.ToString() + " ms";

                if (incomingHexPacket.IndexOf("error") > -1) WriteMessage(incomingHexPacket);
                else ShowBytesInTextBoxes(GetBytes(incomingHexPacket));
            }
            catch (Exception exc)
            {
                WriteMessage(exc.ToString());
                SaveLog(exc.ToString());
            }

        }

        #region SNMP METHODS
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
                WriteMessage(ex.ToString());
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

        private void tsbSNMPSet_Click(object sender, EventArgs e)
        {
            frmInputBox x = new frmInputBox();
            if (x.ShowDialog() == DialogResult.OK)
            {
                sendSetCommand(dgvInstructions.CurrentRow.Cells["InstructionBytes"].Value.ToString(), x.Value);
            }
        }

        #endregion
    }
}
