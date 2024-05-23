namespace DBProject.Forms
{
    partial class Services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AcceptDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DeliverDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServicesTbl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.PhoneNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceDesc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.RemoveBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptDate
            // 
            this.AcceptDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptDate.Animated = true;
            this.AcceptDate.AutoRoundedCorners = true;
            this.AcceptDate.BorderRadius = 10;
            this.AcceptDate.Checked = true;
            this.AcceptDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AcceptDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AcceptDate.Location = new System.Drawing.Point(465, 38);
            this.AcceptDate.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AcceptDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AcceptDate.Name = "AcceptDate";
            this.AcceptDate.Size = new System.Drawing.Size(161, 23);
            this.AcceptDate.TabIndex = 7;
            this.AcceptDate.Value = new System.DateTime(2023, 6, 3, 23, 52, 23, 67);
            this.AcceptDate.ValueChanged += new System.EventHandler(this.AcceptDate_ValueChanged);
            // 
            // DeliverDate
            // 
            this.DeliverDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeliverDate.Animated = true;
            this.DeliverDate.AutoRoundedCorners = true;
            this.DeliverDate.BorderRadius = 10;
            this.DeliverDate.Checked = true;
            this.DeliverDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeliverDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DeliverDate.Location = new System.Drawing.Point(465, 87);
            this.DeliverDate.Margin = new System.Windows.Forms.Padding(2);
            this.DeliverDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DeliverDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DeliverDate.Name = "DeliverDate";
            this.DeliverDate.Size = new System.Drawing.Size(161, 23);
            this.DeliverDate.TabIndex = 8;
            this.DeliverDate.Value = new System.DateTime(2023, 6, 3, 23, 52, 23, 67);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(327, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Acceptance Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(349, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delivery Date:";
            // 
            // ServicesTbl
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ServicesTbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ServicesTbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ServicesTbl.ColumnHeadersHeight = 25;
            this.ServicesTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesTbl.DefaultCellStyle = dataGridViewCellStyle9;
            this.ServicesTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesTbl.Location = new System.Drawing.Point(21, 164);
            this.ServicesTbl.Margin = new System.Windows.Forms.Padding(2);
            this.ServicesTbl.Name = "ServicesTbl";
            this.ServicesTbl.ReadOnly = true;
            this.ServicesTbl.RowHeadersVisible = false;
            this.ServicesTbl.RowHeadersWidth = 62;
            this.ServicesTbl.RowTemplate.Height = 28;
            this.ServicesTbl.Size = new System.Drawing.Size(365, 222);
            this.ServicesTbl.TabIndex = 11;
            this.ServicesTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesTbl.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServicesTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServicesTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServicesTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServicesTbl.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServicesTbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServicesTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServicesTbl.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServicesTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServicesTbl.ThemeStyle.HeaderStyle.Height = 25;
            this.ServicesTbl.ThemeStyle.ReadOnly = true;
            this.ServicesTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServicesTbl.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServicesTbl.ThemeStyle.RowsStyle.Height = 28;
            this.ServicesTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Services Taken:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(408, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Price:";
            // 
            // Price
            // 
            this.Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Price.Location = new System.Drawing.Point(497, 347);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(49, 17);
            this.Price.TabIndex = 14;
            this.Price.Text = "00.00";
            // 
            // PhoneNO
            // 
            this.PhoneNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNO.DefaultText = "";
            this.PhoneNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNO.FillColor = System.Drawing.Color.Transparent;
            this.PhoneNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNO.Location = new System.Drawing.Point(156, 13);
            this.PhoneNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNO.Name = "PhoneNO";
            this.PhoneNO.PasswordChar = '\0';
            this.PhoneNO.PlaceholderText = "";
            this.PhoneNO.SelectedText = "";
            this.PhoneNO.Size = new System.Drawing.Size(155, 20);
            this.PhoneNO.TabIndex = 0;
            this.PhoneNO.TextChanged += new System.EventHandler(this.PhoneNO_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Phone #:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Service:";
            // 
            // ServiceDesc
            // 
            this.ServiceDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceDesc.FormattingEnabled = true;
            this.ServiceDesc.Items.AddRange(new object[] {
            "Bat Repair",
            "Fiber Application",
            "Bat Handle Fix",
            "Bat Bandage",
            "Football Puncture",
            "Football Air",
            "BasketBall Air",
            "Basketball Tube",
            "Tennis Racket Wires",
            "Badminton Racket Wires",
            "Tennis Racket Grip",
            "Badminton Racket Grip"});
            this.ServiceDesc.Location = new System.Drawing.Point(146, 68);
            this.ServiceDesc.Name = "ServiceDesc";
            this.ServiceDesc.Size = new System.Drawing.Size(141, 21);
            this.ServiceDesc.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(29, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Enter Amount:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBtn.Animated = true;
            this.SubmitBtn.AnimatedGIF = true;
            this.SubmitBtn.AutoRoundedCorners = true;
            this.SubmitBtn.BorderRadius = 15;
            this.SubmitBtn.BorderThickness = 1;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(535, 372);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(101, 32);
            this.SubmitBtn.TabIndex = 20;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.Animated = true;
            this.AddBtn.AnimatedGIF = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BorderRadius = 15;
            this.AddBtn.BorderThickness = 1;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(286, 121);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(101, 32);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(155, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 3);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(141, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 3);
            this.panel2.TabIndex = 23;
            // 
            // Amount
            // 
            this.Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amount.Animated = true;
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.DefaultText = "";
            this.Amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Amount.FillColor = System.Drawing.Color.Transparent;
            this.Amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Amount.Location = new System.Drawing.Point(141, 99);
            this.Amount.Name = "Amount";
            this.Amount.PasswordChar = '\0';
            this.Amount.PlaceholderText = "";
            this.Amount.SelectedText = "";
            this.Amount.Size = new System.Drawing.Size(83, 18);
            this.Amount.TabIndex = 24;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveBtn.Animated = true;
            this.RemoveBtn.AnimatedGIF = true;
            this.RemoveBtn.AutoRoundedCorners = true;
            this.RemoveBtn.BorderRadius = 15;
            this.RemoveBtn.BorderThickness = 1;
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.RemoveBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.Location = new System.Drawing.Point(411, 164);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(101, 32);
            this.RemoveBtn.TabIndex = 25;
            this.RemoveBtn.Text = "REMOVE";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(645, 415);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServiceDesc);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ServicesTbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeliverDate);
            this.Controls.Add(this.AcceptDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNO);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Services";
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker AcceptDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DeliverDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView ServicesTbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Price;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServiceDesc;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox Amount;
        private Guna.UI2.WinForms.Guna2Button RemoveBtn;
    }
}