using HotelManagementApp.Classes;
using System;
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
    public partial class itemRoom : UserControl
    {
        public static bool IS_SELECTED = false;
        public static string ID = null;

        private ClassRoom room;
        ClassRoom_Type roomType;

        public itemRoom()
        {
            InitializeComponent();
        }

        public itemRoom(ClassRoom room) : this()
        {
            this.room = room;
            room_id.Text = room.getRoomID();
            type.Text = $"Type: {room.RType}";
            roomType = room.getRoomType();
            guests.Text = $"Guests: {roomType.RTMaxGuests}";
            bed.Text = $"Bed: {roomType.RTBedCount}";

            price.Text = $"Price: {room.RPricePerNight}";
            description.Text = $"Price: {room.RDescription}";

            registerClickEvents(this);
        }

        private void itemRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void registerClickEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Click += Control_Click;
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            click();
        }

        private void itemRoom_Click(object sender, EventArgs e)
        {
            click();
        }

        private void click()
        {
            IS_SELECTED = true;
            ID = $"{room_id.Text} - {roomType.RType} - Bed: {roomType.RTBedCount} - Guest: {roomType.RTMaxGuests}";
        }
    }
}
