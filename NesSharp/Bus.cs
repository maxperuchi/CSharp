namespace NesSharp
{
    public class Bus
    {
        public Cpu.Cpu cpu = new Cpu.Cpu();

        public byte[] ram = new byte[(64 * 1024)];

        public Bus()
        {
            for (int i = 0; i < ram.Length; i++)
            {
                ram[i] = 0;
            }

            cpu.ConnectBus(this);
        }

        ~Bus() { }

        public void Write(ushort addr, byte data)
        {
            if (addr >= 0x0000 && addr <= 0xFFFF)
            {
                ram[addr] = data;
            }
        }

        public byte Read(ushort addr, bool bReadOnly = false)
        {
            if (addr >= 0x0000 && addr <= 0xFFFF)
            {
                return ram[addr];
            }
            return 0x00;
        }
    }
}