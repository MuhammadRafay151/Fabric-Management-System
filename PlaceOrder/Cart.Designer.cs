namespace PlaceOrder
{
    partial class Cart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.BillNumberTextBox = new System.Windows.Forms.TextBox();
            this.BillNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QunatityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QunatityColumn,
            this.ProductIdColumn,
            this.ProductNameColumn,
            this.RateColumn,
            this.AmountColumn,
            this.DeleteButton});
            this.dataGridView1.Location = new System.Drawing.Point(32, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1023, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CustomerId
            // 
            this.CustomerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.Location = new System.Drawing.Point(37, 47);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(127, 23);
            this.CustomerId.TabIndex = 22;
            this.CustomerId.Text = "Customer Id:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(895, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 27);
            this.textBox1.TabIndex = 26;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Enabled = false;
            this.Date.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(835, 43);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 23);
            this.Date.TabIndex = 25;
            this.Date.Text = "Date";
            // 
            // BillNumberTextBox
            // 
            this.BillNumberTextBox.Enabled = false;
            this.BillNumberTextBox.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTextBox.Location = new System.Drawing.Point(552, 41);
            this.BillNumberTextBox.Name = "BillNumberTextBox";
            this.BillNumberTextBox.Size = new System.Drawing.Size(192, 27);
            this.BillNumberTextBox.TabIndex = 24;
            // 
            // BillNumberLabel
            // 
            this.BillNumberLabel.AutoSize = true;
            this.BillNumberLabel.Enabled = false;
            this.BillNumberLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLabel.Location = new System.Drawing.Point(421, 43);
            this.BillNumberLabel.Name = "BillNumberLabel";
            this.BillNumberLabel.Size = new System.Drawing.Size(120, 23);
            this.BillNumberLabel.TabIndex = 23;
            this.BillNumberLabel.Text = "Bill Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total:";
            // 
            // QunatityColumn
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.QunatityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.QunatityColumn.HeaderText = "Quantity";
            this.QunatityColumn.Name = "QunatityColumn";
            this.QunatityColumn.ReadOnly = true;
            // 
            // ProductIdColumn
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ProductIdColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductIdColumn.HeaderText = "Product ID";
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ProductNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductNameColumn.HeaderText = "ProductName";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // RateColumn
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.RateColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.AmountColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = "Delete";
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.BillNumberTextBox);
            this.Controls.Add(this.BillNumberLabel);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1309, 720);
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox BillNumberTextBox;
        private System.Windows.Forms.Label BillNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QunatityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}
