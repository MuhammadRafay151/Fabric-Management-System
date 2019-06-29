using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public  class CustomerOrderLineItem
    {
        public int BillNo { get; set; }
       
        public int Quantity { get; set; }
        public string ProductId { get; set; }

        public string ProductName { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
      
    }
}
