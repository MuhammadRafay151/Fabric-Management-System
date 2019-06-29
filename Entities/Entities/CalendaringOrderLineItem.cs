using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CalendaringOrderLineItem
    {
        public CalendaringOrderLineItem(string BillNo, int quantity, string DesignName, string FabricType, int yard, double rate, double amount, bool OrderReceiveStatus, string receivingdate, string imagepath, string designcode)
        {//complete bill
            this.quantity = quantity;
            this.DesignName = DesignName;
            this.FabricType = FabricType;
            this.yard = yard;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            this.imagepath = imagepath;
            this.BillNo = BillNo;


            this.designcode = designcode;

        }
        public CalendaringOrderLineItem(string BillNo, int quantity, string DesignName, string FabricType, int yard, double rate, double amount, bool OrderReceiveStatus, string receivingdate, string designcode)
        {//complete bill
            this.quantity = quantity;
            this.DesignName = DesignName;
            this.FabricType = FabricType;
            this.yard = yard;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            //this.imagepath = imagepath;
            this.BillNo = BillNo;

            this.designcode = designcode;

        }
        public CalendaringOrderLineItem()
        {
            //call on dashboard....
        }


        public string BillNo { get; set; }

        public int quantity { get; }
        public string DesignName { get; }
        public string FabricType { get; }
        public int yard { get; }
        public double rate { get; }
        public double amount { get; }
        public bool OrderReceiveStatus { get; }
        public string receivingdate { get; }
        public string imagepath { get; }
        public string designcode { get; }

    }
}
