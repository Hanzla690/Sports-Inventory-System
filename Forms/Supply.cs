using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Forms
{
    public partial class Supply : Form
    {
        public Supply()
        {
            InitializeComponent();
            AutoComplete();
            dataTable.Columns.Add("Item_ID");
            dataTable.Columns.Add("Item_Name");
            dataTable.Columns.Add("Company");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            for (int i = 0; i < 5; i++)
            {
                if (i != 4 && i != 3)
                {
                    dataTable.Columns[i].ReadOnly = true;
                }

            }
            SupplyDetails.DataSource = dataTable;
        }
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        DataTable dataTable = new DataTable();

        private void AutoComplete()
        {
            txtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(conStr);
            String query = "Select Item_name From Stock";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String name = reader.GetString(0);
                collection.Add(name);
            }
            txtItemName.AutoCompleteCustomSource = collection;
            con.Close();
        }

        private void AddItembtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            String query = "Select Item_ID, Item_Name, Company, Item_Price as Price, 1 as Quantity, Item_quantity From Stock Where Item_Name = '" + txtItemName.Text + "' AND Company = '" + comboCompany.Text.ToString() + "'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader readerr = command.ExecuteReader();
            int val = 0;
            bool itemExists = false;
            while (readerr.Read())
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (Convert.ToInt32(row["Item_ID"]) == Convert.ToInt32(readerr["Item_ID"]))
                    {
                        itemExists = true;
                        MessageBox.Show("Item already exists in the table");
                        goto label;
                    }
                }
                val = (int)readerr["Item_quantity"];
                if (!itemExists)
                {

                    object[] values = new object[readerr.FieldCount - 1];
                    readerr.GetValues(values);
                    dataTable.Rows.Add(values);
                    SupplyDetails.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Item cannot be added, Current Quantity: '" + val + "'");
                }

            }
        label:
            txtItemName.Clear();
            comboCompany.Items.Clear();
            comboCompany.Text = string.Empty;
        }

        private void comboCompany_Leave_1(object sender, EventArgs e)
        {
            comboCompany.Items.Clear();
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("Select Company From Stock where Item_name = '" + txtItemName.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String company = reader.GetString(0);
                comboCompany.Items.Add(company);
            }
            connection.Close();
        }

        private void SupplyDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = SupplyDetails.Rows[e.RowIndex];
            if (e.ColumnIndex == SupplyDetails.Columns["Quantity"].Index)
            {
                object newQuantity = row.Cells["Quantity"].Value;
                if (System.Text.RegularExpressions.Regex.IsMatch((string)newQuantity, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only valid numbers.");
                    row.Cells["Quantity"].Value = 1;
                    return;
                }
                else if (newQuantity.ToString() == "0")
                {
                    MessageBox.Show("Quantity cannot be 0");
                    row.Cells["Quantity"].Value = 1;
                    return;
                }
                else
                {
                    SqlConnection con = new SqlConnection(conStr);
                    int id = int.Parse(row.Cells["Item_ID"].Value.ToString());
                    int price = 0;
                    String query = "Select Item_Price, Item_quantity From Stock Where Item_ID = '" + id + "'";
                    con.Open();
                    SqlCommand com = new SqlCommand(query, con);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(newQuantity) > 0)
                        {
                            price = reader.GetInt32(0);
                            if (!string.IsNullOrEmpty(row.Cells["Price"].Value.ToString()) || !string.IsNullOrEmpty(row.Cells["Quantity"].Value.ToString()))
                            {
                                row.Cells["Price"].Value = price * int.Parse(row.Cells["Quantity"].Value.ToString());
                                SupplyDetails.Refresh();
                            }
                        }
                        else
                        {
                            row.Cells["Quantity"].Value = 1;
                            MessageBox.Show("Quantity must be greater than 0");
                        }

                    }
                    con.Close();
                }
                
            }
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            if (dataTable.Rows.Count != 0)
            {
                int Supplyid = 0;
                connection.Open();
                SqlCommand command = new SqlCommand("Select Supp_ID from Supply", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Supplyid = (int)reader.GetValue(0);
                    }
                    Supplyid += 1;
                }
                else
                {
                    Supplyid = 1;
                }
                reader.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    SqlCommand command2 = new SqlCommand("Insert Into Supply Values('" + Supplyid + "', '" + row["Item_ID"].ToString() + "', '" + row["Company"].ToString() + "', '" + row["Price"].ToString() +"' ,'" + row["Quantity"].ToString() + "', '" + ReceiveDate.Text.ToString() + "')", connection);
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("Supply Added Successfully");
            }
            else
            {
                MessageBox.Show("Invalid Supply");
            }
            dataTable.Clear();
            connection.Close();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtItemName.Text.ToString(), "[^a-zA-Z\\s]"))
            {
                MessageBox.Show("Please enter only valid characters.");
                txtItemName.Clear();
            }
        }
    }
}
