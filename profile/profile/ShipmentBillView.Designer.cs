namespace profile
{
    partial class ShipmentBillView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabricTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderReceivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BillIssueDate = new System.Windows.Forms.TextBox();
            this.BillNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BillIssueDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToDeleteRows = false;
            this.BillDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuantityColumn,
            this.DescriptionColumn,
            this.FabricTypeCol,
            this.YardColumn,
            this.RateColumn,
            this.AmountColumn,
            this.OrderReceivedColumn,
            this.ReceiveDateColumn,
            this.LotsImageColumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillDataGridView.Location = new System.Drawing.Point(48, 111);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            this.BillDataGridView.RowHeadersVisible = false;
            this.BillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGridView.Size = new System.Drawing.Size(1221, 566);
            this.BillDataGridView.TabIndex = 2;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuantityColumn.Width = 85;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FabricTypeCol
            // 
            this.FabricTypeCol.HeaderText = "Fabric Type";
            this.FabricTypeCol.Name = "FabricTypeCol";
            this.FabricTypeCol.ReadOnly = true;
            this.FabricTypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FabricTypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FabricTypeCol.Width = 90;
            // 
            // YardColumn
            // 
            this.YardColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.YardColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.YardColumn.HeaderText = "Yard";
            this.YardColumn.Name = "YardColumn";
            this.YardColumn.ReadOnly = true;
            this.YardColumn.Width = 60;
            // 
            // RateColumn
            // 
            this.RateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.RateColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            this.RateColumn.Width = 60;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.AmountColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 80;
            // 
            // OrderReceivedColumn
            // 
            this.OrderReceivedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderReceivedColumn.HeaderText = "Order Received";
            this.OrderReceivedColumn.Name = "OrderReceivedColumn";
            this.OrderReceivedColumn.ReadOnly = true;
            this.OrderReceivedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderReceivedColumn.Width = 85;
            // 
            // ReceiveDateColumn
            // 
            this.ReceiveDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReceiveDateColumn.HeaderText = "Receiving Date";
            this.ReceiveDateColumn.Name = "ReceiveDateColumn";
            this.ReceiveDateColumn.ReadOnly = true;
            this.ReceiveDateColumn.Width = 105;
            // 
            // LotsImageColumn
            // 
            this.LotsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotsImageColumn.HeaderText = "Lots Image";
            this.LotsImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.LotsImageColumn.Name = "LotsImageColumn";
            this.LotsImageColumn.ReadOnly = true;
            this.LotsImageColumn.Width = 95;
            // 
            // BillIssueDate
            // 
            this.BillIssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillIssueDate.Enabled = false;
            this.BillIssueDate.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDate.Location = new System.Drawing.Point(809, 48);
            this.BillIssueDate.Name = "BillIssueDate";
            this.BillIssueDate.Size = new System.Drawing.Size(192, 27);
            this.BillIssueDate.TabIndex = 13;
            // 
            // BillNumberTextBox
            // 
            this.BillNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillNumberTextBox.Enabled = false;
            this.BillNumberTextBox.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTextBox.Location = new System.Drawing.Point(432, 50);
            this.BillNumberTextBox.Name = "BillNumberTextBox";
            this.BillNumberTextBox.Size = new System.Drawing.Size(192, 27);
            this.BillNumberTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bill Number";
            // 
            // BillIssueDateLabel
            // 
            this.BillIssueDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillIssueDateLabel.AutoSize = true;
            this.BillIssueDateLabel.Enabled = false;
            this.BillIssueDateLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDateLabel.Location = new System.Drawing.Point(650, 54);
            this.BillIssueDateLabel.Name = "BillIssueDateLabel";
            this.BillIssueDateLabel.Size = new System.Drawing.Size(144, 23);
            this.BillIssueDateLabel.TabIndex = 24;
            this.BillIssueDateLabel.Text = "Bill Issue Date";
            // 
            // ShipmentBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.BillIssueDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillIssueDate);
            this.Controls.Add(this.BillNumberTextBox);
            this.Controls.Add(this.BillDataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ShipmentBillView";
            this.Size = new System.Drawing.Size(1309, 720);
            this.Load += new System.EventHandler(this.ShipmentBillView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn YardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderReceivedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDateColumn;
        private System.Windows.Forms.DataGridViewImageColumn LotsImageColumn;
        private System.Windows.Forms.TextBox BillIssueDate;
        private System.Windows.Forms.TextBox BillNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BillIssueDateLabel;
    }
}
