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
    public partial class FormUpdate : Form
    {

        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada = new SqlDataAdapter();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        public void ConnectionAndSelectPass()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select Password from Users";
        }

        public FormUpdate()
        {
            InitializeComponent();
            con = new SqlConnection(_sqlConnectString);

            ada = new SqlDataAdapter("Select * from Products", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            dataGridViewShow.DataSource = dt;
        }

        private void buttonDeleteConfirm_Click(object sender, EventArgs e)
        {
            ConnectionAndSelectPass();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (textBoxUpdateConfirm.Text.Equals(reader["Password"].ToString()))
                {
                    MessageBox.Show("Correct password, you can update your advert");

                }
                else
                {
                    MessageBox.Show("Incorrect password, please try again");
                }
            }
            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            ConnectionAndSelectPass();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (textBoxUpdateConfirm.Text.Equals(reader["Password"].ToString()))
                {
                    MessageBox.Show("Correct password, you can update your advert");

                }
                else
                {
                    
                }
            }
            con.Close();


        }
    }
}
