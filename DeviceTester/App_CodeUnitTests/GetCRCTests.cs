using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TCPDeviceTester
{
    public class GetCRCTests
    {
        //02 64 4F 4F 46 3F 03
        static byte[] b = new byte[] { 0x02, 0x64, 0x4F, 0x4F, 0x46, 0x3F, 0x03 };

        [Fact]
        public static void TestCheckSumRVInverseHEXString()
        {
            Assert.Equal("35 82 8E 1C", GetCRC.GetCRC32CheckSum(b).InverseHexString);
        }

        [Fact]
        public static void TestCheckSumSum()
        {
            Assert.Equal(193, GetCRC.Sum(b).IntegerCHK);
        }

        [Fact]
        public static void TestCheckSumMod95()
        {
            Assert.Equal(33, GetCRC.Mod95(b).IntegerCHK);
        }

        [Fact]
        public static void TestCheckSumMod256()
        {
            Assert.Equal(33, GetCRC.Mod256(b).IntegerCHK);
        }

        [Fact]
        public static void TestCheckSumXOR()
        {
            Assert.Equal(33, GetCRC.XOR(b).IntegerCHK);
        }

        [Fact]
        public static void TestCheckSumCRC_CCITT_XModem()
        {
            Assert.Equal("33 CE", GetCRC.CRC_CCITT_XModem(b).InverseHexString);
        }

        [Fact]
        public static void TestCheckSumCRC_CCITT_Kermit()
        {
            Assert.Equal("96 D6", GetCRC.CRC_CCITT_Kermit(b).InverseHexString);
        }
    }
}
