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
    public partial class ServicesData : Form
    {
        public ServicesData()
        {
            InitializeComponent();
            getServiceData();

        }
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        DataTable dataTable = new DataTable();

        private void getServiceData()
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand("select Customer.Cus_Name,Customer.Phone_no, Serv_Name, Serv_Cost, Accept_date, Deliver_Date from Services\r\njoin Customer\r\non Customer.Cus_ID = Services.Cus_ID", connection);
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            ServiceTbl.DataSource = dataTable;
            connection.Close();
        }

        private void ServiceDate_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();
            SqlCommand command = new SqlCommand($"select Customer.Cus_Name,Customer.Phone_no, Serv_Name, Serv_Cost, Accept_date, Deliver_Date from Services\r\njoin Customer\r\non Customer.Cus_ID = Services.Cus_ID where Accept_date = '{ServiceDate.Value.ToString("yyyy/MM/dd")}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                dataTable.Clear();
                dataTable.Load(reader);
                ServiceTbl.DataSource = dataTable;
            }
            else
            {
                dataTable.Clear();
            }
            connection.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            getServiceData();
        }
    }
}
