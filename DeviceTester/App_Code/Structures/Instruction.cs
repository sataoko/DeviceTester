using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceTester
{
    public class Instruction
    {
        public string ID { get; set; }
        public string OrderNo { get; set; }
        public string InstructionBytes { get; set; }
        public string CheckSum { get; set; }
        public string Explanation { get; set; }

        public Instruction(string instructionBytes, string explanation)
        {
            InstructionBytes = instructionBytes;
            Explanation = explanation;
        }

        public override string ToString()
        {
            return Explanation;
        }

    }
}
