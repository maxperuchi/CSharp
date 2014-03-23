using System.Windows.Forms;
namespace VUMeter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            _trayIcon.Visible = true;
            _trayIcon.Click += _trayIcon_Click;
            this.Visible = false;

            Program.CoreController.VUControllers.ForEach(v => v.Start());

        }

        void _trayIcon_Click(object sender, System.EventArgs e)
        {
            Program.CoreController.VUControllers.ForEach(v => v.Stop());
            Application.Exit();
        }

        private void Main_Shown(object sender, System.EventArgs e)
        {
            this.Hide();
        }
    }
}
