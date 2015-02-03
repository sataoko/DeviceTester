using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    public partial class frmMain : Form
    {
        #region TOOLS

        private string ConvertToHex(string decimalValue)
        {
            return String.Format("{0:X}", Convert.ToInt32(decimalValue));
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
            int total = 0;
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
    }
}
