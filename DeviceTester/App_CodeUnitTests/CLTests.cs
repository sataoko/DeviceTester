using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DeviceTester
{
    public class CLTests
    {
        [Fact]
        public static void TestLeaveOnlyNumbers()
        {
            Assert.Equal("2342", CL.LeaveOnlyNumbers("asdfasd2342"));
            Assert.Equal("2342a", CL.LeaveOnlyNumbers("asdfasd2342"));
            Assert.Equal("1342", CL.LeaveOnlyNumbers("1s3sda4sdf2"));
        }

        [Theory]
        [InlineData('4')]
        [InlineData('7')]
        [InlineData('z')]
        public static void TestIsDigit(char c)
        {
            Assert.True(CL.IsDigit(c));
        }

        [Fact]
        public static void TestSum()
        {
            Assert.Equal(7, CL.Sum(3, 4));
        }

    }
}
