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
    public partial class UserControl1 : UserControl
    {
        CustomerOrderLineItem[] order;
        CustomerOrder Transactions;
        public UserControl1(CustomerOrderLineItem[] order, CustomerOrder Transactions)
        {
            InitializeComponent();
            this.order = order;
            this.Transactions = Transactions;
            dataGridView1.Rows.Clear();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //double x = 0;
            BillNumberTextBox.Text = order[0].BillNo.ToString();
            textBox1.Text = Transactions.PurchaseDate;
            dataGridView1.Rows.Add(order.Length);
            for (int i = 0; i < order.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = order[i].Quantity;
                dataGridView1.Rows[i].Cells[1].Value = order[i].ProductId;
                dataGridView1.Rows[i].Cells[2].Value = order[i].ProductName;
                dataGridView1.Rows[i].Cells[3].Value = order[i].Rate;
                dataGridView1.Rows[i].Cells[4].Value = order[i].Amount;
              //  x += order[i].Amount;

            }
            label2.Text = Transactions.TotalAmount.ToString();
        }
    }
}
