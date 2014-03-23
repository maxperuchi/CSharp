using System.Windows.Forms;
namespace VUMeter
{
    public partial class PBarVU : ProgressBar, IVU
    {
        public PBarVU()
        {
            InitializeComponent();
        }

        delegate void setLevelVUDelegate(int value);

        public void setLevel(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new setLevelVUDelegate(setLevelVU),value);
            }
            else
            {
                setLevelVU(value);
            }
        }

        private void setLevelVU(int value)
        {
            this.Value = value;
        }

        public void setMaxLevel(int value)
        {
            this.Maximum = value;
        }

        public int getMaxLevel()
        {
            return this.Maximum;
        }
    }
}
