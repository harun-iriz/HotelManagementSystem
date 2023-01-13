using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMangementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left;
            uC_AddRoom1.Visible= true;
            uC_AddRoom1.BringToFront();
        }

        private void btnChechout_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnChechout.Left;
            uC_CustomerChechOut1.Visible = true;
            uC_CustomerChechOut1.BringToFront() ;
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetail.Left;
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_CustomerRegistration1.Visible= false;
            uC_CustomerChechOut1.Visible=false;
            customerDetails1.Visible=false;
            btnAddRoom.PerformClick();
        }
    }
}
