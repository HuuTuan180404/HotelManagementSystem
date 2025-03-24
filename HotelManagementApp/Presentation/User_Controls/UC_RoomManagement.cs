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

namespace Presentation.User_Controls
{
    public partial class UC_RoomManagement : UserControl
    {

        //RoomB RoomB = new RoomB();
        RoomBusiness RoomBusiness = new RoomBusiness();

        public UC_RoomManagement()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadDataFor_comboboxStatus();
        }


        private void loadDataFor_comboboxStatus()
        {
            //comboboxStatus.Items.Clear();
            //comboboxStatus.Items.Add("All status");
            //comboboxStatus.SelectedIndex = 0;
            //var status = RoomB.getListRoomStatus().Select(room_status => room_status.RStatus);

            //foreach (var item in status)
            //    comboboxStatus.Items.Add(item.ToString());
        }

        private void comboboxStatus_Click(object sender, EventArgs e)
        {
            //btnAllRoom.Checked = false;
            comboboxStatus.ForeColor = Color.White;
            comboboxStatus.FillColor = Color.FromArgb(19, 102, 217);
            filterByStatus();

            if (comboboxStatus.SelectedIndex != 0)
            {
                string status = comboboxStatus.SelectedItem.ToString();
                //dataGridView.DataSource = RoomB.getDataSetDetailAllRooms_FilterByStatus(status).Tables[0];
                //Debug.WriteLine(status);
            }
        }

        private void filterByStatus()
        {
            if (comboboxStatus.SelectedIndex != 0)
            {
                string status = comboboxStatus.SelectedItem.ToString();
                //dataGridView.DataSource = RoomB.getDataSetDetailAllRooms_FilterByStatus(status).Tables[0];
                //UC_ViewFloorMode.show();
            }
            else
            {
                //loadDataFor_dataGridView();
            }
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            comboboxStatus.ForeColor = comboboxStatus.BorderColor;
            comboboxStatus.FillColor = Color.White;
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
















        private void demo(object sender, EventArgs e)
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

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByStatus();
        }


    }
}
