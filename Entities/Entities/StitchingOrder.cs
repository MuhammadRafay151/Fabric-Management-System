using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class StitchingOrder
    {

        public StitchingOrder(string BillNo, string BillIssueDate, double amount, string dealerid)
        {//complete bill
            this.BillNo = BillNo;
            this.BillIssueDate = BillIssueDate;

            this.amount = amount;


            //this.imagepath = imagepath;
            this.DealerId = dealerid;



        }
        public StitchingOrder()
        {

        }
        public string DealerId { get; }

        public string BillNo { get; set; }
        public string BillIssueDate { get; }



        public double amount { get; }



    }
}
