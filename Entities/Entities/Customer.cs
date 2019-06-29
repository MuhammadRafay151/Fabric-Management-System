using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Customer
    {
        public Customer(string Name, string AccountNo, String ContactNo, String Address, string joindate, string profile_type, string ImagePath)
        {
            this.Name = Name;
            this.AccountNo = AccountNo;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.joindate = joindate;
            this.profile_type = profile_type;
            this.ImagePath = ImagePath;

        }
        public Customer(string Name, string AccountNo, String ContactNo, String Address, string joindate, string profile_type, double TotalAmountPaid, double RemainingAmount, string ImagePath)
        {
            this.Name = Name;
            this.AccountNo = AccountNo;
            this.ContactNo = ContactNo;
            this.Address = Address;
            this.joindate = joindate;
            this.profile_type = profile_type;
            this.TotalAMountPaid = TotalAmountPaid;
            this.RemainingAmount = RemainingAmount;
            this.ImagePath = ImagePath;

        }
        public string Name { get; }
        public string AccountNo { get; }
        public String ContactNo { get; }
        public String Address { get; }
        public string joindate { get; }
        public string profile_type { get; }
        public double TotalAMountPaid { get; set; }
        public double RemainingAmount { get; set; }
        public string ImagePath { get; }
    }
}
