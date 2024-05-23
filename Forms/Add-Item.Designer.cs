using System;

namespace DBProject.Forms
{
    partial class AddItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.Company = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddItem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemName.Animated = true;
            this.ItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemName.DefaultText = "";
            this.ItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemName.FillColor = System.Drawing.Color.Transparent;
            this.ItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemName.Location = new System.Drawing.Point(51, 92);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemName.Name = "ItemName";
            this.ItemName.PasswordChar = '\0';
            this.ItemName.PlaceholderText = "Item Name";
            this.ItemName.SelectedText = "";
            this.ItemName.Size = new System.Drawing.Size(200, 29);
            this.ItemName.TabIndex = 0;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // Price
            // 
            this.Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price.Animated = true;
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.DefaultText = "";
            this.Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price.FillColor = System.Drawing.Color.Transparent;
            this.Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price.Location = new System.Drawing.Point(51, 142);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Price.Name = "Price";
            this.Price.PasswordChar = '\0';
            this.Price.PlaceholderText = "Price";
            this.Price.SelectedText = "";
            this.Price.Size = new System.Drawing.Size(200, 29);
            this.Price.TabIndex = 1;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantity.Animated = true;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.DefaultText = "";
            this.Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantity.FillColor = System.Drawing.Color.Transparent;
            this.Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantity.Location = new System.Drawing.Point(51, 194);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quantity.Name = "Quantity";
            this.Quantity.PasswordChar = '\0';
            this.Quantity.PlaceholderText = "Quantity";
            this.Quantity.SelectedText = "";
            this.Quantity.Size = new System.Drawing.Size(200, 29);
            this.Quantity.TabIndex = 2;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // Company
            // 
            this.Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Company.Animated = true;
            this.Company.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Company.DefaultText = "";
            this.Company.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Company.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Company.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Company.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Company.FillColor = System.Drawing.Color.Transparent;
            this.Company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Company.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Company.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Company.Location = new System.Drawing.Point(51, 248);
            this.Company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Company.Name = "Company";
            this.Company.PasswordChar = '\0';
            this.Company.PlaceholderText = "Company";
            this.Company.SelectedText = "";
            this.Company.Size = new System.Drawing.Size(200, 29);
            this.Company.TabIndex = 3;
            this.Company.TextChanged += new System.EventHandler(this.Company_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(51, 274);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(51, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(51, 168);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Location = new System.Drawing.Point(51, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 3);
            this.panel4.TabIndex = 6;
            // 
            // AddItem
            // 
            this.AddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItem.Animated = true;
            this.AddItem.AnimatedGIF = true;
            this.AddItem.AutoRoundedCorners = true;
            this.AddItem.BorderRadius = 16;
            this.AddItem.BorderThickness = 1;
            this.AddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItem.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddItem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(94, 306);
            this.AddItem.Margin = new System.Windows.Forms.Padding(2);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(112, 34);
            this.AddItem.TabIndex = 8;
            this.AddItem.Text = "SUBMIT";
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter A New Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DBProject.Properties.Resources.pngwing_com__4_;
            this.pictureBox1.Location = new System.Drawing.Point(387, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(645, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ItemName);
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox ItemName;
        private Guna.UI2.WinForms.Guna2TextBox Price;
        private Guna.UI2.WinForms.Guna2TextBox Quantity;
        private Guna.UI2.WinForms.Guna2TextBox Company;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button AddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}