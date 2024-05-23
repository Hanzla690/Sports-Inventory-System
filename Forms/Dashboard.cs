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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        string conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";

        private void Dashboard_Load(object sender, EventArgs e)
        {
            calculateSales();
            calculateOrderCount();
            calc_OutOfStock();
            mostSellingItem();
        }

        private void calculateSales()
        {
            String saleVal;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand($"exec get_sales '{DateTime.Today.ToString("yyyy/MM/dd")}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            saleVal = reader.GetValue(0).ToString();
            if (string.IsNullOrEmpty(saleVal))
                lblSales.Text = "0";
            else
                lblSales.Text = saleVal;
        }

        private void calculateOrderCount()
        {
            string orderCount;
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand($"exec get_order_count '{DateTime.Today.ToString("yyyy/MM/dd")}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            orderCount = reader.GetValue(0).ToString();
            if (string.IsNullOrEmpty(orderCount))
                MonthlyOrders.Text = "0";
            else
                MonthlyOrders.Text = orderCount;
        }

        private void calc_OutOfStock()
        {
            String query = "select Item_Name,Item_Price,Company,Item_quantity from Stock where Item_quantity=0";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            OutOfStock.DataSource = dataTable;
            con.Close();
        }

        private void mostSellingItem()
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("exec most_selling",connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0);
                string company = reader.GetString(1);
                lblMostSelling.Text = name;
                lblCompany.Text = company;
            }
            else
            {
                lblMostSelling.Text = "None";
                lblCompany.Text = "None";
            }
            connection.Close();
        }
    }
}
