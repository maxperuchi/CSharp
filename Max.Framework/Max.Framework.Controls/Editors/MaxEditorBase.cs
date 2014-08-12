using System.Windows.Forms;

namespace Max.Framework.Controls.Editors
{
    public partial class MaxEditorBase : UserControl
    {
        public virtual string PropName
        {
            get
            {
                return null;
            }
        }

        public virtual object PropValue
        {
            get
            {
                return null;
            }
        }

        public override string Text
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public ControlCollection EditorControls
        {
            get
            {
                return pnlControls.Controls;
            }
        }

        public MaxEditorBase()
        {
            InitializeComponent();
        }
    }
}
