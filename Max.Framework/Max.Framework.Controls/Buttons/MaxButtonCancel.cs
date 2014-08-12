using Max.Framework.Controls.Properties;
namespace Max.Framework.Controls.Buttons
{
    public partial class MaxButtonCancel : MaxButtonBase
    {
        public MaxButtonCancel()
        {
            InitializeComponent();
            Image = Resources.Cancel;
            Size = new System.Drawing.Size(90,30);
        }
        public override string Text
        {
            get
            {
                return "Cancelar";
            }
            set
            {

            }
        }
    }
}
