using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Windows.Forms;
using System.Drawing;
namespace PlaceOrder
{
    public class PlaceOrderController
    {
        SqlConnection con;
        string Connection = "Data Source=DESKTOP-6996G2B;Initial Catalog=HHV_DATABASE;Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        Product[] products;
        double totalamt = 0;
       
        CustomerOrderLineItem[] c2;
        CustomerOrder customerOrder = new CustomerOrder();
        LinkedList<CustomerOrderLineItem> OrderLineItem = new LinkedList<CustomerOrderLineItem>();
        Customer customer;
        public PlaceOrderController(Customer customer)
        {//setting customer...
            this.customer = customer;
        }
        public PlaceOrderController()
        {
        }
        public void ReadItems()
        {

            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Select * from product");
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            LinkedList<Product> l1 = new LinkedList<Product>();
            while (reader.Read())
            {
                l1.AddLast(new Product(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()), double.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), bool.Parse(reader[10].ToString()), bool.Parse(reader[11].ToString()), bool.Parse(reader[12].ToString()), bool.Parse(reader[13].ToString()), reader[14].ToString()));



            }
            con.Close();
            products = l1.ToArray<Product>();
        }
        public void LoadItemWindow(FlowLayoutPanel o1)
        {//load item in profile...
            for (int i = 0; i < products.Length; i++)
                o1.Controls.Add(new OrderTemplete(this, i));
        }
        public void LoadItemWindow(FlowLayoutPanel o1, bool hide)
        {//load item in profile...
            for (int i = 0; i < products.Length; i++)
                o1.Controls.Add(new OrderTemplete(this, i, hide));
        }
        public void LoadDataItemWindow(PictureBox pic, Label Price, int count)
        {
            pic.Image = Image.FromFile(products[count].IMAGE_PATH);
            Price.Text += " " + products[count].PRODUCT_PRICE;
        }
        public void LoadDetails(Label Color, Label designcode, Label numberofpieces, Label quantityinstock, Label kameezfabric, Label shalwarfabric, Label dupattafabric, Label embdfront, Label embdback, Label embddupatta, Label embdshalwar, int count,Label productid)
        {
            Color.Text += ": " + products[count].COLOR;
            designcode.Text += ": " + products[count].DESIGN_CODE;
            numberofpieces.Text += ": " + products[count].NUMBER_OF_PIECES;
            quantityinstock.Text += ": " + products[count].QUANTITY_IN_STOCK;
            kameezfabric.Text += " " + products[count].KAMEEZFABRIC;
            shalwarfabric.Text += "  " + products[count].SHALWAR_FABRIC;
            dupattafabric.Text += "  " + products[count].DUPATTA_FABRIC;
            productid.Text += " " + products[count].PRODUCT_ID;
            if (products[count].IS_KAMEEZ_FRONT_EMBROIDED)
            {
                embdfront.Text += ": YES";
            }
            else
            {
                embdfront.Text += ": NO";
            }
            if (products[count].IS_KAMEEZ_BACK_EMBROIDED)
            {
                embdback.Text += ": YES";
            }
            else
            {
                embdback.Text += ": NO";
            }
            if (products[count].IS_DUPATTA_EMBROIDED)
            {
                embddupatta.Text += ": YES";
            }
            else
            {
                embddupatta.Text += ": NO";
            }
            if (products[count].IS_SHALWAR_EMBROIDED)
            {
                embdshalwar.Text += ": YES";
            }
            else
            {
                embdshalwar.Text += ": NO";
            }


        }
        public Product GetProduct(int index)
        {
            return products[index];
        }
        public void AddToCart(int index, int quantity)
        {//add items to cart....

            CustomerOrder c1 = new CustomerOrder();
            CustomerOrderLineItem c2 = new CustomerOrderLineItem();
            MessageBox.Show(products[index].PRODUCT_ID);
            c2.ProductId = products[index].PRODUCT_ID;
            c2.ProductName = products[index].PRODUCT_NAME;
            c2.Quantity = quantity;
           
            c2.Rate = products[index].PRODUCT_PRICE;
            c2.Amount = c2.Rate * quantity;
            c1.PurchaseDate = DateTime.Now.ToString("yyyy-MM-dd");
            c1.CustomerId = customer.AccountNo;
            c1.BillNo = GetBillNo();
            c2.BillNo = c1.BillNo;

            customerOrder = c1;
            OrderLineItem.AddLast(c2);
        }
        public void LoadBillToCart(DataGridView d1, Label customerid, TextBox billno, TextBox date)
        {
            d1.Rows.Clear();
          
            c2 = OrderLineItem.ToArray < CustomerOrderLineItem>();
            if(c2.Length>0)
            d1.Rows.Add(c2.Length);
            MessageBox.Show(c2.Length.ToString());
            for (int i = 0; i < c2.Length; i++)
            {
                d1.Rows[i].Cells[0].Value = c2[i].Quantity;
                d1.Rows[i].Cells[1].Value = c2[i].ProductId;
                d1.Rows[i].Cells[2].Value = c2[i].ProductName;
                d1.Rows[i].Cells[3].Value = c2[i].Rate;
                d1.Rows[i].Cells[4].Value = c2[i].Amount;
                customerid.Text = "Customer Id: " + customerOrder.CustomerId;
                billno.Text = customerOrder.BillNo.ToString();
                date.Text = customerOrder.PurchaseDate;


            }
        }
        public void RemoveFromCart(int index)
        {
            c2[index] = null;
        }
        public void UpdateCart()
        {
            OrderLineItem = new LinkedList<CustomerOrderLineItem>();
            for(int i=0;i<c2.Length;i++)
            {if (c2[i] != null)
                {
                    OrderLineItem.AddLast(c2[i]);
                }
            }
        }
        public bool IsCartEmpty()
        {
            if (OrderLineItem.Count == 0)
                return true;
            else return false;
        }
        public int GetBillNo()
        {//get last bill no of 
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Select max([BillNo.]) from CustomerOrder");
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            int num;
            if (reader.Read())
            {
                try
                {
                    num = int.Parse(reader[0].ToString());
                    con.Close();
                    reader.Close();
                    return num += 1;
                }
                catch (FormatException)
                {
                    reader.Close();
                    return 1;
                }
            }
            else
            {
                reader.Close();
                return 1;
            }
        }
        public void OrderRecord(DataGridView d1, int bilno, string date)
        {
           
            LinkedList<CustomerOrderLineItem> OrderLineItem = new LinkedList<CustomerOrderLineItem>();
           
            for (int i = 0; i < d1.RowCount - 1; i++)
            {
                CustomerOrderLineItem o1 = new CustomerOrderLineItem();
                o1.BillNo = bilno;
                
                o1.Quantity = int.Parse(d1.Rows[i].Cells[0].Value.ToString());
                o1.ProductId = d1.Rows[i].Cells[1].Value.ToString();
                o1.ProductName = d1.Rows[i].Cells[2].Value.ToString();
                o1.Rate = double.Parse(d1.Rows[i].Cells[3].Value.ToString());
                o1.Amount = double.Parse(d1.Rows[i].Cells[4].Value.ToString());

                customerOrder.TotalAmount = totalamt;


                OrderLineItem.AddLast(o1);




            }
            WriteOrder(customerOrder,OrderLineItem);
            DetectProductQuantity(OrderLineItem);
            UpdateNewRemainingPayment();
            // totalamt = 0;

        }

       private void WriteOrder(CustomerOrder Ordertransaction,LinkedList<CustomerOrderLineItem>OrderLineItem)
        {
           
            CustomerOrderLineItem[] s2 = OrderLineItem.ToArray<CustomerOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            //transaction

                cmd.CommandText = string.Format("insert into CustomerOrder ([BillNo.],PurchaseDate,Amount,CustomerId) values('{0}','{1}','{2}','{3}')", Ordertransaction.BillNo, Ordertransaction.PurchaseDate, Ordertransaction.TotalAmount, Ordertransaction.CustomerId);
                cmd.ExecuteNonQuery();
            
          
            for (int i = 0; i < s2.Length; i++)
            {//transaction line item

                cmd.CommandText = string.Format("insert into CustomerOrderLineItem ([BillNo.],Quantity,[Product Id],[Product Name],Rate,Amount) values('{0}','{1}','{2}','{3}','{4}','{5}')", s2[i].BillNo, s2[i].Quantity, s2[i].ProductId, s2[i].ProductName,s2[i].Rate,s2[i].Amount);
                cmd.ExecuteNonQuery();
            }
            con.Close();

        }
        public double GetTotalBillAmount(DataGridView d1)
        {
            totalamt = 0;
            for (int i = 0; i < d1.RowCount - 1; i++)
            {


                totalamt += double.Parse(d1.Rows[i].Cells[4].Value.ToString());
            }
            double x = totalamt;

            return x;
        }
        private void UpdateNewRemainingPayment()
        {
            //dealer.RemainingAmount = totalamt;
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format("Select [Remaining Amount] from profile where userid='{0}'", customer.AccountNo);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            double temp = 0;
            if (reader.Read())
            {
                if (!string.IsNullOrWhiteSpace(reader[0].ToString()))
                    temp = double.Parse(reader[0].ToString());
            }
            reader.Close();
            con.Close();
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            
            temp += totalamt;
          
            customer.RemainingAmount = temp;
            cmd.CommandText = string.Format("update profile set [Remaining Amount]={0} where UserID='{1}'", temp, customer.AccountNo);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void DetectProductQuantity(LinkedList<CustomerOrderLineItem> OrderLineItem)
        { CustomerOrderLineItem[] c1 = OrderLineItem.ToArray<CustomerOrderLineItem>();
            con = new SqlConnection();
            cmd = new SqlCommand();
           
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
           
            Product[] p1 = new Product[c1.Length];
            for (int i = 0; i <c1.Length; i++)
            {
                cmd.CommandText = string.Format("Select [Quantity in Stock] from product where [Product ID]='{0}'", c1[i].ProductId);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int x = int.Parse(reader[0].ToString())-c1[i].Quantity;
                    p1[i] = new Product();
                    p1[i].PRODUCT_ID = c1[i].ProductId;
                    p1[i].QUANTITY_IN_STOCK = x;
                    for(int j=0;j<products.Length ;j++)
                    {
                        if(c1[i].ProductId== products[j].PRODUCT_ID)
                        {
                            products[j].QUANTITY_IN_STOCK = x;
                        }
                    }
                    

                   
                }
                reader.Close();
            }

            reader.Close();
            for (int i = 0; i < p1.Length; i++)
            {
                cmd.CommandText = string.Format("update product set [Quantity in Stock]={0}   where [Product ID]='{1}'", p1[i].QUANTITY_IN_STOCK, p1[i].PRODUCT_ID);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            
           
        }
    }
}
