using System;
using System.Collections.Generic;
using System.Text;

 namespace Entities
{
   public class ShopManager
    {
        String Name;
        string UserId;
        string Password;
        string ContactNumber;
        string Address;
        string ImagePath;
        string JoinDate;
        public ShopManager(string Name, string UserId, String password, string ContactNumber, string Address, string ImagePath, string JoinDate)
        {
            this.Name = Name;
            this.UserId = UserId;
            this.Password = password;
            this.ContactNumber = ContactNumber;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.JoinDate = JoinDate;
        }
        public string NAME
        {
            get { return Name; }
        }
        public string PASSWORD
        {
            get { return Password; }
        }
        public string CONTACTNUMBER
        {
            get { return ContactNumber; }
        }
        public string ADDRESS
        {
            get { return Address; }
        }
        public string IMAGEPATH
        {
            get { return ImagePath; }
        }
        public string JOINDATE
        {
            get { return JoinDate; }
        }
        public string USERID
        {
            get { return UserId; }
        }

    }
}
