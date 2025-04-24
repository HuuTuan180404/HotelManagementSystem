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
        RoomB RoomBusiness = new RoomB();
        SelectAttribute SelectAttribute = new SelectAttribute(RoomDTO.Properties());

        private List<RoomDTO> currentList = null;

        public UC_ViewTableMode()
        {
            InitializeComponent();
            this.Controls.Add(SelectAttribute);
            SelectAttribute.BringToFront();
            SelectAttribute.Visible = false;
            FirstLoad();
        }

        private void FirstLoad()
        {
            currentList = RoomBusiness.GetAllRooms();
        }

        private void UC_ViewTableMode_Load(object sender, EventArgs e)
        {
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
                RoomDTO r = RoomBusiness.GetRoom(row.Cells["RId"].Value.ToString());
                RoomDetail roomDetail = new RoomDetail(r);
                roomDetail.ShowDialog();
            }
        }

        private void btnSelectAttribute_Click(object sender, EventArgs e)
        {
            SelectAttribute.Location = new Point(btnSelectAttribute.Location.X - 10, btnSelectAttribute.Location.Y - 10);
            SelectAttribute.Visible = true;
            timerListener.Start();
        }

        public void SetCurrentList(List<RoomDTO> list)
        {
            this.currentList = list;
            LoadRooms();
        }

        private void timerListener_Tick(object sender, EventArgs e)
        {
            if (SelectAttribute.Visible == false) timerListener.Stop();
            else
                SelectAttribute.ACTION += (Dictionary<string, object> data) =>
                {
                    if ((bool)data["value"])
                        dataGridView.Columns[(string)data["key"]].Visible = true;
                    else dataGridView.Columns[(string)data["key"]].Visible = false;
                };
        }
    }
}
