using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using Entities;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace Administrator
{
    public class AdministratorController
    {
        bool AccountActive = false;
        SqlConnection con;
        string Connection = "Data Source=DESKTOP-6996G2B;Initial Catalog=HHV_DATABASE;Integrated Security=True";
        SqlDataReader reader;
        SqlCommand cmd;
        ShopManager SM;
        Product p1;
        LinkedList<FabricInfo> info;

        public bool ConnectDatabase()
        {
            con = new SqlConnection(Connection);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                ReadShopManagerData();
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }
        private void ReadShopManagerData()
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from ShopManager";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                con.Close();
                throw new Exception();
            }
            else
            {
                SM = new ShopManager(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), DateTime.Parse(reader[6].ToString()).ToString("dd-MM-yyyy"));

            }
            reader.Close();

           con.Close();


        }
        public bool Authenticate(string password)
        {
            if (SM.PASSWORD == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(string Name, string UserId, String password, string ContactNumber, string Address, string ImagePath, string JoinDate)
        {
            SM = new ShopManager(Name, UserId, password, ContactNumber, Address, ImagePath, JoinDate);
            string value = "";


            try
            {
                value = string.Format(@"insert into ShopManager (Name,UserId,Password,ContactNumber,Address,[Join Date],Picture) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", SM.NAME, SM.USERID, SM.PASSWORD, SM.CONTACTNUMBER, SM.ADDRESS, SM.JOINDATE, SaveImage(SM.IMAGEPATH));
            }
            catch (Exception e)

            {

            }

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                //cmd.CommandText = "insert into shopmanager (Name,UserId,Password,ContactNumber,Picture,Address,[Join Date]) values(@Name,@UserId,@Password,@ContactNumber,@Address,@Picture,@JoinDate)";
                //cmd.Parameters["@Name"].Value = SM.NAME;
                //cmd.Parameters["@UserId"].Value = SM.NAME;
                //cmd.Parameters["@Password"].Value = SM.NAME;
                //cmd.Parameters["@ContactNumber"].Value = SM.NAME;
                //cmd.Parameters["@Address"].Value = SM.NAME;
                //cmd.Parameters["@Picture"].Value = SM.NAME;
                //cmd.Parameters["@JoinDate"].Value = SM.NAME;
                //cmd.CommandText = "insert into shopmanager (Name,UserId,Password,ContactNumber,Picture,Address,[Join Date]) values(" + value + ")";
                cmd.CommandText = value;
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Registered Successfully");



                cmd.Connection.Close();
                con.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("DataBase Connection Failed");
            }
        }
        public void LoadUsername(System.Windows.Forms.Label Userlabel)
        {
            Userlabel.Text = "User Name:  " + SM.USERID;
        }
        public void AddItem(string ProductName, String ProductId, string DesignCode, String Color, int NumberOfPieces, int QuantityInStock, double ProductPrice, string KameezFabric, String ShalwarFabric, String DupattaFabric, bool IsKameezFrontEmbroided, bool IsKameezBackEmbroided, bool IsDupattaEmbroided, bool IsShalwarEmbroided, string ProductImagePath)
        {//copy image to folder....

            //query
            string sqlQuery = string.Format("insert into Product ([Product Name],[Product Id],[Design Code], Color,[Number of Pieces],[Quantity in stock],[Product Price],[Kameez Fabric],[Shalwar Fabric],[Dupatta Fabric],IsKameezFrontEmbroided,IsKameezBackEmbroided,IsDupattaEmbroided,IsShalwarEmbroided,[Item Image]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{8}','{10}','{11}','{12}','{13}','{14}')",
             ProductName, ProductId, DesignCode, Color, NumberOfPieces, QuantityInStock, ProductPrice, KameezFabric, ShalwarFabric, DupattaFabric, IsKameezFrontEmbroided, IsKameezBackEmbroided, IsDupattaEmbroided, IsShalwarEmbroided, SaveImage(ProductImagePath));

            WriteDataBase(sqlQuery);

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


        private void WriteDataBase(string SqlQuery)
        {//does the query is insert query ,code must be added if we have time...
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = SqlQuery;
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool SearchProduct(string ProductID)
        {
            string Query = string.Format("Select * from product where [product id]='{0}'", ProductID);
            return ReadProductData(Query);

        }
        private bool ReadProductData(string Query)
        {
           // con.Close();
           con.Open();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
                p1 = new Product(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), int.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()), double.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), Convert.ToBoolean(reader[10].ToString()), Convert.ToBoolean(reader[11].ToString()), Convert.ToBoolean(reader[12].ToString()), Convert.ToBoolean(reader[13].ToString()), reader[14].ToString());
            else
                return false;
            con.Close();
            reader.Close();
            return true;
        }
        public void LoadDataEditItem(TextBox ProductNameEd, TextBox ProductIdEd, TextBox DesignCodeEd, ComboBox ColorEd, MaskedTextBox NumberOfPiecesEd, MaskedTextBox QuantityInStockEd, MaskedTextBox ProductPriceEd, ComboBox KameezFabricEd, ComboBox ShalwarFabricEd, ComboBox DupattaFabricEd, CheckedListBox EmbroideryStatusEd, PictureBox ProductImageEd)
        {
            //this will　load data to edit item window....
            ProductNameEd.Text = p1.PRODUCT_NAME;
            ProductIdEd.Text = p1.PRODUCT_ID;
            DesignCodeEd.Text = p1.DESIGN_CODE;
            ColorEd.Text = p1.COLOR;
            NumberOfPiecesEd.Text = p1.NUMBER_OF_PIECES.ToString();
            QuantityInStockEd.Text = p1.QUANTITY_IN_STOCK.ToString();
            ProductPriceEd.Text = p1.PRODUCT_PRICE.ToString();
            KameezFabricEd.Text = p1.KAMEEZFABRIC;
            ShalwarFabricEd.Text = p1.SHALWAR_FABRIC;
            DupattaFabricEd.Text = p1.DUPATTA_FABRIC;
            EmbroideryStatusEd.SetItemChecked(0, p1.IS_KAMEEZ_FRONT_EMBROIDED);
            EmbroideryStatusEd.SetItemChecked(1, p1.IS_KAMEEZ_BACK_EMBROIDED);
            EmbroideryStatusEd.SetItemChecked(2, p1.IS_DUPATTA_EMBROIDED);
            EmbroideryStatusEd.SetItemChecked(3, p1.IS_SHALWAR_EMBROIDED);
            ProductImageEd.Image = Image.FromFile(p1.IMAGE_PATH);
            ProductImageEd.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImageEd.ImageLocation = p1.IMAGE_PATH;



        }
        public void UpdateProduct(string ProductName, String ProductId, string DesignCode, String Color, int NumberOfPieces, int QuantityInStock, double ProductPrice, string KameezFabric, String ShalwarFabric, String DupattaFabric, bool IsKameezFrontEmbroided, bool IsKameezBackEmbroided, bool IsDupattaEmbroided, bool IsShalwarEmbroided, string ProductImagePath)
        {
            //MessageBox.Show(p1.IMAGE_PATH);
            //MessageBox.Show(ProductImagePath);
            if (p1.IMAGE_PATH != ProductImagePath)
                DeletePrevoiusPic(p1.IMAGE_PATH);
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update Product Set [Product Name]='{0}',[Product Id]='{1}',[Design Code]='{2}', Color='{3}',[Number of Pieces]='{4}',[Quantity in stock]='{5}',[Product Price]='{6}',[Kameez Fabric]='{7}',[Shalwar Fabric]='{8}',[Dupatta Fabric]='{9}',IsKameezFrontEmbroided='{10}',IsKameezBackEmbroided='{11}',IsDupattaEmbroided='{12}',IsShalwarEmbroided='{13}',[Item Image]='{14}' where [product id]= '" + ProductId + "'", ProductName, ProductId, DesignCode, Color, NumberOfPieces, QuantityInStock, ProductPrice, KameezFabric, ShalwarFabric, DupattaFabric, IsKameezFrontEmbroided, IsKameezBackEmbroided, IsDupattaEmbroided, IsShalwarEmbroided, ProductImagePath);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            p1 = null;
        }

        public void DeleteProducut()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Delete from Product where [Product Id]='{0}'", p1.PRODUCT_ID);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            DeletePrevoiusPic(p1.IMAGE_PATH);
            p1 = null;
        }
        public void ReadFabricInfo(ComboBox Color, ComboBox KameezFabric, ComboBox ShalwarFabric, ComboBox DupattaFabric)
        {
            LinkedList<Entities.FabricInfo> f1 = new LinkedList<FabricInfo>();
            con.Open();
            cmd.CommandText = "Select * from FabricInfo";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FabricInfo f2 = new FabricInfo(reader[1].ToString(), reader[0].ToString());
                f1.AddLast(f2);

            }
            con.Close();
            reader.Close();
            FabricInfo[] f3 = f1.ToArray<FabricInfo>();
            f1 = null;

            for (int i = 0; i < f3.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(f3[i].FabricName))
                {
                    KameezFabric.Items.Add(f3[i].FabricName);
                    ShalwarFabric.Items.Add(f3[i].FabricName);
                    DupattaFabric.Items.Add(f3[i].FabricName);
                }
                if (!String.IsNullOrWhiteSpace(f3[i].FabricColor))
                    Color.Items.Add(f3[i].FabricColor);

            }
        }
        public void ReadFabricInfo(ListBox l1, ListBox l2, ListBox l3,ListBox l4)
        {
            LinkedList<Entities.FabricInfo> f1 = new LinkedList<FabricInfo>();
            con.Open();
            cmd.CommandText = "Select * from FabricInfo";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FabricInfo f2 = new FabricInfo(reader[1].ToString(), reader[0].ToString(), reader[2].ToString(),reader[3].ToString());
                f1.AddLast(f2);

            }
            con.Close();
            reader.Close();
            FabricInfo[] f3 = f1.ToArray<FabricInfo>();
            f1 = null;

            for (int i = 0; i < f3.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(f3[i].FabricName))
                {
                    l1.Items.Add(f3[i].FabricName);
                }
                if (!String.IsNullOrWhiteSpace(f3[i].FabricColor))
                    l2.Items.Add(f3[i].FabricColor);

                if (!string.IsNullOrWhiteSpace(f3[i].Stitching_Type))
                    l3.Items.Add(f3[i].Stitching_Type);
                if (!string.IsNullOrWhiteSpace(f3[i].DesignCode))
                    l4.Items.Add(f3[i].DesignCode);

            }
            info = new LinkedList<FabricInfo>();
        }
        public void AddInfo(string Name, String Color, String StitchingType,string DesignCode)
        {
            
           info.AddLast(new FabricInfo(Color, Name, StitchingType, DesignCode));
            
        }
        public void WriteFabricInfo()
        {
            FabricInfo[] f1 = info.ToArray<FabricInfo>();
           
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            for (int i = 0; i < f1.Length; i++)
            {
               
                cmd.CommandText = string.Format("Insert into fabricinfo ([Fabric Name], [Fabric Color] ,[Stitching Type],[Design Code]) values('{0}','{1}','{2}','{3}')", f1[i].FabricName, f1[i].FabricColor, f1[i].Stitching_Type,f1[i].DesignCode);
                cmd.ExecuteNonQuery();
            }
           
            con.Close();
            f1 = null;
            info = null;

        }
        public void DeleteFabricInfoColor(string Color)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update FabricInfo set [Fabric Color]=null where [Fabric Color]='{0}'",Color);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteFabricInfoName(string Name)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update FabricInfo set [Fabric Name]=null where [Fabric Name]='{0}'", Name);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteFabricInfoStitchingType(string StitchingType)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update FabricInfo set [Stitching Type]=null where [Stitching Type]='{0}'", StitchingType);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteDesignCode(string Name)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update FabricInfo set [Design Code]=null,[Design Name]=null where [Design Code]='{0}'", Name);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LoadAccountWindow(Label Name, Label ID, Label Password, Label Contact_No, Label Address, Label JoinDate, PictureBox Image)
        {//load data for shopmanager to view its details.
            Name.Text = "NAME: " + SM.NAME;
            ID.Text = "USER ID: " + SM.USERID;
            Password.Text = "PASSWORD: ";
            for (int i = 0; i < SM.PASSWORD.Length; i++)
            {
                Password.Text += "*";
            }
            Contact_No.Text = "Contact Number: " + SM.CONTACTNUMBER;
            Address.Text = "Address: " + SM.ADDRESS;
            JoinDate.Text = "Join Date: " + SM.JOINDATE;
            Image.Image = System.Drawing.Image.FromFile(SM.IMAGEPATH);
        }
        public void LoadAccountWindow(TextBox Name, TextBox ID, TextBox Contact_No, TextBox Address, Label JoinDate, PictureBox Image)
        {//load data for shopmanager to edit its details.
            Name.Text = SM.NAME;
            ID.Text = SM.USERID;
            ID.Enabled = false;


            Contact_No.Text = SM.CONTACTNUMBER;
            Address.Text = SM.ADDRESS;
            JoinDate.Text = SM.JOINDATE;
            Image.Image = System.Drawing.Image.FromFile(SM.IMAGEPATH);
            Image.ImageLocation = SM.IMAGEPATH;
        }
        public void UpdateShopManagerAccount(string Name, string Password, string Contact_No, string Address, string ImagePath)
        {//overloaded for password
            if (SM.IMAGEPATH != ImagePath)
                DeletePrevoiusPic(SM.IMAGEPATH);
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update ShopManager Set Name='{0}',[Password]='{2}', ContactNumber ='{3}',Address='{4}',Picture='{5}' where userid='{1}'", Name, SM.USERID, Password, Contact_No, Address, ImagePath);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateShopManagerAccount(string Name, string Contact_No, string Address, string ImagePath)
        {//password not updated....
            if (SM.IMAGEPATH != ImagePath)
                DeletePrevoiusPic(SM.IMAGEPATH);
            con = new SqlConnection();
            cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update ShopManager Set Name='{0}', ContactNumber ='{2}',Address='{3}',Picture='{4}' where userid='{1}'", Name, SM.USERID, Contact_No, Address, ImagePath);
            con.ConnectionString = Connection;
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DeletePrevoiusPic(string Path)
        {

            File.Delete(Path);
        }
        public void LaodProducts(ComboBox c1)
        {
            con.Open();
            cmd.CommandText = "select [Product ID] from product";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
          while (reader.Read())
                c1.Items.Add(reader[0].ToString());
          
            reader.Close();
            con.Close();
        }


    }
}



