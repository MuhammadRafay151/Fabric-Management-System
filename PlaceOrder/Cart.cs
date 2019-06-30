using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlaceOrder
{
    public partial class Cart : UserControl
    {
        PlaceOrderController orderController;
        public Cart(PlaceOrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (!orderController.IsCartEmpty())
            {
                orderController.LoadBillToCart(dataGridView1, CustomerId, BillNumberTextBox, textBox1);
                label2.Text = orderController.GetTotalBillAmount(dataGridView1).ToString();
                button1.Enabled = true;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    orderController.RemoveFromCart(e.RowIndex);
                }
                catch { }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //writeorder to database and detect quantity from stock...
            if (dataGridView1.Rows.Count > 1)
            {
                orderController.OrderRecord(dataGridView1, int.Parse(BillNumberTextBox.Text), textBox1.Text);
                dataGridView1.Rows.Clear();
                textBox1.Clear();
                BillNumberTextBox.Clear();
                label2.ResetText();
            }
            else
            {
                MessageBox.Show("Empty Cart");
            }
            
        }
    }
}
