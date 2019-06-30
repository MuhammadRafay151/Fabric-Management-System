using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace DynamicDateTimePicker
{
    public partial class DynamicStitchingTypeSelector : UserControl
    {
        DataGridView gridview;
        int rowindex;
        int columnindex;
        string TypesOfStitching = null;
        string stitchtype = null;
        public DynamicStitchingTypeSelector()
        {
            InitializeComponent();
            string[] a = new string[] { "rat", "blue", "purple" };
            foreach (string i in a)
            {
                dataGridView1.Rows.Add(i);
            }
        }
        public DynamicStitchingTypeSelector(FabricInfo[] types)
        {
            InitializeComponent();
            foreach (FabricInfo i in types)
            {
                dataGridView1.Rows.Add(i.Stitching_Type);
            }
        }
        public void LocationOfPanel(DataGridView gridview, int rowindex, int columnindex)
        {
            this.rowindex = rowindex;
            this.columnindex = columnindex;
            this.gridview = gridview;
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    TypesOfStitching = TypesOfStitching + dataGridView1.Rows[i].Cells[0].Value + ", ";
                }
            }
            if (TypesOfStitching != null)
            {
                for (int i = 0; i < TypesOfStitching.Length - 2; i++)
                {
                    stitchtype = stitchtype + TypesOfStitching[i];
                }
                gridview.Rows[rowindex].Cells[columnindex].Value = stitchtype;
            }
            
            TypesOfStitching = null;
            stitchtype = null;
            this.Dispose();
        }
        public void SetLocation(Point CursorPositon)
        {
            Point p1 = PointToClient(CursorPositon);

            this.Location = new Point(p1.X, p1.Y);
        }
    }
}
