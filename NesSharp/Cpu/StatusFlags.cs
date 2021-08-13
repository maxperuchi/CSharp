namespace NesSharp.Cpu
{
    public static class StatusFlags
    {
        public const byte C = (1 << 0); //Carry bit
        public const byte Z = (1 << 1); //Zero
        public const byte I = (1 << 2); //Disable interrupts
        public const byte D = (1 << 3); //Decimal mode - not used in this implementation
        public const byte B = (1 << 4); //Break
        public const byte U = (1 << 5); //Unused
        public const byte V = (1 << 6); //Overflow
        public const byte N = (1 << 7); //Negative
    }
}