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
    public partial class OrderDetails : Form
    {
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        int OrderID;
        DataTable dataTable = new DataTable();
        public OrderDetails()
        {
            InitializeComponent();
            getOrderData();
        }

        private void getOrderData()
        {
            String query = "select Order_ID, SUM(Stock.Item_Price * Quantity) as 'Total Cost', OrderDate from Orders\r\nJoin Stock \r\non Stock.Item_ID = Orders.Item_ID\r\ngroup by Order_ID, OrderDate";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);

            OrderCost.DataSource = dataTable;
            con.Close();
        }

        private void OrderCost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = OrderCost.Rows[e.RowIndex];
            OrderID = (int)row.Cells["Order_ID"].Value;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            String query = "select order_ID, Stock.Item_name, Orders.Quantity, Stock.Item_Price * Orders.Quantity as 'Cost' from Orders join Stock on Stock.Item_ID = Orders.Item_ID where Orders.Order_ID = '"+OrderID+"'";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            OrderInfo.Visible = true;
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            OrderInfo.DataSource = dataTable;
            con.Close();
        }

        private void OrderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            String query = $"select Order_ID, OrderDate ,SUM(Stock.Item_Price * Quantity) as 'Total Cost' from Orders\r\nJoin Stock \r\non Stock.Item_ID = Orders.Item_ID\r\nwhere OrderDate = '{OrderDatePicker.Value.ToString("yyyy/MM/dd")}'\r\ngroup by Order_ID, OrderDate";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dataTable.Clear();
                dataTable.Load(reader);
                OrderCost.DataSource = dataTable;
            }
            else
            {
                dataTable.Clear();
            }
            con.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            getOrderData();
        }
    }
}
