using System;

namespace NesSharp.Cpu
{
    public class Instruction
    {
        public Func<Cpu, byte> Operation;
        public Func<Cpu, byte> AddrMode;
        public string Name { get; set; }
        public byte Cycles { get; set; }

        public Instruction()
        {
            Cycles = 0;
        }
    }
}