using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    public partial class frmNetworkCommands : Form
    {
        public string DOSCommand = string.Empty;
        
        public frmNetworkCommands()
        {
            InitializeComponent();
        }

        private void frmNetworkCommands_Load(object sender, EventArgs e)
        {
            dgvCommands.Rows.Add("ping 192.168.1.1", "Test Connectivity");
            dgvCommands.Rows.Add("ipconfig", "");
            dgvCommands.Rows.Add("ipconfig /release", "Release All IP Address Connections");
            dgvCommands.Rows.Add("ipconfig /flushdns", "Clear DNS Cache");
            dgvCommands.Rows.Add("ipconfig /renew","Renew All IP Address Connections");
            dgvCommands.Rows.Add("ipconfig /registerdns", "Re-Register the DNS connections");
            dgvCommands.Rows.Add("ipconfig /showclassid", "Display DHCP Class Information:");
            dgvCommands.Rows.Add("ipconfig /setclassid", "Change/Modify DHCP Class ID");
            dgvCommands.Rows.Add("control netconnections", "Network Connections");
            dgvCommands.Rows.Add("tracert", "Trace Route");
            dgvCommands.Rows.Add("route", "Display Local Route");
            dgvCommands.Rows.Add("arp", "Display Resolved MAC Addresses");
            dgvCommands.Rows.Add("hostname", "Display Name of Computer Currently on");
            dgvCommands.Rows.Add("netstat", "Displays the TCP/IP protocol sessions");
            dgvCommands.Rows.Add("nslookup unizayn.com", "NameServer Lookup");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DOSCommand = dgvCommands.CurrentRow.Cells["Command"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
