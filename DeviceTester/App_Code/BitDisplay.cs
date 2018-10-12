using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTester
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
            double sum = 0;
            sum += (lblBit0.Text == "1" ? 1 : 0) * Math.Pow(2, 0);
            sum += (lblBit1.Text == "1" ? 1 : 0) * Math.Pow(2, 1);
            sum += (lblBit2.Text == "1" ? 1 : 0) * Math.Pow(2, 2);
            sum += (lblBit3.Text == "1" ? 1 : 0) * Math.Pow(2, 3);
            sum += (lblBit4.Text == "1" ? 1 : 0) * Math.Pow(2, 4);
            sum += (lblBit5.Text == "1" ? 1 : 0) * Math.Pow(2, 5);
            sum += (lblBit6.Text == "1" ? 1 : 0) * Math.Pow(2, 6);
            sum += (lblBit7.Text == "1" ? 1 : 0) * Math.Pow(2, 7);
            txtDecimalValue.Text = sum.ToString();
        }

        public BitDisplay()
        {
            InitializeComponent();
        }

        internal void Clear()
        {
            ShowBitsOfByte(0);
        }

        private void ToggleBit(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Text == "0") label.Text = "1"; else label.Text = "0";
            CalculateBits();
        }
    }
}
