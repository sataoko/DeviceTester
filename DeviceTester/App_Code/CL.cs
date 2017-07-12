using System;
using System.Windows.Forms;


namespace TCPDeviceTester
{
    public class CL
    {
        public static bool IsNumberKey(Keys inKey)
        {
            if (inKey < Keys.D0 || inKey > Keys.D9)
            {
                if (inKey < Keys.NumPad0 || inKey > Keys.NumPad9)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsActionKey(Keys inKey)
        {
            return inKey == Keys.Delete || inKey == Keys.Back || inKey == Keys.Tab || inKey == Keys.Return;//||  Keyboard.Modifiers.HasFlag(ModifierKeys.Alt)
        }

        public static string LeaveOnlyNumbers(String inString)
        {
            String tmp = inString;
            foreach (char c in inString.ToCharArray())
            {
                if (!(char.IsNumber(c)))
                {
                    tmp = tmp.Replace(c.ToString(), "");
                }
            }
            return tmp;
        }

        public static bool IsDigit(char c)
        {
            return (c >= '0' || c <= '9');
        }

       
        public static int Sum(int a, int b)
        {
            return a+b;
        }

    }
}
