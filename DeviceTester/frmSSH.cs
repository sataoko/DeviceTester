using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tamir.SharpSsh;

namespace DeviceTester
{
    public partial class frmSSH : Form
    {
        SshStream ssh;

        private void ReadSSH()
        {
            System.Threading.Thread.Sleep(100);
            txtConsole.Text += ssh.ReadResponse() + Environment.NewLine;
        }

        public frmSSH()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ssh = new SshStream(txtIP.Text, txtUsername.Text, txtPassword.Text);

                txtConsole.Text = string.Format("OK ({0}/{1})", ssh.Cipher, ssh.Mac) + Environment.NewLine;
                txtConsole.Text += string.Format("Server version={0}, Client version={1}", ssh.ServerVersion, ssh.ClientVersion) + Environment.NewLine;
                txtConsole.Text += string.Format("-Use the 'exit' command to disconnect.");
            }
            catch (Exception exc)
            {
                txtConsole.Text += exc.ToString();
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ssh.Write(txtCommand.Text);
            ReadSSH();
        }

        private void btnStartPointsat_Click(object sender, EventArgs e)
        {
            ssh = new SshStream(txtIP.Text, txtUsername.Text, txtPassword.Text);
            ssh.Write("cd svs");

            ReadSSH();
            ssh.Write("export LD_LIBRARY_PATH=/svs/libs");

            ReadSSH();

            ssh.Write("./pointsat_core&");
            ReadSSH();

        }

        private void btbReboot_Click(object sender, EventArgs e)
        {
            ssh = new SshStream(txtIP.Text, txtUsername.Text, txtPassword.Text);
            ssh.Write("reboot");
            ReadSSH();
        }

        private void shellControl1_CommandEntered(object sender, CommandEnteredEventArgs e)
        {
            
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtConsole.Clear();
        }
    }
}
