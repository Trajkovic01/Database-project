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
using System.Configuration;

namespace Inlämingsuppgift_1__Databaser
{
    public partial class loggedIn : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        public void CloseForm()
        {
            this.Close();
        }

        public loggedIn()
        {
            InitializeComponent();
            con = new SqlConnection(_sqlConnectString);
        }
    
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Close();
            createAdvert f4 = new createAdvert();
            f4.ShowDialog();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Close();
            FormDeleteAd f5 = new FormDeleteAd();
            f5.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Close();
            FormUpdate f6 = new FormUpdate();
            f6.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            listBoxResults.Items.Clear();
            string myQuery = "SELECT p.Titel, p.Description, p.Price, c.CategorieTypes, u.Username FROM Products p " +
            "INNER JOIN Users u " +
            "On p.UserID=u.ID INNER JOIN Categories c On p.CategoriesID=c.CategoriesID WHERE Titel LIKE '" + textBoxSearch.Text + "%' OR categorieTypes LIKE '" + textBoxSearch.Text + "%'";

            cmd = new SqlCommand(myQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string Titel = reader["Titel"].ToString();
                string Description = reader["Description"].ToString();
                string Price = reader["Price"].ToString();
                string UserID = reader["Username"].ToString();
                string CategorieTypes = reader["CategorieTypes"].ToString();

                listBoxResults.Items.Add(Titel + ", " + Description + ", " + Price + ", " + CategorieTypes + ", " + UserID);
            }
            con.Close();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(listBoxResults.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
