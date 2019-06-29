using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CalendaringOrder
    {
        public CalendaringOrder(string dealerid, string BillNo, string BillIssueDate,   double amount)
        {//complete bill
            this.BillNo = BillNo;
            this.DealerId = dealerid;
            this.BillIssueDate = BillIssueDate;
            this.amount = amount;
        }

        public CalendaringOrder()
        {
            //call on dashboard....
        }
        public string DealerId { get; }

        public string BillNo { get; set; }
        public string BillIssueDate { get; }


        public double amount { get; }
       
    }
}
