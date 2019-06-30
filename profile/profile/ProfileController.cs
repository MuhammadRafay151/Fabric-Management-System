using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using Entities;
using System.Windows.Forms;

namespace profile
{
    class ProfileController

    {
        SqlConnection con;
        string Connection = "Data Source=DESKTOP-6996G2B;Initial Catalog=HHV_DATABASE;Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        Entities.Dealer dealer;
        Entities.Customer customer;
        public void CreateAccountCustomer(string Name, string Userid, String ContactNo, String Address, string joindate, string profile_type)
        {//without image....
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert into profile (name,Userid,[contact number],address,[join date],[Profile Type]) values ('{0}','{1}','{2}','{3}','{4}','{5}')", Name, Userid, ContactNo, Address, joindate, profile_type);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void CreateAccountCustomer(string Name, string Userid, String ContactNo, String Address, string joindate, string profile_type, string ImagePath)
        {//with image
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert into profile (name,Userid,[contact number],address,[join date],[Profile Type],[Picture Path]) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Name, Userid, ContactNo, Address, joindate, profile_type, SaveImage(ImagePath));
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CreateAccountDealer(string Name, string Userid, String ContactNo, String Address, string joindate, string profile_type, string ImagePath, string dealertype)
        {//with image
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert into profile (name,Userid,[contact number],address,[join date],[Profile Type],[Picture Path],[Dealer Type]) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Name, Userid, ContactNo, Address, joindate, profile_type, SaveImage(ImagePath), dealertype);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void CreateAccountDealer(string Name, string Userid, String ContactNo, String Address, string joindate, string profile_type, string dealertype)
        {//without image....
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert into profile (name,Userid,[contact number],address,[join date],[Profile Type],[Dealer Type]) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Name, Userid, ContactNo, Address, joindate, profile_type, dealertype);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string SaveImage(String ImagePath)
        {//save image in new folder and return new path...
            //if the image already exist the below will autoincrement imagename and save it...
            string NewImagepath = Directory.GetCurrentDirectory() + "\\ImageDir\\" + Path.GetFileName(ImagePath);
            string ImageName = Path.GetFileNameWithoutExtension(ImagePath);
            string extension = Path.GetExtension(ImagePath);

            for (int i = 1; ; i++)
            {
                try
                {
                    ImageName = Path.GetFileNameWithoutExtension(ImagePath);

                    if (Directory.Exists(Directory.GetCurrentDirectory() + "\\ImageDir"))
                    {
                        System.IO.File.Copy(ImagePath, NewImagepath);
                    }
                    else
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ImageDir");
                        System.IO.File.Copy(ImagePath, NewImagepath);
                    }
                    return NewImagepath;
                }
                catch (Exception)
                {
                    ImageName += i;
                    NewImagepath = Directory.GetCurrentDirectory() + "\\ImageDir\\" + ImageName + extension;


                }
            }
            return NewImagepath;
        }
        public bool SearchDealer(string id)
        {
            con = new SqlConnection(Connection);
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Select * from profile where Userid='{0}'", id);
            cmd.Connection = con;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (string.IsNullOrWhiteSpace(reader[6].ToString()) && string.IsNullOrWhiteSpace(reader[5].ToString()))
                {
                    if (reader[7].ToString() == "Customer")
                        return false;
                    dealer = new Dealer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 0, 0, reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                    //start from here...
                    //start from here.
                }
                else if (string.IsNullOrWhiteSpace(reader[6].ToString()))
                {
                    if (reader[7].ToString() == "Customer")
                        return false;
                    dealer = new Dealer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Double.Parse(reader[5].ToString()), 0, reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                    //start from here...
                    //start from here.
                }
                else if (string.IsNullOrWhiteSpace(reader[5].ToString()))
                {
                    if (reader[7].ToString() == "Customer")
                        return false;
                    dealer = new Dealer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), 0, Double.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                    //start from here...
                    //start from here.
                }
                else
                {
                    if (reader[7].ToString() == "Customer")
                        return false;

                    dealer = new Dealer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Double.Parse(reader[5].ToString()), Double.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                    //start from here...

                }

                return true;
            }
            else
                return false;

            con.Close();
        }
        public bool SearchCustomer(string id)
        {
            con = new SqlConnection(Connection);
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Select * from profile where Userid='{0}'", id);
            cmd.Connection = con;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                if (string.IsNullOrWhiteSpace(reader[6].ToString()) && string.IsNullOrWhiteSpace(reader[5].ToString()))
                {

                    if (reader[7].ToString() == "Dealer")
                        return false;
                    customer = new Customer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[7].ToString(), 0, 0, reader[8].ToString());
                    //start from here...
                    //start from here.
                }
                else if (string.IsNullOrWhiteSpace(reader[6].ToString()))
                {

                    if (reader[7].ToString() == "Dealer")
                        return false;
                    customer = new Customer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[7].ToString(), Double.Parse(reader[5].ToString()), 0, reader[8].ToString());
                    //start from here...
                    //start from here.
                }
                else if (string.IsNullOrWhiteSpace(reader[5].ToString()))
                {
                    if (reader[7].ToString() == "Dealer")
                        return false;

                    customer = new Customer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[7].ToString(), 0, Double.Parse(reader[6].ToString()), reader[8].ToString());
                    //start from here...
                    //start from here.
                }
                else
                {
                    if (reader[7].ToString() == "Dealer")
                        return false;

                    customer = new Customer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[7].ToString(), Double.Parse(reader[5].ToString()), Double.Parse(reader[6].ToString()), reader[8].ToString());
                    //start from here...

                }
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }
        public Dealer GetDealer
        {
            get { return dealer; }
        }
        public Customer GetCustomer
        {
            get
            {

                return customer;
            }
        }

        public void Payamount(double amount)
        {
            dealer.TotalAMountPaid += amount;
            dealer.RemainingAmount -= amount;
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Profile set [Total Amount Paid]={0},[Remaining Amount]={1} where userid='{2}'", dealer.TotalAMountPaid, dealer.RemainingAmount, dealer.UserId);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void CustomerPayamount(double amount)
        {
            customer.TotalAMountPaid += amount;
            customer.RemainingAmount -= amount;
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Profile set [Total Amount Paid]={0},[Remaining Amount]={1} where userid='{2}'", customer.TotalAMountPaid, customer.RemainingAmount, customer.AccountNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ReturnCustomerPayamount(double amount)
        {

            customer.RemainingAmount -= amount;
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Profile set [Remaining Amount]={0} where userid='{1}'", customer.RemainingAmount, customer.AccountNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ReturnCustomerPayamount2(double amount)
        {

            customer.TotalAMountPaid -= amount;
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("update Profile set [Total Amount Paid]={0} where userid='{1}'", customer.TotalAMountPaid, customer.AccountNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ShipmentOrder[] LoadPrevoiusShipmentDealerTransactions()
        {
            LinkedList<ShipmentOrder> e1 = new LinkedList<ShipmentOrder>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select [BillNo.] from ShipmentOrder where dealeruserid='{0}'", dealer.UserId);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ShipmentOrder e2 = new ShipmentOrder();
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<ShipmentOrder>();

        }
        public ShipmentOrderLineItem[] LoadPrevoiusShipmentDealerBill(string BillNo)
        {
            LinkedList<ShipmentOrderLineItem> e1 = new LinkedList<ShipmentOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from ShipmentOrderLineItem where  [BillNo.]='{0}'", BillNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ShipmentOrderLineItem e2 = new ShipmentOrderLineItem(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), double.Parse(reader[5].ToString()), double.Parse(reader[6].ToString()), bool.Parse(reader[7].ToString()), DateTime.Parse(reader[8].ToString()).ToShortDateString(), reader[9].ToString());
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<ShipmentOrderLineItem>();
        }
        public ShipmentOrder LoadShipmentOrderTransaction(string billno)
        {
            ShipmentOrder e1 = new ShipmentOrder();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from ShipmentOrder where dealeruserid='{0}' and [BillNo.]='{1}'", dealer.UserId, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                e1 = new ShipmentOrder(reader[3].ToString(), reader[0].ToString(), reader[1].ToString(),double.Parse( reader[2].ToString()));
             
                reader.Close();
                con.Close();
                return e1;
            }
            else
            {
                reader.Close();
                con.Close();
                return null;
            }

           

        }
        public CalendaringOrder[] LoadPrevoiusCalendarDealerTransactions()
        {
            LinkedList<CalendaringOrder> e1 = new LinkedList<CalendaringOrder>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select  [BillNo.] from CalendaringOrder where dealeruserid='{0}'", dealer.UserId);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CalendaringOrder e2 = new CalendaringOrder();
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<CalendaringOrder>();
        }
        public CalendaringOrderLineItem[] LoadPrevoiusCalendarDealerBill(string BillNo)
        {
            LinkedList<CalendaringOrderLineItem> e1 = new LinkedList<CalendaringOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CalendaringOrderLineItem where  [BillNo.]='{0}' ", BillNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CalendaringOrderLineItem e2 = new CalendaringOrderLineItem(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[3].ToString(), reader[4].ToString(), int.Parse(reader[5].ToString()), Double.Parse(reader[6].ToString()), double.Parse(reader[7].ToString()), bool.Parse(reader[8].ToString()), reader[9].ToString(), reader[10].ToString(), reader[2].ToString());
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<CalendaringOrderLineItem>();
        }
        public CalendaringOrder LoadCalendarOrderTransactionDetails(string billno)
        {

            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CalendaringOrder where dealeruserid='{0}' and  [BillNo.]='{1}'", dealer.UserId, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            CalendaringOrder e2;
            if (reader.Read())
            {
                e2 = new CalendaringOrder(reader[3].ToString(), reader[0].ToString(), reader[1].ToString(), double.Parse(reader[2].ToString()));

                //e2.BillNo = reader[0].ToString();
                con.Close();
                reader.Close();

                return e2;

            }
            else
            {
                MessageBox.Show("");
                reader.Close();
                con.Close();
                return null;
            }



        }
        public StitchingOrder[] LoadPrevoiusStitchingDealerTransactions()
        {
            LinkedList<StitchingOrder> e1 = new LinkedList<StitchingOrder>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select [BillNo.] from StitchingOrder where dealeruserid='{0}'", dealer.UserId);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StitchingOrder e2 = new StitchingOrder();
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<StitchingOrder>();
        }
        public StitchingOrderLineItem[] LoadPrevoiusStitchingDealerBill(string BillNo)
        {
            LinkedList<StitchingOrderLineItem> e1 = new LinkedList<StitchingOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from StitchingOrderLineItem where [BillNo.]='{0}'", BillNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StitchingOrderLineItem e2 = new StitchingOrderLineItem(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), int.Parse(reader[5].ToString()), double.Parse(reader[6].ToString()), double.Parse(reader[7].ToString()), bool.Parse(reader[8].ToString()), reader[9].ToString(), reader[10].ToString());
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<StitchingOrderLineItem>();
        }
        public StitchingOrder LoadStitchingOrderTransactionDetails(String billno)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from StitchingOrder  where DealerUserId='{0}' and [BillNo.]='{1}'", dealer.UserId, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            StitchingOrder e2;
            if (reader.Read())
            {
                e2 = new StitchingOrder(reader[0].ToString(), reader[1].ToString(), Double.Parse(reader[2].ToString()), reader[3].ToString());
                reader.Close();
                con.Close();

                return e2;

            }
            else
            {
                reader.Close();
                con.Close();

                return null;
            }


        }



        public EmbroideryOrder[] LoadPrevoiusEmbdDealerTransactions()
        {
            LinkedList<EmbroideryOrder> e1 = new LinkedList<EmbroideryOrder>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select [BillNo.] from EmbroideryOrder where dealeruserid='{0}'", dealer.UserId);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmbroideryOrder e2 = new EmbroideryOrder();
                e2.BillNo = reader[0].ToString();
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<EmbroideryOrder>();
        }
        public EmbroideryOrderLineItem[] LoadPrevoiusEmbdDealerBill(string BillNo)
        {
            LinkedList<EmbroideryOrderLineItem> e1 = new LinkedList<EmbroideryOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from EmbroideryOrderLineItem where  [BillNo.]='{0}'", BillNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmbroideryOrderLineItem e2 = new EmbroideryOrderLineItem(reader[0].ToString(), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), double.Parse(reader[4].ToString()), double.Parse(reader[5].ToString()), bool.Parse(reader[6].ToString()), reader[7].ToString());

                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<EmbroideryOrderLineItem>();
        }

        public EmbroideryOrder LoadEmbroideryOrderTransactiondetails(string billno)
        {
            EmbroideryOrder e2;
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from EmbroideryOrder where dealeruserid='{0}' and [BillNo.]='{1}'", dealer.UserId, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                e2 = new EmbroideryOrder(reader[0].ToString(), reader[1].ToString(), double.Parse(reader[2].ToString()), reader[3].ToString());

                reader.Close();
                con.Close();
                return e2;
            }
            else
            {
                reader.Close();
                con.Close();
                return null;
            }

        }



        public CustomerOrder[] LoadPreviousCustomerOrders()
        {
            LinkedList<CustomerOrder> e1 = new LinkedList<CustomerOrder>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select [BillNo.] from CustomerOrder where CustomerId='{0}'", customer.AccountNo);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerOrder e2 = new CustomerOrder();
                e2.BillNo = int.Parse(reader[0].ToString());
                e1.AddLast(e2);
            }

            con.Close();
            return e1.ToArray<CustomerOrder>();

        }
        public CustomerOrderLineItem[] LoadPreviousCutomerBill(int billno)
        {
            LinkedList<CustomerOrderLineItem> e1 = new LinkedList<CustomerOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CustomerOrderLineItem where [BillNo.]={1}", customer.AccountNo, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerOrderLineItem e2 = new CustomerOrderLineItem();
                e2.BillNo = int.Parse(reader[0].ToString());
                // e2.PurchaseDate = reader[1].ToString();
                e2.Quantity = int.Parse(reader[1].ToString());
                e2.ProductId = reader[2].ToString();
                e2.ProductName = reader[3].ToString();
                e2.Rate = double.Parse(reader[4].ToString());
                e2.Amount = double.Parse(reader[5].ToString());
                e1.AddLast(e2);
            }
            reader.Close();
            con.Close();
            return e1.ToArray<CustomerOrderLineItem>();

        }
        public CustomerOrder LoadCustomerTransactionDetails(int billno)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from CustomerOrder where CustomerId='{0}' and  [BillNo.]={1}", customer.AccountNo, billno);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            CustomerOrder e2 = new CustomerOrder();
            if (reader.Read())
            {

                e2.BillNo = int.Parse(reader[0].ToString());
                e2.PurchaseDate = reader[1].ToString();
                e2.TotalAmount = double.Parse(reader[2].ToString());
                e2.CustomerId = reader[3].ToString();


            }

            reader.Close();
            con.Close();
            return e2;
        }
        public void GetCustomerId(ComboBox c1)
        {
            c1.Items.Clear();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select UserID from profile where [Profile Type]='Customer'");
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                c1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public void GetDealerId(ComboBox c1)
        {
           c1.Items.Clear();
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("select UserID from profile where [Profile Type]='Dealer'");
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                c1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
    }
}
