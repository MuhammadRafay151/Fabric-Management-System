using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceOrder
{
    public partial class ViewItemDetails : Form
    {
        public ViewItemDetails(PlaceOrderController orderController, int CountNum)
        {
            InitializeComponent();
            orderController.LoadDetails(ColorLb, DesignCodeLb, NumberOfPiecesLb, QuantityInStockLb, KameezaFabricLb, ShalwarFabricLb, DupattaFabricLb, EmbdKameezFrontLb, EmbdKameezBackLb, EmbdDupattaLb, EmbdShalwarLb, CountNum,label1);

        }

        private void ViewItemDetails_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
