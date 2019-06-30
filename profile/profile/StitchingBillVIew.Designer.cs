namespace profile
{
    partial class StitchingBillVIew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfStitchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPiecesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderReceivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StitchedLotsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BillIssueDate = new System.Windows.Forms.TextBox();
            this.BillIssueDateLabel = new System.Windows.Forms.Label();
            this.BillNumberTextBox = new System.Windows.Forms.TextBox();
            this.BillNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.DesignCodeColumn,
            this.DesignNameColumn,
            this.TypeOfStitchColumn,
            this.NumberOfPiecesColumn,
            this.RateColumn,
            this.AmountColumn,
            this.OrderReceivedColumn,
            this.ReceiveDateColumn,
            this.StitchedLotsImageColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillDataGridView.Location = new System.Drawing.Point(36, 110);
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
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuantityColumn.Frozen = true;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuantityColumn.Width = 85;
            // 
            // DesignCodeColumn
            // 
            this.DesignCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.DesignNameColumn.HeaderText = "Design Name";
            this.DesignNameColumn.Name = "DesignNameColumn";
            this.DesignNameColumn.ReadOnly = true;
            this.DesignNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TypeOfStitchColumn
            // 
            this.TypeOfStitchColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TypeOfStitchColumn.HeaderText = "Stitching\'s & Piece\'s Type";
            this.TypeOfStitchColumn.Name = "TypeOfStitchColumn";
            this.TypeOfStitchColumn.ReadOnly = true;
            this.TypeOfStitchColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeOfStitchColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeOfStitchColumn.Width = 162;
            // 
            // NumberOfPiecesColumn
            // 
            this.NumberOfPiecesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.NumberOfPiecesColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NumberOfPiecesColumn.HeaderText = "Number of Pieces";
            this.NumberOfPiecesColumn.Name = "NumberOfPiecesColumn";
            this.NumberOfPiecesColumn.ReadOnly = true;
            this.NumberOfPiecesColumn.Width = 75;
            // 
            // RateColumn
            // 
            this.RateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.RateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            this.RateColumn.Width = 60;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.AmountColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            // StitchedLotsImageColumn
            // 
            this.StitchedLotsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StitchedLotsImageColumn.HeaderText = "Stitched Lots Image";
            this.StitchedLotsImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.StitchedLotsImageColumn.Name = "StitchedLotsImageColumn";
            this.StitchedLotsImageColumn.ReadOnly = true;
            this.StitchedLotsImageColumn.Width = 95;
            // 
            // BillIssueDate
            // 
            this.BillIssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillIssueDate.Enabled = false;
            this.BillIssueDate.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDate.Location = new System.Drawing.Point(849, 40);
            this.BillIssueDate.Name = "BillIssueDate";
            this.BillIssueDate.Size = new System.Drawing.Size(192, 27);
            this.BillIssueDate.TabIndex = 13;
            // 
            // BillIssueDateLabel
            // 
            this.BillIssueDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillIssueDateLabel.AutoSize = true;
            this.BillIssueDateLabel.Enabled = false;
            this.BillIssueDateLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDateLabel.Location = new System.Drawing.Point(685, 44);
            this.BillIssueDateLabel.Name = "BillIssueDateLabel";
            this.BillIssueDateLabel.Size = new System.Drawing.Size(144, 23);
            this.BillIssueDateLabel.TabIndex = 12;
            this.BillIssueDateLabel.Text = "Bill Issue Date";
            // 
            // BillNumberTextBox
            // 
            this.BillNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillNumberTextBox.Enabled = false;
            this.BillNumberTextBox.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTextBox.Location = new System.Drawing.Point(472, 42);
            this.BillNumberTextBox.Name = "BillNumberTextBox";
            this.BillNumberTextBox.Size = new System.Drawing.Size(192, 27);
            this.BillNumberTextBox.TabIndex = 11;
            // 
            // BillNumberLabel
            // 
            this.BillNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillNumberLabel.AutoSize = true;
            this.BillNumberLabel.Enabled = false;
            this.BillNumberLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLabel.Location = new System.Drawing.Point(341, 44);
            this.BillNumberLabel.Name = "BillNumberLabel";
            this.BillNumberLabel.Size = new System.Drawing.Size(120, 23);
            this.BillNumberLabel.TabIndex = 10;
            this.BillNumberLabel.Text = "Bill Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total:";
            // 
            // StitchingBillVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillIssueDate);
            this.Controls.Add(this.BillIssueDateLabel);
            this.Controls.Add(this.BillNumberTextBox);
            this.Controls.Add(this.BillNumberLabel);
            this.Controls.Add(this.BillDataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StitchingBillVIew";
            this.Size = new System.Drawing.Size(1309, 720);
            this.Load += new System.EventHandler(this.StitchingBillVIew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfStitchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPiecesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderReceivedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDateColumn;
        private System.Windows.Forms.DataGridViewImageColumn StitchedLotsImageColumn;
        private System.Windows.Forms.TextBox BillIssueDate;
        private System.Windows.Forms.Label BillIssueDateLabel;
        private System.Windows.Forms.TextBox BillNumberTextBox;
        private System.Windows.Forms.Label BillNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
