using Business;
using DataTransferObject;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public UC_ViewTableMode()
        {
            InitializeComponent();
            this.Controls.Add(SelectAttribute);
            SelectAttribute.BringToFront();
            SelectAttribute.Visible = false;
        }

        private void UC_ViewTableMode_Load(object sender, EventArgs e)
        {
            LoadAllRooms("");
        }

        private void LoadAllRooms(string str)
        {
            if (str.Trim() == "") dataGridView.DataSource = RoomBusiness.GetAllRooms();
            else dataGridView.DataSource = RoomBusiness.GetAllRooms(str);
            RenameColumns();
        }

        public void FIlterByStatus(string status)
        {
            LoadAllRooms(status);
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
                RoomDetail roomDetail = new RoomDetail(row.Cells["RId"].ToString());
                roomDetail.ShowDialog();
            }
        }

        private void btnSelectAttribute_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAttribute_MouseClick(object sender, MouseEventArgs e)
        {
            SelectAttribute.Location = e.Location;
            SelectAttribute.Visible = true;
        }
    }
}
