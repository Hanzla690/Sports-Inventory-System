using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Forms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";

        private void eyeicon_Click(object sender, EventArgs e)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
             if(!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
                MessageBox.Show("Password cannot be less than 8 characters");

        }


        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((string)txtSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtSalary.Clear();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("Select Username from Staff", connection);
            SqlDataReader reader = command.ExecuteReader();
            string email;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtSalary.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(dob.Text))
            {
                MessageBox.Show("Fields cannot be empty");
                connection.Close();
            }
            else
            {
                while (reader.Read())
                {
                    email = reader.GetString(0);
                    if (email == txtEmail.Text)
                    {
                        MessageBox.Show("User already exists!");
                        connection.Close();
                        return;
                    }
                }
                reader.Close();
                SqlCommand command2 = new SqlCommand($"Insert into Staff values('{txtEmail.Text}', '{txtPassword.Text}', '{txtName.Text}', '{txtSalary.Text}', '{DateTime.Today.ToString("yyyy/MM/dd")}', '{dob.Value.ToString("yyyy/MM/dd")}', '{txtAddress.Text}')",connection);
                command2.ExecuteNonQuery();
                txtName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtSalary.Clear();
                txtAddress.Clear();
                MessageBox.Show("User added succesfully");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
