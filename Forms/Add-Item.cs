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
using System.Data.Common;
using Guna.UI2.WinForms;

namespace DBProject.Forms
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";

        private bool validateFields(Guna2TextBox name, Guna2TextBox price, Guna2TextBox quantity, Guna2TextBox company)
        {
            if (String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(price.Text) || String.IsNullOrEmpty(quantity.Text) || String.IsNullOrEmpty(company.Text))
            {
                MessageBox.Show("Fields cannot be empty");
                return false;
            }
            else if (Price.Text == "0")
            {
                MessageBox.Show("Price cannot be 0");
                return false;
            }
            else if (Quantity.Text == "0")
            {
                MessageBox.Show("Quantity cannot be 0");
                return false;
            }
            return true;
        }

        private bool validateItems(String name, String comp)
        {
            SqlConnection connection = new SqlConnection(conStr);
            String sql = "Select Item_Name, Company From Stock";
            connection.Open();  
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while(dataReader.Read())
            {
                String ItemName = dataReader.GetString(0);
                String ItemCompany = dataReader.GetString(1);
                if (ItemName == name && ItemCompany == comp)
                {
                    MessageBox.Show("Item Already Exists");
                    connection.Close();
                    return false;
                }
                    
            }
            connection.Close();
            return true;
        }

        private void AddItem_Click_1(object sender, EventArgs e)
        {
            if (validateItems(ItemName.Text.ToString(), Company.Text.ToString()) && validateFields(ItemName, Price, Quantity, Company))
            {
                SqlConnection connection = new SqlConnection(conStr);
                String sql = "Insert into Stock(Item_Name, Item_Price, Item_quantity, Company) Values('" + ItemName.Text.ToString() + "', '" + Price.Text.ToString() + "', '" + Quantity.Text.ToString() + "', '" + Company.Text.ToString() + "')";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Item Added Succesfully");
                ItemName.Clear();
                Price.Clear();
                Quantity.Clear();
                Company.Clear();
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Price.Text.ToString(), "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Price.Clear();
            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Quantity.Text.ToString(), "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Quantity.Clear();
            }
        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ItemName.Text.ToString(), "[^a-zA-Z\\s]"))
            {
                MessageBox.Show("Please enter only valid characters.");
                ItemName.Clear();
            }
        }

        private void Company_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Company.Text.ToString(), "[^a-zA-Z\\s]"))
            {
                MessageBox.Show("Please enter only valid characters.");
                Company.Clear();
            }
        }
    }
}
