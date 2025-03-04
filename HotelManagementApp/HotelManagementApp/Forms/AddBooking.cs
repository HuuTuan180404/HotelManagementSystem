using HotelManagementApp.Classes;
using HotelManagementApp.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.Forms
{
    public partial class AddBooking : Form
    {

        function function = new function();
        public AddBooking()
        {
            InitializeComponent();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            List<ClassRoom> classRooms = ClassRoom.getAllRooms();
            foreach (var i in classRooms)
            {
                //Debug.WriteLine(i.getRoomID());
                itemRoom item = new itemRoom(i);
                flowLayoutPanel.Controls.Add(item);
            }
        }

        int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool itemIsShow = false;

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (itemIsShow)
            {
                btnShowItem.Image = Properties.Resources.left;
                timer2.Stop();
                flowLayoutPanel.AutoScroll = false;
            }
            else
            {
                btnShowItem.Image = Properties.Resources.down;
                flowLayoutPanel.AutoScroll = true;
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (itemIsShow == false)
            {
                flowLayoutPanel.Height += 10;
                if (flowLayoutPanel.Height >= flowLayoutPanel.MaximumSize.Height)
                {
                    itemIsShow = true;
                    timer1.Stop();
                }
            }
            else
            {
                flowLayoutPanel.Height -= 10;
                if (flowLayoutPanel.Height <= flowLayoutPanel.MinimumSize.Height)
                {
                    itemIsShow = false;
                    timer1.Stop();
                }
            }
        }

        private void btnShowItem_Leave(object sender, EventArgs e)
        {
            if (itemIsShow) { btnShowItem.PerformClick(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (itemRoom.IS_SELECTED)
            {
                btnShowItem.Text = itemRoom.ID;
                timer2.Start();
                itemRoom.IS_SELECTED = false;
            }
        }

        private void timeCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckin.Text = string.Empty;
            }
        }

        private void timeCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                timeCheckout.Text = string.Empty;
            }
        }

        private void dateCheckin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckin.Text = string.Empty;
            }
        }

        private void dateCheckout_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                dateCheckout.Text = string.Empty;
            }
        }

        private void timeCheckin_Click(object sender, EventArgs e)
        {
            timeCheckin.SelectionStart = 0;
        }

        private void timeCheckout_Click(object sender, EventArgs e)
        {
            timeCheckout.SelectionStart = 0;
        }

        private void dateCheckin_Click(object sender, EventArgs e)
        {
            dateCheckin.SelectionStart = 0;
        }

        private void dateCheckout_Click(object sender, EventArgs e)
        {
            dateCheckout.SelectionStart = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void timeCheckin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}