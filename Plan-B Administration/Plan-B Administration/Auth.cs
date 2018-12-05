using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net;
using Bcrypt = BCrypt.Net.BCrypt;


namespace Plan_B_Administration
{
    public partial class Auth : MaterialSkin.Controls.MaterialForm
    {
        public Auth()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager SkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Auth_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=MAHNO;Initial Catalog=PlanBadmin;" + "Integrated Security=true;");
            string CPass = Bcrypt.HashPassword(txtPassword.Text, "$2a$11$fhmmGItQBp5ncDeCSnDPG/");
            string query = "Select * from Admin Where Login ='" + txtUsername.Text.Trim() + "' and Password = '" + CPass.Remove(50, 10) + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Main main = new Main();
                this.Hide();
                main.Show();

            }
            else
            {
                MessageBox.Show("Перепроверьте введеный вами логин и пароль");
            }
        }
    }
}
