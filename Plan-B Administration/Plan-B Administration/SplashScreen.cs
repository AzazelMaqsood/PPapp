﻿using System;
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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 360)
            {

                timer1.Stop();
                Auth avtoriz = new Auth();
                avtoriz.Show();
                this.Hide();
            }
        }
    }
}
