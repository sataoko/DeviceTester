using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace DeviceTester
{
    public partial class frmTryCommands : Form
    {
        int selectedItem = 0;

        
        
        public byte[] RequestData(byte[] byteArrayToSend)
        {
            TcpClient _tcpClient;
        NetworkStream _stream;

            _tcpClient = new TcpClient(txtIP.Text, Convert.ToInt32(txtPort.Text));
            _stream = _tcpClient.GetStream();

            int timeout = 1000;
            _tcpClient.SendTimeout = timeout;
            _tcpClient.ReceiveTimeout = timeout;
            _stream.WriteTimeout = timeout;
            _stream.ReadTimeout = timeout;

            try
            {
                byte[] incomingByteArray = new byte[_tcpClient.ReceiveBufferSize];

                if (_stream.CanWrite)
                {
                    _tcpClient.SendBufferSize = 0;
                    _stream.Write(byteArrayToSend, 0, byteArrayToSend.Length);
                    dgvLogs.Rows.Add(selectedItem.ToString(), DateTime.Now.ToString(), "Sent:" + byteArrayToSend.ToString());
                }

                if (_stream.CanRead)
                {
                    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);
                    dgvLogs.Rows.Add(selectedItem.ToString(), DateTime.Now.ToString(), "Received:" + incomingByteArray.ToString());
                }

                return incomingByteArray;
            }
            catch (Exception exp)
            {
                dgvLogs.Rows.Add(selectedItem.ToString(), DateTime.Now.ToString(), exp.ToString());
                return null;
            }

            finally
            {
                _tcpClient.Close();
                _stream.Close();
            }
        }
        
        public frmTryCommands()
        {
            InitializeComponent();
        }

        private void lmkGenerateCommands_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          /*  string startByte = string.Empty;
            string endByte = string.Empty;

            if (rbASCII.Checked)
            {
                startByte = "123";
                endByte = "125";
            }

            if (rbSTXETX.Checked)
            {
                startByte = "2";
                endByte = "3";
            }

            for (int address = Convert.ToInt16(txtAddressStart.Text); address < Convert.ToInt16(txtAddressEnd.Text); address++)
			{
                string command = startByte + "," + address.ToString() + "," + txtCommandInDecimal.Text + "," + endByte;
                byte[] bytes = Common.GetBytesToSend(command);
                int checkSum = CheckSum.CIFProtocolCheckSum(bytes, Common.GetByteCount(command));
                command += "," + checkSum.ToString();
                lbGeneratedCommands.Items.Add(command);
			}*/

        }


        private void SendCommandsInList()
        {
            for (int i = 0; i < lbGeneratedCommands.Items.Count-1; i++)
            {
                SendSingleCommand(lbGeneratedCommands.Items[i].ToString());
            }
        }

        private void SendSingleCommand(string command)
        {
            byte[] bytesToSend = new byte[5000];
            bytesToSend = Common.GetBytes(command);

            byte[] receivedBytes = new byte[10000];
            receivedBytes = RequestData(bytesToSend);

            if (receivedBytes == null)
            {
                dgvLogs.Rows.Add(selectedItem.ToString(), DateTime.Now.ToString(), "Gelen byte dizisi null.");
                return;
            }

            txtReceivedBytes.Clear();
            for (int i = 0; i < 100; i++)
            {
                txtReceivedBytes.Text += receivedBytes[i].ToString() + ",";
            }

            txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(receivedBytes);
        }

        private void SendSingleCommand2(string command)
        {
            TCPConnection tcp = new TCPConnection(txtIP.Text,Convert.ToInt32(txtPort.Text));
            byte[] bytesToSend = new byte[5000];
            bytesToSend = Common.GetBytes(command);

            byte[] receivedBytes = new byte[10000];
            receivedBytes = tcp.RequestData(bytesToSend);

            if (receivedBytes == null)
            {
                dgvLogs.Rows.Add(selectedItem.ToString(), DateTime.Now.ToString(), "Gelen byte dizisi null.");
                return;
            }

            txtReceivedBytes.Clear();
            for (int i = 0; i < 100; i++)
            {
                txtReceivedBytes.Text += receivedBytes[i].ToString() + ",";
            }

            txtReceivedBytesASCII.Text = ASCIIEncoding.ASCII.GetString(receivedBytes);
        }



        private void lnkSendCommand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendSingleCommand2(lbGeneratedCommands.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selectedItem >= lbGeneratedCommands.Items.Count)
            {
                selectedItem = 0;
                timer1.Enabled = false;
                dgvLogs.Rows.Add(selectedItem.ToString(),DateTime.Now.ToString(),"Tarama tamamlandı.");
            }
            else
            {
                lbGeneratedCommands.SelectedIndex = selectedItem;
                SendSingleCommand(lbGeneratedCommands.Text);
                selectedItem++;
            }
        }

        private void lnkStartSending_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void lnkStopSending_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
          //_tcpClient = new TcpClient(txtIP.Text, Convert.ToInt32(txtPort.Text));
          //_stream = _tcpClient.GetStream();

          //int timeout = 1000;
          //_tcpClient.SendTimeout = timeout;
          //_tcpClient.ReceiveTimeout = timeout;
          //_stream.WriteTimeout = timeout;
          //_stream.ReadTimeout = timeout;


        }

        private void frmTryCommands_Load(object sender, EventArgs e)
        {
            lmkGenerateCommands_LinkClicked(null, null);

        }

        private void lnkClearCommandsListBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbGeneratedCommands.Items.Clear();
        }

        private void dgvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLogInfo.Text = dgvLogs.CurrentRow.Cells["LogInfo"].Value.ToString();
        }
    }
}
