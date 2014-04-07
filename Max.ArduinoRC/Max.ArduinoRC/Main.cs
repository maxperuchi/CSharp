using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace Max.ArduinoRC
{
    public partial class Main : Form
    {
        private RC rc;
        private bool isParado;
        public Main()
        {
            InitializeComponent();
            GetSerialPorts();
        }

        private void GetSerialPorts()
        {
            cboPort.DataSource = SerialPort.GetPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            rc = new RC(cboPort.Text);
            cboPort.Enabled = false;
            btnConnect.Enabled = false;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (rc != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        {
                            if (isParado)
                            {
                                rc.Acelerar();
                            }
                            else
                            {
                                rc.Parar();
                            }
                            isParado = !isParado;
                            break;
                        }
                    case Keys.Down:
                        {
                            if (isParado)
                            {
                                rc.Tras();
                            }
                            else
                            {
                                rc.Parar();
                            }
                            isParado = !isParado;
                            break;
                        }
                    case Keys.Left:
                        {
                            rc.Esquerda();
                            break;
                        }
                    case Keys.Right:
                        {
                            rc.Direita();
                            break;
                        }
                    case Keys.F:
                        {
                            rc.Farois();
                            break;
                        }
                }
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (rc != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        {
                            rc.Centralizar();
                            break;
                        }
                    case Keys.Right:
                        {
                            rc.Centralizar();
                            break;
                        }
                }
            }
        }
    }
}
