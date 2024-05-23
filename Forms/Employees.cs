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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            LoadTheme();
        }


        public void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Member Added.");
        }

        private void radSalary_CheckedChanged(object sender, EventArgs e)
        {
            modData.Text = "Salary";
        }

        private void radAddress_CheckedChanged(object sender, EventArgs e)
        {
            modData.Text = "Address";
        }

        private void radRole_CheckedChanged(object sender, EventArgs e)
        {
            modData.Text = "Role";
        }
    }
}
