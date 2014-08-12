using Max.Framework.Controls.Properties;
namespace Max.Framework.Controls.Buttons
{
    public partial class MaxButtonOK : MaxButtonBase
    {
        public MaxButtonOK()
        {
            InitializeComponent();
            Image = Resources.OK;
            Size = new System.Drawing.Size(60,30);
        }

        public override string Text
        {
            get
            {
                return "OK";
            }
            set
            {
                
            }
        }
    }
}
