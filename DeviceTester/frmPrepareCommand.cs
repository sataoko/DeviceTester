using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    public partial class frmPrepareCommand : Form
    {
        public frmPrepareCommand()
        {
            InitializeComponent();
        }

        private string ConvertToHex(string decimalValue)
        {
            return String.Format("{0:X}", Convert.ToInt32(decimalValue));
        }

        private void ApplyConversions()
        {
            if (!string.IsNullOrEmpty(txtASCII.Text))
            {
                txtDecimalByteValue.Text = Convert.ToInt32(txtASCII.Text[0]).ToString();
                txtHEXByteValue.Text = ConvertToHex(txtDecimalByteValue.Text);
            }
        }

        private void frmPrepareCommand_Load(object sender, EventArgs e)
        {
        }

        


        #region TOOLS
        
        private void txtASCII_TextChanged(object sender, EventArgs e)
        {
            ApplyConversions();
        }

        private void lnkGenerateCheckSum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecimalBytes.Focus();

            byte[] bytes = Common.GetBytesToSend(txtDecimalBytes.Text);
            int checkSum = CheckSum.CalculateCheckSum(bytes, Common.GetByteCount(txtDecimalBytes.Text));

            txtDecimalBytes.Text += "," + checkSum.ToString();
        }

        private void lnkCRC32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecimalBytes.Focus();

            byte[] a = Common.GetCheckSumInBytes(Common.GetBytesToSend(txtDecimalBytes.Text), Common.GetByteCount(txtDecimalBytes.Text));
            txtDecimalBytes.Text += "," + a[0].ToString() + ",";
            txtDecimalBytes.Text += a[1].ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecimalBytes.Focus();

            byte[] bytes = Common.GetBytesToSend(txtDecimalBytes.Text);
            int checkSum = CheckSum.CalculateCheckSum3(bytes, Common.GetByteCount(txtDecimalBytes.Text));

            txtDecimalBytes.Text += "," + checkSum.ToString();
        }

        private void lnkCIFCheckSum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecimalBytes.Focus();

            byte[] bytes = Common.GetBytesToSend(txtDecimalBytes.Text);
            int checkSum = CheckSum.CIFProtocolCheckSum(bytes, Common.GetByteCount(txtDecimalBytes.Text));

            txtDecimalBytes.Text += "," + checkSum.ToString();
        }

        private void lnkMiteqCheckSum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDecimalBytes.Focus();

            byte[] bytes = Common.GetBytesToSend(txtDecimalBytes.Text);
            int checkSum = CheckSum.CalculateCheckSumMiteq(bytes, Common.GetByteCount(txtDecimalBytes.Text));

            txtDecimalBytes.Text += "," + checkSum.ToString();
        }


       

        private void txtASCIIBytes_TextChanged(object sender, EventArgs e)
        {
            if (rbASCII.Checked)
            {
                txtDecimalBytes.Clear();
                txtHEXBytes.Clear();

                string[] bytes = txtASCIIBytes.Text.Split(',');

                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string decimalByteValue = Convert.ToInt32(bytes[i][0]).ToString();
                    txtDecimalBytes.Text += decimalByteValue + ",";
                    txtHEXBytes.Text += ConvertToHex(decimalByteValue) + ",";
                }

                if (txtHEXBytes.Text.Length > 0)
                {
                    txtDecimalBytes.Text = txtDecimalBytes.Text.Remove(txtDecimalBytes.Text.Length - 1, 1);
                    txtHEXBytes.Text = txtHEXBytes.Text.Remove(txtHEXBytes.Text.Length - 1, 1);
                }
            }
        }
   
        private void txtDecimalBytes_TextChanged(object sender, EventArgs e)
        {
            if (rbDecimal.Checked)
            {
                string[] bytes = txtDecimalBytes.Text.Split(',');
                 
                txtHEXBytes.Clear();
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string decimalByteValue = Convert.ToInt32(bytes[i]).ToString();
                    //   txtDecimalBytes.Text +=decimalByteValue  + ",";
                    txtHEXBytes.Text += ConvertToHex(decimalByteValue) + ",";
                }
                // txtDecimalBytes.Text = txtDecimalBytes.Text.Remove(txtDecimalBytes.Text.Length - 1, 1);
                txtHEXBytes.Text = txtHEXBytes.Text.Remove(txtHEXBytes.Text.Length - 1, 1);
            }
          
        }

        private void txtHEXBytes_TextChanged(object sender, EventArgs e)
        {
            if (rbHEX.Checked)
            {
                txtDecimalBytes.Clear();

                string[] bytes = txtHEXBytes.Text.Split(',');
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string decimalByteValue = System.Convert.ToInt32(bytes[i], 16).ToString();
                    //   txtDecimalBytes.Text +=decimalByteValue  + ",";
                    txtDecimalBytes.Text += decimalByteValue + ",";
                }
                // txtDecimalBytes.Text = txtDecimalBytes.Text.Remove(txtDecimalBytes.Text.Length - 1, 1);
                txtDecimalBytes.Text = txtDecimalBytes.Text.Remove(txtDecimalBytes.Text.Length - 1, 1);
            }
            
        }

        private void txtDecimalBytes_Enter(object sender, EventArgs e)
        {
            rbDecimal.Checked = true;
        }

        private void txtHEXBytes_Enter(object sender, EventArgs e)
        {
            rbHEX.Checked = true;
        }

        private void txtASCIIBytes_Enter(object sender, EventArgs e)
        {
            rbASCII.Checked = true;
        }

        private void lnkCRC16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CRCTool c = new CRCTool();
            c.Init(CRCTool.CRCCode.CRC16);
            ushort data = (ushort)c.crctablefast(Common.GetBytes(txtDecimalBytes.Text));
            byte[] a = new byte[2];
            a[1] = (byte)(data & ('\x00FF'));
            a[0] = (byte)(data >> 8);
            txtDecimalBytes.Text += "," + a[0].ToString() + ",";
            txtDecimalBytes.Text += a[1].ToString();
        }

        private void lnkMod256_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] b = Common.GetBytes(txtDecimalBytes.Text);
            int total=0;
            for (int i = 0; i < b.Length; i++)
            {
                total += b[i];
            }

            int checksum = total - ((total % 256) * 256);
            
            byte[] a = new byte[2];
            a[1] = (byte)(checksum & ('\x00FF'));
            a[0] = (byte)(checksum >> 8);
            txtDecimalBytes.Text += "," + a[0].ToString() + ",";
            txtDecimalBytes.Text += a[1].ToString();
        }

        #endregion

        public string ConvertHexToAscii(string Hex)
        {
            //if (!(Hex.Length % 2 == 0)) Hex += "0";
           
            string ReturnStr = "";
            for (int ptr = 0; ptr < Hex.Length; ptr++)
            {
                if (!(ptr % 2 == 0))
                {
                    ReturnStr += Convert.ToChar(int.Parse(Hex.Substring(ptr - 1, 2),  System.Globalization.NumberStyles.HexNumber));
                }
            }
            return ReturnStr;
        }

        public string htoAscii(string Hex)
        {

            return Convert.ToChar(int.Parse(Hex, System.Globalization.NumberStyles.HexNumber)).ToString();
            
        }

        private void txtDecimalByteValue_TextChanged(object sender, EventArgs e)
        {
            Convertor c = new Convertor();
            c.DecimalToHexIntoTextBox((sender as TextBox), txtHEXByteValue);
        }

        private void txtHEXByteValue_TextChanged(object sender, EventArgs e)
        {
            if(txtHEXByteValue.Text.Length>0)
            if(txtHEXByteValue.Focused)
            txtASCII.Text = htoAscii(txtHEXByteValue.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int h = Convert.ToInt16(txtH.Text);
            int l = Convert.ToInt16(txtL.Text);

            int r = (h - l) / 2 + l;
            lblResult.Text = r.ToString();

        }
    }
}
