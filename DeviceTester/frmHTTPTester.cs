using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace DeviceTester
{
    public partial class frmHTTPTester : Form
    {
        TcpClient _tcpClient;
        NetworkStream _stream;

        public void ShowMessage(string message)
        {
            txtReceivedBytesASCII.Text += message + Environment.NewLine;
        }

        private byte[] RequestDisplaying(string command)
        {
            byte[] byteArrayToSend = ASCIIEncoding.ASCII.GetBytes(command);

            //txtReceivedBytesASCII.Text += ASCIIEncoding.ASCII.GetString(byteArrayToSend);

            byte[] incomingByteArray = new byte[_tcpClient.ReceiveBufferSize];

            try
            {
                if (_stream.CanWrite)
                {
                    _tcpClient.SendBufferSize = 0;
                    _stream.Write(byteArrayToSend, 0, byteArrayToSend.Length);
                }
                if (_stream.CanRead)
                {
                    // MessageBox.Show("Reading");
                    System.Threading.Thread.Sleep(350);
                    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);


                    txtReceivedBytesASCII.Text += ASCIIEncoding.ASCII.GetString(incomingByteArray) + "\r\n";
                    /*txtReceivedBytesASCII.Text += "Unicode>" + ASCIIEncoding.Unicode.GetString(incomingByteArray)+"\r\n" ;
                    txtReceivedBytesASCII.Text += "Default>" + ASCIIEncoding.Default.GetString(incomingByteArray)+"\r\n";
                    txtReceivedBytesASCII.Text += "UTF32>" + ASCIIEncoding.UTF32.GetString(incomingByteArray) + "\r\n";
                    txtReceivedBytesASCII.Text += "UTF7>" + ASCIIEncoding.UTF7.GetString(incomingByteArray) + "\r\n";
                    txtReceivedBytesASCII.Text += "UTF8>" + ASCIIEncoding.UTF8.GetString(incomingByteArray) + "\r\n";
                    txtReceivedBytesASCII.Text += "Big Endian>" + ASCIIEncoding.BigEndianUnicode.GetString(incomingByteArray) + "\r\n";*/


                }
            }
            catch (Exception exp)
            {
                ShowMessage(exp.ToString());

            }


            return incomingByteArray;
        }



        public frmHTTPTester()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnSendAdmin_Click(object sender, EventArgs e)
        {
            RequestDisplaying("admin");
        }

        private void lnkClearConsole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtReceivedBytesASCII.Clear();
        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _tcpClient = new TcpClient(txtIP.Text, Convert.ToInt16(txtPort.Text));
                _stream = _tcpClient.GetStream();

                int timeout = 1500;
                //int delayTime = 200;
                _tcpClient.ReceiveTimeout = timeout;
                _tcpClient.SendTimeout = timeout;
                _stream.ReadTimeout = timeout;
                _stream.WriteTimeout = timeout;

                ShowMessage("connected...");


            }
            catch (Exception exp)
            {
                ShowMessage(exp.ToString());
            }
        }

        private void tsbSend_Click(object sender, EventArgs e)
        {
            RequestDisplaying(txtCommand.Text);
        }

        private void tsbClearConsole_Click(object sender, EventArgs e)
        {
            txtReceivedBytesASCII.Clear();
        }

        private void tsbGetIP_Click(object sender, EventArgs e)
        {

            IPAddress[] addresslist = Dns.GetHostAddresses(txtURL.Text);
            txtIP.Text = addresslist[0].ToString();
        }
    }
}
