using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TCPDeviceTester
{
    class Convertor
    {
        public string DecimalToHex(string decimalValue)
        {
            string s = String.Format("{0:X}", Convert.ToInt32(decimalValue));
            if (s == "0" || s == "1" || s == "2" || s == "3" || s == "4" 
                || s == "5" || s == "6" || s == "7" || s == "8" || s == "9"
                || s == "A" || s == "B" || s == "C" || s == "D" || s == "E" || s == "F"
                ) s = "0" + s;
            return s;
        }

        public string HexToASCII(string hexValue)
        {
          return Convert.ToChar(int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber)).ToString();
        }

        public void DecimalToHexIntoTextBox(TextBox sender, TextBox target)
        {
            if (sender.Text.Length > 0)
            {
                string[] bytes = sender.Text.Split(' ');
                
                target.Clear();

                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                     string decimalByteValue = Convert.ToInt32(bytes[i]).ToString();
                    target.Text += DecimalToHex(decimalByteValue)+ " ";
                }
                target.Text = target.Text.Remove(target.Text.Length - 1, 1);
            }
        }

        public void AsciiToDecimalIntoTextBox(TextBox sender, TextBox target)
        {
            if (sender.Text.Length > 0)
            {
                //string[] bytes = sender.Text.Split(',');
                string bytes = sender.Text;
                target.Clear();
                for (int i = 0; i < bytes.Length; i++)
                {
                    //if (bytes[i] == string.Empty) continue;
                    target.Text += Convert.ToInt32(bytes[i]).ToString() + " ";
                }
                target.Text = target.Text.Remove(target.Text.Length - 1, 1);
            }
        }
        
        public void HexToAsciiIntoTextBox(TextBox sender, TextBox target)
        {
            if (sender.Text.Length > 0)
            {
                //int l = sender.Text.Length;

                //if (l % 2 != 0) return;

                //int byteCount = sender.Text.Length / 2;

                //for (int i = 0; i < byteCount; i+=2)
                //{
                    
                //}

                //string[] bytes = sender.Text.Split(',');

                string[] bytes = sender.Text.Split(' ');

                target.Clear();

                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string s = HexToASCII(bytes[i]);
                    target.Text += s;
                }
                
                //target.Text = target.Text.Remove(target.Text.Length - 1, 1);
            }
        }

        public void ConvertBytesIntoTextBox(TextBox sender, TextBox target, string conversionType)
        {
            string[] bytes = sender.Text.Split(' ');

            target.Clear();
            if (conversionType == "HEX")
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string decimalByteValue = Convert.ToInt32(bytes[i][0]).ToString();
                    target.Text += DecimalToHex(decimalByteValue) + " ";
                }
                target.Text = target.Text.Remove(target.Text.Length - 1, 1);
            }

            if (conversionType == "ASCII")
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    string s = HexToASCII(bytes[i]);
                    target.Text += s + " ";
                }
            }
            if (conversionType == "Decimal")
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] == string.Empty) continue;
                    target.Text += Convert.ToInt32(bytes[i][0]).ToString() + " ";
                }
            }
        }

        //public void ApplyConvertionsToTextBoxes(TextBox sender, TextBox target1, string target1ConversionType, TextBox target2, string target2ConversionType)
        //{
        //    string[] bytes = sender.Text.Split(',');

        //    target1.Clear();
        //    target2.Clear();

        //    ConvertBytesIntoTextBox(bytes, target1, target1ConversionType);

        //    ConvertBytesIntoTextBox(bytes, target2, target2ConversionType);
        //}
    }
}
