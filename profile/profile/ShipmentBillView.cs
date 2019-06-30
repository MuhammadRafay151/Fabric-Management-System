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
    public partial class ShipmentBillView : UserControl
    {
        ShipmentOrderLineItem[] order;
        ShipmentOrder Transaction;
        public ShipmentBillView(ShipmentOrderLineItem[] order,ShipmentOrder Transaction)
        {
            InitializeComponent();
            this.order = order;
            this.Transaction = Transaction;
            BillDataGridView.Rows.Clear();
        }
        public ShipmentBillView() { }

        private void ShipmentBillView_Load(object sender, EventArgs e)
        {
            BillNumberTextBox.Text = Transaction.BillNo;
            BillIssueDate.Text = Transaction.BillIssueDate;
            label2.Text = Transaction.amount.ToString();
            BillDataGridView.Rows.Add(order.Length);
            for (int i = 0; i < order.Length; i++)
            {
                BillDataGridView.Rows[i].Cells[0].Value = order[i].quantity;
                BillDataGridView.Rows[i].Cells[1].Value = order[i].Description;
                BillDataGridView.Rows[i].Cells[2].Value = order[i].FabricType;
                BillDataGridView.Rows[i].Cells[3].Value = order[i].yard;
                BillDataGridView.Rows[i].Cells[4].Value = order[i].rate;
                BillDataGridView.Rows[i].Cells[5].Value = order[i].amount;
                if (order[i].OrderReceiveStatus == true)
                    BillDataGridView.Rows[i].Cells[6].Value = "Yes";
                else
                    BillDataGridView.Rows[i].Cells[6].Value = "No";
                BillDataGridView.Rows[i].Cells[7].Value = DateTime.Parse(order[i].receivingdate).ToShortDateString();
                if (!string.IsNullOrWhiteSpace(order[i].imagepath))
                    BillDataGridView.Rows[i].Cells[8].Value = Image.FromFile(order[i].imagepath);
            }
        }
    }
}
