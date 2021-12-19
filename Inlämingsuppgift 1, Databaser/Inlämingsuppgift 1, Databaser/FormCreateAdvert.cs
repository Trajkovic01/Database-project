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
    public partial class createAdvert : Form
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        string category;
        int loggedInMember;
     
        public void CmdDisp()
        {
            con.Open();
            string q = "Select CategorieTypes, CategoriesID FROM Categories";
            cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCategori.Items.Add(dr["CategorieTypes"].ToString());
                comboBoxCategori.DisplayMember = dr["CategorieTypes"].ToString();
                comboBoxCategori.ValueMember = dr["categoriesID"].ToString();

            }
            con.Close();
        }     

        public createAdvert()
        {
            InitializeComponent();
            con = new SqlConnection(_sqlConnectString);

            CmdDisp();
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                cmd = new SqlCommand("SELECT ID From Users where Password = '" + textBoxPassword.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.Read())
                {
                    loggedInMember = Convert.ToInt32(reader["ID"]);

                    cmd = new SqlCommand("insert into Products(Titel, Description, Price, CategoriesID, UserID) Values ('" + textBoxTitel.Text + "','" + textBoxDesc.Text + "'," + textBoxPrice.Text.ToString() + "," + category + " , " +loggedInMember+ ")", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Advert has been created!");
                }
                else
                {
                    MessageBox.Show("Wrong password! Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                                           
            con.Close();
        }
     
        private void comboBoxCategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            string query = "SELECT CategoriesID from Categories where CategorieTypes = '" + comboBoxCategori.SelectedItem + "'";

            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                category = dr[0].ToString();
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
