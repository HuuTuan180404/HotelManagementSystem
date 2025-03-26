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
            foreach (var x in RoomDTO.Properties())
            {
                Debug.WriteLine(x);
            }
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadDataFor_comboboxStatus();
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
            UC_ViewFloorMode.FIlterByStatus("");
            UC_ViewTableMode.FIlterByStatus("");
        }

        private void btnAvailabelRoom_Click(object sender, EventArgs e)
        {
            UC_ViewFloorMode.FIlterByStatus("Availabel");
            UC_ViewTableMode.FIlterByStatus("Availabel");
        }

        private void btnOccupiedRoom_Click(object sender, EventArgs e)
        {
            UC_ViewFloorMode.FIlterByStatus("Occupied");
            UC_ViewTableMode.FIlterByStatus("Occupied");
        }

        private void btnOhterRoom_Click(object sender, EventArgs e)
        {

        }






        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.DataChanged += LoadDataRoom;
            addRoom.ShowDialog();
        }

        private void LoadDataRoom()
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
