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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
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
            orderTable.DataSource = dataTable;
        }
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        DataTable dataTable = new DataTable();
        int Price;


        private void AutoComplete()
        {
            SearchTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            SearchTxt.AutoCompleteCustomSource = collection;
            con.Close();
        }

        private void SearchTxt_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            String query = "Select Company From Stock where Item_name = '"+SearchTxt.Text+"'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                String company = reader.GetString(0);
                CompanyChoice.Items.Add(company);
            }
            con.Close();
        }

        private void CompanyChoice_Leave(object sender, EventArgs e)
        {
            CompanyChoice.Items.Clear();
        }

        private void orderTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = orderTable.Rows[e.RowIndex];
            if (checkInput(row))
            {
                if (e.ColumnIndex == orderTable.Columns["Quantity"].Index)
                {
                    object newQuantity = row.Cells["Quantity"].Value;
                    SqlConnection con = new SqlConnection(conStr);
                    int id = int.Parse(row.Cells["Item_ID"].Value.ToString());
                    int price = 0;
                    String query = "Select Item_Price, Item_quantity From Stock Where Item_ID = '" + id + "'";
                    con.Open();
                    SqlCommand com = new SqlCommand(query, con);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(newQuantity) <= Convert.ToInt32(reader["Item_quantity"]))
                        {
                            price = reader.GetInt32(0);
                            if (!string.IsNullOrEmpty(row.Cells["Price"].Value.ToString()) || !string.IsNullOrEmpty(row.Cells["Quantity"].Value.ToString()))
                            {
                                row.Cells["Price"].Value = price * int.Parse(row.Cells["Quantity"].Value.ToString());
                                orderTable.Refresh();
                                Price = 0;
                                for (int i = 0; i < dataTable.Rows.Count; i++)
                                {

                                    Price = Price + Convert.ToInt32(dataTable.Rows[i]["Price"]);
                                }

                                lblTotal.Text = Price.ToString();
                            }
                        }
                        else
                        {
                            row.Cells["Quantity"].Value = 1;
                            MessageBox.Show("Item cannot be added, Current Quantity: '" + (int)reader["Item_quantity"] + "'");
                        }

                    }
                    con.Close();
                }
            }
        }

        private void AddItem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            String query = "Select Item_ID, Item_Name, Company, Item_Price as Price, 1 as Quantity, Item_quantity From Stock Where Item_Name = '" + SearchTxt.Text + "' AND Company = '" + CompanyChoice.Text + "'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            int val = 0;
            bool itemExists = false;
            while (reader.Read())
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (Convert.ToInt32(row["Item_ID"]) == Convert.ToInt32(reader["Item_ID"]))
                    {
                        itemExists = true;
                        MessageBox.Show("Item already exists in the table");
                        goto label;
                    }
                }
                val = (int)reader["Item_quantity"];
                if (val > 0 && !itemExists)
                {
                    object[] values = new object[reader.FieldCount - 1];
                    reader.GetValues(values);
                    dataTable.Rows.Add(values);
                    Price = 0;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Price = Price + Convert.ToInt32(dataTable.Rows[i]["Price"]);
                    }

                    lblTotal.Text = Price.ToString();
                    orderTable.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Item cannot be added, Current Quantity: '" + val + "'");
                }

            }
        label:
            SearchTxt.Clear();
            CompanyChoice.Items.Clear();
            orderTable.ClearSelection();
            CompanyChoice.Text = string.Empty;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            if (dataTable.Rows.Count != 0)
            {
                int Orderid = 0;
                connection.Open();
                SqlCommand command2 = new SqlCommand("Select Order_ID from Orders", connection);
                SqlDataReader reader = command2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Orderid = (int)reader.GetValue(0);
                    }
                    Orderid += 1;
                }
                else
                {
                    Orderid = 1;
                }
                reader.Close();
                String date = DateTime.Now.ToString("yyyy/MM/dd");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    SqlCommand command3 = new SqlCommand("Insert Into Orders Values('" + Orderid + "', '" + dataTable.Rows[i]["Item_ID"].ToString() + "', '" + dataTable.Rows[i]["Quantity"].ToString() + "', '" + date + "')", connection);
                    command3.ExecuteNonQuery();
                }
                MessageBox.Show("Order Placed Successfully");
                Total.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid Order");
            }
            dataTable.Clear();
            connection.Close();

        }

        private bool checkInput(DataGridViewRow row)
        {
            object newQuantity = row.Cells["Quantity"].Value;
            if (System.Text.RegularExpressions.Regex.IsMatch((string)newQuantity, "[^0-9]"))
            {
                MessageBox.Show("Please enter only valid numbers.");
                row.Cells["Quantity"].Value = 1;
                return false;
            }
            else if(newQuantity.ToString() == "0")
            {
                MessageBox.Show("Quantity cannot be 0");
                row.Cells["Quantity"].Value = 1;
                return false;
            }
            return true;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int amountToRemove = 0;

            if (orderTable.SelectedRows.Count > 0)
            {
                DataGridViewRow row = orderTable.SelectedRows[0];
                amountToRemove = int.Parse(row.Cells[3].Value.ToString());
                DataRow[] rowToRemove = dataTable.Select("Item_ID = '" + row.Cells["Item_ID"].Value.ToString() + "'");
                dataTable.Rows.Remove(rowToRemove[0]);
                orderTable.DataSource = dataTable;
                orderTable.ClearSelection();
                Price -= amountToRemove;
                lblTotal.Text = Price.ToString();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
