using Max.Framework.Controls.EditForm;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Max.Framework.Controls.GridView
{
    [ToolboxItem(true)]
    public partial class MaxGridView : DataGridView
    {
        public event EventHandler<MaxGridViewRowEventArgs> RowUpdated;
        public bool UseEditForm { get; set; }
        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e)
        {
            if (UseEditForm)
            {
                var item = Rows[e.RowIndex].DataBoundItem;
                
                using (var frm = new MaxEditForm(item))
                {
                    frm.ShowDialog();
                }

                Refresh();

                RowUpdated(this, new MaxGridViewRowEventArgs(item));

                return;
            }
            base.OnCellDoubleClick(e);
        }
    }
}
