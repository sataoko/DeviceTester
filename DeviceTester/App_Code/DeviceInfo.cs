using System;
using System.Collections.Generic;
using System.Text;

namespace TCPDeviceTester
{
    class DeviceInfo
    {
        public string DeviceName { set; get; }
        public string DeviceExplanation { set; get; }
        public string DeviceIP { set; get; }
        public string DevicePort { set; get; }
        public string CheckSumType { set; get; }
        public string InstructionStructure { set; get; }

        public DeviceInfo()
        {

        }
    }
}
