using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_B_Administration
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int poss = 10;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            todoCard.Visible = false;
            logomain.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            todoCard.Visible = true;
            logomain.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 52)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 225;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator1.ShowSync(LogoFull);
                //btnMenu.Location = new Point(269, 18);
            }
            else
            {
                LogoAnimator1.Hide(LogoFull);
                sidemenu.Visible = false;
                sidemenu.Width = 52;
                PanelAnimator.ShowSync(sidemenu);
                //btnMenu.Location = new Point(17, 18);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void addItem(string Text,string Key, bool Checked)
        {
            todo_item item = new todo_item(Text, Key, Checked);
            todoPanel.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;
            item.Top = poss;
            poss = (item.Top+item.Height+10);
        }

        private void Item_onDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Задача успешно удалена");
        }

        private void Item_onChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            addItem(txtTaskName.Text, "0", false);
        }

        private void btnSotr_Click(object sender, EventArgs e)
        {
            Sotr sotr = new Sotr();
            sotr.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
}
