namespace DBProject.Forms
{
    partial class PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.CompanyChoice = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.AddItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.orderTable = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTxt.Location = new System.Drawing.Point(32, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(188, 20);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.Leave += new System.EventHandler(this.SearchTxt_Leave);
            // 
            // CompanyChoice
            // 
            this.CompanyChoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompanyChoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompanyChoice.FormattingEnabled = true;
            this.CompanyChoice.Location = new System.Drawing.Point(275, 20);
            this.CompanyChoice.Name = "CompanyChoice";
            this.CompanyChoice.Size = new System.Drawing.Size(121, 21);
            this.CompanyChoice.TabIndex = 1;
            this.CompanyChoice.Leave += new System.EventHandler(this.CompanyChoice_Leave);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(539, 344);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 19);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Total:";
            // 
            // Total
            // 
            this.Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(586, 344);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 5;
            // 
            // AddItem
            // 
            this.AddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItem.Animated = true;
            this.AddItem.AnimatedGIF = true;
            this.AddItem.AutoRoundedCorners = true;
            this.AddItem.BorderRadius = 11;
            this.AddItem.BorderThickness = 1;
            this.AddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItem.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddItem.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(441, 16);
            this.AddItem.Margin = new System.Windows.Forms.Padding(2);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(97, 25);
            this.AddItem.TabIndex = 7;
            this.AddItem.Text = "ADD";
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Animated = true;
            this.btnConfirm.AnimatedGIF = true;
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BorderRadius = 11;
            this.btnConfirm.BorderThickness = 1;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(543, 377);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 25);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(585, 344);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "00.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.AnimatedGIF = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 11;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(543, 66);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(97, 25);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "REMOVE";
            this.guna2Button1.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.orderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderTable.ColumnHeadersHeight = 25;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.Location = new System.Drawing.Point(32, 56);
            this.orderTable.Name = "orderTable";
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.Size = new System.Drawing.Size(507, 336);
            this.orderTable.TabIndex = 11;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderTable.ThemeStyle.HeaderStyle.Height = 25;
            this.orderTable.ThemeStyle.ReadOnly = false;
            this.orderTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderTable.ThemeStyle.RowsStyle.Height = 22;
            this.orderTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderTable_CellValueChanged);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(645, 415);
            this.Controls.Add(this.orderTable);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CompanyChoice);
            this.Controls.Add(this.SearchTxt);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox CompanyChoice;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Total;
        private Guna.UI2.WinForms.Guna2Button AddItem;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView orderTable;
    }
}