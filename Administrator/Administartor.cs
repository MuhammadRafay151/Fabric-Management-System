using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administrator
{
    public partial class Administartor : Form
    {
        SignUp SN;
        AdministratorController Admin;
        public Administartor()
        {
            InitializeComponent();
            Admin = new AdministratorController();


        }



        private void SignIn_Click(object sender, EventArgs e)
        {//the exception is thrown when no shop manager is register.



            if (Admin.Authenticate(this.Password.Text))
            {
                //load further fronts;
                AdminProfile adminProfile = new AdminProfile(Admin);
                this.Controls.Add(adminProfile);
                adminProfile.Dock = DockStyle.Fill;
                adminProfile.BringToFront();
            }
            else
            {
                MessageBox.Show("Wrong Password ");
            }
            Password.Clear();

        }

        private void Administartor_Load(object sender, EventArgs e)
        {//the code checks if the session is first or not....
            try
            {
                Admin.ConnectDatabase();
                Admin.LoadUsername(UserName);
            }

            catch (SqlException)
            {
                MessageBox.Show("Database Connection failed");
            }
            catch (Exception)
            {
                MessageBox.Show("Welcome You are using application first time so get register to login");
                SN = new SignUp(Admin);
                this.Controls.Add(SN);
                SN.Dock = DockStyle.Fill;
                SN.Show();
                SN.BringToFront();
            }
        }
    }
}
