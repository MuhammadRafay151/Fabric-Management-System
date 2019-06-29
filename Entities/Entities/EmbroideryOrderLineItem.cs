using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public  class EmbroideryOrderLineItem
    {
     
        public EmbroideryOrderLineItem( string BillNo,  int quantity, string designcode, string DesignName, double rate, double amount, bool OrderReceiveStatus, string receivingdate, string imagepath)
        {//complete bill
            this.quantity = quantity;
            this.DesignName = DesignName;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            this.imagepath = imagepath;
            this.BillNo = BillNo;
          
            this.designcode = designcode;

        }
        public EmbroideryOrderLineItem( string BillNo,  int quantity, string designcode, string DesignName, double rate, double amount, bool OrderReceiveStatus, string receivingdate)
        {//complete bill
            this.quantity = quantity;
            this.DesignName = DesignName;


            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            //this.imagepath = imagepath;
            this.BillNo = BillNo;
            this.designcode = designcode;

        }
        public EmbroideryOrderLineItem()
        {

        }
       

        public string BillNo { get; set; }
        public int quantity { get; }
        public string DesignName { get; }
        public double rate { get; }
        public double amount { get; }
        public bool OrderReceiveStatus { get; }
        public string receivingdate { get; }
        public string imagepath { get; }
        public string designcode { get; }
    }
}
