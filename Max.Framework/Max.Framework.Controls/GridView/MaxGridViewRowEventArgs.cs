using System;

namespace Max.Framework.Controls.GridView
{
    public class MaxGridViewRowEventArgs : EventArgs
    {
        private object item;
        public object Item
        {
            get
            {
                return item;
            }
        }
        public MaxGridViewRowEventArgs(object item)
        {
            this.item = item;
        }
    }
}
