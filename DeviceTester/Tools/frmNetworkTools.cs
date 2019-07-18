using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace DeviceTester
{
    public partial class frmNetworkTools : Form
    {
        StringBuilder falseIPList = new StringBuilder();
        StringBuilder trueIPList = new StringBuilder();

        public frmNetworkTools()
        {
            InitializeComponent();
        }

        private void btnListIPs_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //ListIPs();

            //Thread x = new Thread(new ThreadStart(ListIPs));
            //x.Start();
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
                txtConsole.Text += ex.ToString() + Environment.NewLine;
            }
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtConsole.Clear();
        }

        private void btnGetAllDevicesOnLAN_Click(object sender, EventArgs e)
        {
            txtConsole.Text = string.Format("My IP : {0}", GetIPViaMAC.GetIPAddress()) + Environment.NewLine;
            // Get My PC MAC address
            txtConsole.Text += string.Format("My MAC: {0}", GetIPViaMAC.GetMacAddress()) + Environment.NewLine;
            // Get all devices on network
            Dictionary<IPAddress, System.Net.NetworkInformation.PhysicalAddress> all = GetIPViaMAC.GetAllDevicesOnLAN();
            foreach (KeyValuePair<IPAddress, System.Net.NetworkInformation.PhysicalAddress> kvp in all)
            {
                txtConsole.Text += string.Format("IP : {0}\n MAC {1}", kvp.Key, kvp.Value) + Environment.NewLine;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int c = 1;

            int ip1LastOctet = Convert.ToInt16(txtIP1LastOctet.Text);
            int ip2LastOctet = Convert.ToInt16(txtIP2LastOctet.Text);
            int percentageRef = (ip2LastOctet - ip1LastOctet);

            for (int i = ip1LastOctet; i <= ip2LastOctet; i++)
            {
                backgroundWorker1.ReportProgress(100 * (c / percentageRef));
                string ip = txtIP1.Text + i.ToString();

                bool b = Common.CheckNetworkConnection(ip);
                if (b)
                    trueIPList.Append(c.ToString() + " > " + ip + " , " + b.ToString() + Environment.NewLine);
                else falseIPList.Append(ip + ",");
                c++;

                //txtConsole.Text += c++.ToString() + " > " + ip + " , " + Common.CheckNetworkConnection(ip).ToString() + Environment.NewLine;
                //txtConsole.Text = checkedIPList;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtConsole.Text = "Pinging IPs. Wait...";
            txtConsole.Text = trueIPList.ToString()+"---"+Environment.NewLine
                +"False IP List:"+Environment.NewLine+falseIPList.ToString();
            progressBar1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // txtConsole.Text = checkedIPList.ToString();
            trueIPList.Clear();
            falseIPList.Clear();
        }


        public bool CheckNetworkConnection(string IP)
        {
            if (string.IsNullOrEmpty(IP)) return false;
            try
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IP);
                System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply reply;
                reply = pinger.Send(ipAddress, Convert.ToInt32(txtPingTimeout.Text));
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

        private void btnPing_Click(object sender, EventArgs e)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            txtConsole.Text = txtPingIP.Text + " : " + CheckNetworkConnection(txtPingIP.Text).ToString();
            stopWatch.Stop();
            txtConsole.Text += Environment.NewLine + stopWatch.ElapsedMilliseconds.ToString() + " ms";
        }
    }
}
