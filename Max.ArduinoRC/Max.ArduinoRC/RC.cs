using System;
using System.IO.Ports;
namespace Max.ArduinoRC
{
    public class RC : IDisposable
    {
        private SerialPort serialPort;
        private string lastCommand;
        private bool isFarolOn;

        public RC(string port)
        {
            serialPort = new SerialPort(port);
            serialPort.Open();
            serialPort.BaudRate = 9600;
        }

        public void Acelerar()
        {
            if (lastCommand != "F")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "F";
                    serialPort.Write("F");
                }
            }
        }
        public void Esquerda()
        {
            if (lastCommand != "E")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "E";
                    serialPort.Write("E");
                }
            }
        }

        public void Direita()
        {
            if (lastCommand != "D")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "D";
                    serialPort.Write("D");
                }
            }
        }

        public void Tras()
        {
            if (lastCommand != "R")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "R";
                    serialPort.Write("R");
                }
            }
        }

        public void Centralizar()
        {
            if (lastCommand != "C")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "C";
                    serialPort.Write("C");
                }
            }
        }

        public void Parar()
        {
            if (lastCommand != "P")
            {
                if (serialPort.IsOpen)
                {
                    lastCommand = "P";
                    serialPort.Write("P");
                }
            }
        }


        public void Dispose()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        internal void Farois()
        {
            if (serialPort.IsOpen)
            {
                if (!isFarolOn)
                {
                    serialPort.Write("L");
                }
                else
                {
                    serialPort.Write("A");
                }
                isFarolOn = !isFarolOn;

            }
        }
    }
}
