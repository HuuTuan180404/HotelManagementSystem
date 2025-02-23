using HotelManagementApp.Classes;
using HotelManagementApp.Forms;
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

namespace HotelManagementApp
{
    public partial class Main : Form
    {
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

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Show();
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
            Debug.WriteLine("CLICK");
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingManagement bookingManagement = new BookingManagement();
            bookingManagement.Show();
        }
    }
}
