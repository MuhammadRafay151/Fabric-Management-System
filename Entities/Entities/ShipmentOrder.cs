using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ShipmentOrder

    {
        public ShipmentOrder(string dealerid, string BillNo, string BillIssueDate,  double amount)
        {//complete bill
            
            this.amount = amount;

            this.BillNo = BillNo;
            this.DealerId = dealerid;
            this.BillIssueDate = BillIssueDate;

        }
      
        public ShipmentOrder()
        { }
        public string DealerId { get; }

        public string BillNo { get; set; }
        public string BillIssueDate { get; }
        public double amount { get; }
    }
}
