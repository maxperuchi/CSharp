using System;

namespace Max8.Core
{
    public interface IVideoOut
    {
        void Draw(byte[] gfx);
        
        void Initialize();
    }
}
