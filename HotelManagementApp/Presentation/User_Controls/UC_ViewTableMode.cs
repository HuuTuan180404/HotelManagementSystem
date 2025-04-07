using Business;
using DataTransferObject;
using Presentation.Forms;
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

namespace Presentation.User_Controls
{
    public partial class UC_ViewTableMode : UserControl
    {
        RoomBusiness RoomBusiness = new RoomBusiness();
        SelectAttribute SelectAttribute = new SelectAttribute(RoomDTO.Properties());

        private List<RoomDTO> currentList = null;

        public UC_ViewTableMode()
        {
            InitializeComponent();
            this.Controls.Add(SelectAttribute);
            SelectAttribute.BringToFront();
            SelectAttribute.Visible = false;

            FIlterByStatus("");
        }

        private void UC_ViewTableMode_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        public void FIlterByStatus(string status)
        {
            if (status.Trim() == "") currentList = RoomBusiness.GetAllRooms();
            else currentList = RoomBusiness.GetAllRooms(status);
            LoadRooms();
        }

        public void FilterByString(string s)
        {
            this.currentList = this.currentList.Where(x => x.Display().IndexOf(s) >= 0).ToList();
            LoadRooms();
        }

        private void LoadRooms()
        {
            if (this.currentList != null)
            {
                dataGridView.DataSource = currentList;
                RenameColumns();
            }
        }

        private void RenameColumns()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                switch (column.Name)
                {
                    case "RId":
                        column.HeaderText = "Mã Phòng";
                        break;
                    case "RType":
                        column.HeaderText = "Loại Phòng";
                        break;
                    case "RTBedCount":
                        column.HeaderText = "Số giường";
                        break;
                    case "RTMaxGuests":
                        column.HeaderText = "Người tối đa";
                        break;
                    case "RTypeDescription":
                        column.HeaderText = "Mô tả loại phòng";
                        break;
                    case "RStatus":
                        column.HeaderText = "Trạng thái";
                        break;
                    case "RStatusDescription":
                        column.HeaderText = "Mô tả trạng thái";
                        break;
                    case "RPricePerNight":
                        column.HeaderText = "Giá";
                        break;
                    case "RDescription":
                        column.HeaderText = "Mô Tả phòng";
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                Debug.WriteLine(row.Cells["RId"].Value.ToString());
                RoomDetail roomDetail = new RoomDetail(RoomBusiness.GetRoom(row.Cells["RId"].Value.ToString()));
                roomDetail.ShowDialog();
            }
        }

        private void btnSelectAttribute_Click(object sender, EventArgs e)
        {
            SelectAttribute.Location = new Point(btnSelectAttribute.Location.X-10, btnSelectAttribute.Location.Y-10);
            SelectAttribute.Visible = true;
        }

    }
}
