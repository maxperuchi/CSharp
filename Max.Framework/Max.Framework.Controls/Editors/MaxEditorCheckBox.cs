using System.Windows.Forms;
namespace Max.Framework.Controls.Editors
{
    public partial class MaxEditorCheckBox : MaxEditorBase
    {
        private string propName;
        private object propValue;
        private string displayName;

        public override string PropName
        {
            get
            {
                return propName;
            }
        }
        public override object PropValue
        {
            get
            {
                var chkbox = EditorControls["chkValue"] as CheckBox;
                var value = chkbox.Checked as object;

                return value;
            }
        }

        public MaxEditorCheckBox()
        {
            InitializeComponent();
        }

        public MaxEditorCheckBox(string displayName, string propName, object propValue) : this()
        {
            this.displayName = displayName;
            this.propName = propName;
            this.propValue = propValue;

            ShowValues();
        }

        private void ShowValues()
        {
            Text = displayName;

            EditorControls.Add(new CheckBox() { Name ="chkValue", Text = string.Empty, Checked = bool.Parse(propValue.ToString())});
        }
    }
}
