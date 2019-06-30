namespace profile
{
    partial class CalendarBillView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarBillView));
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.BillIssueDate = new System.Windows.Forms.TextBox();
            this.BillNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfLotsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YardColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderReceivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalendaredLotsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillDataGridView
            // 
            this.BillDataGridView.AllowUserToDeleteRows = false;
            this.BillDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuantityColumn,
            this.TypeOfLotsColumn,
            this.DesignCodeColumn,
            this.DesignNameColumn,
            this.YardColumn,
            this.RateColumn,
            this.AmountColumn,
            this.OrderReceivedColumn,
            this.ReceiveDateColumn,
            this.CalendaredLotsImageColumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillDataGridView.Location = new System.Drawing.Point(45, 112);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.ReadOnly = true;
            this.BillDataGridView.RowHeadersVisible = false;
            this.BillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGridView.Size = new System.Drawing.Size(1221, 566);
            this.BillDataGridView.TabIndex = 2;
            // 
            // BillIssueDate
            // 
            this.BillIssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillIssueDate.Enabled = false;
            this.BillIssueDate.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDate.Location = new System.Drawing.Point(814, 44);
            this.BillIssueDate.Name = "BillIssueDate";
            this.BillIssueDate.Size = new System.Drawing.Size(192, 27);
            this.BillIssueDate.TabIndex = 13;
            // 
            // BillNumberTextBox
            // 
            this.BillNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillNumberTextBox.Enabled = false;
            this.BillNumberTextBox.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTextBox.Location = new System.Drawing.Point(437, 46);
            this.BillNumberTextBox.Name = "BillNumberTextBox";
            this.BillNumberTextBox.Size = new System.Drawing.Size(192, 27);
            this.BillNumberTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 681);
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
            this.label1.Location = new System.Drawing.Point(41, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bill Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Bill Issue Date";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuantityColumn.Width = 85;
            // 
            // TypeOfLotsColumn
            // 
            this.TypeOfLotsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.TypeOfLotsColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeOfLotsColumn.HeaderText = "Fabric Type";
            this.TypeOfLotsColumn.Name = "TypeOfLotsColumn";
            this.TypeOfLotsColumn.ReadOnly = true;
            this.TypeOfLotsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeOfLotsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeOfLotsColumn.Width = 90;
            // 
            // DesignCodeColumn
            // 
            this.DesignCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DesignCodeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DesignCodeColumn.HeaderText = "Design Code";
            this.DesignCodeColumn.Name = "DesignCodeColumn";
            this.DesignCodeColumn.ReadOnly = true;
            this.DesignCodeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DesignCodeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DesignCodeColumn.Width = 115;
            // 
            // DesignNameColumn
            // 
            this.DesignNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DesignNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.DesignNameColumn.HeaderText = "Design Name";
            this.DesignNameColumn.Name = "DesignNameColumn";
            this.DesignNameColumn.ReadOnly = true;
            this.DesignNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // YardColumn
            // 
            this.YardColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.YardColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.YardColumn.HeaderText = "Yard";
            this.YardColumn.Name = "YardColumn";
            this.YardColumn.ReadOnly = true;
            this.YardColumn.Width = 60;
            // 
            // RateColumn
            // 
            this.RateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.RateColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            this.RateColumn.Width = 60;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.AmountColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 80;
            // 
            // OrderReceivedColumn
            // 
            this.OrderReceivedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.OrderReceivedColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderReceivedColumn.HeaderText = "Order Received";
            this.OrderReceivedColumn.Name = "OrderReceivedColumn";
            this.OrderReceivedColumn.ReadOnly = true;
            this.OrderReceivedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderReceivedColumn.Width = 85;
            // 
            // ReceiveDateColumn
            // 
            this.ReceiveDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.ReceiveDateColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ReceiveDateColumn.HeaderText = "Receiving Date";
            this.ReceiveDateColumn.Name = "ReceiveDateColumn";
            this.ReceiveDateColumn.ReadOnly = true;
            this.ReceiveDateColumn.Width = 105;
            // 
            // CalendaredLotsImageColumn
            // 
            this.CalendaredLotsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            this.CalendaredLotsImageColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.CalendaredLotsImageColumn.HeaderText = "Calendared Lots Image";
            this.CalendaredLotsImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CalendaredLotsImageColumn.Name = "CalendaredLotsImageColumn";
            this.CalendaredLotsImageColumn.ReadOnly = true;
            this.CalendaredLotsImageColumn.Width = 138;
            // 
            // CalendarBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillIssueDate);
            this.Controls.Add(this.BillNumberTextBox);
            this.Controls.Add(this.BillDataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CalendarBillView";
            this.Size = new System.Drawing.Size(1309, 720);
            this.Load += new System.EventHandler(this.CalendarBillView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.TextBox BillIssueDate;
        private System.Windows.Forms.TextBox BillNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfLotsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YardColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderReceivedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDateColumn;
        private System.Windows.Forms.DataGridViewImageColumn CalendaredLotsImageColumn;
    }
}
