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
using System.Runtime.Remoting.Contexts;

namespace HotelMangementSystem
{
    public partial class LoginPage : System.Windows.Forms.Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-TR88KHI;Initial Catalog=Hotel_Management_System;Integrated Security=True";
        SqlConnection db1 = new SqlConnection(constring);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "haruniriz" && txtPassword.Text == "123456")
            {
                labelError.Visible= false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelError.Visible= true;
                txtPassword.Clear();
            }
        }
    }
}
