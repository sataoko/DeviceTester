using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    public partial class frmPython : Form
    {
        private void RunPython(string args)
        {
            string s = DOSPrompt.CMDAutomate(args, "C:\\python3.5\\python.exe");
            txtConsole.Text = s;
        }
        public frmPython()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunPython("-c \""+rtbCode.Text+ "\"");
        }

        private void txtArgs_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtArgs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                string path = "\""+Application.StartupPath + "\\Py\\sum.py\" ";
                RunPython(path+txtArgs.Text); 
                //RunPython(txtArgs.Text);
            }
        }
    }
}
