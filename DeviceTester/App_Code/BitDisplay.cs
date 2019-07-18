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
            GetASCIIView(b);
        }

        private void GetBitView(byte value)
        {
            try
            {
                System.Collections.BitArray myBA = new System.Collections.BitArray(BitConverter.GetBytes(value).ToArray());

                lblBit0.Text = GetBool(myBA.Get(0));
                lblBit1.Text = GetBool(myBA.Get(1));
                lblBit2.Text = GetBool(myBA.Get(2));
                lblBit3.Text = GetBool(myBA.Get(3));
                lblBit4.Text = GetBool(myBA.Get(4));
                lblBit5.Text = GetBool(myBA.Get(5));
                lblBit6.Text = GetBool(myBA.Get(6));
                lblBit7.Text = GetBool(myBA.Get(7));
            }
            catch (Exception)
            {


            }
        }

        private byte GetLabelBitValue(Label bitLabel)
        {
            byte bitValue = bitLabel.Text == "1" ? Convert.ToByte(1) : Convert.ToByte(0);
            return bitValue;
        }

        private void CalculateBits()
        {
            byte sum = Convert.ToByte(GetLabelBitValue(lblBit0) * 1);
            sum += Convert.ToByte(GetLabelBitValue(lblBit1) * 2);
            sum += Convert.ToByte(GetLabelBitValue(lblBit2) * 4);
            sum += Convert.ToByte(GetLabelBitValue(lblBit3) * 8);
            sum += Convert.ToByte(GetLabelBitValue(lblBit4) * 16);
            sum += Convert.ToByte(GetLabelBitValue(lblBit5) * 32);
            sum += Convert.ToByte(GetLabelBitValue(lblBit6) * 64);
            sum += Convert.ToByte(GetLabelBitValue(lblBit7) * 128);

            txtDecimalValue.Text = sum.ToString();

            //byte[] arr = BitConverter.GetBytes(sum);
            //lblASCII.Text = Encoding.ASCII.GetString(arr);
            GetASCIIView(sum);
        }

        private void GetASCIIView(byte value)
        {
            try
            {
                txtASCII.Text = Convert.ToChar(value).ToString();
            }
            catch (Exception)
            {
                throw;
            }
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

        private string GetBool(bool value)
        {
            if (value) return "1"; else return "0";
        }

        private void TxtDecimalValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int b = Convert.ToInt16(txtDecimalValue.Text);
                if (b > 255)
                {
                    txtDecimalValue.Text = "255";
                }
                if (b < 0) txtDecimalValue.Text = "0";
            }
            catch (Exception)
            {
                txtDecimalValue.Text = "0";
            }
        }

        private void TxtDecimalValue_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDecimalValue.Text))
                    GetBitView(0);
                else
                {
                    int b = Convert.ToInt16(txtDecimalValue.Text);
                    if ((b > 255) || (b < 0)) b = 0;
                    GetBitView((byte)b);
                    GetASCIIView((byte)b);
                }
            }
            catch (Exception exc)
            {

            }
        }

        private void TxtASCII_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtASCII.Text))
            {
                GetBitView(0);
                txtDecimalValue.Text = "0";
            }
            else
            {
                try
                {
                    char c = Convert.ToChar(txtASCII.Text);
                    int i = Convert.ToInt16(c);
                    if (i < 256)
                    {
                        GetBitView((byte)i);
                        txtDecimalValue.Text = i.ToString();
                    } 
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
