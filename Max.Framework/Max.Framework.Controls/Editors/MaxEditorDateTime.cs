
using System;
using System.Windows.Forms;
namespace Max.Framework.Controls.Editors
{
    public partial class MaxEditorDateTime : MaxEditorBase
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
                var dtp = EditorControls["dtpDate"] as DateTimePicker;
                var value = dtp.Value as object;

                return value;
            }
        }

        public MaxEditorDateTime()
        {
            InitializeComponent();
        }

        public MaxEditorDateTime(string displayName, string propName, object propValue) : this()
        {
            this.displayName = displayName;
            this.propName = propName;
            this.propValue = propValue;

            ShowValues();
        }

        private void ShowValues()
        {
            Text = displayName;

            EditorControls.Add(new DateTimePicker() { 
                Name = "dtpDate", 
                Format = DateTimePickerFormat.Short,
                Value = DateTime.Parse(propValue.ToString()),
                Size = new System.Drawing.Size(100,30)
            });
        }
    }
}
