using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicDateTimePicker;
using Entities;


namespace PuttingOrderForShipment
{
    public partial class Form1 : Form
    {
        DynamicDateTimePicker.DynamicDateTimePicker DynamicPanel;
        ShipmentOrderController ShipOrder;
        Dealer dealer;
        private bool IsImgUploaded;
        OpenFileDialog o1;

        public Form1(Dealer dealer)
        {
            InitializeComponent();
            this.dealer = dealer;
            DealerId.Text += " " + dealer.UserId;
            ShipOrder = new ShipmentOrderController(dealer);

        }
        public Form1()
        {
            InitializeComponent();
      

        }

        private void BillDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (DynamicPanel == null || DynamicPanel.IsDisposed)
                {
                    DynamicPanel = new DynamicDateTimePicker.DynamicDateTimePicker(BillDataGridView, e.ColumnIndex, e.RowIndex);
                    this.Controls.Add(DynamicPanel);
                    DynamicPanel.SetLocation(Cursor.Position);
                    DynamicPanel.BringToFront();
                    DynamicPanel.Show();
                }
                else
                {
                    DynamicPanel.Show();
                    DynamicPanel.BringToFront();
                }
            }
            if (e.ColumnIndex == 8)
            {
                o1 = new OpenFileDialog();

                o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (o1.ShowDialog() == DialogResult.OK)
                {


                    BillDataGridView[e.ColumnIndex, e.RowIndex].Value = Image.FromFile(o1.FileName);

                    IsImgUploaded = true;
                    //GraphicsPath gp = new GraphicsPath();
                    //gp.AddEllipse(pictureBox1.DisplayRectangle);
                    //pictureBox1.Region = new Region(gp);

                    
                }
            }
        }




        private void UpdateButton_Click(object sender, EventArgs e)
        {
           
            string date = BillIssueDateDateTimePicker.Value.ToString("yyyy-MM-dd");
            bool isempty = true;
            for (int i = 0; i < BillDataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < BillDataGridView.ColumnCount; j++)
                {if (j == 5 || j == 8)
                        continue;
                    try
                    {
                        if (string.IsNullOrWhiteSpace(BillDataGridView.Rows[i].Cells[j].Value.ToString()) || BillDataGridView.Rows[i].Cells[j].Value == null)
                        {

                            isempty = true;
                            break;
                        }
                        else
                            isempty = false;
                    }
                    catch (NullReferenceException) { isempty = true; }
                }
                if (i == BillDataGridView.RowCount - 1)
                    isempty = false;
                if (isempty)
                    break;
               
            }
            MessageBox.Show(isempty.ToString());
            if (string.IsNullOrWhiteSpace(BillNumberTextBox.Text))
                isempty = true;
            if (!isempty)
            {
                if (IsImgUploaded)
                {
                    Button1_Click_1(sender, e);
                    ShipOrder.CompleteOrderRecord(BillDataGridView, BillNumberTextBox.Text, date, dealer.UserId, o1.FileName);

                }
                else
                {
                    Button1_Click_1(sender, e);
                    ShipOrder.CompleteOrderRecord(BillDataGridView, BillNumberTextBox.Text,date, dealer.UserId,string.Empty);

                }
                if (DynamicPanel != null)
                {
                    DynamicPanel.Dispose();

                }
                BillNumberTextBox.Clear();
                BillIssueDateDateTimePicker.ResetText();
                BillDataGridView.Rows.Clear();
            }
            else
            {
                MessageBox.Show("please input complete information");
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ShipOrder.ReadFabricInfo(FabricTypeCol);
        }

     

        private void Button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < BillDataGridView.RowCount-1; i++)
            {
               BillDataGridView.Rows[i].Cells[5].Value = double.Parse(BillDataGridView.Rows[i].Cells[0].Value.ToString()) * double.Parse(BillDataGridView.Rows[i].Cells[4].Value.ToString());
            }
            label2.Text = ShipOrder.GetTotalBillAmount(BillDataGridView).ToString();
        }
    }
}
