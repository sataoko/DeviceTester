using System;
using System.Collections.Generic;
using System.Text;

namespace TCPDeviceTester
{
    class CheckSum
    {
        public static int CalculateCheckSum(byte[] byteArray, int length)
        {
            int cs = 0;
            int n;
            for (n = 0; n < length; n++)
            {
                cs = cs ^ byteArray[n];
            }
            return cs;
        }

        public static int CalculateCheckSum3(byte[] csArray, int length)
        {
            int result = 0, toplamDeger = 0;

            for (int i = 0; i < length; i++)
            {
                toplamDeger = toplamDeger + csArray[i];
            }

            result = 32 + ((toplamDeger - (32 * length)) % 95);
            return result;
        }

        public static int CIFProtocolCheckSum(byte[] csArray, int length)
        {
            int result = 0, toplamDeger = 0;

            for (int i = 0; i < length; i++)
            {
                toplamDeger = toplamDeger + csArray[i];
            }

            result = 32 + (toplamDeger - 32 * length)% 95;
            return result;
        }

        public static int crc_ccitt_xmodem(byte[] buffer, int size)
        {
            int crc = 0;
            int i, j;
            for (j = 0; j <= size; j++)
            {
                crc = crc ^ (buffer[j] << 8);
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

        public static int CalculateCheckSum2(byte[] data, int size)
        {
            int crc_buff = 0; /* init our buffer to 0 */
            int i, j;
            byte buf;
            for (j = 0; j < size; j++)
            {
                buf = data[j];
                for (i = 0; i < 8; i++)
                {
                    if (((crc_buff & 0x0001) ^ (buf & 0x01)) == 1)
                    {
                        /* shift crc buffer */
                        crc_buff >>= 1;
                        /* XOR in the x16 value */
                        crc_buff ^= 0x8408;
                    }
                    else
                    {
                        /* shift crc buffer */
                        crc_buff >>= 1;
                        /* XOR in the x16 value */
                        crc_buff ^= 0x0000;
                    }
                    /* shift input for next iteration */
                    buf >>= 1;
                }
            }
            return crc_buff;
        }

        public static int CalculateCheckSumMiteq(byte[] checksumArray, int length)
        {
            int result = 0, toplamDeger = 0;

            for (int i = 0; i < length; i++)
            {
                toplamDeger = toplamDeger + checksumArray[i];
            }

            result = 32 + ((toplamDeger - (32 * length)) % 95);
            return result;
        }

        

    }
}
