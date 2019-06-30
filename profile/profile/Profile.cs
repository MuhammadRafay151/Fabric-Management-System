using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuttingOrderForShipment;
using Entities;
using PuttingOrderForEmbroidery;
using PuttingOrderForStitching;
namespace profile
{
    public partial class Profile : Form
    {
        ProfileController p1;
        PuttingOrderForShipment.Form1 f1;
        PuttingOrderForCalendar.Form1 f2;
        PuttingOrderForEmbroidery.Form1 f3;
        PuttingOrderForStitching.Form1 f4;
        PlaceOrder.Order OrderWindow;
        OpenFileDialog o1;
        private bool IsImgUploaded;

        public Profile()
        {
            InitializeComponent();
            p1 = new ProfileController();

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (Registration.Visible == false)
                Registration.Visible = true;
            label7.Text += ":  " + DateTime.Now.ToShortDateString();
            Registration.BringToFront();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            SearchPanel.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Container.BringToFront();
            if (Customer.Checked)
            {
                if (!string.IsNullOrWhiteSpace(SearchTextBox.Text))
                {
                    if (p1.SearchCustomer(SearchTextBox.Text))
                    {
                        CustomerContainer.BringToFront();
                        SearchPanel.Hide();
                        Registration.Hide();

                        AmountPayment.Hide();
                        amountpaymentcu.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Wrong ID");
                    }
                }
            }
            else if (Dealer.Checked)
            {
                if (p1.SearchDealer(SearchTextBox.Text))
                {
                    DealerContainer.BringToFront();
                    SearchPanel.Hide();
                    Registration.Hide();

                    AmountPayment.Hide();
                    amountpaymentcu.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong ID");
                }
            }
            Registration.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            amountpaymentcu.Show();
            amountpaymentcu.BringToFront();
            label35.Text = "Total Amount Paid = " + p1.GetCustomer.TotalAMountPaid;
            label31.Text = "Remainig Amount to pay = " + p1.GetCustomer.RemainingAmount;


        }

        private void CloseProfile_Click(object sender, EventArgs e)
        {//close profile and destroy the objects....
            dashboardpanelcupanel.Hide();
            dataGridView2.Hide();
            amountpaymentcu.Hide();
            SearchPanel.Visible = true;
            SearchPanel.BringToFront();
            if (OrderWindow != null)
            {

                OrderWindow.Dispose();
                OrderWindow = null;

            }

        }

        private void PaymentDealer_Click(object sender, EventArgs e)
        {
            label11.Text = "Total Amount Paid = " + p1.GetDealer.TotalAMountPaid;
            label12.Text = "Remainig Amount to pay = " + p1.GetDealer.RemainingAmount;
            AmountPaymentMaskedTextBox.Clear();
            AmountPayment.Show();
            AmountPayment.BringToFront();

        }


        private void CloseDealerProfile_Click(object sender, EventArgs e)
        {
            dashboardpanel.Hide();
            BillViewContainer.Hide();
            AmountPayment.Hide();

            SearchPanel.Visible = true;
            SearchPanel.BringToFront();
            if (f1 != null && !f1.IsDisposed)
            {
                f1.Close();
                f1.Hide();
                f1.Dispose();
                f1 = null;

            }

            if (f2 != null && !f2.IsDisposed)
            {

                f2.Close();
                f2.Hide();
                f2.Dispose();
                f2 = null;

            }
            if (f3 != null && !f3.IsDisposed)
            {

                f3.Close();
                f3.Hide();
                f3.Dispose();
                f3 = null;

            }
            if (f4 != null && !f4.IsDisposed)
            {

                f4.Close();
                f4.Hide();
                f4.Dispose();
                f4 = null;

            }
        }

        private void PlaceCustomerOrder_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach (Form open in Application.OpenForms)
            {
                if (open.Name == "Order")
                    check = true;
            }
            if (!check)
            {
                OrderWindow = new PlaceOrder.Order(p1.GetCustomer);
                OrderWindow.Width = this.Width;

                OrderWindow.TopLevel = false;
                CustomerContainer.Controls.Add(OrderWindow);
                OrderWindow.Dock = DockStyle.Fill;

                OrderWindow.Show();
                OrderWindow.BringToFront();
                if (this.IsMdiChild == true)
                {

                    this.MdiParent.WindowState = FormWindowState.Maximized;
                }
                else
                    this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                if (this.IsMdiChild == true)
                {

                    this.MdiParent.WindowState = FormWindowState.Maximized;
                }
                else
                    this.WindowState = FormWindowState.Maximized;
                OrderWindow.BringToFront();
                OrderWindow.Show();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (DealerRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(UserIdMaskedTextBox.Text) || string.IsNullOrWhiteSpace(AccountNameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumMaskedTextBox.Text) || string.IsNullOrWhiteSpace(ShopAddressTextBox.Text) || string.IsNullOrWhiteSpace(DealerType.Text))
                {
                    MessageBox.Show("Enter All Fields");


                }
                else
                {
                    if (!IsImgUploaded)
                    {


                        p1.CreateAccountDealer(UserIdMaskedTextBox.Text, AccountNameTextBox.Text, ContactNumMaskedTextBox.Text, ShopAddressTextBox.Text, DateTime.Now.ToString("yyyy-MM-dd"), "Dealer", DealerType.Text);
                        UserIdMaskedTextBox.Clear();
                        AccountNameTextBox.Clear();
                        ContactNumMaskedTextBox.Clear();
                        ShopAddressTextBox.Clear();
                        DealerType.Text = "";
                        label7.ResetText();
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = pictureBox1.InitialImage;
                        SearchPanel.Show();
                        SearchPanel.BringToFront();
                    }
                    else
                    {

                        p1.CreateAccountDealer(UserIdMaskedTextBox.Text, AccountNameTextBox.Text, ContactNumMaskedTextBox.Text, ShopAddressTextBox.Text, DateTime.Now.ToString("yyyy-MM-dd"), "Dealer", o1.FileName, DealerType.Text);
                        UserIdMaskedTextBox.Clear();
                        AccountNameTextBox.Clear();
                        ContactNumMaskedTextBox.Clear();
                        ShopAddressTextBox.Clear();
                        DealerType.Text = "";
                        label7.ResetText();
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = pictureBox1.InitialImage;
                        SearchPanel.Show();
                        SearchPanel.BringToFront();
                    }
                }
            }
            if (CustomerRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(UserIdMaskedTextBox.Text) || string.IsNullOrWhiteSpace(AccountNameTextBox.Text) || string.IsNullOrWhiteSpace(ContactNumMaskedTextBox.Text) || string.IsNullOrWhiteSpace(ShopAddressTextBox.Text))
                {
                    MessageBox.Show("Enter All Fields");


                }
                else
                {
                    if (!IsImgUploaded)
                    {


                        p1.CreateAccountCustomer(UserIdMaskedTextBox.Text, AccountNameTextBox.Text, ContactNumMaskedTextBox.Text, ShopAddressTextBox.Text, DateTime.Now.ToString("yyyy-MM-dd"), "Customer");
                        CustomerContainer.BringToFront();
                        UserIdMaskedTextBox.Clear();
                        AccountNameTextBox.Clear();
                        ContactNumMaskedTextBox.Clear();
                        ShopAddressTextBox.Clear();

                        label7.ResetText();
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = pictureBox1.InitialImage;
                        SearchPanel.Show();
                        SearchPanel.BringToFront();
                    }
                    else
                    {


                        p1.CreateAccountCustomer(UserIdMaskedTextBox.Text, AccountNameTextBox.Text, ContactNumMaskedTextBox.Text, ShopAddressTextBox.Text, DateTime.Now.ToString("yyyy-MM-dd"), "Customer", o1.FileName);
                        CustomerContainer.BringToFront();
                        UserIdMaskedTextBox.Clear();
                        AccountNameTextBox.Clear();
                        ContactNumMaskedTextBox.Clear();
                        ShopAddressTextBox.Clear();

                        label7.ResetText();
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = pictureBox1.InitialImage;
                        SearchPanel.Show();
                        SearchPanel.BringToFront();
                    }
                }
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            o1 = new OpenFileDialog();

            o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (o1.ShowDialog() == DialogResult.OK)
            {


                pictureBox1.Image = Image.FromFile(o1.FileName);
                //GraphicsPath gp = new GraphicsPath();
                //gp.AddEllipse(pictureBox1.DisplayRectangle);
                //pictureBox1.Region = new Region(gp);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                IsImgUploaded = true;

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void DealerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DealerType.Enabled = true;
            label6.Text = "Shop Address:";
        }

        private void CustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DealerType.Enabled = false;
            label6.Text = "Address:";
        }

        private void DealerOrder_Click(object sender, EventArgs e)
        {

            if (p1.GetDealer.dealertype == "Shipment Dealer")
            {
                f1 = new PuttingOrderForShipment.Form1(p1.GetDealer);
                f1.TopLevel = false;
                DealerContainer.Controls.Add(f1);
                this.WindowState = FormWindowState.Maximized;

                f1.Show();
                f1.BringToFront();
                f1.Dock = DockStyle.Fill;
                //  MessageBox.Show("");
            }
            else if (p1.GetDealer.dealertype == "Calendaring Dealer")
            {
                f2 = new PuttingOrderForCalendar.Form1(p1.GetDealer);
                f2.TopLevel = false;
                DealerContainer.Controls.Add(f2);

                f2.Show();
                f2.BringToFront();
                f2.Dock = DockStyle.Fill;
            }
            else if (p1.GetDealer.dealertype == "Embroidery Dealer")
            {
                f3 = new PuttingOrderForEmbroidery.Form1(p1.GetDealer);
                f3.TopLevel = false;
                DealerContainer.Controls.Add(f3);

                f3.Show();
                f3.BringToFront();
                f3.Dock = DockStyle.Fill;
            }
            else if (p1.GetDealer.dealertype == "Stitching Dealer")
            {
                f4 = new PuttingOrderForStitching.Form1(p1.GetDealer);
                f4.TopLevel = false;
                DealerContainer.Controls.Add(f4);

                f4.Show();
                f4.BringToFront();
                f4.Dock = DockStyle.Fill;
            }

            //if (this.IsMdiChild == true)
            //{

            //    this.MdiParent.WindowState = FormWindowState.Maximized;
            //}
            //else
            this.WindowState = FormWindowState.Maximized;

        }

        private void AddToAccountsButton_Click(object sender, EventArgs e)
        {
            if (double.Parse(AmountPaymentMaskedTextBox.Text) <= p1.GetDealer.RemainingAmount)
                p1.Payamount(double.Parse(AmountPaymentMaskedTextBox.Text));
            else
                MessageBox.Show("You have to pay only " + p1.GetDealer.RemainingAmount);
            label11.Text = "Total Amount Paid = " + p1.GetDealer.TotalAMountPaid;
            label12.Text = "Remainig Amount to pay = " + p1.GetDealer.RemainingAmount;
            AmountPaymentMaskedTextBox.Clear();
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            //p1.get dealer

            DashBoard.Show();
            DashBoard.BringToFront();
            BillViewContainer.Controls.Clear();
            pictureBox2.Image.Dispose();
            label13.ResetText();
            label14.ResetText();
            label19.ResetText();
            label20.ResetText();
            label15.ResetText();
            label16.ResetText();
            label21.ResetText();
            label17.ResetText();
            label18.ResetText();
            pictureBox2.Image = Image.FromFile(p1.GetDealer.ImagePath);
            label13.Text = "Name: " + p1.GetDealer.Name;
            label14.Text = "User Id: " + p1.GetDealer.UserId;
            label19.Text = "Contact No.: " + p1.GetDealer.ContactNo;
            label20.Text = "Address: " + p1.GetDealer.Address;
            label15.Text = "Profile Type: " + p1.GetDealer.profile_type;
            label16.Text = "Dealer Type" + p1.GetDealer.dealertype;
            label21.Text = "Join Date:" + DateTime.Parse(p1.GetDealer.joindate).ToShortDateString();
            label17.Text = "Remaining Amount: " + p1.GetDealer.RemainingAmount;
            label18.Text = "Total Amount: " + p1.GetDealer.TotalAMountPaid;
            if (p1.GetDealer.dealertype == "Embroidery Dealer")
            {
                dashboardpanel.Show();
                dashboardpanel.BringToFront();
                EmbroideryOrder[] e1 = p1.LoadPrevoiusEmbdDealerTransactions();
                dataGridView1.Rows.Clear();
                if (e1.Length > 0)
                    dataGridView1.Rows.Add(e1.Length);
                for (int i = 0; i < e1.Length; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = e1[i].BillNo;


                }
            }
            else if (p1.GetDealer.dealertype == "Calendaring Dealer")
            {
                dashboardpanel.Show();
                dashboardpanel.BringToFront();
                CalendaringOrder[] e1 = p1.LoadPrevoiusCalendarDealerTransactions();
                dataGridView1.Rows.Clear();
                if (e1.Length > 0)
                    dataGridView1.Rows.Add(e1.Length);
                for (int i = 0; i < e1.Length; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = e1[i].BillNo;


                }
            }
            else if (p1.GetDealer.dealertype == "Stitching Dealer")
            {
                dashboardpanel.Show();
                dashboardpanel.BringToFront();
                StitchingOrder[] e1 = p1.LoadPrevoiusStitchingDealerTransactions();
                dataGridView1.Rows.Clear();
                if (e1.Length > 0)
                    dataGridView1.Rows.Add(e1.Length);
                for (int i = 0; i < e1.Length; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = e1[i].BillNo;


                }
            }
            else if (p1.GetDealer.dealertype == "Shipment Dealer")
            {
                dashboardpanel.Show();
                dashboardpanel.BringToFront();
                ShipmentOrder[] e1 = p1.LoadPrevoiusShipmentDealerTransactions();
                dataGridView1.Rows.Clear();
                if (e1.Length > 0)
                    dataGridView1.Rows.Add(e1.Length);
                for (int i = 0; i < e1.Length; i++)
                {

                    dataGridView1.Rows[i].Cells[0].Value = e1[i].BillNo;


                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//start from here ....
            if (e.ColumnIndex == 1)
            {

                if (p1.GetDealer.dealertype == "Embroidery Dealer")
                {
                    try
                    {
                        string billno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        EmbroideryBillView view = new EmbroideryBillView(p1.LoadPrevoiusEmbdDealerBill(billno), p1.LoadEmbroideryOrderTransactiondetails(billno));
                        this.WindowState = FormWindowState.Maximized;
                        BillViewContainer.Controls.Add(view);
                        view.Dock = DockStyle.Fill;
                        BillViewContainer.Dock = DockStyle.Fill;
                        BillViewContainer.Show();
                        BillViewContainer.BringToFront();
                    }
                    catch (NullReferenceException) { }
                }
                else if (p1.GetDealer.dealertype == "Calendaring Dealer")
                {
                    try
                    {
                        string billno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        CalendarBillView view = new CalendarBillView(p1.LoadPrevoiusCalendarDealerBill(billno), p1.LoadCalendarOrderTransactionDetails(billno));
                        this.WindowState = FormWindowState.Maximized;
                        BillViewContainer.Controls.Add(view);
                        view.Dock = DockStyle.Fill;
                        BillViewContainer.Show();
                        BillViewContainer.BringToFront();
                    }
                    catch (NullReferenceException)
                    { }
                }
                else if (p1.GetDealer.dealertype == "Stitching Dealer")
                {
                    try
                    {
                        string billno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        StitchingBillVIew view = new StitchingBillVIew(p1.LoadPrevoiusStitchingDealerBill(billno), p1.LoadStitchingOrderTransactionDetails(billno));
                        this.WindowState = FormWindowState.Maximized;
                        BillViewContainer.Controls.Add(view);
                        view.Dock = DockStyle.Fill;
                        BillViewContainer.Show();
                        BillViewContainer.BringToFront();
                    }
                    catch (NullReferenceException)
                    { }
                }
                else if (p1.GetDealer.dealertype == "Shipment Dealer")
                {
                    try
                    {
                        string billno = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ShipmentBillView view = new ShipmentBillView(p1.LoadPrevoiusShipmentDealerBill(billno), p1.LoadShipmentOrderTransaction(billno));
                        this.WindowState = FormWindowState.Maximized;
                        BillViewContainer.Controls.Add(view);

                        view.Dock = DockStyle.Fill;
                        BillViewContainer.Show();
                        BillViewContainer.BringToFront();
                    }
                    catch (NullReferenceException) { }
                }
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            //
        }

        private void DashBoardCuBtn_Click(object sender, EventArgs e)
        {
            dashboardpanelcupanel.Show();
            dashboardpanelcupanel.BringToFront();
            //BillViewCustomer.Controls.Clear();
            dataGridView2.Show();
            pictureBox3.Image.Dispose();
            label34.ResetText();
            label33.ResetText();
            label28.ResetText();
            label27.ResetText();
            label32.ResetText();
            label26.ResetText();
            label30.ResetText();
            label29.ResetText();
            pictureBox3.Image = Image.FromFile(p1.GetCustomer.ImagePath);
            label34.Text = "Name: " + p1.GetCustomer.Name;
            label33.Text = "User Id: " + p1.GetCustomer.AccountNo;
            label28.Text = "Contact No.: " + p1.GetCustomer.ContactNo;
            label27.Text = "Address: " + p1.GetCustomer.Address;
            label32.Text = "Profile Type: " + p1.GetCustomer.profile_type;
            label26.Text = "Join Date:" + DateTime.Parse(p1.GetCustomer.joindate).ToShortDateString();
            label30.Text = "Remaining Amount: " + p1.GetCustomer.RemainingAmount;
            label29.Text = "Total Amount: " + p1.GetCustomer.TotalAMountPaid;

            dashboardpanelcupanel.Show();
            dashboardpanelcupanel.BringToFront();
            CustomerOrder[] e1 = p1.LoadPreviousCustomerOrders();
            dataGridView2.Rows.Clear();
            if (e1.Length > 0)
                dataGridView2.Rows.Add(e1.Length);
            for (int i = 0; i < e1.Length; i++)
            {

                dataGridView2.Rows[i].Cells[0].Value = e1[i].BillNo;


            }





        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //amount payment customer...
            if (double.Parse(maskedTextBox1.Text) <= p1.GetCustomer.RemainingAmount)
                p1.CustomerPayamount(double.Parse(maskedTextBox1.Text));
            else
                MessageBox.Show("You have to pay only " + p1.GetCustomer.RemainingAmount);
            label35.Text = "Total Amount Paid = " + p1.GetCustomer.TotalAMountPaid;
            label31.Text = "Remainig Amount to pay = " + p1.GetCustomer.RemainingAmount;
            AmountPaymentMaskedTextBox.Clear();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int billno = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    UserControl1 a = new UserControl1(p1.LoadPreviousCutomerBill(billno), p1.LoadCustomerTransactionDetails(billno));

                    this.WindowState = FormWindowState.Maximized;
                    panel15.Controls.Add(a);
                    a.Show();
                    a.Dock = DockStyle.Fill;
                    panel15.Show();
                    panel15.BringToFront();


                }
                catch (NullReferenceException) { }
            }
        }

        private void ReturnOrder_Click(object sender, EventArgs e)
        {
            label37.Text = "Total Amount Paid = " + p1.GetCustomer.TotalAMountPaid;
            label36.Text = "Remainig Amount to pay = " + p1.GetCustomer.RemainingAmount;
            panel14.BringToFront();
            panel14.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (double.Parse(maskedTextBox2.Text) >= p1.GetCustomer.RemainingAmount)
            {
                if (double.Parse(maskedTextBox2.Text) <= p1.GetCustomer.TotalAMountPaid)
                    p1.ReturnCustomerPayamount2(double.Parse(maskedTextBox2.Text));
                else MessageBox.Show("Insufficient Balance");
            }
            //  MessageBox.Show("You  only retrun " + p1.GetCustomer.RemainingAmount);

            else
            {

                p1.ReturnCustomerPayamount(double.Parse(maskedTextBox2.Text));
            }
            label37.Text = "Total Amount Paid = " + p1.GetCustomer.TotalAMountPaid;
            label36.Text = "Remainig Amount to pay = " + p1.GetCustomer.RemainingAmount;
            AmountPaymentMaskedTextBox.Clear();
        }

        private void Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Dealer_CheckedChanged(object sender, EventArgs e)
        {
            p1.GetDealerId(SearchTextBox);
        }

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {

            p1.GetCustomerId(SearchTextBox);
        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
