using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ShipmentOrderLineItem
    {
        public ShipmentOrderLineItem(string BillNo, int quantity, string Description, string FabricType, int yard, double rate, double amount, bool OrderReceiveStatus, string receivingdate, string imagepath)
        {//complete bill
            this.quantity = quantity;
            this.Description = Description;
            this.FabricType = FabricType;
            this.yard = yard;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            this.imagepath = imagepath;
            this.BillNo = BillNo;


        }
        public ShipmentOrderLineItem(string BillNo, int quantity, string Description, string FabricType, int yard, double rate, double amount, bool OrderReceiveStatus, string receivingdate)
        {//complete bill
            this.quantity = quantity;
            this.Description = Description;
            this.FabricType = FabricType;
            this.yard = yard;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            //this.imagepath = imagepath;
            this.BillNo = BillNo;


        }
        public ShipmentOrderLineItem()
        { }
    
        public string BillNo { get; set; }
       
        public int quantity { get; }
        public string Description { get; }
        public string FabricType { get; }
        public int yard { get; }
        public double rate { get; }
        public double amount { get; }
        public bool OrderReceiveStatus { get; }
        public string receivingdate { get; }
        public string imagepath { get; }
    }
}
