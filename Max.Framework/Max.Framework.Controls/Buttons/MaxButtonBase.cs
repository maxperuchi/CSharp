using System.Drawing;
using System.Windows.Forms;

namespace Max.Framework.Controls.Buttons
{
    public partial class MaxButtonBase : Button
    {
        public MaxButtonBase()
        {
            SetDefaultSettings();
            Cursor = Cursors.Hand;
            MouseEnter += MaxButtonBase_MouseEnter;
            MouseLeave += MaxButtonBase_MouseLeave;
        }

        void MaxButtonBase_MouseLeave(object sender, System.EventArgs e)
        {
            Font = new Font(Font, FontStyle.Regular);
        }

        void MaxButtonBase_MouseEnter(object sender, System.EventArgs e)
        {
            Font = new Font(Font, FontStyle.Underline);
        }

        private void SetDefaultSettings()
        {
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            BackColor = Color.White;
        }
    }
}
