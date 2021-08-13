using System;

namespace NesSharp.Cpu
{
    public static class OpCodes
    {
        public static byte AND(Cpu cpu)
        {
            cpu.Fetch();
            cpu.a = (byte)(cpu.a & cpu.fetched);
            cpu.SetFlag(StatusFlags.Z, (cpu.a == 0x00));
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean(cpu.a & 0x80));
            return 1;
        }

        public static byte BCS(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.C) == 1)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BCC(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.C) == 1)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BEQ(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.Z) == 1)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BMI(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.N) == 1)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BNE(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.Z) == 0)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BPL(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.N) == 0)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BVC(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.V) == 0)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte BVS(Cpu cpu)
        {
            if (cpu.GetFlag(StatusFlags.V) == 1)
            {
                cpu.cycles++;
                cpu.addr_abs = (ushort)(cpu.pc + cpu.addr_rel);

                if ((cpu.addr_abs & 0xFF00) != (cpu.pc & 0xFF00))
                {
                    cpu.cycles++;
                }

                cpu.pc = cpu.addr_abs;
            }
            return 0;
        }

        public static byte CLC(Cpu cpu)
        {
            cpu.SetFlag(StatusFlags.C, false);
            return 0;
        }

        public static byte CLD(Cpu cpu)
        {
            cpu.SetFlag(StatusFlags.D, false);
            return 0;
        }

        public static byte ADC(Cpu cpu)
        {
            cpu.Fetch();
            ushort temp = (ushort)((ushort)cpu.a + (ushort)cpu.fetched + (ushort)cpu.GetFlag(StatusFlags.C));
            cpu.SetFlag(StatusFlags.C, temp > 255);
            cpu.SetFlag(StatusFlags.Z, (temp & 0x00FF) == 0);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((ushort)(temp & 0x80)));
            cpu.SetFlag(StatusFlags.V, Convert.ToBoolean((ushort)((~((ushort)cpu.a ^ (ushort)cpu.fetched) & ((ushort)cpu.a ^ (ushort)temp)) & 0x0080)));
            cpu.a = (byte)(temp & 0x00FF);
            return 1;
        }

        public static byte SBC(Cpu cpu)
        {
            cpu.Fetch();

            ushort value = (ushort)(((ushort)cpu.fetched) ^ 0x00FF);

            ushort temp = (ushort)((ushort)cpu.a + value + (ushort)cpu.GetFlag(StatusFlags.C));
            cpu.SetFlag(StatusFlags.C, Convert.ToBoolean((ushort)(temp & 0xFF00)));
            cpu.SetFlag(StatusFlags.Z, ((temp & 0x00FF) == 0));
            cpu.SetFlag(StatusFlags.V, Convert.ToBoolean((ushort)((temp ^ (ushort)cpu.a) & (temp ^ value) & 0x0080)));
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((ushort)(temp & 0x0080)));
            cpu.a = (byte)(temp & 0x00FF);
            return 1;
        }

        public static byte RTI(Cpu cpu)
        {
            cpu.stkp++;
            cpu.status = cpu.Read((ushort)(0x0100 + cpu.stkp));
            cpu.status &= StatusFlags.B;
            cpu.status &= StatusFlags.U;
            cpu.stkp++;
            cpu.pc = (ushort)cpu.Read((ushort)(0x0100 + cpu.stkp));
            cpu.stkp++;
            cpu.pc |= (ushort)cpu.Read((ushort)((0x0100 + cpu.stkp) << 8));
            return 0;
        }

        public static byte NOP(Cpu cpu)
        {
            switch (cpu.opcode)
            {
                case 0x1C:
                case 0x3C:
                case 0x5C:
                case 0x7C:
                case 0xDC:
                case 0xFC:
                    return 1;
            }
            return 0;
        }

        public static byte LDY(Cpu cpu)
        {
            cpu.Fetch();
            cpu.y = cpu.fetched;
            cpu.SetFlag(StatusFlags.Z, cpu.y == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((byte)(cpu.y & 0x80)));
            return 1;
        }

        public static byte EOR(Cpu cpu)
        {
            cpu.Fetch();
            cpu.a = (byte)(cpu.a ^ cpu.fetched);
            cpu.SetFlag(StatusFlags.Z, cpu.a == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((byte)(cpu.a & 0x80)));
            return 1;
        }

        public static byte STA(Cpu cpu)
        {
            cpu.Write(cpu.addr_abs, cpu.a);
            return 0;
        }

        public static byte LDA(Cpu cpu)
        {
            cpu.Fetch();
            cpu.a = cpu.fetched;
            cpu.SetFlag(StatusFlags.Z, cpu.a == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((byte)(cpu.a & 0x80)));
            return 1;
        }

        public static byte CMP(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte JMP(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte TSX(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte DEX(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte TAX(Cpu cpu)
        {
            throw new NotImplementedException();
        }
        public static byte TXS(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte TXA(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte SED(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte INX(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte INY(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte CLV(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte TAY(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte TYA(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte JSR(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte RTS(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte SEI(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte SEC(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte CLI(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte PLP(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte PHP(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte INC(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte DEC(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte ROR(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte LSR(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte ROL(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte CPX(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte BIT(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte STY(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte CPY(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte ORA(Cpu cpu)
        {
            throw new NotImplementedException();
        }

        public static byte ASL(Cpu cpu)
        {
            return 0;
        }

        public static byte DEY(Cpu cpu)
        {
            cpu.y--;
            cpu.SetFlag(StatusFlags.Z, cpu.y == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((byte)(cpu.y & 0x80)));
            return 0;
        }

        public static byte PLA(Cpu cpu)
        {
            cpu.stkp++;
            cpu.a = cpu.Read((ushort)(0x0100 + cpu.stkp));
            cpu.SetFlag(StatusFlags.Z, cpu.a == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean(((byte)(cpu.a & 0x80))));
            return 0;
        }

        public static byte PHA(Cpu cpu)
        {
            cpu.Write((ushort)(0x0100 + cpu.stkp), cpu.a);
            cpu.stkp--;
            return 0;
        }

        public static byte STX(Cpu cpu)
        {
            cpu.Write(cpu.addr_abs, cpu.x);
            return 0;
        }

        public static byte XXX(Cpu cpu)
        {
            return 0;
        }

        public static byte LDX(Cpu cpu)
        {
            cpu.Fetch();
            cpu.x = cpu.fetched;
            cpu.SetFlag(StatusFlags.Z, cpu.x == 0x00);
            cpu.SetFlag(StatusFlags.N, Convert.ToBoolean((byte)(cpu.x & 0x80)));
            return 1;
        }

        public static byte BRK(Cpu cpu)
        {
            cpu.pc++;

            cpu.SetFlag(StatusFlags.I, true);
            cpu.Write((ushort)(0x0100 + cpu.stkp), (byte)((cpu.pc >> 8) & 0x00FF));
            cpu.stkp--;
            cpu.Write((ushort)(0x0100 + cpu.stkp), (byte)(cpu.pc & 0x00FF));
            cpu.stkp--;

            cpu.SetFlag(StatusFlags.B, true);
            cpu.Write((ushort)(0x0100 + cpu.stkp), cpu.status);
            cpu.stkp--;
            cpu.SetFlag(StatusFlags.B, false);

            cpu.pc = (ushort)((byte)cpu.Read(0xFFFE) | ((byte)cpu.Read(0xFFFF) << 8));
            return 0;
        }
    }
}