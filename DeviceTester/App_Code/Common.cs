using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceTester
{
    class Common
    {
        /*
        //frmMainCommandTools uses this method. Maybe deleted later.
        public static int GetByteCount(string text)
        {
            string[] bytes = System.Text.RegularExpressions.Regex.Split(text, ",");
            return bytes.Length;
        }

        public static byte[] GetBytesToSend(string byteStringWithComma)
        {
            string[] bytes = byteStringWithComma.Split(',');

            byte[] bytesToSend = new byte[1000];
            for (int i = 0; i < bytes.Length; i++)
            {
                int k = Convert.ToInt16(bytes[i]);
                bytesToSend[i] = (byte)k;
            }

            return bytesToSend;
        }
         public static byte[] GetHexBytes(string byteString)
        {
            try
            {
                string[] bytes = byteString.Split(' ');
                byte[] bytesToSend = new byte[bytes.Length];
                for (int i = 0; i < bytes.Length; i++)
                {
                    //int k = splitChar == ',' ? Convert.ToInt16(bytes[i]) : Convert.ToInt32(bytes[i], 16);
                    bytesToSend[i] = byte.Parse(bytes[i], System.Globalization.NumberStyles.HexNumber);
                }
                return bytesToSend;
            }
            catch (Exception exp)
            {
                return null;
            }
        }

        public static byte[] GetBytes(string byteStringWithComma)
        {

            if (string.IsNullOrEmpty(byteStringWithComma)) return null;
            string[] bytes = byteStringWithComma.Split(',');

            byte[] bytesToSend = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                int k = Convert.ToInt16(bytes[i]);
                bytesToSend[i] = (byte)k;
            }

            return bytesToSend;
        }
        public static byte[] GetBytes(string byteString, char splitChar)
        {
            if (string.IsNullOrEmpty(byteString)) return null;
            string[] bytes = byteString.Split(splitChar);

            byte[] bytesToSend = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            bytesToSend[i] =Convert.ToByte(bytes[i],10);//Convert.ToInt16(bytes[i]); (byte)k;

            return bytesToSend;
        }

    */


        public static byte[] GetBytesFromHex(string hexString)
        {
            hexString = hexString.Replace(" ", "");

            string[] bytes = new string[hexString.Length / 2];

            string s = string.Empty;
            int c = 0;
            for (int i = 0; i < hexString.Length; i++)
            {
                s += hexString[i];

                if (i % 2 != 0)
                {
                    bytes[c++] = s;
                    s = string.Empty;
                }
            }

            byte[] bytesToSend = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
                bytesToSend[i] = byte.Parse(bytes[i], System.Globalization.NumberStyles.HexNumber);

            return bytesToSend;

        }

        public static string GetString(byte[] byteArray)
        {
            //string s = string.Empty;
            //for (int i = 0; i < byteArray.Length; i++)
            //{
            //    if (byteArray[i] == 0) byteArray[i] = 46;
            //}

            //return Encoding.ASCII.GetString(byteArray);
            return ASCIIEncoding.Default.GetString(byteArray);
        }

        public static string GetBits(byte b)
        {
            byte value = b;
            string bits = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if ((value & Convert.ToByte((Math.Pow(2, i)))) != 0)
                {
                    bits= "1"+bits;
                }
                else
                {
                    bits = "0"+bits;
                }
            }

            return bits;
        }

        public static bool CheckNetworkConnection(string IP)
        {
            if (string.IsNullOrEmpty(IP)) return false;
            try
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IP);
                System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply reply;
                reply = pinger.Send(ipAddress, 50);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static byte[] SendBytes(string IP,string port,byte[] command)
        {
            TCPConnection t = new TCPConnection(IP, Convert.ToUInt16(port));

            byte[] receivedBytes = new byte[t.ReadBufferSize];

            return  t.RequestData(command);
        }

        public static DateTime RetrieveLinkerTimestamp()
        {
            string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;
            byte[] b = new byte[2048];
            System.IO.Stream s = null;

            try
            {
                s = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                s.Read(b, 0, 2048);
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                }
            }

            int i = System.BitConverter.ToInt32(b, c_PeHeaderOffset);
            int secondsSince1970 = System.BitConverter.ToInt32(b, i + c_LinkerTimestampOffset);
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            dt = dt.AddSeconds(secondsSince1970);
            dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
            return dt;
        }

        public static string RemoveNonHexChars(string hexCharsInput)
        {
            Char replacementChar = ' ';
            IEnumerable<Char> allowedChars = new[] {
                'a', 'b', 'c', 'd', 'e','f', 'A', 'B', 'C', 'D', 'E', 'F',
                '0','1','2','3','4','5','6','7','8','9'
            };

            string result = new string(
              hexCharsInput.Select(x => !allowedChars.Contains(x) ? replacementChar : x).ToArray()
            );

            return result;
        }

        public static string VerifyHexFormat(string hexBytePacket)
        {
            hexBytePacket = RemoveNonHexChars(hexBytePacket).Replace(" ",string.Empty);
            if ((hexBytePacket.Length) % 2 != 0) return "error";
            else return hexBytePacket;
        }
    }
}
