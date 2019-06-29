using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Administrator
{
    public partial class AdminProfile : UserControl
    {
        AdministratorController Admin;
        private bool IsImgUploaded;
        OpenFileDialog o1;
        public AdminProfile(AdministratorController Admin)
        {
            InitializeComponent();
            this.Admin = Admin;


        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            ProductPicture.Image = ProductPicture.InitialImage;
            ProductNametxt.Clear();
            ProductIDtxt.Clear();
            DesignCodetxt.Clear();
            ColorTxt.ResetText();
            EmbroideryStatus.Refresh();
            AddItems.Show();
            AddItems.BringToFront();
            EditItem.TabStop = false;
            ViewAccount.TabStop = false;
            AccountSetting.TabStop = false;
            KameezaFabricTxt.Items.Clear();
            ShalwarFabricTxt.Items.Clear();
            DupattaFabricTxt.Items.Clear();
            ColorTxt.Items.Clear();
            Admin.ReadFabricInfo(ColorTxt, KameezaFabricTxt, ShalwarFabricTxt, DupattaFabricTxt);

        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            label8.Show();
            comboBox1.Items.Clear();
            comboBox1.Text = string.Empty;
            Admin.LaodProducts(comboBox1);
            ProductImageEd.Image = ProductImageEd.InitialImage;
            IsImgUploaded = false;
            ProductNameEd.Clear();
            ProductIdEd.Clear();
            ColorEd.Items.Clear();
            ColorEd.Text = string.Empty;
            ProductPriceEd.Clear();
            QuantityInStockEd.Clear();
            KameezFabricEd.Items.Clear();
            KameezFabricEd.Text = "";
            ShalwarFabricEd.Items.Clear();
            ShalwarFabricEd.Text = "";
            DupattaFabricEd.Items.Clear();
            DupattaFabricEd.Text = "";
            for (int i = 0; i < EmbroideryStatusEd.Items.Count; i++)
            {
                EmbroideryStatusEd.SetItemChecked(i, false);
            }
            NumberOfPiecesEd.Clear();
            DesignCodeEd.Clear();
          

            ProductImageEd.Enabled = false;
            ProductNameEd.Enabled = false;
            ProductIdEd.Enabled = false;
            ColorEd.Enabled = false;
            ProductPriceEd.Enabled = false;
            QuantityInStockEd.Enabled = false;
            KameezFabricEd.Enabled = false;
            ShalwarFabricEd.Enabled = false;
            DupattaFabricEd.Enabled = false;
            EmbroideryStatusEd.Enabled = false;
            NumberOfPiecesEd.Enabled = false;
            DesignCodeEd.Enabled = false;
            UpdateChanges.Enabled = false;
            DeleteItemEd.Enabled = false;
            EditItem.Show();
            EditItem.BringToFront();
        }
        //private void SearchProduct_Click(object sender, EventArgs e)
        //{
        //    if (Admin.SearchProduct(textBox5.Text))
        //    {
        //        ProductImageEd.Image = ProductPicture.InitialImage;
        //        ProductImageEd.Enabled = true;
        //        ProductNameEd.Enabled = true;
        //        ProductIdEd.Enabled = true;
        //        ColorEd.Enabled = true;
        //        ProductPriceEd.Enabled = true;
        //        QuantityInStockEd.Enabled = true;
        //        KameezFabricEd.Enabled = true;
        //        ShalwarFabricEd.Enabled = true;
        //        DupattaFabricEd.Enabled = true;
        //        EmbroideryStatusEd.Enabled = true;
        //        NumberOfPiecesEd.Enabled = true;
        //        DesignCodeEd.Enabled = true;
        //        UpdateChanges.Enabled = true;
        //        DeleteItemEd.Enabled = true;
        //        Admin.ReadFabricInfo(ColorEd, KameezFabricEd, ShalwarFabricEd, DupattaFabricEd);
        //        Admin.LoadDataEditItem(ProductNameEd, ProductIdEd, DesignCodeEd, ColorEd, NumberOfPiecesEd, QuantityInStockEd, ProductPriceEd, KameezFabricEd, ShalwarFabricEd, DupattaFabricEd, EmbroideryStatusEd, ProductImageEd);
        //    }
        //}
        private void BrowseEd_Click(object sender, EventArgs e)
        {
            o1 = new OpenFileDialog();

            o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (o1.ShowDialog() == DialogResult.OK)
            {


                ProductImageEd.Image = Image.FromFile(o1.FileName);

                GC.Collect();
                //GraphicsPath gp = new GraphicsPath();
                //gp.AddEllipse(pictureBox1.DisplayRectangle);
                //pictureBox1.Region = new Region(gp);

                ProductImageEd.SizeMode = PictureBoxSizeMode.StretchImage;
                IsImgUploaded = true;

            }
        }
        private void UpdateChanges_Click(object sender, EventArgs e)
        {
            string imgloc;
            if (IsImgUploaded)
            {

                imgloc = Admin.SaveImage(o1.FileName);


            }
            else
            {
                imgloc = ProductImageEd.ImageLocation;
            }
            //update changes code goes here...
            Admin.UpdateProduct(ProductNameEd.Text, ProductIdEd.Text, DesignCodeEd.Text, ColorEd.Text, int.Parse(NumberOfPiecesEd.Text),
           int.Parse(QuantityInStockEd.Text), double.Parse(ProductPriceEd.Text), KameezFabricEd.Text, ShalwarFabricEd.Text,
           DupattaFabricEd.Text, EmbroideryStatusEd.GetItemChecked(0), EmbroideryStatusEd.GetItemChecked(1), EmbroideryStatusEd.GetItemChecked(2),
           EmbroideryStatusEd.GetItemChecked(3), imgloc);


            EditItemBtn_Click(sender, e);
            o1.Dispose();
            // ProductImageEd.Image = initial; 
            // ProductNameEd.Clear();
            // ProductIdEd.Clear();

            // ColorEd.Text = string.Empty;
            // ProductPriceEd.Clear();
            // QuantityInStockEd.Clear();

            // KameezFabricEd.Text = "";

            // ShalwarFabricEd.Text = "";

            // DupattaFabricEd.Text = "";
            // for (int i = 0; i < EmbroideryStatusEd.Items.Count; i++)
            // {
            //     EmbroideryStatusEd.SetItemChecked(i, false);
            // }
            // NumberOfPiecesEd.Clear();
            // DesignCodeEd.Clear();
            // textBox5.Clear();
            //// ProductImageEd.Image = ProductPicture.InitialImage;
            // ProductImageEd.Enabled = false;
            // ProductNameEd.Enabled = false;
            // ProductIdEd.Enabled = false;
            // ColorEd.Enabled = false;
            // ProductPriceEd.Enabled = false;
            // QuantityInStockEd.Enabled = false;
            // KameezFabricEd.Enabled = false;
            // ShalwarFabricEd.Enabled = false;
            // DupattaFabricEd.Enabled = false;
            // EmbroideryStatusEd.Enabled = false;
            // NumberOfPiecesEd.Enabled = false;
            // DesignCodeEd.Enabled = false;
            // UpdateChanges.Enabled = false;
            // DeleteItemEd.Enabled = false;
            // EditItem.Show();
            // EditItem.BringToFront();
        }


        private void ViewAccountBtn_Click(object sender, EventArgs e)
        {
            Admin.LoadAccountWindow(NAME_SM, USERID_SM, PASSWORD_SM, CONTACTNUMBER_SM, ADDRESS_SM, JOINDATE_SM, IMAGE_SM);
            ViewAccount.Show();
            ViewAccount.BringToFront();
        }


        private void AddNewItem_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(ProductNametxt.Text) || string.IsNullOrWhiteSpace(ProductIDtxt.Text) || string.IsNullOrWhiteSpace(DesignCodetxt.Text) || string.IsNullOrWhiteSpace(ColorTxt.Text) || string.IsNullOrWhiteSpace(NumberOfPiecesTxt.Text) || string.IsNullOrWhiteSpace(QuantityInStockTxt.Text) || string.IsNullOrWhiteSpace(ProductPriceTxt.Text) ||
                 string.IsNullOrWhiteSpace(KameezaFabricTxt.Text) || string.IsNullOrWhiteSpace(ShalwarFabricTxt.Text) || string.IsNullOrWhiteSpace(DupattaFabricTxt.Text) || !IsImgUploaded)


            {
                MessageBox.Show("Please Fill All Fields And Mark Embroidery Status If Require");
            }
            else
            {
                try
                {


                    Admin.AddItem(ProductNametxt.Text, ProductIDtxt.Text, DesignCodetxt.Text, ColorTxt.Text, int.Parse(NumberOfPiecesTxt.Text), int.Parse(QuantityInStockTxt.Text), double.Parse(ProductPriceTxt.Text),
                        KameezaFabricTxt.Text, ShalwarFabricTxt.Text, DupattaFabricTxt.Text, EmbroideryStatus.GetItemChecked(0),
                        EmbroideryStatus.GetItemChecked(1), EmbroideryStatus.GetItemChecked(2), EmbroideryStatus.GetItemChecked(3),
                       o1.FileName);



                    ProductPicture.Image = ProductPicture.InitialImage;
                    ProductNametxt.Clear();
                    ProductIDtxt.Clear();
                    DesignCodetxt.Clear();
                    ColorTxt.ResetText();
                    NumberOfPiecesTxt.ResetText();
                    QuantityInStockTxt.ResetText();
                    ProductPriceTxt.ResetText();
                    KameezaFabricTxt.ResetText();
                    ShalwarFabricTxt.ResetText();
                    DupattaFabricTxt.ResetText();
                    ProductPicture.Image = ProductPicture.InitialImage;
                    //EmbroideryStatus.Refresh();
                    for (int i = 0; i < EmbroideryStatus.Items.Count; i++)
                    {
                        EmbroideryStatus.SetItemChecked(i, false);
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Product Id Already Reserved for some other product please try some other Id");
                    }
                }


            }
        }


        private void BrowsePic_Click(object sender, EventArgs e)
        {
            o1 = new OpenFileDialog();

            o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (o1.ShowDialog() == DialogResult.OK)
            {


                ProductPicture.Image = Image.FromFile(o1.FileName);
                //GraphicsPath gp = new GraphicsPath();
                //gp.AddEllipse(pictureBox1.DisplayRectangle);
                //pictureBox1.Region = new Region(gp);
                ProductImageEd.SizeMode = PictureBoxSizeMode.StretchImage;

                IsImgUploaded = true;

            }

        }
        private void AccountSettingBtn_Click(object sender, EventArgs e)
        {
            IsImgUploaded = false;
            Admin.LoadAccountWindow(ShopManager, UserID, ContactNumber, Address, Date, pictureBox1);
            AccountSetting.Show();
            AccountSetting.BringToFront();
        }

        private void UpdateSM_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Admin.Authenticate(textBox1.Text))
                {
                    string imgloc;
                    if (IsImgUploaded)
                    {

                        imgloc = Admin.SaveImage(o1.FileName);
                        Admin.UpdateShopManagerAccount(ShopManager.Text, textBox2.Text, ContactNumber.Text, Address.Text, imgloc);
                        ShopManager.Clear();
                        UserID.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        ContactNumber.Clear();
                        Address.Clear();
                        Date.Text = "";
                        pictureBox1.Image = pictureBox1.InitialImage;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;

                    }
                    else
                    {
                        imgloc = pictureBox1.ImageLocation;
                        Admin.UpdateShopManagerAccount(ShopManager.Text, textBox2.Text, ContactNumber.Text, Address.Text, imgloc);
                        ShopManager.Clear();
                        UserID.Clear();
                        textBox1.Clear();
                        textBox2.Clear();
                        ContactNumber.Clear();
                        Address.Clear();
                        Date.Text = "";
                        pictureBox1.Image = pictureBox1.InitialImage;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Current Password");
                }
            }
            else
            {
                string imgloc;
                if (IsImgUploaded)
                {

                    imgloc = Admin.SaveImage(o1.FileName);
                    Admin.UpdateShopManagerAccount(ShopManager.Text, ContactNumber.Text, Address.Text, imgloc);
                    ShopManager.Clear();
                    UserID.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    ContactNumber.Clear();
                    Address.Clear();
                    Date.Text = "";
                    pictureBox1.Image = pictureBox1.InitialImage;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;


                }
                else
                {
                    imgloc = pictureBox1.ImageLocation;
                    Admin.UpdateShopManagerAccount(ShopManager.Text, ContactNumber.Text, Address.Text, imgloc);
                    ShopManager.Clear();
                    UserID.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    ContactNumber.Clear();
                    Address.Clear();
                    Date.Text = "";
                    pictureBox1.Image = pictureBox1.InitialImage;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                }

            }
        }

        private void BrowseAccountSettings_Click(object sender, EventArgs e)
        {
            o1 = new OpenFileDialog();

            o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (o1.ShowDialog() == DialogResult.OK)
            {


                pictureBox1.Image = Image.FromFile(o1.FileName);

                GC.Collect();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                IsImgUploaded = true;
                //GraphicsPath gp = new GraphicsPath();
                //gp.AddEllipse(pictureBox1.DisplayRectangle);
                //pictureBox1.Region = new Region(gp);



            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void DeleteItemEd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductImageEd.Image.Dispose();
            ProductImageEd.Image = null;

            GC.Collect();
            Admin.DeleteProducut();
            EditItemBtn_Click(sender, e);

        }

        private void AddDeleteFabricInfoBtn_Click(object sender, EventArgs e)
        {//overload this method to load in list box...
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox7.Items.Clear();
            AddDeleteFAbricINfo.Show();
            AddDeleteFAbricINfo.BringToFront();
            Admin.ReadFabricInfo(listBox1, listBox2, listBox3,listBox7);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin.WriteFabricInfo();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void AddInfoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text) || !string.IsNullOrWhiteSpace(textBox4.Text) || !string.IsNullOrWhiteSpace(textBox6.Text) || !string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    listBox1.Items.Add(textBox3.Text);
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                    listBox2.Items.Add(textBox4.Text);
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                    listBox3.Items.Add(textBox6.Text);
                if(!string.IsNullOrWhiteSpace(textBox7.Text))
                    listBox7.Items.Add(textBox7.Text);
                Admin.AddInfo(textBox4.Text, textBox3.Text, textBox6.Text,textBox7.Text);
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            DeleteItem.Show();
            DeleteItem.BringToFront();
            Admin.ReadFabricInfo(listBox6, listBox5, listBox4,listBox8);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddDeleteFAbricINfo.BringToFront();
            DeleteItem.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                Admin.DeleteFabricInfoColor(listBox6.SelectedItem.ToString());
                listBox6.Items.Remove(listBox6.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Item then press delete");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.DeleteFabricInfoName(listBox5.SelectedItem.ToString());
                listBox5.Items.Remove(listBox5.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Item then press delete");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.DeleteFabricInfoStitchingType(listBox4.SelectedItem.ToString());
                listBox4.Items.Remove(listBox4.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Item then press delete");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {

                Admin.DeleteDesignCode(listBox8.SelectedItem.ToString());
                listBox8.Items.Remove(listBox8.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Item then press delete");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Admin.SearchProduct(comboBox1.Text))
            {
                ProductImageEd.Image = ProductPicture.InitialImage;
                ProductImageEd.Enabled = true;
                ProductNameEd.Enabled = true;
                ProductIdEd.Enabled = true;
                ColorEd.Enabled = true;
                ProductPriceEd.Enabled = true;
                QuantityInStockEd.Enabled = true;
                KameezFabricEd.Enabled = true;
                ShalwarFabricEd.Enabled = true;
                DupattaFabricEd.Enabled = true;
                EmbroideryStatusEd.Enabled = true;
                NumberOfPiecesEd.Enabled = true;
                DesignCodeEd.Enabled = true;
                UpdateChanges.Enabled = true;
                DeleteItemEd.Enabled = true;
                Admin.ReadFabricInfo(ColorEd, KameezFabricEd, ShalwarFabricEd, DupattaFabricEd);
                Admin.LoadDataEditItem(ProductNameEd, ProductIdEd, DesignCodeEd, ColorEd, NumberOfPiecesEd, QuantityInStockEd, ProductPriceEd, KameezFabricEd, ShalwarFabricEd, DupattaFabricEd, EmbroideryStatusEd, ProductImageEd);
            }
        }
    }
}
