using CommandPattern.Core;
using System.Linq;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Principal : Form
    {
        private readonly ICommand[] comandos;

        public Principal()
        {
            InitializeComponent();

            comandos = new ICommand[]
            {
                new LigarVentiladorCommand(Ventilador),
                new DesligarVentiladorCommand(Ventilador),
                new LigarLuzCommand(Ventilador),
                new DesligarLuzCommand(Ventilador)
            };

            cboSw1Off.DataSource = comandos.ToList();
            cboSw1Off.SelectedItem = comandos.First(c => c.GetType() == typeof(DesligarVentiladorCommand));

            cboSw1On.DataSource = comandos.ToList();
            cboSw1On.SelectedItem = comandos.First(c => c.GetType() == typeof(LigarVentiladorCommand));

            cboSw2Off.DataSource = comandos.ToList();
            cboSw2Off.SelectedItem = comandos.First(c => c.GetType() == typeof(DesligarLuzCommand));

            cboSw2On.DataSource = comandos.ToList();
            cboSw2On.SelectedItem = comandos.First(c => c.GetType() == typeof(LigarLuzCommand));
        }

        private void btnOn1_Click(object sender, System.EventArgs e)
        {
            ((ICommand)cboSw1On.SelectedItem).Execute();
        }

        private void btnOff1_Click(object sender, System.EventArgs e)
        {
            ((ICommand)cboSw1Off.SelectedItem).Execute();
        }

        private void btnOn2_Click(object sender, System.EventArgs e)
        {
            ((ICommand)cboSw2On.SelectedItem).Execute();
        }

        private void btnOff2_Click(object sender, System.EventArgs e)
        {
            ((ICommand)cboSw2Off.SelectedItem).Execute();
        }
    }
}
