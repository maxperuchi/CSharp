using Max.Framework.Controls.Editors;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Max.Framework.Controls.EditForm
{
    public partial class MaxEditForm : Form
    {
        private object item;

        public MaxEditForm()
        {
            InitializeComponent();
        }
        public MaxEditForm(object item) : this()
        {
            this.item = item;
            
            var props = item.GetType().GetProperties();

            CreatePropertiesFields(props);

            Location = Cursor.Position;            
        }

        private void CreatePropertiesFields(System.Reflection.PropertyInfo[] props)
        {
            foreach (var prop in props)
            {
                var typeName = prop.PropertyType.Name;
                var value = prop.GetValue(item);
                string displayName = prop.Name;

                var displayNameAttrib = prop.GetCustomAttributes(true).Where(a => a.GetType() == typeof(MaxEditorDisplayNameAttribute)).FirstOrDefault() as MaxEditorDisplayNameAttribute;
                if (displayNameAttrib != null)
                {
                    displayName = displayNameAttrib.DisplayName;
                }

                switch(typeName)
                {
                    case "String":
                    case "Int32":
                        {
                            var editor = new MaxEditorText(displayName, prop.Name, value);

                            flpEditors.Controls.Add(editor);
                            break;
                        }
                    case "Boolean":
                        {
                            var editor = new MaxEditorCheckBox(displayName, prop.Name, value);

                            flpEditors.Controls.Add(editor);
                            break;
                        }
                    case "DateTime":
                        {
                            var editor = new MaxEditorDateTime(displayName, prop.Name, value);

                            flpEditors.Controls.Add(editor);
                            break;
                        }
                }
            }
        }

        private void UpdateValues()
        {
            var props = item.GetType().GetProperties();

            foreach (MaxEditorBase editor in flpEditors.Controls)
            {
                var prop = props.Where(p => p.Name == editor.PropName).FirstOrDefault();
                switch (prop.PropertyType.Name)
                {
                    case "String":
                        {
                            prop.SetValue(item, editor.PropValue.ToString());
                            break;
                        }
                    case "Int32":
                        {
                            prop.SetValue(item, int.Parse(editor.PropValue.ToString()));
                            break;
                        }
                    case "Boolean":
                        {
                            prop.SetValue(item, bool.Parse(editor.PropValue.ToString()));

                            break;
                        }
                    case "DateTime":
                        {
                            prop.SetValue(item, DateTime.Parse(editor.PropValue.ToString()));

                            break;
                        }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateValues();
            Close();
        }

        private void tlpGrid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Brushes.Black,2),DisplayRectangle);
        }
    }
}
