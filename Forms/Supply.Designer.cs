namespace DBProject.Forms
{
    partial class Supply
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiveDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplyDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddSupply = new Guna.UI2.WinForms.Guna2Button();
            this.AddItembtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brand:";
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceiveDate.Animated = true;
            this.ReceiveDate.AutoRoundedCorners = true;
            this.ReceiveDate.BorderRadius = 10;
            this.ReceiveDate.Checked = true;
            this.ReceiveDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReceiveDate.Location = new System.Drawing.Point(430, 25);
            this.ReceiveDate.Margin = new System.Windows.Forms.Padding(2);
            this.ReceiveDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReceiveDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.Size = new System.Drawing.Size(167, 23);
            this.ReceiveDate.TabIndex = 5;
            this.ReceiveDate.Value = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Receiving Date:";
            // 
            // SupplyDetails
            // 
            this.SupplyDetails.AllowUserToAddRows = false;
            this.SupplyDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SupplyDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplyDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SupplyDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplyDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SupplyDetails.ColumnHeadersHeight = 25;
            this.SupplyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplyDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.SupplyDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplyDetails.Location = new System.Drawing.Point(94, 133);
            this.SupplyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.SupplyDetails.Name = "SupplyDetails";
            this.SupplyDetails.RowHeadersVisible = false;
            this.SupplyDetails.RowHeadersWidth = 62;
            this.SupplyDetails.RowTemplate.Height = 28;
            this.SupplyDetails.Size = new System.Drawing.Size(347, 273);
            this.SupplyDetails.TabIndex = 7;
            this.SupplyDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SupplyDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SupplyDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SupplyDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SupplyDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SupplyDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SupplyDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplyDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplyDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SupplyDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SupplyDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SupplyDetails.ThemeStyle.HeaderStyle.Height = 25;
            this.SupplyDetails.ThemeStyle.ReadOnly = false;
            this.SupplyDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SupplyDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SupplyDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplyDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SupplyDetails.ThemeStyle.RowsStyle.Height = 28;
            this.SupplyDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplyDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SupplyDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyDetails_CellValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(93, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Quantity:-";
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(99, 68);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(150, 21);
            this.comboCompany.TabIndex = 12;
            this.comboCompany.Leave += new System.EventHandler(this.comboCompany_Leave_1);
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Animated = true;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FillColor = System.Drawing.Color.Transparent;
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.Location = new System.Drawing.Point(100, 28);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(149, 19);
            this.txtItemName.TabIndex = 13;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSupply.Animated = true;
            this.btnAddSupply.AnimatedGIF = true;
            this.btnAddSupply.AutoRoundedCorners = true;
            this.btnAddSupply.BorderRadius = 15;
            this.btnAddSupply.BorderThickness = 1;
            this.btnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSupply.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddSupply.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupply.ForeColor = System.Drawing.Color.White;
            this.btnAddSupply.Location = new System.Drawing.Point(453, 374);
            this.btnAddSupply.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(101, 32);
            this.btnAddSupply.TabIndex = 14;
            this.btnAddSupply.Text = "ADD SUPPLY";
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // AddItembtn
            // 
            this.AddItembtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItembtn.Animated = true;
            this.AddItembtn.AnimatedGIF = true;
            this.AddItembtn.AutoRoundedCorners = true;
            this.AddItembtn.BorderRadius = 15;
            this.AddItembtn.BorderThickness = 1;
            this.AddItembtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItembtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItembtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItembtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItembtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItembtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddItembtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItembtn.ForeColor = System.Drawing.Color.White;
            this.AddItembtn.Location = new System.Drawing.Point(339, 95);
            this.AddItembtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddItembtn.Name = "AddItembtn";
            this.AddItembtn.Size = new System.Drawing.Size(101, 32);
            this.AddItembtn.TabIndex = 15;
            this.AddItembtn.Text = "ADD ITEM";
            this.AddItembtn.Click += new System.EventHandler(this.AddItembtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DBProject.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(466, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(659, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddItembtn);
            this.Controls.Add(this.btnAddSupply);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplyDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceiveDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supply";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.SupplyDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReceiveDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView SupplyDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCompany;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2Button btnAddSupply;
        private Guna.UI2.WinForms.Guna2Button AddItembtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}