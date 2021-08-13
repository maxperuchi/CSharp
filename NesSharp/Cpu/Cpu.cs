using System;

namespace NesSharp.Cpu
{
    public class Cpu
    {
        public byte a = 0x00;
        public byte x = 0x00;
        public byte y = 0x00;
        public byte stkp = 0x00;
        public ushort pc = 0x0000;
        public byte status = 0x00;
        public byte fetched = 0x00;
        public ushort addr_abs = 0x0000;
        public ushort addr_rel = 0x00;
        public byte opcode = 0x00;
        public byte cycles = 0;

        private Bus bus = null;

        public Cpu() { }

        ~Cpu() { }

        public void ConnectBus(Bus bus)
        {
            this.bus = bus;
        }

        public byte Read(ushort addr)
        {
            return bus.Read(addr, false);
        }

        public void Write(ushort addr, byte data)
        {
            bus.Write(addr, data);
        }

        public byte GetFlag(byte f)
        {
            return ((status & f) > 0) ? (byte)1 : (byte)0;
        }

        public bool Complete()
        {
            return cycles == 0;
        }

        public void SetFlag(byte f, bool v)
        {
            if (v)
            {
                status |= f;
            }
            else
            {
                status &= (byte)(~f);
            }
        }

        public byte Fetch()
        {
            if (!(LookupTable.Instructions[opcode].AddrMode == AddressingModes.IND))
            {
                fetched = Read(addr_abs);
            }
            return fetched;
        }

        public void Clock()
        {
            if (cycles == 0)
            {
                opcode = Read(pc);
                pc++;

                cycles = LookupTable.Instructions[opcode].Cycles;

                byte additional_cycle1 = LookupTable.Instructions[opcode].AddrMode.Invoke(this);

                byte additional_cycle2 = LookupTable.Instructions[opcode].Operation.Invoke(this);

                cycles += (byte)(additional_cycle1 & additional_cycle2);
            }
            cycles--;
        }

        public void Reset()
        {
            // Get address to set program counter to
            addr_abs = 0xFFFC;
            ushort lo = Read((ushort)(addr_abs + 0));
            ushort hi = Read((ushort)(addr_abs + 1));

            // Set it
            pc = (ushort)((hi << 8) | lo);

            // Reset internal registers
            a = 0;
            x = 0;
            y = 0;
            stkp = 0xFD;
            status = 0x00 | (byte)StatusFlags.U;

            // Clear internal helper variables
            addr_rel = 0x0000;
            addr_abs = 0x0000;
            fetched = 0x00;

            // Reset takes time
            cycles = 8;
        }

        public void Irq()
        {
            // If interrupts are allowed
            if (GetFlag(StatusFlags.I) == 0)
            {
                // Push the program counter to the stack. It's 16-bits dont
                // forget so that takes two pushes
                Write((ushort)(0x0100 + stkp), (byte)((pc >> 8) & 0x00FF));
                stkp--;
                Write((ushort)(0x0100 + stkp), (byte)(pc & 0x00FF));
                stkp--;

                // Then Push the status register to the stack
                SetFlag(StatusFlags.B, false);
                SetFlag(StatusFlags.U, true);
                SetFlag(StatusFlags.I, true);
                Write((ushort)(0x0100 + stkp), (byte)status);
                stkp--;

                // Read new program counter location from fixed address
                addr_abs = 0xFFFE;
                ushort lo = Read((ushort)(addr_abs + 0));
                ushort hi = Read((ushort)(addr_abs + 1));
                pc = (ushort)((hi << 8) | lo);

                // IRQs take time
                cycles = 7;
            }
        }

        public void Nmi()
        {
            Write((ushort)(0x0100 + stkp), (byte)((pc >> 8) & 0x00FF));
            stkp--;
            Write((ushort)(0x0100 + stkp), (byte)(pc & 0x00FF));
            stkp--;

            SetFlag(StatusFlags.B, false);
            SetFlag(StatusFlags.U, true);
            SetFlag(StatusFlags.I, true);
            Write((ushort)(0x0100 + stkp), status);
            stkp--;

            addr_abs = 0xFFFA;
            ushort lo = Read((ushort)(addr_abs + 0));
            ushort hi = Read((ushort)(addr_abs + 1));
            pc = (ushort)((hi << 8) | lo);

            cycles = 8;
        }
    }
}