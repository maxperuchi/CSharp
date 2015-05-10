using System.Windows.Forms;

namespace SimuladorEscalonamento.Controles
{
    public partial class ucFIlaEspera : UserControl, IFila
    {
        public void AdicionarProcesso(ucProcesso processo)
        {
            flpFila.Controls.Add(processo);
            Refresh();
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

        public void Limpar()
        {
            flpFila.Controls.Clear();
        }

        public void RemoverProcesso(ucProcesso processo)
        {
            flpFila.Controls.Remove(processo);
            Refresh();
        }
    }
}
