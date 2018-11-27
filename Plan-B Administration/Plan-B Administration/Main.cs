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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

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
    }
}
