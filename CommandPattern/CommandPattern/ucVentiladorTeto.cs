using CommandPattern.Core;
using CommandPattern.Properties;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class ucVentiladorTeto : UserControl, IVentiladorComLuz
    {
        private EstadoVentiladorTeto estado = EstadoVentiladorTeto.Parado;

        public bool VentiladorLigado
        {
            get
            {
                return estado == EstadoVentiladorTeto.Girando || estado == EstadoVentiladorTeto.GirandoLuz;
            }

            set
            {
                if (value)
                {
                    if (estado == EstadoVentiladorTeto.ParadoLuz)
                    {
                        estado = EstadoVentiladorTeto.GirandoLuz;
                    }
                    else if (estado == EstadoVentiladorTeto.Parado)
                    {
                        estado = EstadoVentiladorTeto.Girando;
                    }
                }
                else
                {
                    if (estado == EstadoVentiladorTeto.GirandoLuz)
                    {
                        estado = EstadoVentiladorTeto.ParadoLuz;
                    }
                    else if (estado == EstadoVentiladorTeto.Girando)
                    {
                        estado = EstadoVentiladorTeto.Parado;
                    }
                }

                Redraw();
            }
        }

        public bool LuzLigada
        {
            get
            {
                return estado == EstadoVentiladorTeto.GirandoLuz || estado == EstadoVentiladorTeto.ParadoLuz;
            }

            set
            {
                if (value)
                {
                    if (estado == EstadoVentiladorTeto.Girando)
                    {
                        estado = EstadoVentiladorTeto.GirandoLuz;
                    }
                    else if (estado == EstadoVentiladorTeto.Parado)
                    {
                        estado = EstadoVentiladorTeto.ParadoLuz;
                    }
                }
                else
                {
                    if (estado == EstadoVentiladorTeto.GirandoLuz)
                    {
                        estado = EstadoVentiladorTeto.Girando;
                    }
                    else if (estado == EstadoVentiladorTeto.ParadoLuz)
                    {
                        estado = EstadoVentiladorTeto.Parado;
                    }
                }

                Redraw();
            }
        }

        public ucVentiladorTeto()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Redraw()
        {
            switch (estado)
            {
                case EstadoVentiladorTeto.Parado:
                    {
                        BackgroundImage = Resources.fanstopped;
                        break;
                    }
                case EstadoVentiladorTeto.ParadoLuz:
                    {
                        BackgroundImage = Resources.fanstoppedlight;
                        break;
                    }
                case EstadoVentiladorTeto.Girando:
                    {
                        BackgroundImage = Resources.fanspinning;
                        break;
                    }
                case EstadoVentiladorTeto.GirandoLuz:
                    {
                        BackgroundImage = Resources.fanspinninglight;
                        break;
                    }
            }
        }
    }
}
