using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Forms
{
    public partial class Login : Form
    {
        Form1 form1 = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Empty Username or Password..!!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                SqlCommand command = new SqlCommand($"Select UserName, Password from Staff Where Username = '{txtUsername.Text}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if(txtUsername.Text == reader.GetString(0) && txtPassword.Text == reader.GetString(1))
                    {
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
        }



        private void eyeicon_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
