using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    public partial class BitDisplay : UserControl
    {

        public void ShowBitsOfByte(byte b)
        {
            string s = Common.GetBits(b);
            lblBit0.Text = s[7].ToString();
            lblBit1.Text = s[6].ToString();
            lblBit2.Text = s[5].ToString();
            lblBit3.Text = s[4].ToString();
            lblBit4.Text = s[3].ToString();
            lblBit5.Text = s[2].ToString();
            lblBit6.Text = s[1].ToString();
            lblBit7.Text = s[0].ToString();

            txtDecimalValue.Text = b.ToString();
        }

        private void CalculateBits()
        {
            /*if (dgvSelectedByteBits.CurrentCell != null)
            {
                if (dgvSelectedByteBits.CurrentCell.Value.ToString() == "1") dgvSelectedByteBits.CurrentCell.Value = "0";
                else dgvSelectedByteBits.CurrentCell.Value = "1";

                byte i = 7; double sum = 0;
                foreach (DataGridViewCell c in dgvSelectedByteBits.Rows[0].Cells)
                    sum += (c.Value.ToString() == "1" ? 1 : 0) * Math.Pow(2, i--);

                txtSelectedBitsValue.Text = sum.ToString();
            }*/
        }

        public BitDisplay()
        {
            InitializeComponent();
        }

        internal void Clear()
        {
            ShowBitsOfByte(0);
        }
    }
}
