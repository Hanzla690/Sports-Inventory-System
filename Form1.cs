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
using DBProject.Forms;

namespace DBProject
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //public String dbString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                   
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        } 

        private void btndash_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PlaceOrder(), sender);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Services(), sender);
        }

        private void btnAddDel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddItems(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customer(), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OrderDetails(), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UpdateStock(), sender);
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Supply(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            this.Hide();
        }

        private void btnServicesData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServicesData(), sender);
        }
    }
}
