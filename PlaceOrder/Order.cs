using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entities;

namespace PlaceOrder
{
    public partial class Order : Form
    {
        Cart o1;
        PlaceOrderController orderController;
        public Order(bool HideCArt)
        {//view only contructor....
            InitializeComponent();
            Cart.Hide();
            panel1.Hide();
            orderController = new PlaceOrderController();
            orderController.ReadItems();
            orderController.LoadItemWindow(OrderPanel,true);
            
        }
        public Order(Customer customer)
        {//we will add loop to add multiple controls...
            InitializeComponent();
            orderController = new PlaceOrderController(customer);
            orderController.ReadItems();
            orderController.LoadItemWindow(OrderPanel);
          

        }
        public Order() { }


        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                orderController.UpdateCart();
                button2.Hide();
                o1.Hide();
                o1.Dispose();
                
            }
            catch (NullReferenceException)
            {
                button2.Hide();
                o1.Hide();
                o1.Dispose();
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {//panel2 is used to hold the cart page.
            
            o1 = new Cart(orderController);
            this.Controls.Add(o1);
            o1.Dock = DockStyle.Fill;   
            o1.AutoScroll = true;
            o1.BringToFront();
            button2.Visible = true;

        }
    }
}
