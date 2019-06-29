using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
namespace Administrator
{
    public partial class SignUp : UserControl
    {
        AdministratorController Admin;
        
        bool IsImgUploaded = false;   
        
        OpenFileDialog o1;
        public SignUp(AdministratorController Admin)
        {//passing contrller to the signupform....
           
            InitializeComponent();
          Date.Text= DateTime.Today.Date.ToString("yyyy-MM-dd");
            
            this.Admin = Admin;
          
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShopManager.Text) || string.IsNullOrWhiteSpace(UserID.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(Address.Text) || string.IsNullOrWhiteSpace(ContactNumber.Text)|| IsImgUploaded==false)
            {
                
                timer1.Start();
                Note.Show();
            }
            else
            {
                
                Admin.Register(ShopManager.Text, UserID.Text, Password.Text, ContactNumber.Text, Address.Text, o1.FileName, DateTime.Now.ToString("yyyy-MM-dd"));
                this.Dispose();

            }
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Note.Hide();
            timer1.Stop();
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

      
    }
}
