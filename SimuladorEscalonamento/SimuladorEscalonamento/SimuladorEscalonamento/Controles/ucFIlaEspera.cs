using System;
using System.Windows.Forms;

namespace SimuladorEscalonamento.Controles
{
    public partial class ucFIlaEspera : UserControl
    {
        private ucFila Fila;
        public void SetarFila(ucFila valor)
        {
            Fila = valor;
        }

        public void AdicionarProcesso(ucProcesso processo)
        {
            processo.ProcessarEvento += processo_ProcessarEvento;
            flpFila.Controls.Add(processo);
            Refresh();
        }

        void processo_ProcessarEvento(object sender, EventArgs e)
        {
            ucProcesso processo = (ucProcesso)sender;
            processo.EmEspera = false;
            flpFila.Controls.Remove(processo);
            Fila.AdicionarProcesso(processo);
        }
        public ucProcesso RetirarProximoProcesso()
        {
            if (flpFila.Controls.Count > 0)
            {
                var p = flpFila.Controls[0] as ucProcesso;

                flpFila.Controls.Remove(p);

                return p;
            }
            else
            {
                return null;
            }
        }
        public ucFIlaEspera()
        {
            InitializeComponent();
            flpFila.VerticalScroll.Enabled = false;
            flpFila.VerticalScroll.Visible = false;
            flpFila.WrapContents = false;
            flpFila.HorizontalScroll.Enabled = true;
            flpFila.HorizontalScroll.Visible = true;
        }

        public void Limpa()
        {
            flpFila.Controls.Clear();
        }
    }
}
