using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public  class StitchingOrderLineItem
    {
        public StitchingOrderLineItem(string BillNo, int quantity, string designcode, string DesignName, string Stitching_PieceType, int NumberOfPieces, double rate, double amount, bool OrderReceiveStatus, string receivingdate, string imagepath)
        {//complete bill
            this.BillNo = BillNo;
         
            this.quantity = quantity;
            this.designcode = designcode;
            this.DesignName = DesignName;
            this.Stitching_PieceType = Stitching_PieceType;
            this.NumberOfPieces = NumberOfPieces;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            this.imagepath = imagepath;
           


        }
        public StitchingOrderLineItem(string BillNo, int quantity, string designcode, string DesignName, string Stitching_PieceType, int NumberOfPieces, double rate, double amount, bool OrderReceiveStatus, string receivingdate)
        {//complete bill
            this.BillNo = BillNo;
            
            this.quantity = quantity;
            this.designcode = designcode;
            this.DesignName = DesignName;
            this.Stitching_PieceType = Stitching_PieceType;
            this.NumberOfPieces = NumberOfPieces;
            this.rate = rate;
            this.amount = amount;
            this.OrderReceiveStatus = OrderReceiveStatus;
            this.receivingdate = receivingdate;
            //this.imagepath = imagepath;
         



        }
        public string BillNo { get; set; }
        public int quantity { get; set; }
        public string DesignName { get; set; }
        public double rate { get; set; }
        public double amount { get; set; }
        public bool OrderReceiveStatus { get; set; }
        public string receivingdate { get; set; }
        public string imagepath { get; set; }
        public string designcode { get; set; }
        public string Stitching_PieceType { get; set; }
        public int NumberOfPieces { get; set; }
    }
}
