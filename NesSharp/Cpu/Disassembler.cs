using System.Collections.Generic;

namespace NesSharp.Cpu
{
    public static class Disassembler
    {
        public static SortedDictionary<ushort, string> Disassemble(Bus bus, ushort nStart, ushort nStop)
        {
            int addr = nStart;
            byte value = 0x00, lo = 0x00, hi = 0x00;
            var mapLines = new SortedDictionary<ushort, string>();
            ushort line_addr = 0;

            while (addr <= nStop)
            {
                line_addr = (ushort)addr;

                var sInst = "$" + addr.ToString("X2").PadLeft(4, '0') + ": ";

                byte opcode = bus.Read((ushort)addr, true); addr++;
                sInst += LookupTable.Instructions[opcode].Name + " ";

                if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.IMP)
                {
                    sInst += " {IMP}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.IMM)
                {
                    value = bus.Read((ushort)addr, true); addr++;
                    sInst += "#$" + value.ToString("X2").PadLeft(2, '0') + " {IMM}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ZP0)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = 0x00;
                    sInst += "$" + lo.ToString("X2").PadLeft(2, '0') + " {ZP0}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ZPX)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = 0x00;
                    sInst += "$" + lo.ToString("X2").PadLeft(2, '0') + ", X {ZPX}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ZPY)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = 0x00;
                    sInst += "$" + lo.ToString("X2").PadLeft(2, '0') + ", Y {ZPY}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.IZX)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = 0x00;
                    sInst += "($" + lo.ToString("X2").PadLeft(2, '0') + ", X) {IZX}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.IZY)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = 0x00;
                    sInst += "($" + lo.ToString("X2").PadLeft(2, '0') + "), Y {IZY}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ABS)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = bus.Read((ushort)addr, true); addr++;
                    sInst += "$" + ((ushort)((hi << 8) | lo)).ToString("X2").PadLeft(4, '0') + " {ABS}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ABX)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = bus.Read((ushort)addr, true); addr++;
                    sInst += "$" + ((ushort)((hi << 8) | lo)).ToString("X2").PadLeft(4, '0') + ", X {ABX}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.ABY)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = bus.Read((ushort)addr, true); addr++;
                    sInst += "$" + ((ushort)((hi << 8) | lo)).ToString("X2").PadLeft(4, '0') + ", Y {ABY}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.IND)
                {
                    lo = bus.Read((ushort)addr, true); addr++;
                    hi = bus.Read((ushort)addr, true); addr++;
                    sInst += "($" + ((ushort)((hi << 8) | lo)).ToString("X2").PadLeft(4, '0') + ") {IND}";
                }
                else if (LookupTable.Instructions[opcode].AddrMode == AddressingModes.REL)
                {
                    value = bus.Read((ushort)addr, true); addr++;
                    sInst += "$" + value.ToString("X2").PadLeft(2, '0') + " [$" + ((ushort)(addr + value)).ToString("X2").PadLeft(4, '0') + "] {REL}";
                }

                mapLines[line_addr] = sInst;
            }

            return mapLines;
        }
    }
}