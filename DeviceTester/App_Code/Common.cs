using System;
using System.Collections.Generic;
using System.Text;

namespace TCPDeviceTester
{
    class Common
    {
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

        //frmMainCommandTools uses this method. Maybe deleted later.
        public static int GetByteCount(string text)
        {
            string[] bytes = System.Text.RegularExpressions.Regex.Split(text, ",");
            return bytes.Length;
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

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] HexAsBytes = new byte[hexString.Length / 2];
            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                HexAsBytes[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
            }

            return HexAsBytes;
        }

        public static bool CheckNetworkConnection(string IP)
        {
            if (string.IsNullOrEmpty(IP)) return false;
            try
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IP);
                System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply reply;
                reply = pinger.Send(ipAddress, 5);
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
    }
}
