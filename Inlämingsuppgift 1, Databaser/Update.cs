using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Linq;

namespace Inlämingsuppgift_1__Databaser
{
    public partial class FormUpdate : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada = new SqlDataAdapter();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        string category;
        int indexRow;
        
        public void ConnectionAndSelectPass()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Users WHERE password = '" + textBoxUpdateConfirm.Text + "'";
            cmd.ExecuteNonQuery();
        }

        public FormUpdate()
        {
            InitializeComponent();
            con = new SqlConnection(_sqlConnectString);

            ada = new SqlDataAdapter("SELECT p.ID, p.Titel, p.Description, p.Price, c.CategorieTypes, u.Username FROM Products p " +
            "INNER JOIN Users u " +
            "On p.UserID=u.ID INNER JOIN Categories c On p.CategoriesID=c.CategoriesID", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridViewShow.DataSource = dt;

            con.Open();
            string q = "Select CategorieTypes, CategoriesID FROM Categories";
            cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCat.Items.Add(dr["CategorieTypes"].ToString());
                comboBoxCat.DisplayMember = dr["CategorieTypes"].ToString();
                comboBoxCat.ValueMember = dr["categoriesID"].ToString();
            }
            con.Close();
        }

        private void buttonDeleteConfirm_Click(object sender, EventArgs e)
        {
            ConnectionAndSelectPass();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Correct password, you can update your advert");                
            }
            else
            {
                MessageBox.Show("Incorrect password, please try again");
            }
            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selected = dataGridViewShow.SelectedCells[0].RowIndex;
            DataGridViewRow dgr = dataGridViewShow.Rows[selected];
            string id = dgr.Cells[0].Value.ToString();

            try
            {
                ConnectionAndSelectPass();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DataGridViewRow newDataRow = dataGridViewShow.Rows[indexRow];

                    newDataRow.Cells[1].Value = textBoxTitel.Text;
                    newDataRow.Cells[2].Value = textBoxDesc.Text;
                    newDataRow.Cells[3].Value = textBoxPrice.Text;
                    newDataRow.Cells[4].Value = comboBoxCat.Text;

                    cmd = new SqlCommand("Update Products SET Titel = '" + textBoxTitel.Text + "', Description='" + textBoxDesc.Text + "', Price='" + textBoxPrice.Text.ToString() + "', CategoriesID='" + category + "' WHERE ID='" + id + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Rows updated successfully");
                }
                else
                {
                    MessageBox.Show("Incorrect password, plesae try again");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            string query = "SELECT CategoriesID from Categories where CategorieTypes = '" + comboBoxCat.SelectedItem + "'";

            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                category = dr[0].ToString();
            }
            con.Close();
        }

        private void dataGridViewShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridViewShow.Rows[indexRow];

            textBoxTitel.Text = row.Cells[1].Value.ToString();
            textBoxDesc.Text = row.Cells[2].Value.ToString();
            textBoxPrice.Text = row.Cells[3].Value.ToString();
            comboBoxCat.Text = row.Cells[4].Value.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            loggedIn back = new loggedIn();
            back.ShowDialog();
        }
    }
}
