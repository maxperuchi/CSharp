using System.Collections.Generic;

namespace NesSharp.Cpu
{
    public static class LookupTable
    {
        public static List<Instruction> Instructions = new List<Instruction>
            {
                new Instruction { Name = "BRK", Operation = OpCodes.BRK, AddrMode = AddressingModes.IMM, Cycles = 7 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "ASL", Operation = OpCodes.ASL, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "PHP", Operation = OpCodes.PHP, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "ASL", Operation = OpCodes.ASL, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "ASL", Operation = OpCodes.ASL, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BPL", Operation = OpCodes.BPL, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "ASL", Operation = OpCodes.ASL, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "CLC", Operation = OpCodes.CLC, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ORA", Operation = OpCodes.ORA, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "ASL", Operation = OpCodes.ASL, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
                new Instruction { Name = "JSR", Operation = OpCodes.JSR, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "BIT", Operation = OpCodes.BIT, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "ROL", Operation = OpCodes.ROL, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "PLP", Operation = OpCodes.PLP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "ROL", Operation = OpCodes.ROL, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "BIT", Operation = OpCodes.BIT, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "ROL", Operation = OpCodes.ROL, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BMI", Operation = OpCodes.BMI, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "ROL", Operation = OpCodes.ROL, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "SEC", Operation = OpCodes.SEC, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "AND", Operation = OpCodes.AND, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "ROL", Operation = OpCodes.ROL, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
                new Instruction { Name = "RTI", Operation = OpCodes.RTI, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "LSR", Operation = OpCodes.LSR, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "PHA", Operation = OpCodes.PHA, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "LSR", Operation = OpCodes.LSR, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "JMP", Operation = OpCodes.JMP, AddrMode = AddressingModes.ABS, Cycles = 3 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "LSR", Operation = OpCodes.LSR, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BVC", Operation = OpCodes.BVC, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "LSR", Operation = OpCodes.LSR, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "CLI", Operation = OpCodes.CLI, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "EOR", Operation = OpCodes.EOR, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "LSR", Operation = OpCodes.LSR, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
                new Instruction { Name = "RTS", Operation = OpCodes.RTS, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "ROR", Operation = OpCodes.ROR, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "PLA", Operation = OpCodes.PLA, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "ROR", Operation = OpCodes.ROR, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "JMP", Operation = OpCodes.JMP, AddrMode = AddressingModes.IND, Cycles = 5 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "ROR", Operation = OpCodes.ROR, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BVS", Operation = OpCodes.BVS, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "ROR", Operation = OpCodes.ROR, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "SEI", Operation = OpCodes.SEI, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "ADC", Operation = OpCodes.ADC, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "ROR", Operation = OpCodes.ROR, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
                new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "STY", Operation = OpCodes.STY, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "STX", Operation = OpCodes.STX, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "DEY", Operation = OpCodes.DEY, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "TXA", Operation = OpCodes.TXA, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "STY", Operation = OpCodes.STY, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "STX", Operation = OpCodes.STX, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 },
                new Instruction { Name = "BCC", Operation = OpCodes.BCC, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.IZY, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "STY", Operation = OpCodes.STY, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "STX", Operation = OpCodes.STX, AddrMode = AddressingModes.ZPY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "TYA", Operation = OpCodes.TYA, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.ABY, Cycles = 5 }, new Instruction { Name = "TXS", Operation = OpCodes.TXS, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "STA", Operation = OpCodes.STA, AddrMode = AddressingModes.ABX, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 },
                new Instruction { Name = "LDY", Operation = OpCodes.LDY, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "LDX", Operation = OpCodes.LDX, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "LDY", Operation = OpCodes.LDY, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "LDX", Operation = OpCodes.LDX, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 3 }, new Instruction { Name = "TAY", Operation = OpCodes.TAY, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "TAX", Operation = OpCodes.TAX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "LDY", Operation = OpCodes.LDY, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "LDX", Operation = OpCodes.LDX, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 },
                new Instruction { Name = "BCS", Operation = OpCodes.BCS, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "LDY", Operation = OpCodes.LDY, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "LDX", Operation = OpCodes.LDX, AddrMode = AddressingModes.ZPY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "CLV", Operation = OpCodes.CLV, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "TSX", Operation = OpCodes.TSX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "LDY", Operation = OpCodes.LDY, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "LDA", Operation = OpCodes.LDA, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "LDX", Operation = OpCodes.LDX, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 4 },
                new Instruction { Name = "CPY", Operation = OpCodes.CPY, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "CPY", Operation = OpCodes.CPY, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "DEC", Operation = OpCodes.DEC, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "INY", Operation = OpCodes.INY, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "DEX", Operation = OpCodes.DEX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "CPY", Operation = OpCodes.CPY, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "DEC", Operation = OpCodes.DEC, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BNE", Operation = OpCodes.BNE, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "DEC", Operation = OpCodes.DEC, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "CLD", Operation = OpCodes.CLD, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "NOP", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "CMP", Operation = OpCodes.CMP, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "DEC", Operation = OpCodes.DEC, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
                new Instruction { Name = "CPX", Operation = OpCodes.CPX, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.IZX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "CPX", Operation = OpCodes.CPX, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.ZP0, Cycles = 3 }, new Instruction { Name = "INC", Operation = OpCodes.INC, AddrMode = AddressingModes.ZP0, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 5 }, new Instruction { Name = "INX", Operation = OpCodes.INX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.IMM, Cycles = 2 }, new Instruction { Name = "NOP", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.SBC, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "CPX", Operation = OpCodes.CPX, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.ABS, Cycles = 4 }, new Instruction { Name = "INC", Operation = OpCodes.INC, AddrMode = AddressingModes.ABS, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 },
                new Instruction { Name = "BEQ", Operation = OpCodes.BEQ, AddrMode = AddressingModes.REL, Cycles = 2 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.IZY, Cycles = 5 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 8 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.ZPX, Cycles = 4 }, new Instruction { Name = "INC", Operation = OpCodes.INC, AddrMode = AddressingModes.ZPX, Cycles = 6 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 6 }, new Instruction { Name = "SED", Operation = OpCodes.SED, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.ABY, Cycles = 4 }, new Instruction { Name = "NOP", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 2 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.NOP, AddrMode = AddressingModes.IMP, Cycles = 4 }, new Instruction { Name = "SBC", Operation = OpCodes.SBC, AddrMode = AddressingModes.ABX, Cycles = 4 }, new Instruction { Name = "INC", Operation = OpCodes.INC, AddrMode = AddressingModes.ABX, Cycles = 7 }, new Instruction { Name = "???", Operation = OpCodes.XXX, AddrMode = AddressingModes.IMP, Cycles = 7 },
            };
    }
}