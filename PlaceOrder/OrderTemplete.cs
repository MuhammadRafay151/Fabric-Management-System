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

namespace PlaceOrder
{
    public partial class OrderTemplete : UserControl
    {
        int quantity = 0;

        int countNum ;
        PlaceOrderController orderController;
        
      
        public OrderTemplete()
        {//dedfault constructor...
            InitializeComponent();




        }

        public OrderTemplete(PlaceOrderController place,int count)
        {
            InitializeComponent();
            this.orderController = place;
            this.countNum = count;
            place.LoadDataItemWindow(pictureBox1, Price,countNum);
            
        }
        public OrderTemplete(PlaceOrderController place, int count,bool hide)
        {//view only code...
            InitializeComponent();
            
            this.orderController = place;
            this.countNum = count;
            button1.Hide();
            place.LoadDataItemWindow(pictureBox1, Price, countNum);
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            ViewItemDetails v1 = new ViewItemDetails(orderController,countNum);
            v1.Show();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        { quantity++;
            Qtytxt.Text = quantity.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(quantity>0)
            {
                quantity--;
                Qtytxt.Text = quantity.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {if (int.Parse(Qtytxt.Text) > orderController.GetProduct(countNum).QUANTITY_IN_STOCK)
            {
                MessageBox.Show(string.Format("Only {0} pieces avilable", orderController.GetProduct(countNum).QUANTITY_IN_STOCK.ToString()));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Qtytxt.Text))
                    orderController.AddToCart(countNum, int.Parse(Qtytxt.Text));
                Qtytxt.Text=string.Empty;
            }
        }
    }
}
