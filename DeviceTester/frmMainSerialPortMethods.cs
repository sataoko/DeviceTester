using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
        string _rxString;
        int _serialPortPacketCount = 0;
        List<byte> _serialPortBuffer = new List<byte>();
        //byte[] _serialReceivedByteArray = new byte[1000];
        //int _serialCounter = 0;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            _serialPortPacketCount++;
            try
            {
                if (!string.IsNullOrEmpty(txtDelayTime.Text))
                    System.Threading.Thread.Sleep(Convert.ToInt32(txtDelayTime.Text));

                //_serialReceivedByteArray[_serialCounter++] = (byte)serialPort1.ReadByte();

                //serialPort1.Read(_serialReceivedByteArray, 0,serialPort1.BytesToRead);
                //WriteMessage("serial port bytes count in received buffer:" + serialPort1.BytesToRead.ToString());

                byte[] b = new byte[serialPort1.BytesToRead];
                serialPort1.Read(b, 0, serialPort1.BytesToRead);
                for (int i = 0; i < b.Length; i++) _serialPortBuffer.Add(b[i]);

                _rxString = serialPort1.ReadExisting();

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
            catch (Exception exc)
            {
                WriteMessage(exc.ToString());
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
                //txtReceivedBytesASCII.Text = txtReceivedBytesASCII.Text.Insert(0, _rxString);
                //DynamicByteProvider b = new DynamicByteProvider(Encoding.ASCII.GetBytes(_rxString));
                try
                {
                    //txtReceivedBytesASCII.Text = txtReceivedBytesASCII.Text.Insert(0, Encoding.ASCII.GetString(_serialPortBuffer.ToArray()));

                    byte[] byteArray = _serialPortBuffer.ToArray();

                    //string s=string.Empty;
                    //for (int i = 0; i < byteArray.Length; i++)
                    //    s += Convert.ToChar(byteArray[i]).ToString();
                    //txtReceivedBytesASCII.Text = txtReceivedBytesASCII.Text.Insert(0, s);

                    txtReceivedBytesASCII.Text = txtReceivedBytesASCII.Text.Insert(0, System.Text.Encoding.UTF8.GetString(byteArray));

                    DynamicByteProvider b = new DynamicByteProvider(byteArray);
                    hexReceivedBytes.ByteProvider = b;
                }
                catch (Exception exc)
                {
                    WriteMessage(exc.ToString());
                }
            }
        }

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
        }

        private void tsbComPortSettings_Click(object sender, EventArgs e)
        {
            frmComPortSettings x = new frmComPortSettings();
            if (x.ShowDialog() == DialogResult.OK)
            {
                SetSerialPortParameters(x.ComPort, x.BaudRate, x.Parity, x.DataBits, x.StopBits);
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
            try
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
