using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inlämingsuppgift_1__Databaser
{
    public partial class FormDeleteAd : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada = new SqlDataAdapter();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        public void ConnectionAndSelectPass()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Users WHERE Password = '" + textBoxDeleteConfirm.Text + "'", con);
        }

        public FormDeleteAd()
        {
            InitializeComponent();
            con = new SqlConnection(_sqlConnectString);

            ada = new SqlDataAdapter("SELECT p.ID, p.Titel, p.Description, p.Price, c.CategorieTypes, u.Username FROM Products p " +
            "INNER JOIN Users u " +
            "On p.UserID=u.ID INNER JOIN Categories c On p.CategoriesID=c.CategoriesID", con);
            
            DataTable dt = new DataTable();
            ada.Fill(dt);

            dataGridViewShow.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
                    cmd = new SqlCommand("Delete from Products where ID=" + id + "", con);
                    cmd.ExecuteNonQuery();
                    dataGridViewShow.Rows.RemoveAt(dataGridViewShow.SelectedRows[0].Index);

                    MessageBox.Show("Advert deleted");
                }
                else
                {
                    MessageBox.Show("You need to confirm your password or incorrect password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();            
        }

        private void buttonDeleteConfirm_Click(object sender, EventArgs e)
        {
            ConnectionAndSelectPass();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {                
                    MessageBox.Show("Correct password, you can now delete your advert");                
            }
            else
            {
                MessageBox.Show("Incorrect password, please try again");
            }
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            loggedIn back = new loggedIn();
            back.ShowDialog();
        }
    }
}
