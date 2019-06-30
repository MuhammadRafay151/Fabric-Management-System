namespace PuttingOrderForEmbroidery
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PuttingOrderForEmbroideyPanel = new System.Windows.Forms.Panel();
            this.DealerId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BillDataGridView = new System.Windows.Forms.DataGridView();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignCodeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DesignNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderReceivedColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReceiveDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmbroideredLotsImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BillReceivedGroupBox = new System.Windows.Forms.GroupBox();
            this.BillIssueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BillIssueDateLabel = new System.Windows.Forms.Label();
            this.BillNumberTextBox = new System.Windows.Forms.TextBox();
            this.BillNumberLabel = new System.Windows.Forms.Label();
            this.PuttingOrderForEmbroideyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            this.BillReceivedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PuttingOrderForEmbroideyPanel
            // 
            this.PuttingOrderForEmbroideyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.DealerId);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.button1);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.label2);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.label1);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.UpdateButton);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.BillDataGridView);
            this.PuttingOrderForEmbroideyPanel.Controls.Add(this.BillReceivedGroupBox);
            this.PuttingOrderForEmbroideyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PuttingOrderForEmbroideyPanel.ForeColor = System.Drawing.Color.White;
            this.PuttingOrderForEmbroideyPanel.Location = new System.Drawing.Point(0, 0);
            this.PuttingOrderForEmbroideyPanel.Name = "PuttingOrderForEmbroideyPanel";
            this.PuttingOrderForEmbroideyPanel.Size = new System.Drawing.Size(1309, 720);
            this.PuttingOrderForEmbroideyPanel.TabIndex = 0;
            // 
            // DealerId
            // 
            this.DealerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DealerId.AutoSize = true;
            this.DealerId.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerId.Location = new System.Drawing.Point(47, 45);
            this.DealerId.Name = "DealerId";
            this.DealerId.Size = new System.Drawing.Size(96, 23);
            this.DealerId.TabIndex = 20;
            this.DealerId.Text = "Dealer Id:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculate Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(1138, 665);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(119, 39);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BillDataGridView
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.BillDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuantityColumn,
            this.DesignCodeColumn,
            this.DesignNameColumn,
            this.RateColumn,
            this.AmountColumn,
            this.OrderReceivedColumn,
            this.ReceiveDateColumn,
            this.EmbroideredLotsImageColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillDataGridView.Location = new System.Drawing.Point(51, 141);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.BillDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGridView.Size = new System.Drawing.Size(1206, 491);
            this.BillDataGridView.TabIndex = 1;
            this.BillDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDataGridView_CellClick);
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuantityColumn.Width = 85;
            // 
            // DesignCodeColumn
            // 
            this.DesignCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DesignCodeColumn.HeaderText = "Design Code";
            this.DesignCodeColumn.Name = "DesignCodeColumn";
            this.DesignCodeColumn.Width = 115;
            // 
            // DesignNameColumn
            // 
            this.DesignNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DesignNameColumn.HeaderText = "Design Name";
            this.DesignNameColumn.Name = "DesignNameColumn";
            this.DesignNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RateColumn
            // 
            this.RateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.RateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
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
            this.OrderReceivedColumn.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.OrderReceivedColumn.Name = "OrderReceivedColumn";
            this.OrderReceivedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderReceivedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // EmbroideredLotsImageColumn
            // 
            this.EmbroideredLotsImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EmbroideredLotsImageColumn.HeaderText = "Embroidered Lots Image";
            this.EmbroideredLotsImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EmbroideredLotsImageColumn.Name = "EmbroideredLotsImageColumn";
            this.EmbroideredLotsImageColumn.Width = 147;
            // 
            // BillReceivedGroupBox
            // 
            this.BillReceivedGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillReceivedGroupBox.Controls.Add(this.BillIssueDateDateTimePicker);
            this.BillReceivedGroupBox.Controls.Add(this.BillIssueDateLabel);
            this.BillReceivedGroupBox.Controls.Add(this.BillNumberTextBox);
            this.BillReceivedGroupBox.Controls.Add(this.BillNumberLabel);
            this.BillReceivedGroupBox.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillReceivedGroupBox.Location = new System.Drawing.Point(292, 16);
            this.BillReceivedGroupBox.Name = "BillReceivedGroupBox";
            this.BillReceivedGroupBox.Size = new System.Drawing.Size(724, 99);
            this.BillReceivedGroupBox.TabIndex = 0;
            this.BillReceivedGroupBox.TabStop = false;
            this.BillReceivedGroupBox.Text = "Bill Received";
            // 
            // BillIssueDateDateTimePicker
            // 
            this.BillIssueDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.BillIssueDateDateTimePicker.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BillIssueDateDateTimePicker.Location = new System.Drawing.Point(497, 63);
            this.BillIssueDateDateTimePicker.Name = "BillIssueDateDateTimePicker";
            this.BillIssueDateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BillIssueDateDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.BillIssueDateDateTimePicker.TabIndex = 5;
            // 
            // BillIssueDateLabel
            // 
            this.BillIssueDateLabel.AutoSize = true;
            this.BillIssueDateLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIssueDateLabel.Location = new System.Drawing.Point(347, 65);
            this.BillIssueDateLabel.Name = "BillIssueDateLabel";
            this.BillIssueDateLabel.Size = new System.Drawing.Size(144, 23);
            this.BillIssueDateLabel.TabIndex = 4;
            this.BillIssueDateLabel.Text = "Bill Issue Date";
            // 
            // BillNumberTextBox
            // 
            this.BillNumberTextBox.Font = new System.Drawing.Font("Corbert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTextBox.Location = new System.Drawing.Point(134, 63);
            this.BillNumberTextBox.Name = "BillNumberTextBox";
            this.BillNumberTextBox.Size = new System.Drawing.Size(192, 27);
            this.BillNumberTextBox.TabIndex = 3;
            // 
            // BillNumberLabel
            // 
            this.BillNumberLabel.AutoSize = true;
            this.BillNumberLabel.Font = new System.Drawing.Font("Corbert", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLabel.Location = new System.Drawing.Point(3, 65);
            this.BillNumberLabel.Name = "BillNumberLabel";
            this.BillNumberLabel.Size = new System.Drawing.Size(120, 23);
            this.BillNumberLabel.TabIndex = 2;
            this.BillNumberLabel.Text = "Bill Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 720);
            this.Controls.Add(this.PuttingOrderForEmbroideyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PuttingOrderForEmbroideyPanel.ResumeLayout(false);
            this.PuttingOrderForEmbroideyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            this.BillReceivedGroupBox.ResumeLayout(false);
            this.BillReceivedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PuttingOrderForEmbroideyPanel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView BillDataGridView;
        private System.Windows.Forms.GroupBox BillReceivedGroupBox;
        private System.Windows.Forms.DateTimePicker BillIssueDateDateTimePicker;
        private System.Windows.Forms.Label BillIssueDateLabel;
        private System.Windows.Forms.TextBox BillNumberTextBox;
        private System.Windows.Forms.Label BillNumberLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DesignCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrderReceivedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDateColumn;
        private System.Windows.Forms.DataGridViewImageColumn EmbroideredLotsImageColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DealerId;
    }
}

