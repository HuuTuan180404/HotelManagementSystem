using Business;
using Guna.UI2.WinForms;
using Presentation.Forms;
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
using TheArtOfDevHtmlRenderer.Adapters;
using DataTransferObject;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.User_Controls
{
    public partial class UC_RoomManagement : UserControl
    {

        RoomBusiness RoomBusiness = new RoomBusiness();

        public UC_RoomManagement()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadDataFor_comboboxStatus();
            btnAllRoom.Text = $"Tất cả ({RoomBusiness.GetAllRooms().Count})";
            btnAvailableRoom.Text = $"Phòng trống ({RoomBusiness.GetAllRooms("Available").Count})";
            btnOccupiedRoom.Text = $"Có khách ({RoomBusiness.GetAllRooms("Occupied").Count})";
        }

        bool isFloor = true;
        private void btnChangeViewMode_Click(object sender, EventArgs e)
        {
            if (isFloor)
            {
                UC_ViewTableMode.BringToFront();
                isFloor = false;
                btnChangeViewMode.Image = Properties.Resources.mode_floor;
            }
            else
            {
                UC_ViewFloorMode.BringToFront();
                isFloor = true;
                btnChangeViewMode.Image = Properties.Resources.mode_table;
            }
        }

        private void loadDataFor_comboboxStatus()
        {
            comboboxStatus.Items.Clear();
            comboboxStatus.Items.Add("All status");
            comboboxStatus.SelectedIndex = 0;
            List<string> status = RoomBusiness.GetAllRoomStates().Select(x => x.RStatus).ToList();
            foreach (var item in status)
                comboboxStatus.Items.Add(item);
        }

        private void filterByStatus()
        {
            if (comboboxStatus.SelectedIndex != 0)
            {
                string status = comboboxStatus.SelectedItem.ToString();
                UC_ViewFloorMode.FIlterByStatus(status);
                UC_ViewTableMode.FIlterByStatus(status);
            }
            else
            {
                UC_ViewFloorMode.FIlterByStatus("");
                UC_ViewTableMode.FIlterByStatus("");
            }
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByStatus();
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            comboboxStatus.SelectedIndex = Convert.ToInt32(btnAllRoom.Tag);
        }

        private void btnAvailabelRoom_Click(object sender, EventArgs e)
        {
            comboboxStatus.SelectedItem = btnAvailableRoom.Tag;
        }

        private void btnOccupiedRoom_Click(object sender, EventArgs e)
        {
            comboboxStatus.SelectedItem = btnOccupiedRoom.Tag;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.DataChanged += LoadDataRoom;
            addRoom.ShowDialog();
        }

        private void LoadDataRoom()
        {
            string currentStatus = comboboxStatus.SelectedItem.ToString();
            Room_Load(null, null);
            comboboxStatus.SelectedItem = currentStatus;
            if (comboboxStatus.Items.Contains(currentStatus))
                comboboxStatus.SelectedItem = currentStatus;
            else comboboxStatus.SelectedIndex = 0;
        }

        private void txtSearch_IconRightClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
            txtSearch.IconRight = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.IconRight = null;
            }
            else
            {
                txtSearch.IconRight = Properties.Resources.x;
            }
            txtIconSearch_Click(sender, e);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtIconSearch_Click(sender, e);
            }
        }

        private void txtIconSearch_Click(object sender, EventArgs e)
        {
            //filterByStatus();
            string s = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(s))
            {
                UC_ViewFloorMode.FilterByString(s);
                UC_ViewTableMode.FilterByString(s);
            }
            else filterByStatus();
        }
    }
}
