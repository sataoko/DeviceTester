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
    public partial class frmCharMap : Form
    {
        public frmCharMap()
        {
            InitializeComponent();
        }

        private void BtnShowChars_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[256];

            for (int i = 10; i < 256; i++)
                array[i] = (byte)i;

            string ascii = Encoding.ASCII.GetString(array);
            txtCharMap.Text = "ASCII" + Environment.NewLine + ascii + Environment.NewLine;

            string unicode= Encoding.Unicode.GetString(array);
            txtCharMap.Text += "Unicode" + Environment.NewLine + unicode + Environment.NewLine;
            string utf7 = Encoding.UTF7.GetString(array);
            txtCharMap.Text += "UTF7" + Environment.NewLine + utf7 + Environment.NewLine;
            string utf8 = Encoding.UTF8.GetString(array);
            txtCharMap.Text += "UTF8" + Environment.NewLine + utf8 + Environment.NewLine;
            return;

            for (int i = 0; i < 256; i++)
            {
                //dgvChars.Rows.Add(i.ToString(), i.ToString("X2"),unicode[i], ascii[i], utf7[i], utf8[i]);
                dgvChars.Rows.Add(i.ToString(), i.ToString("X2"), ascii[i],"", "","");
            }

        }
    }
}
