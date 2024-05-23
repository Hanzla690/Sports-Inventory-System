using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Forms
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Service Description");
            dataTable.Columns.Add("Amount");
            ServicesTbl.DataSource = dataTable;
        }
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        DataTable dataTable = new DataTable();
        int PriceVal = 0;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(PhoneNO.Text) || String.IsNullOrEmpty(ServiceDesc.Text) || String.IsNullOrEmpty(Amount.Text))
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else if (Amount.Text == "0")
            {
                MessageBox.Show("Amount cannot be 0");
            }
            else
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    if(row["Service Description"].ToString() == ServiceDesc.Text)
                    {
                        MessageBox.Show("Item already exists in the table");
                        return;
                    }
                }
                String number = PhoneNO.Text;
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                SqlCommand command = new SqlCommand("Select Cus_Name from Customer where Phone_no = '"+PhoneNO.Text+"'",connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    DataRow row = dataTable.NewRow();
                    row["Customer Name"] = reader.GetValue(0);
                    row["Service Description"] = ServiceDesc.Text;
                    row["Amount"] = Amount.Text;
                    dataTable.Rows.Add(row);
                    ServicesTbl.DataSource = dataTable;
                    if(PhoneNO.Enabled == true)
                    {
                        PhoneNO.Enabled = false;
                    }
                    PriceVal += int.Parse(Amount.Text);
                    Price.Text = PriceVal.ToString();
                    ServiceDesc.Text = String.Empty;
                    Amount.Clear();
                    ServicesTbl.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Customer doesn't exist yet, add customer first");
                    Amount.Clear();
                    PhoneNO.Clear();
                }
            }
        }

        private void AcceptDate_ValueChanged(object sender, EventArgs e)
        {
            DeliverDate.MinDate = AcceptDate.Value;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            if (dataTable.Rows.Count > 0) 
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    SqlCommand command = new SqlCommand($"Insert Into Services(Cus_ID, Serv_Name, Serv_Cost, Accept_Date, Deliver_Date) Select Cus_ID, '{row["Service Description"]}', '{Price.Text.ToString()}', '{AcceptDate.Value.ToString("yyyy/MM/dd")}', '{DeliverDate.Value.ToString("yyyy/MM/dd")}' from Customer Where Phone_no = '{PhoneNO.Text}'", connection);
                    command.ExecuteNonQuery();
                }
                dataTable.Clear();
                MessageBox.Show("Service added succesfully");
                connection.Close();
                Price.Text = string.Empty;
                PhoneNO.Enabled = true;
                PhoneNO.Clear();
                Amount.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Order");
            }
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int amountToRemove = 0;

            if (ServicesTbl.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ServicesTbl.SelectedRows[0];
                amountToRemove = int.Parse(row.Cells[2].Value.ToString());
                DataRow[] rowToRemove = dataTable.Select("[Service Description] = '" + row.Cells["Service Description"].Value.ToString() + "'");
                dataTable.Rows.Remove(rowToRemove[0]);
                ServicesTbl.DataSource = dataTable;
                ServicesTbl.ClearSelection();
                PriceVal -= amountToRemove;
                Price.Text = PriceVal.ToString();
            }
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Amount.Text.ToString(), "[^0-9]"))
            {
                MessageBox.Show("Please enter only valid numbers.");
                Amount.Clear();
            }
        }

        private void PhoneNO_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNO.Text.ToString(), "[^0-9]"))
            {
                MessageBox.Show("Please enter only valid numbers.");
                PhoneNO.Clear();
            }
        }
    }
}
