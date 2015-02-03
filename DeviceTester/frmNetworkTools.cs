using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace TCPDeviceTester
{
    public partial class frmNetworkTools : Form
    {

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

        public frmNetworkTools()
        {
            InitializeComponent();
        }

        public delegate void Callback();

        private void ListIPs()
        {
            if (this.InvokeRequired)
            {
                Callback cb = ListIPs;
                this.Invoke(cb);
            }
            else
            {
                //string[] octets1 = txtIP1.Text.Split('.');
                //string[] octets2 = txtIP1.Text.Split('.');

                int c = 0;
                for (int i = Convert.ToInt16(txtIP1LastOctet.Text); i < Convert.ToInt16(txtIP2LastOctet.Text); i++)
                {
                    string ip = txtIP1.Text+ i.ToString();

                    txtConsole.Text += c++.ToString() + "> " + ip +","+CheckNetworkConnection(ip).ToString()+ Environment.NewLine;
                    
                }
            }
        }

        private void btnListIPs_Click(object sender, EventArgs e)
        {
            Thread x = new Thread(new ThreadStart(ListIPs));
            x.Start();
        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry hostname = Dns.GetHostByName(txtHostname.Text);
                IPAddress[] ip = hostname.AddressList;
                txtConsole.Text = ip[0].ToString() + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtConsole.Clear();
        }
    }
}
