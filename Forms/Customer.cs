using Guna.UI2.WinForms;
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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into Customer(Cus_Name, Phone_no, Email) Values('" + txtCusName.Text.ToString()+"', '"+txtPhoneNo.Text.ToString()+"', '"+txtEmail.Text.ToString()+"')", connection);
            if(String.IsNullOrEmpty(txtCusName.Text) || String.IsNullOrEmpty(txtPhoneNo.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Kindly Enter all the Values in All the Fields...!!");
            }
            else if (txtPhoneNo.Text.Length != 11)
            {
                MessageBox.Show("Kindly Enter a valid Phone Number");
            }
            else
            {
                try 
                { 
                    command.ExecuteNonQuery(); 
                } catch (SqlException ex) 
                {
                    MessageBox.Show("Customer already exists");
                }
                txtCusName.Clear();
                txtPhoneNo.Clear();
                txtEmail.Clear();
                MessageBox.Show("Customer added succesfully");
            }
            connection.Close();
            showCusDetails();
        }

        private void showCusDetails() 
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Customer", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            CusDetails.DataSource = table;
            connection.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            showCusDetails();
        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCusName.Text.ToString(), "[^a-zA-Z\\s]"))
            {
                MessageBox.Show("Please enter only valid characters.");
                txtCusName.Clear();
            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text.ToString(), "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhoneNo.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailPattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Clear();
            }
        }
    }
}
