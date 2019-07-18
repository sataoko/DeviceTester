using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmHexKeyboard : Form
    {
        public frmHexKeyboard()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string start = chkAddZeroToHexKeyboard.Checked ? "0" : string.Empty;
            //txtHEXBytesInCHKCalculator.Text += start + (sender as Button).Text + " ";
        }
    }
}
