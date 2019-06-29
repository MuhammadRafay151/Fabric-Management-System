using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public  class EmbroideryOrder
    {
        public EmbroideryOrder( string BillNo, string BillIssueDate, double amount, string dealerid)
        {//complete bill
            this.BillNo = BillNo;
            this.DealerId = dealerid;
            this.BillIssueDate = BillIssueDate;
            this.amount = amount;
        }

        public EmbroideryOrder()
        {
            //call on dashboard....
        }
        public string DealerId { get; }

        public string BillNo { get; set; }
        public string BillIssueDate { get; }


        public double amount { get; }



    }
}
