using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
namespace PuttingOrderForEmbroidery
{
    class EmbroideryOrderController
    {
        double totalamt = 0;
        SqlConnection con;
        string Connection = "Data Source=DESKTOP-6996G2B;Initial Catalog=HHV_DATABASE;Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        EmbroideryOrder OrderTransactions;
        LinkedList<EmbroideryOrderLineItem> OrderLineItem;

        Dealer dealer;
        public EmbroideryOrderController(Dealer dealer)
        {
            this.dealer = dealer;

        }
        public EmbroideryOrderController()
        {

        }
        public void CompleteOrderRecord(DataGridView d1, string bilno, string billissuedate, string dealerid, string imagepath)
        {
            OrderLineItem = new LinkedList<EmbroideryOrderLineItem>();
            for (int i = 0; i < d1.RowCount - 1; i++)
            {
                bool x;
                if (d1.Rows[i].Cells[5].Value.ToString() == "Yes")
                {
                    x = true;
                }
                else
                    x = false;
                string date = d1.Rows[i].Cells[6].Value.ToString();

                OrderLineItem.AddLast(new EmbroideryOrderLineItem( bilno, int.Parse(d1.Rows[i].Cells[0].Value.ToString()), d1.Rows[i].Cells[1].Value.ToString(), d1.Rows[i].Cells[2].Value.ToString(), double.Parse(d1.Rows[i].Cells[3].Value.ToString()), Double.Parse(d1.Rows[i].Cells[4].Value.ToString()), x, date, SaveImage(imagepath)));

                OrderTransactions = new EmbroideryOrder(bilno, billissuedate, totalamt, dealer.UserId);
                AddCodeName(d1.Rows[i].Cells[1].Value.ToString(), d1.Rows[i].Cells[2].Value.ToString());

            }
            WriteOrder();
            UpdateNewRemainingPayment();
            totalamt = 0;

        }

        private void WriteOrder()
        {
            try
            {
                EmbroideryOrderLineItem[] s1 = OrderLineItem.ToArray<EmbroideryOrderLineItem>();
                con = new SqlConnection();
                cmd = new SqlCommand();
                con.ConnectionString = Connection;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format("insert into EmbroideryOrder ([BillNo.],[Bill Issue Date],Amount,DealerUserId) values('{0}','{1}','{2}','{3}')", OrderTransactions.BillNo, OrderTransactions.BillIssueDate, OrderTransactions.amount, OrderTransactions.DealerId);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < s1.Length; i++)
                {

                    cmd.CommandText = string.Format("insert into EmbroideryOrderLineItem ([BillNo.],Quantity,DesignCode,DesignName,Rate,Amount,[Order Received Status],[Receiving Date],[Lot Image Path]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", s1[i].BillNo, s1[i].quantity, s1[i].designcode, s1[i].DesignName, s1[i].rate, s1[i].amount, s1[i].OrderReceiveStatus, s1[i].receivingdate, s1[i].imagepath);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
            catch(SqlException e)
            {
                if(e.Number==2627)
                {
                    MessageBox.Show("BillNo Alraedy Exist");
                }
            }
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
        public void UpdateNewRemainingPayment()
        {
            //dealer.RemainingAmount = totalamt;
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format("Select [Remaining Amount] from profile where userid='{0}'", dealer.UserId);
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
           // MessageBox.Show("Totalamt" + totalamt);
            temp += totalamt;
            //MessageBox.Show("temmp" + temp);
            dealer.RemainingAmount = temp;
            cmd.CommandText = string.Format("update profile set [Remaining Amount]={0} where UserID='{1}'", temp, dealer.UserId);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public string SaveImage(String ImagePath)
        {//save image in new folder and return new path...
            //if the image already exist the below will autoincrement imagename and save it...
            if (!string.IsNullOrWhiteSpace(ImagePath))
            {
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

            }
            else
                return string.Empty;

        }

        public void ReadFabricInfoDesignCode(DataGridViewComboBoxColumn d1)
        {
            LinkedList<Entities.FabricInfo> f1 = new LinkedList<FabricInfo>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select [Design Code] from FabricInfo";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FabricInfo f2 = new FabricInfo();
                f2.DesignCode = reader[0].ToString();
                f1.AddLast(f2);

            }
            con.Close();
            reader.Close();
            FabricInfo[] f3 = f1.ToArray<FabricInfo>();
            f1 = null;

            for (int i = 0; i < f3.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(f3[i].DesignCode))
                {
                    d1.Items.Add(f3[i].DesignCode);
                }


            }
        }
        public string ReadFabricInfoDesignName(string DesignCode)
        {
            LinkedList<Entities.FabricInfo> DesignName = new LinkedList<FabricInfo>();
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format("Select [Design Name] from FabricInfo where [design code]='{0}'", DesignCode);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!string.IsNullOrWhiteSpace(reader[0].ToString()))
                {
                    FabricInfo f2 = new FabricInfo();
                    f2.DesignName = reader[0].ToString();
                    DesignName.AddLast(f2);
                }
            }

            con.Close();
            reader.Close();
            FabricInfo[] f3 = DesignName.ToArray<FabricInfo>();

            if (f3.Length == 0)
                return string.Empty;
            else
                return f3[0].DesignName;
        }
        public void AddCodeName(string code, string DesignName)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format("update fabricinfo set [Design Name]='{0}' where [design code]='{1}'", DesignName, code);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
