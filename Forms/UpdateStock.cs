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
using static System.Net.Mime.MediaTypeNames;

namespace DBProject.Forms
{
    public partial class UpdateStock : Form
    {
        String conStr = "Data Source=DESKTOP-M6JB41I\\SQLEXPRESS;Initial Catalog=SportsDB;User ID=Test;Password=Hello123";
        int IDval, Priceval, Quantityval;
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            updateStockTable();
        }

        private void updateStockTable()
        {
            SqlConnection con = new SqlConnection(conStr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Stock", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string price = row.Cells["Item_Price"].Value.ToString();
            string id = row.Cells["Item_ID"].Value.ToString();
            txtPrice.Text = price;
            txtID.Text = id;
            Priceval = int.Parse(price);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPrice.Clear();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPrice.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else if (txtPrice.Text == Priceval.ToString())
            {
                MessageBox.Show("Same values can't be added");
            }
            else if (txtPrice.Text == "0")
            {
                MessageBox.Show("Price cannot be 0");
                txtPrice.Clear();
            }
            else
            {
                String sql = "Update Stock Set Item_Price = '" + txtPrice.Text + "' Where Item_ID = '" + txtID.Text + "'";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Item Updated Succesfully");
                con.Close();
                updateStockTable();

            }
        }

    }
}
