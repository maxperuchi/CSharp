using System.Windows.Forms;
namespace Max.Framework.Controls.Editors
{
    public partial class MaxEditorText : MaxEditorBase
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
                var value = EditorControls["txtValue"].Text as object;
                return value;
            }
        }

        public MaxEditorText()
        {
            InitializeComponent();
        }

        public MaxEditorText(string displayName, string propName, object propValue) : this()
        {
            this.displayName = displayName;
            this.propName = propName;
            this.propValue = propValue;

            ShowValues();
        }
        private void ShowValues()
        {
            Text = displayName;

            EditorControls.Add(new TextBox() { Name = "txtValue",Text = propValue.ToString() });
        }
    }
}
