using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
       


        private void SendBytesToDevice(byte[] bytesToSend)
        {
            if (bytesToSend == null) return;

            if (tsbClearBeforeSend.Checked)
            {
                txtReceivedBytesASCII.Clear();
            }

            var stopWatch = new System.Diagnostics.Stopwatch();

            switch (_currentConnectionType)
            {
                case ConnectionType.TCPIPStandard:
                    if (CheckNetworkConnection(txtCurrentIP.Text))
                    {
                        stopWatch.Start();
                        try
                        {

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
                    }
                    else
                    {
                        txtReceivedBytesASCII.Text = "IP problem.Check IP address.";
                        SaveLog("IP Problem");
                    }; break;
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

                    ; break;
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

                    break;
                default: txtReceivedBytesASCII.Text = "Connection type not specified."; break;
            }

            tbcTools.SelectedIndex = 0;
            tbcIncomingBytes.SelectedIndex = 0;

        }
    }
}
