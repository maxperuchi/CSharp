using System;
using System.IO;

namespace Max8.Core
{
    public class Chip8
    {
        byte[] chip8_fontset =
        {
          0xF0, 0x90, 0x90, 0x90, 0xF0, // 0
          0x20, 0x60, 0x20, 0x20, 0x70, // 1
          0xF0, 0x10, 0xF0, 0x80, 0xF0, // 2
          0xF0, 0x10, 0xF0, 0x10, 0xF0, // 3
          0x90, 0x90, 0xF0, 0x10, 0x10, // 4
          0xF0, 0x80, 0xF0, 0x10, 0xF0, // 5
          0xF0, 0x80, 0xF0, 0x90, 0xF0, // 6
          0xF0, 0x10, 0x20, 0x40, 0x40, // 7
          0xF0, 0x90, 0xF0, 0x90, 0xF0, // 8
          0xF0, 0x90, 0xF0, 0x10, 0xF0, // 9
          0xF0, 0x90, 0xF0, 0x90, 0x90, // A
          0xE0, 0x90, 0xE0, 0x90, 0xE0, // B
          0xF0, 0x80, 0x80, 0x80, 0xF0, // C
          0xE0, 0x90, 0x90, 0x90, 0xE0, // D
          0xF0, 0x80, 0xF0, 0x80, 0xF0, // E
          0xF0, 0x80, 0xF0, 0x80, 0x80  // F
        };

        public void EmulateCycle()
        {
            // Fetch opcode
            OpCode = Memory[PC] << 8 | Memory[PC + 1];

            // Process opcode
            this.ProcessOpCode();

            // Update timers
            if (Delay_Timer > 0)
                --Delay_Timer;

            if (Sound_Timer > 0)
            {
                if (Sound_Timer == 1)
                    Console.WriteLine("BEEP!\n");
                --Sound_Timer;
            }
        }

        private void ProcessOpCode()
        {
            // Process opcode
            switch (OpCode & 0xF000)
            {
                case 0x0000:
                    switch (OpCode & 0x000F)
                    {
                        case 0x0000: // 0x00E0: Clears the screen
                            for (int i = 0; i < 2048; ++i)
                                GFX[i] = 0x0;
                            DrawFlag = true;
                            PC += 2;
                            break;

                        case 0x000E: // 0x00EE: Returns from subroutine
                            --SP;           // 16 levels of stack, decrease stack pointer to prevent overwrite
                            PC = Stack[SP]; // Put the stored return address from the stack back into the program counter					
                            PC += 2;        // Don't forget to increase the program counter!
                            break;

                        default:
                            {
                                Console.WriteLine("Unknown opcode: {0}", OpCode);
                                break;
                            }
                    }
                    break;

                case 0x1000: // 0x1NNN: Jumps to address NNN
                    PC = OpCode & 0x0FFF;
                    break;

                case 0x2000: // 0x2NNN: Calls subroutine at NNN.
                    Stack[SP] = PC;         // Store current address in stack
                    ++SP;                   // Increment stack pointer
                    PC = OpCode & 0x0FFF;   // Set the program counter to the address at NNN
                    break;

                case 0x3000: // 0x3XNN: Skips the next instruction if VX equals NN
                    if (V[(OpCode & 0x0F00) >> 8] == (OpCode & 0x00FF))
                        PC += 4;
                    else
                        PC += 2;
                    break;

                case 0x4000: // 0x4XNN: Skips the next instruction if VX doesn't equal NN
                    if (V[(OpCode & 0x0F00) >> 8] != (OpCode & 0x00FF))
                        PC += 4;
                    else
                        PC += 2;
                    break;

                case 0x5000: // 0x5XY0: Skips the next instruction if VX equals VY.
                    if (V[(OpCode & 0x0F00) >> 8] == V[(OpCode & 0x00F0) >> 4])
                        PC += 4;
                    else
                        PC += 2;
                    break;

                case 0x6000: // 0x6XNN: Sets VX to NN.
                    V[(OpCode & 0x0F00) >> 8] = OpCode & 0x00FF;
                    PC += 2;
                    break;

                case 0x7000: // 0x7XNN: Adds NN to VX.
                    V[(OpCode & 0x0F00) >> 8] += OpCode & 0x00FF;
                    PC += 2;
                    break;

                case 0x8000:
                    switch (OpCode & 0x000F)
                    {
                        case 0x0000: // 0x8XY0: Sets VX to the value of VY
                            V[(OpCode & 0x0F00) >> 8] = V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0001: // 0x8XY1: Sets VX to "VX OR VY"
                            V[(OpCode & 0x0F00) >> 8] |= V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0002: // 0x8XY2: Sets VX to "VX AND VY"
                            V[(OpCode & 0x0F00) >> 8] &= V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0003: // 0x8XY3: Sets VX to "VX XOR VY"
                            V[(OpCode & 0x0F00) >> 8] ^= V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0004: // 0x8XY4: Adds VY to VX. VF is set to 1 when there's a carry, and to 0 when there isn't					
                            if (V[(OpCode & 0x00F0) >> 4] > (0xFF - V[(OpCode & 0x0F00) >> 8]))
                                V[0xF] = 1; //carry
                            else
                                V[0xF] = 0;
                            V[(OpCode & 0x0F00) >> 8] += V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0005: // 0x8XY5: VY is subtracted from VX. VF is set to 0 when there's a borrow, and 1 when there isn't
                            if (V[(OpCode & 0x00F0) >> 4] > V[(OpCode & 0x0F00) >> 8])
                                V[0xF] = 0; // there is a borrow
                            else
                                V[0xF] = 1;
                            V[(OpCode & 0x0F00) >> 8] -= V[(OpCode & 0x00F0) >> 4];
                            PC += 2;
                            break;

                        case 0x0006: // 0x8XY6: Shifts VX right by one. VF is set to the value of the least significant bit of VX before the shift
                            V[0xF] = V[(OpCode & 0x0F00) >> 8] & 0x1;
                            V[(OpCode & 0x0F00) >> 8] >>= 1;
                            PC += 2;
                            break;

                        case 0x0007: // 0x8XY7: Sets VX to VY minus VX. VF is set to 0 when there's a borrow, and 1 when there isn't
                            if (V[(OpCode & 0x0F00) >> 8] > V[(OpCode & 0x00F0) >> 4])  // VY-VX
                                V[0xF] = 0; // there is a borrow
                            else
                                V[0xF] = 1;
                            V[(OpCode & 0x0F00) >> 8] = V[(OpCode & 0x00F0) >> 4] - V[(OpCode & 0x0F00) >> 8];
                            PC += 2;
                            break;

                        case 0x000E: // 0x8XYE: Shifts VX left by one. VF is set to the value of the most significant bit of VX before the shift
                            V[0xF] = V[(OpCode & 0x0F00) >> 8] >> 7;
                            V[(OpCode & 0x0F00) >> 8] <<= 1;
                            PC += 2;
                            break;

                        default:
                            {
                                Console.WriteLine("Unknown opcode: {0}", OpCode);
                                break;
                            }
                    }
                    break;

                case 0x9000: // 0x9XY0: Skips the next instruction if VX doesn't equal VY
                    if (V[(OpCode & 0x0F00) >> 8] != V[(OpCode & 0x00F0) >> 4])
                        PC += 4;
                    else
                        PC += 2;
                    break;

                case 0xA000: // ANNN: Sets I to the address NNN
                    I = OpCode & 0x0FFF;
                    PC += 2;
                    break;

                case 0xB000: // BNNN: Jumps to the address NNN plus V0
                    PC = (OpCode & 0x0FFF) + V[0];
                    break;

                case 0xC000: // CXNN: Sets VX to a random number and NN
                    V[(OpCode & 0x0F00) >> 8] = (new Random().Next() % 0xFF) & (OpCode & 0x00FF);
                    PC += 2;
                    break;

                case 0xD000: // DXYN: Draws a sprite at coordinate (VX, VY) that has a width of 8 pixels and a height of N pixels. 
                             // Each row of 8 pixels is read as bit-coded starting from memory location I; 
                             // I value doesn't change after the execution of this instruction. 
                             // VF is set to 1 if any screen pixels are flipped from set to unset when the sprite is drawn, 
                             // and to 0 if that doesn't happen
                    {
                        var x = V[(OpCode & 0x0F00) >> 8];
                        var y = V[(OpCode & 0x00F0) >> 4];
                        var height = OpCode & 0x000F;
                        int pixel;

                        V[0xF] = 0;
                        for (int yline = 0; yline < height; yline++)
                        {
                            pixel = Memory[I + yline];
                            for (int xline = 0; xline < 8; xline++)
                            {
                                if ((pixel & (0x80 >> xline)) != 0)
                                {
                                    if (GFX[(x + xline + ((y + yline) * 64))] == 1)
                                    {
                                        V[0xF] = 1;
                                    }
                                    GFX[x + xline + ((y + yline) * 64)] ^= 1;
                                }
                            }
                        }

                        DrawFlag = true;
                        PC += 2;
                    }
                    break;

                case 0xE000:
                    switch (OpCode & 0x00FF)
                    {
                        case 0x009E: // EX9E: Skips the next instruction if the key stored in VX is pressed
                            if (Key[V[(OpCode & 0x0F00) >> 8]] != 0)
                                PC += 4;
                            else
                                PC += 2;
                            break;

                        case 0x00A1: // EXA1: Skips the next instruction if the key stored in VX isn't pressed
                            if (Key[V[(OpCode & 0x0F00) >> 8]] == 0)
                                PC += 4;
                            else
                                PC += 2;
                            break;

                        default:
                            {
                                Console.WriteLine("Unknown opcode: {0}", OpCode);
                                break;
                            }
                    }
                    break;

                case 0xF000:
                    switch (OpCode & 0x00FF)
                    {
                        case 0x0007: // FX07: Sets VX to the value of the delay timer
                            V[(OpCode & 0x0F00) >> 8] = Delay_Timer;
                            PC += 2;
                            break;

                        case 0x000A: // FX0A: A key press is awaited, and then stored in VX		
                            {
                                bool keyPress = false;

                                for (int i = 0; i < 16; ++i)
                                {
                                    if (Key[i] != 0)
                                    {
                                        V[(OpCode & 0x0F00) >> 8] = i;
                                        keyPress = true;
                                    }
                                }

                                // If we didn't received a keypress, skip this cycle and try again.
                                if (!keyPress)
                                    return;

                                PC += 2;
                            }
                            break;

                        case 0x0015: // FX15: Sets the delay timer to VX
                            Delay_Timer = V[(OpCode & 0x0F00) >> 8];
                            PC += 2;
                            break;

                        case 0x0018: // FX18: Sets the sound timer to VX
                            Sound_Timer = V[(OpCode & 0x0F00) >> 8];
                            PC += 2;
                            break;

                        case 0x001E: // FX1E: Adds VX to I
                            if (I + V[(OpCode & 0x0F00) >> 8] > 0xFFF)  // VF is set to 1 when range overflow (I+VX>0xFFF), and 0 when there isn't.
                                V[0xF] = 1;
                            else
                                V[0xF] = 0;
                            I += V[(OpCode & 0x0F00) >> 8];
                            PC += 2;
                            break;

                        case 0x0029: // FX29: Sets I to the location of the sprite for the character in VX. Characters 0-F (in hexadecimal) are represented by a 4x5 font
                            I = (V[(OpCode & 0x0F00) >> 8] * 0x5);
                            PC += 2;
                            break;

                        case 0x0033: // FX33: Stores the Binary-coded decimal representation of VX at the addresses I, I plus 1, and I plus 2
                            Memory[I] = (V[((OpCode & 0x0F00) >> 8)] / 100);
                            Memory[I + 1] = ((V[((OpCode & 0x0F00) >> 8)] / 10) % 10);
                            Memory[I + 2] = ((V[((OpCode & 0x0F00) >> 8)] % 100) % 10);
                            PC += 2;
                            break;

                        case 0x0055: // FX55: Stores V0 to VX in memory starting at address I					
                            for (int i = 0; i <= ((OpCode & 0x0F00) >> 8); ++i)
                                Memory[I + i] = V[i];

                            // On the original interpreter, when the operation is done, I = I + X + 1.
                            I += (((OpCode & 0x0F00) >> 8) + 1);
                            PC += 2;
                            break;

                        case 0x0065: // FX65: Fills V0 to VX with values from memory starting at address I					
                            for (int i = 0; i <= ((OpCode & 0x0F00) >> 8); ++i)
                                V[i] = Memory[I + i];

                            // On the original interpreter, when the operation is done, I = I + X + 1.
                            I += (((OpCode & 0x0F00) >> 8) + 1);
                            PC += 2;
                            break;

                        default:
                            {
                                Console.WriteLine("Unknown opcode: {0}", OpCode);
                                break;
                            }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Unknown opcode: {0}", OpCode);
                        break;
                    }
            }
        }

        public void SetKeys()
        {
        }

        public int OpCode { get; set; }

        public int[] Memory { get; set; }

        public int[] V { get; set; }

        public int I { get; set; }

        public int PC { get; set; }

        public byte[] GFX { get; set; }

        public int Delay_Timer { get; set; }

        public int Sound_Timer { get; set; }

        public int[] Stack { get; set; }

        public int SP { get; set; }

        public int[] Key { get; set; }

        public bool DrawFlag { get; set; }

        public void Load(string filePath)
        {
            var file = File.ReadAllBytes(filePath);

            for (int i = 0; i < file.Length; ++i)
                Memory[i + 512] = file[i];
        }

        public void Initialize()
        {
            this.Memory = new int[4096];
            this.OpCode = 0;
            this.PC = 0x200;
            this.I = 0;
            this.SP = 0;

            this.V = new int[16];

            this.GFX = new byte[64 * 32];

            this.Stack = new int[16];

            this.Key = new int[16];

            // Clear display
            for (int i = 0; i < 2048; ++i)
                GFX[i] = 0;

            // Clear stack
            for (int i = 0; i < 16; ++i)
                Stack[i] = 0;

            for (int i = 0; i < 16; ++i)
                Key[i] = V[i] = 0;

            // Clear memory
            for (int i = 0; i < 4096; ++i)
                Memory[i] = 0;

            // Load fontset
            for (int i = 0; i < 80; ++i)
                Memory[i] = chip8_fontset[i];

            // Reset timers
            Delay_Timer = 0;
            Sound_Timer = 0;

            // Clear screen once
            DrawFlag = true;
        }
    }
}
