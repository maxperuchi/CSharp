using System;
namespace Max.Framework.Controls.Editors
{
    public class MaxEditorDisplayNameAttribute : Attribute
    {
        private string displayName;

        public string DisplayName
        {
            get
            {
                return displayName;
            }
        }
        public MaxEditorDisplayNameAttribute(string DisplayName)
        {
            this.displayName = DisplayName;
        }
    }
}
