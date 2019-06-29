using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Dealer
    {
        public Dealer(string Name, string UserId, String ContactNo, String Address, string joindate, string profile_type,string ImagePath ,string dealertype)
        {//to create Profile
            //if not want to add pic then pass string.empty
            this.Name = Name;
            this.UserId = UserId;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.joindate = joindate;
            this.profile_type = profile_type;
            this.ImagePath = ImagePath;
            this.dealertype = dealertype;
        }
        
        public Dealer(string Name, string UserId, String ContactNo, String Address, string joindate, double TotalAmountPaid, double RemainingAmount, string profile_type, string ImagePath, string dealertype)
        {
            this.Name = Name;
            this.UserId = UserId;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.joindate = joindate;
            this.profile_type = profile_type;
            this.TotalAMountPaid = TotalAmountPaid;
            this.RemainingAmount = RemainingAmount;
            this.ImagePath = ImagePath;
            this.dealertype = dealertype;
        }
        public string Name { get; }
        public string UserId { get; }
        public String ContactNo { get; }
        public String Address { get; }
        public string joindate { get; }
        public string profile_type { get; }
        public double TotalAMountPaid { get; set; }
        public double RemainingAmount { get; set; }
        public string ImagePath { get; }
         public string dealertype { get; }
    }
}
