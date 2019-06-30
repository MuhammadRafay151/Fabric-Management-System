using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicDateTimePicker
{
    public partial class DynamicDateTimePicker: UserControl
    {
        public DynamicDateTimePicker()
        {
            InitializeComponent();
           
        }
        DataGridView d1;
        int Cindex;
        int Rindex;
        public DynamicDateTimePicker(DataGridView d1, int Cindex, int Rindex)
        {
            InitializeComponent();
            this.d1 = d1;
            this.Cindex = Cindex;
            this.Rindex = Rindex;
            
          
            
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            d1.Rows[Rindex].Cells[Cindex].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.Dispose();
           
        }
        public void SetLocation(Point CursorPositon)
        {
            Point p1 = PointToClient(CursorPositon);

            this.Location = new Point(p1.X, p1.Y);
        }
    }
}
