using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.User_Controls
{
    public partial class itemRoom : UserControl
    {
        public static bool IS_SELECTED = false;
        public static string ID = null;

        public static string RoomId = null;
        public RoomDTO RoomDTO { get; set; }

        private itemRoom()
        {
            InitializeComponent();
            registerClickEvents(this);
        }

        public itemRoom(RoomDTO roomDTO) : this()
        {
            RoomDTO = roomDTO;
        }

        private void itemRoom_Load(object sender, EventArgs e)
        {
            room_id.Text = RoomDTO.RId;
            type.Text = $"Type: {RoomDTO.RType}";
            guests.Text = $"Guests: {RoomDTO.RTMaxGuests}";
            bed.Text = $"Bed: {RoomDTO.RTBedCount}";
            price.Text = $"Price: {RoomDTO.RPricePerNight}";
            description.Text = $"Description: {RoomDTO.RDescription}";
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
            RoomId = RoomDTO.RId;
            ID = $"{RoomDTO.RId} - {RoomDTO.RType}";
        }
    }
}
