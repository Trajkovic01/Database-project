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
    public partial class CreateAccount : Form
    {             
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();

        public string _sqlConnectString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
              
        public CreateAccount()
        {
            InitializeComponent();   
            con = new SqlConnection(_sqlConnectString);
        }        

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Mail = textBoxLoginMail.Text;
            user.Password = textBoxLoginPassword.Text;

            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "Select * FROM Users WHERE Mail = '" + user.Mail + "' and Password = '" + user.Password + "'";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {                
                MessageBox.Show("Correct mail and password! You are logged in!");
                this.Hide();
                loggedIn f2 = new loggedIn();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect mail or password, please try again");
            }
            con.Close();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Name = textBoxCreateName.Text;
            user.Lastname = textBoxCreateLastname.Text;
            user.Username = textBoxCreateUserName.Text;
            user.Mail = textBoxCreateMail.Text;
            user.Password = textBoxCreatePassword.Text;
            user.Number = int.Parse(textBoxCreateNumber.Text);
            user.SSN = int.Parse(textBoxCreateSSN.Text);

            con.Open();

            cmd = new SqlCommand("insert into Users values('" + user.Name + "', '" + user.Lastname + "', '" + user.Username +
            "', '" + user.Mail + "', '"+user.Password+"', '"+user.Number.ToString()+"', '"+user.SSN.ToString()+"')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("User has been created!");
            con.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGuest f3 = new formGuest();
            f3.ShowDialog();
        }
    }
    class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Number { get; set; }
        public int SSN { get; set; }
    }

    class Product
    {
        public string Titel { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}
