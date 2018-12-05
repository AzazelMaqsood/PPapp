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

namespace Plan_B_Administration
{
    public partial class Sotr : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MAHNO;Initial Catalog=PlanBadmin;" + "Integrated Security=true;");
        int Id_sotr = 0;
        System.Data.DataTable dtbl = new System.Data.DataTable();

        public Sotr()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                if (btnAdd.Text == "Добавить")
                {
                    SqlCommand sqlCmd = new SqlCommand("SotrAdd", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Id_sotr", txtId.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@I_sotr", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@F_sotr", txtFam.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@O_sotr", txtOtch.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Dolzhn_sotr", txtDolzhn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email_sotr", txtEmail.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Сотрудник добавлен в базу");



                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("SotrAdd", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id_sotr", Id_sotr);
                    sqlCmd.Parameters.AddWithValue("@I_sotr", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@F_sotr", txtFam.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@O_sotr", txtOtch.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Dolzhn", txtDolzhn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email_sotr", txtEmail.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Данные о сотруднике обновлены");


                }

               
                UpdateDTBL();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка добавления");
            }

            finally
            {
                con.Close();
            }
        }

        void FillDataGridView()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SotrSearch", con);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@I_sotr", txtSearch.Text.Trim());

            sqlDa.Fill(dtbl);
            dgvSotr.DataSource = dtbl;
            dgvSotr.Columns[0].Visible = false;
            con.Close();
        }

        void UpdateDTBL()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MAHNO;Initial Catalog=PlanBadmin;" + "Integrated Security=true;");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Sotr", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Sotr");

            dgvSotr.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Введите параметры поиска");
                }
                else
                {
                    for (int i = 0; i < dgvSotr.RowCount; i++)
                    {
                        dgvSotr.Rows[i].Selected = false;
                        for (int j = 0; j < dgvSotr.ColumnCount; j++)
                            if (dgvSotr.Rows[i].Cells[j].Value != null)
                                if (dgvSotr.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                                {
                                    dgvSotr.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }

                FillDataGridView();
                

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при поиске");
            }
        }
    }
}
