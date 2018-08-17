using Max8.Core;
using System;
using System.Windows.Forms;

namespace Max8.Main
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            IVideoOut videoOut = new Max8.WinFormsScreen.Screen();
            videoOut.Initialize();

            var chip8 = new Chip8();
            chip8.Initialize();
            LoadProgram(chip8);

            while (true)
            {
                chip8.EmulateCycle();

                if (chip8.DrawFlag)
                {
                    videoOut.Draw(chip8.GFX);
                }

                chip8.SetKeys();
            }
        }

        private static void LoadProgram(Chip8 chip8)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    chip8.Load(ofd.FileName);
                }
            }
        }
    }
}
