using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace profile
{
    public partial class StitchingBillVIew : UserControl
    {
        StitchingOrderLineItem[] order;
        StitchingOrder transaction;
        public StitchingBillVIew(StitchingOrderLineItem[] order,StitchingOrder transaction)
        {
            InitializeComponent();
            this.order = order;
            this.transaction = transaction;
            BillDataGridView.Rows.Clear();
        }
        public StitchingBillVIew() { }

        private void StitchingBillVIew_Load(object sender, EventArgs e)
        {
            BillNumberTextBox.Text = order[0].BillNo;
            BillIssueDate.Text= transaction.BillIssueDate;
            label2.Text = transaction.amount.ToString();
            BillDataGridView.Rows.Add(order.Length);
            for (int i = 0; i < order.Length; i++)
            {
                BillDataGridView.Rows[i].Cells[0].Value = order[i].quantity;
                BillDataGridView.Rows[i].Cells[1].Value = order[i].designcode;
                BillDataGridView.Rows[i].Cells[2].Value = order[i].DesignName;
                BillDataGridView.Rows[i].Cells[3].Value = order[i].Stitching_PieceType;
                BillDataGridView.Rows[i].Cells[4].Value = order[i].NumberOfPieces;
                BillDataGridView.Rows[i].Cells[5].Value = order[i].rate;
                BillDataGridView.Rows[i].Cells[6].Value = order[i].amount;

                if (order[i].OrderReceiveStatus == true)
                    BillDataGridView.Rows[i].Cells[7].Value = "Yes";
                else
                    BillDataGridView.Rows[i].Cells[7].Value = "No";
                BillDataGridView.Rows[i].Cells[8].Value = DateTime.Parse(order[i].receivingdate).ToShortDateString();
                if (!string.IsNullOrWhiteSpace(order[i].imagepath))
                    BillDataGridView.Rows[i].Cells[9].Value = Image.FromFile(order[i].imagepath);
            }
        }
    }
}
