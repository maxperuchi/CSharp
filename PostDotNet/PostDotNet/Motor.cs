using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostDotNet
{
    public class Motor
    {
        static private Motor instance;
        static public Motor getInstance()
        {
            if (instance == null)
            {
                instance = new Motor();
            }
            return instance;
        }
        private Motor()
        {
        }
    }
}
