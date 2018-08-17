using Max8.Core;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max8.WinFormsScreen
{
    public partial class Screen : Form, IVideoOut
    {
        private Brush whiteBrush = new SolidBrush(Color.White);

        private Brush blackBrush = new SolidBrush(Color.Black);

        private Size pixelSize = new Size(8, 8);

        private bool[] pixelState = new bool[2048];

        public Screen()
        {
            InitializeComponent();
            this.ClearPixelState();
        }

        public void Draw(byte[] gfx)
        {
            for (int i = 0; i < 2048; i++)
            {
                var pixelState = gfx[i] == Convert.ToByte(true);
                this.SetPixel(i, pixelState);
            }

            this.Invoke(new MethodInvoker(this.Update));
            this.Invoke(new MethodInvoker(this.Refresh));
        }

        private void ClearPixelState()
        {
            for (int x = 0; x < 2048; x++)
            {
                pixelState[x] = false;
            }
        }

        public void SetPixel(int position, bool state)
        {
            if (position < 0 || position > 2048)
            {
                return;
            }

            this.pixelState[position] = state;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int i = 0;

            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < 64; x++, i++)
                {
                    this.PerformDrawPixel(x, y, this.pixelState[i] ? blackBrush : whiteBrush, e);
                }
            }
        }

        private void PerformDrawPixel(int x, int y, Brush brush, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, new Rectangle(new Point(x * 8, y * 8), pixelSize));
        }

        public void Initialize()
        {
            Task mytask = Task.Run(() =>
            {
                this.ShowDialog();
            });
        }
    }
}
