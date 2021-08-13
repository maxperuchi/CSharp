using System;

namespace NesSharp.Cpu
{
    public static class AddressingModes
    {
        public static byte IMP(Cpu cpu)
        {
            cpu.fetched = cpu.a;
            return 0;
        }

        public static byte IMM(Cpu cpu)
        {
            cpu.addr_abs = cpu.pc++;
            return 0;
        }

        public static byte ZP0(Cpu cpu)
        {
            cpu.addr_abs = cpu.Read(cpu.pc);
            cpu.pc++;
            cpu.addr_abs &= 0x00FF;
            return 0;
        }

        public static byte ZPX(Cpu cpu)
        {
            cpu.addr_abs = (ushort)(cpu.Read(cpu.pc) + (byte)cpu.x);
            cpu.pc++;
            cpu.addr_abs &= 0x00FF;
            return 0;
        }

        public static byte ZPY(Cpu cpu)
        {
            cpu.addr_abs = (ushort)(cpu.Read(cpu.pc) + (byte)cpu.y);
            cpu.pc++;
            cpu.addr_abs &= 0x00FF;
            return 0;
        }

        public static byte ABS(Cpu cpu)
        {
            ushort lo = cpu.Read(cpu.pc);
            cpu.pc++;
            ushort hi = cpu.Read(cpu.pc);
            cpu.pc++;

            cpu.addr_abs = (ushort)((hi << 8) | lo);

            return 0;
        }

        public static byte ABX(Cpu cpu)
        {
            ushort lo = cpu.Read(cpu.pc);
            cpu.pc++;
            ushort hi = cpu.Read(cpu.pc);
            cpu.pc++;

            cpu.addr_abs = (ushort)((hi << 8) | lo);
            cpu.addr_abs += (byte)cpu.x;

            if ((cpu.addr_abs & 0xFF00) != (hi << 8))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static byte ABY(Cpu cpu)
        {
            ushort lo = cpu.Read(cpu.pc);
            cpu.pc++;
            ushort hi = cpu.Read(cpu.pc);
            cpu.pc++;

            cpu.addr_abs = (ushort)((hi << 8) | lo);
            cpu.addr_abs += (byte)cpu.y;

            if ((cpu.addr_abs & 0xFF00) != (hi << 8))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static byte IND(Cpu cpu)
        {
            ushort ptr_lo = cpu.Read(cpu.pc);
            cpu.pc++;
            ushort ptr_hi = cpu.Read(cpu.pc);
            cpu.pc++;

            ushort ptr = (ushort)((ptr_hi << 8) | ptr_lo);

            if (ptr_lo == 0x00FF) // simulate page boundary hardware bug
            {
                cpu.addr_abs = (ushort)((cpu.Read((ushort)(ptr & 0xFF00)) << 8) | cpu.Read((ushort)(ptr + 0)));
            }
            else // behave normally
            {
                cpu.addr_abs = (ushort)((cpu.Read((ushort)(ptr + 1)) << 8) | cpu.Read((ushort)(ptr + 0)));
            }

            return 0;
        }

        public static byte IZX(Cpu cpu)
        {
            ushort t = cpu.Read(cpu.pc);
            cpu.pc++;

            ushort lo = cpu.Read((ushort)((t + (ushort)cpu.x) & 0x00FF));
            cpu.pc++;

            ushort hi = cpu.Read((ushort)((t + (ushort)cpu.x + 1) & 0x00FF));
            cpu.pc++;

            cpu.addr_abs = (ushort)((hi << 8) | lo);

            return 0;
        }

        public static byte IZY(Cpu cpu)
        {
            ushort t = cpu.Read(cpu.pc);
            cpu.pc++;

            ushort lo = cpu.Read((ushort)(t & 0x00FF));

            ushort hi = cpu.Read((ushort)((t + (byte)1) & 0x00FF));

            cpu.addr_abs = (ushort)((hi << 8) | lo);
            cpu.addr_abs += ((byte)cpu.y);

            if ((cpu.addr_abs & 0xFF00) != (hi << 8))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static byte REL(Cpu cpu)
        {
            cpu.addr_rel = cpu.Read(cpu.pc);
            cpu.pc++;

            if (Convert.ToBoolean((ushort)(cpu.addr_rel & 0x80)))
            {
                cpu.addr_rel |= 0xFF00;
            }

            return 0;
        }
    }
}