using System;
using System.Collections.Generic;
using System.Text;

namespace TCPDeviceTester
{
    public enum CRCType { Mod95, XOR, CRC16, CRC_CCITT_Kermit }

    class CRC
    {
        public static int Mod95(byte[] byteArray)
        {
            int result = 0, sum = 0;

            for (int i = 0; i < byteArray.Length; i++)
            {
                sum = sum + byteArray[i];
            }

            result = 32 + ((sum - (32 * byteArray.Length)) % 95);
            return result;
        }

        public static int XOR(byte[] byteArray)
        {
            int cs = 0;
            int n;
            for (n = 0; n < byteArray.Length; n++)
            {
                cs = cs ^ byteArray[n];
            }
            return cs;
        }

        public static int CRC16(byte[] byteArray)
        {
            int size = byteArray.Length;
            int crc_buff = 0; 
            int i, j;
            byte buf;
            for (j = 0; j < size; j++)
            {
                buf = byteArray[j];
                for (i = 0; i < 8; i++)
                {
                    if (((crc_buff & 0x0001) ^ (buf & 0x01)) == 1)
                    {
                        crc_buff >>= 1;
                        crc_buff ^= 0x8408;
                    }
                    else
                    {
                        crc_buff >>= 1;
                        crc_buff ^= 0x0000;
                    }
                    buf >>= 1;
                }
            }
            return crc_buff;
        }

        public static int CRC_CCITTKermit0(byte[] byteArray)
        {
            
            int crc = 0;
            int i, j;
            for (j = 0; j < byteArray.Length; j++)
            {
                crc = crc ^ (byteArray[j] << 8);
                for (i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) == 0x8000)
                        crc = (crc << 1) ^ 0x1021;
                    else
                        crc <<= 1;
                }
                crc &= 0xFFFF;
            }
            return crc;
        }

        public static int CRC_CCITTKermit(byte[] dataArray)
        {
            int crc_buff = 0; 
            int i, j;
            byte buf;
            for (j = 0; j < dataArray.Length; j++)
            {
                buf = dataArray[j];
                for (i = 0; i < 8; i++)
                {
                    if (((crc_buff & 0x0001) ^ (buf & 0x01)) == 1)
                    {
                        crc_buff >>= 1;
                        crc_buff ^= 0x8408;
                    }
                    else
                    {
                        crc_buff >>= 1;
                        crc_buff ^= 0x0000;
                    }
                    buf >>= 1;
                }
            }
            return crc_buff;

        }

        public static int crc_mcl(byte[] byteArray)
        {
            int crc = 0;
            int i, j;
            for (j = 0; j < byteArray.Length; j++)
            {
                byte buffer = byteArray[j];
                for (i = 0; i < 8; i++)
                {
                    crc = (((buffer & 0x01) ^ (crc & 0x0001)) > 0) ? (crc >> 1 ^ 0xA001) : (crc >> 1);
                    buffer >>= 1;
                }
            }
            return crc;
        }

        public static string CalculateCheckSum(byte[] byteArray, CRCType crcType)
        {
            string checkSumString = string.Empty;

            switch (crcType)
            {
                case CRCType.Mod95:
                    int c = CRC.Mod95(byteArray);
                    checkSumString += c.ToString();
                    break;
                case CRCType.XOR:
                    int d = CRC.XOR(byteArray);
                    checkSumString += d.ToString();
                    break;
                case CRCType.CRC16:
                    int data = CRC.crc_mcl(byteArray);
                    byte[] chk = new byte[2];
                    chk[0] = (byte)(data & ('\x00FF'));
                    chk[1] = (byte)(data >> 8);
                    checkSumString += chk[0].ToString() + ",";
                    checkSumString += chk[1].ToString();
                    break;
                case CRCType.CRC_CCITT_Kermit:

                    int da = CRC.CRC_CCITTKermit(byteArray);
                    byte[] a = new byte[2];
                    a[1] = (byte)(da & ('\x00FF'));
                    a[0] = (byte)(da >> 8);
                    checkSumString += a[0].ToString() + ",";
                    checkSumString += a[1].ToString();
                    break;
                default:
                    break;
            }

            return checkSumString;
        }
    }
}
