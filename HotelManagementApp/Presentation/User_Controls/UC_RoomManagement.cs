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

        RoomB RoomB = new RoomB();

        public UC_RoomManagement()
        {
            InitializeComponent();
            loadDataFor_comboboxStatus();
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }


        private void loadDataFor_comboboxStatus()
        {
            comboboxStatus.Items.Clear();
            comboboxStatus.Items.Add("All status");
            comboboxStatus.SelectedIndex = 0;
            var status = RoomB.getListRoomStatus().Select(room_status => room_status.RStatus);

            foreach (var item in status)
                comboboxStatus.Items.Add(item.ToString());
        }

        private void comboboxStatus_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = false;
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
                UC_ViewFloorMode.show();
            }
            else
            {
                //loadDataFor_dataGridView();
            }
        }

        private void btnAllRoom_Click(object sender, EventArgs e)
        {
            btnAllRoom.Checked = true;

            comboboxStatus.ForeColor = comboboxStatus.BorderColor;
            comboboxStatus.FillColor = Color.White;

            //loadDataFor_dataGridView();
        }

        private void btnChangeViewMode_Click(object sender, EventArgs e)
        {
            int indexUC_ViewFloorMode = panel1.Controls.GetChildIndex(UC_ViewFloorMode);
            int indexUC_ViewTableMode = panel1.Controls.GetChildIndex(UC_ViewTableMode);

            if (indexUC_ViewFloorMode < indexUC_ViewTableMode) UC_ViewTableMode.BringToFront();
            else UC_ViewFloorMode.BringToFront();

        }



















        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

            //    if (hitTestInfo.RowIndex >= 0) // Kiểm tra có hàng hay không
            //    {
            //        dataGridView.ClearSelection();
            //        dataGridView.Rows[hitTestInfo.RowIndex].Selected = true; // Chọn hàng
            //        CreateContextMenuRightClick();
            //        contextMenuStrip.Show(dataGridView, new Point(e.X, e.Y)); // Hiển thị menu
            //    }
            //}
        }

        private void demo(object sender, EventArgs e)
        {

        }

        private void CreateContextMenuRightClick()
        {
            contextMenuStrip.Items.Clear();
            contextMenuStrip.Items.Add("Edit", null, demo);
            contextMenuStrip.Items.Add("View detail", null, demo);
            contextMenuStrip.Items.Add("Làm mới", null, demo);
        }




        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            //addRoom.DataChanged += loadDataFor_dataGridView;
            addRoom.ShowDialog();
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
