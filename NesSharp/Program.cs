using System;
using System.Collections.Generic;
using System.Linq;
using NesSharp.Cpu;

namespace NesSharp
{
    class Program
    {
        private static Bus bus = new Bus();

        private static SortedDictionary<ushort, string> mapAsm;

        private static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        private static int GetHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : 55);
        }

        private static void DrawRam(ushort nAddr, int nRows, int nColumns)
        {
            for (int row = 0; row < nRows; row++)
            {
                var sOffset = "$" + nAddr.ToString("X2").PadLeft(4, '0') + ":";
                for (int col = 0; col < nColumns; col++)
                {
                    sOffset += " " + bus.Read(nAddr, true).ToString("X2");
                    nAddr += 1;
                }
                DrawString(sOffset);
            }
        }

        private static void DrawCode()
        {
            var current = mapAsm.AsEnumerable().FirstOrDefault(i => i.Key == bus.cpu.pc);
            var index = mapAsm.AsEnumerable().ToList().IndexOf(current);
            var previous = mapAsm.AsEnumerable().ToList().Skip(index - 20).Take(20).ToList();
            var next = mapAsm.AsEnumerable().ToList().Skip(index + 1).Take(20).ToList();

            DrawString("");
            previous.ForEach(p => DrawString(p.Value));
            DrawString(current.Value, ConsoleColor.Cyan);
            next.ForEach(n => DrawString(n.Value));
        }

        private static void DrawCpu()
        {
            DrawString("STATUS:");
            DrawString("N ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.N)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("V ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.V)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("- ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.U)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("B ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.B)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("D ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.D)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("I ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.I)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("Z ", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.Z)) ? ConsoleColor.Green : ConsoleColor.Red, false);
            DrawString("C", Convert.ToBoolean((byte)(bus.cpu.status & StatusFlags.C)) ? ConsoleColor.Green : ConsoleColor.Red);
            DrawString("PC: $" + bus.cpu.pc.ToString("X2"));
            DrawString("A: $" + bus.cpu.a.ToString("X2") + "  [" + bus.cpu.a.ToString("X2") + "]");
            DrawString("X: $" + bus.cpu.x.ToString("X2") + "  [" + bus.cpu.x.ToString("X2") + "]");
            DrawString("Y: $" + bus.cpu.y.ToString("X2") + "  [" + bus.cpu.y.ToString("X2") + "]");
            DrawString("Stack P: $" + bus.cpu.stkp.ToString());
        }

        private static void DrawString(string text, ConsoleColor? color = null, bool lineBreak = true)
        {
            Console.ForegroundColor = color.HasValue ? color.Value : ConsoleColor.White;
            if (lineBreak)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }
        }

        private static bool Initialize()
        {
            byte[] bytes = StringToByteArrayFastest("A2 0A 8E 00 00 A2 03 8E 01 00 AC 00 00 A9 00 18 6D 01 00 88 D0 FA 8D 02 00 EA EA EA".Replace(" ", ""));

            ushort nOffset = 0x8000;
            foreach (var b in bytes)
            {
                bus.ram[nOffset++] = b;
            }

            // Set Reset Vector
            bus.ram[0xFFFC] = 0x00;
            bus.ram[0xFFFD] = 0x80;

            // Dont forget to set IRQ and NMI vectors if you want to play with those

            // Extract dissassembly
            mapAsm = Disassembler.Disassemble(bus, 0x0000, 0xFFFF);

            // Reset
            bus.cpu.Reset();
            return true;
        }

        private static bool Update()
        {
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            if (keyinfo.Key == ConsoleKey.Spacebar)
            {
                do
                {
                    bus.cpu.Clock();
                }
                while (!bus.cpu.Complete());
            }

            if (keyinfo.Key == ConsoleKey.R)
                bus.cpu.Reset();

            if (keyinfo.Key == ConsoleKey.I)
                bus.cpu.Irq();

            if (keyinfo.Key == ConsoleKey.N)
                bus.cpu.Nmi();

            if (keyinfo.Key == ConsoleKey.Q)
                return false;

            // Draw Ram Page 0x00		
            DrawRam(0x0000, 16, 16);

            DrawString("");
            // Draw Ram Page 0x80	
            DrawRam(0x8000, 16, 16);
            DrawCpu();
            DrawCode();


            DrawString("SPACE = Step Instruction    R = RESET    I = IRQ    N = NMI    Q = QUIT");

            return true;
        }

        static void Main(string[] args)
        {
            if (Initialize())
            {
                while (Update()) { };
            }
        }
    }
}
