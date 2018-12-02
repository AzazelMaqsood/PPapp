using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_B_Administration
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(string Text, string Key, bool Checked)
        {
            key = Key;
            value = Text;
            InitializeComponent();
            todolbl.Text = Text;
            check.Checked = Checked;
        }

        private void check_OnChange(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                todolbl.Font = new Font(todolbl.Font.Name, todolbl.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                todolbl.Font = new Font(todolbl.Font.Name, todolbl.Font.SizeInPoints, FontStyle.Regular);
            }

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void todo_item_Load(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                todolbl.Font = new Font(todolbl.Font.Name, todolbl.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                todolbl.Font = new Font(todolbl.Font.Name, todolbl.Font.SizeInPoints, FontStyle.Regular);
            }

        }

        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;
        public string key = null;
        public string value = null;

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }
    }
}
