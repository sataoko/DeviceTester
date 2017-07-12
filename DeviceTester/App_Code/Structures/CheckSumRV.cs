using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPDeviceTester
{
    /// <summary>
    /// Check sum return value.
    /// </summary>
    public class CheckSumRV
    {
        byte _checksumByteCount = 0;
        public CheckSumRV(long checksumIntegerValue, byte checksumByteCount)
        {
            _checksumIntegerValue = checksumIntegerValue;
            _checksumByteCount = checksumByteCount;
        }

        private long _checksumIntegerValue = 0;
        public long IntegerCHK
        {
            set { _checksumIntegerValue = value; }
            get { return _checksumIntegerValue; }
        }

        public byte[] ByteArray
        {
            get
            {   //checkSum.HexString = String.Format("{0:X}", checkSum.Integer);

                //byte[] chk = new byte[2];
                //chk[1] = (byte)(this.IntegerCHK & ('\x00FF'));
                //chk[0] = (byte)(this.IntegerCHK >> 8);

                byte[] b = BitConverter.GetBytes(this.IntegerCHK);
                byte[] returnBytes = new byte[_checksumByteCount];
                Buffer.BlockCopy(b, 0, returnBytes,0, _checksumByteCount);
                return returnBytes ;
            }
        }

        public string HexString
        {
            get
            {
                return BitConverter.ToString(this.ByteArray).Replace("-", " ");
            }
        }

        public string InverseHexString
        {
            get
            {
                if (!string.IsNullOrEmpty(this.HexString))
                {
                    string[] s = HexString.Split(' ');
                    if (s.Length > 0) return s[1] + " " + s[0];
                    else return string.Empty;
                }
                else return string.Empty;
            }
        }
        

    }
}
