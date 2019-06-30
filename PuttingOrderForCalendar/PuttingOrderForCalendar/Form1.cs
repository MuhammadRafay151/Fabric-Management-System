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

namespace PuttingOrderForCalendar
{
    public partial class Form1 : Form
    {
        DynamicDateTimePicker.DynamicDateTimePicker DynamicPanel;
        Dealer dealer;
        private bool IsImgUploaded;
        OpenFileDialog o1;
        CalendarOrderController CalendarOrder;
       
        public Form1(Dealer dealer)
        {
            InitializeComponent();
            this.dealer = dealer;
            DealerId.Text += " " + dealer.UserId;
            CalendarOrder = new CalendarOrderController(dealer);
        }
        public Form1()
        {
            InitializeComponent();
            CalendarOrder = new CalendarOrderController();
            
           
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
           

            string date = BillIssueDateDateTimePicker.Value.ToString("yyyy-MM-dd");
            bool isempty = true;
            for (int i = 0; i < BillDataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < BillDataGridView.ColumnCount; j++)
                {
                    if (j == 6 || j == 9)
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
                if (isempty)
                    break;
                if (i == BillDataGridView.RowCount - 1)
                    isempty = false;
            }
            if (string.IsNullOrWhiteSpace(BillNumberTextBox.ToString()))
                isempty = true;
            if (!isempty)
            {
                
                if (IsImgUploaded)
                {
                    Button1_Click_1(sender, e);
                    CalendarOrder.CompleteOrderRecord(BillDataGridView, BillNumberTextBox.Text, date, dealer.UserId, o1.FileName);

                }
                else
                {
                    Button1_Click_1(sender, e);
                    CalendarOrder.CompleteOrderRecord(BillDataGridView, BillNumberTextBox.Text, date, dealer.UserId, string.Empty);

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
        private void Button1_Click_1(object sender, EventArgs e)
        {//calculation for total...
            for (int i = 0; i < BillDataGridView.RowCount - 1; i++)
            {
                BillDataGridView.Rows[i].Cells[6].Value = double.Parse(BillDataGridView.Rows[i].Cells[0].Value.ToString()) * double.Parse(BillDataGridView.Rows[i].Cells[5].Value.ToString());
            }
            label2.Text = CalendarOrder.GetTotalBillAmount(BillDataGridView).ToString();
        }

        private void BillDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Point p = PointToClient(Cursor.Position);
            if (e.ColumnIndex == 8)
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
            if (e.ColumnIndex == 9)
            {
                o1 = new OpenFileDialog();

                o1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (o1.ShowDialog() == DialogResult.OK)
                {


                    BillDataGridView[e.ColumnIndex, e.RowIndex].Value = Image.FromFile(o1.FileName);

                    IsImgUploaded = true;
                }
            }
            if (e.ColumnIndex == 3)
            {
                try
                {
                    
                    string dname = CalendarOrder.ReadFabricInfoDesignName(BillDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (!string.IsNullOrWhiteSpace(dname))
                    {
                        BillDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dname;

                    }
                }
                catch (NullReferenceException) { }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CalendarOrder.ReadFabricInfo(TypeOfLotsColumn);
            CalendarOrder.ReadFabricInfoDesignCode(DesignCodeColumn);
        }
    }
}
