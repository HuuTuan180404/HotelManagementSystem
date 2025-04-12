using Presentation.Forms;
using Presentation.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Main : Form
    {
        private bool sideBarIsShow = false;
        private Timer timer;
        public Main()
        {
            InitializeComponent();
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss dddd, dd/MM/yyyy");
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss dddd, dd/MM/yyyy");
        }

        private void pic_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            UC_BookingManagement.BringToFront();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            UC_RoomManagement.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_CustomerManagement.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_EmployeeManagement1.BringToFront();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogout_MouseClick(object sender, MouseEventArgs e)
        {
            logout();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            Test test = new Test();
            test.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarIsShow)
            {
                sideBar.Width -= 20;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarIsShow = false;
                    timer1.Stop();
                }
            }
            else
            {
                sideBar.Width += 20;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarIsShow = true;
                    timer1.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //UC_Test.BringToFront();
        }

        private void UC_BookingManagement_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC_BookingManagement.Left = (panelUC.ClientSize.Width - UC_BookingManagement.Width) / 2;
            UC_BookingManagement.Top = (panelUC.ClientSize.Height - UC_BookingManagement.Height) / 2;
        }
    }
}
