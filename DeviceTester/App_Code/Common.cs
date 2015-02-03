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

        public static byte[] GetCheckSumInBytes(byte[] dataArray, int size)
        {
            int data = CheckSum.CalculateCheckSum2(dataArray, size);

            byte[] ayrilmisData = new byte[2];

            ayrilmisData[1] = (byte)(data & ('\x00FF'));
            ayrilmisData[0] = (byte)(data >> 8);
            return ayrilmisData; //data=byte_ayrilmis_data[0] + byte_ayrilmis_data[1] * 256

        }

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

        public static byte[] GetBytes(string byteStringWithComma, char splitChar)
        {

            if (string.IsNullOrEmpty(byteStringWithComma)) return null;
            string[] bytes = byteStringWithComma.Split(splitChar);

            byte[] bytesToSend = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                int k = Convert.ToInt16(bytes[i]);
                bytesToSend[i] = (byte)k;
            }

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
