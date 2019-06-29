using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CustomerOrder
    {
        public CustomerOrder()
        {

        }
        public int BillNo { get; set; }
        public string PurchaseDate { get; set; }
        public double TotalAmount { get; set; }
        public string CustomerId { get; set; }
    }
}
