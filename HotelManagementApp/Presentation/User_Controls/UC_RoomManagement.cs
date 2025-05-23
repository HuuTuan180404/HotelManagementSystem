﻿using Business;
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
        RoomB RoomBusiness = new RoomB();
        private List<RoomDTO> currentList = null;

        public UC_RoomManagement()
        {
            InitializeComponent(); ThayDoiMau();
            currentList = RoomBusiness.GetAllRooms();
        }

        private void ThayDoiMau()
        {
            panel3.BackColor = ColorTranslator.FromHtml("#F4F6F9");
            panel2.BackColor = ColorTranslator.FromHtml("#F4F6F9");
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadDataFor_comboboxStatus();
            btnAllRoom.Text = $"Tất cả ({RoomBusiness.GetAllRooms().Count})";
            btnAvailableRoom.Text = $"Phòng trống ({RoomBusiness.GetAllRooms("Available").Count})";
            btnOccupiedRoom.Text = $"Có khách ({RoomBusiness.GetAllRooms("Occupied").Count})";
            SetupGiaoDien();
        }

        private void SetupGiaoDien()
        {
            int x = 10;
            int y = (panel3.Height - txtSearch.Height) / 2;
            txtSearch.Location = new Point(x, y);

            x = txtSearch.Location.X + txtSearch.Width;
            txtIconSearch.Location = new Point(x, y);

            x = txtIconSearch.Location.X + txtIconSearch.Width + 10;
            y = (panel3.Height - comboboxStatus.Height) / 2;
            comboboxStatus.Location = new Point(x, y);

            x = comboboxStatus.Location.X + comboboxStatus.Width + 10;
            y = (panel3.Height - btnChangeViewMode.Height) / 2;
            btnChangeViewMode.Location = new Point(x, y);


            x = panel3.Width - btnAddRoom.Width - 10;
            y = (panel3.Height - btnAddRoom.Height) / 2;
            btnAddRoom.Location = new Point(x, y);

        }

        bool isFloor = true;

        private void btnChangeViewMode_Click(object sender, EventArgs e)
        {
            if (isFloor)
            {
                UC_ViewTableMode.UC_ViewTableMode_Load(null, null);
                UC_ViewTableMode.BringToFront();

                isFloor = false;
                btnChangeViewMode.Image = Properties.Resources.mode_floor;
            }
            else
            {
                UC_ViewFloorMode.UC_ViewFloorMode_Load(null, null);
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

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxStatus.SelectedIndex == 0)
            {
                FIlterByStatus("");
            }
            else
            {
                string status = comboboxStatus.SelectedItem.ToString();
                FIlterByStatus(status);
            }
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

        private void LoadDataRoom(object sender, EventArgs e)
        {
            currentList = RoomBusiness.GetAllRooms();
            string currentStatus = comboboxStatus.SelectedItem.ToString();
            btnAllRoom.Text = $"Tất cả ({RoomBusiness.GetAllRooms().Count})";
            btnAvailableRoom.Text = $"Phòng trống ({RoomBusiness.GetAllRooms("Available").Count})";
            btnOccupiedRoom.Text = $"Có khách ({RoomBusiness.GetAllRooms("Occupied").Count})";

            if (comboboxStatus.Items.Contains(currentStatus))
                comboboxStatus.SelectedItem = currentStatus;
            else comboboxStatus.SelectedIndex = 0;

            UC_ViewTableMode.SetCurrentList(this.currentList);
            UC_ViewFloorMode.SetCurrentList(this.currentList);
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
            string s = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(s))
            {
                FilterByString(s);
            }
            else FIlterByStatus("");
        }

        private void FIlterByStatus(string status)
        {
            if (status.Trim() == "")
            {
                this.currentList = RoomBusiness.GetAllRooms();
            }
            else
            {
                this.currentList = RoomBusiness.GetAllRooms(status);
            }
            UC_ViewTableMode.SetCurrentList(this.currentList);
            UC_ViewFloorMode.SetCurrentList(this.currentList);
        }

        private void FilterByString(string s)
        {
            if (this.currentList != null && this.currentList.Count > 0)
            {
                this.currentList = this.currentList.Where(x => x.Display().IndexOf(s) >= 0).ToList();
            }
            UC_ViewTableMode.SetCurrentList(this.currentList);
            UC_ViewFloorMode.SetCurrentList(this.currentList);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            if (isFloor)
                UC_ViewFloorMode.UC_ViewFloorMode_Load(null, null);
            else
                UC_ViewTableMode.UC_ViewTableMode_Load(null, null);

            loadDataFor_comboboxStatus();
        }
    }
}
