using HotelManagementApp.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.User_Controls
{
    public partial class UC_BookingManagement : UserControl
    {

        function function = new function();
        public UC_BookingManagement()
        {
            InitializeComponent();
        }       

        private void UC_BookingManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = ClassBookings.TABLE_Bookings + " ORDER BY BID DESC";

            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Clcick");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(timeCheckIn_1.Text+" "+timeCheckIn_2.Text);
        }
    }
}
