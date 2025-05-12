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
        RoomB RoomB = null;
        SelectAttribute SelectAttribute = new SelectAttribute(RoomDTO.Properties());

        private List<RoomDTO> currentList = null;

        public UC_ViewTableMode()
        {
            InitializeComponent();
            this.Controls.Add(SelectAttribute);
            RoomB = new RoomB();
            SelectAttribute.BringToFront();
            SelectAttribute.Visible = false;
            FirstLoad();
        }

        private void FirstLoad()
        {
            currentList = RoomB.GetAllRooms();
            CreateContentMenuStrip();
        }

        public void UC_ViewTableMode_Load(object sender, EventArgs e)
        {
            currentList = RoomB.GetAllRooms();
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

        DataGridViewRow lastRow = null;

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                RoomDetail roomDetail = new RoomDetail(row.Cells["RId"].Value.ToString());
                roomDetail.DataChanged += UC_ViewTableMode_Load;
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

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show(Cursor.Position);
            }
        }

        private void CreateContentMenuStrip()
        {
            menuStrip.Items.Clear();
            menuStrip.Items.Add("Xem chi tiết", Properties.Resources.show_password, (sender, e) =>
            {
                if (lastRow == null && dataGridView.Rows[0] != null)
                {
                    lastRow = dataGridView.Rows[0];
                }
                if (lastRow != null)
                {
                    RoomDetail roomDetail = new RoomDetail(lastRow.Cells["RId"].Value.ToString());
                    roomDetail.DataChanged += UC_ViewTableMode_Load;
                    roomDetail.ShowDialog();
                }

            });

            menuStrip.Items.Add("Đặt phòng", Properties.Resources.icon_booking, (sender, e) =>
            {
                if (lastRow == null && dataGridView.Rows[0] != null)
                {
                    lastRow = dataGridView.Rows[0];
                }
                if (lastRow != null)
                {
                    if (RoomB.RoomIsAvailable(lastRow.Cells["RId"].Value.ToString()))
                    {
                        AddBooking AddBooking = new AddBooking(lastRow.Cells["RId"].Value.ToString());
                        AddBooking.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Phòng chưa sẵn sàng để nhận khách",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
            });

            menuStrip.Items.Add("Nhận phòng", Properties.Resources.checkedIn, (sender, e) =>
            {
                try
                {
                    if (lastRow == null && dataGridView.Rows[0] != null)
                    {
                        lastRow = dataGridView.Rows[0];
                    }
                    if (lastRow != null)
                    {
                        var room = RoomB.GetRoom(lastRow.Cells["RId"].Value.ToString());
                        if (RoomB.RoomIsAvailable(room.RId))
                        {
                            CheckIn checkIn = new CheckIn(lastRow.Cells["RId"].Value.ToString(), true);
                            checkIn.DataChanged += UC_ViewTableMode_Load;
                            checkIn.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(room.RStatusDescription, "Không thể nhận phòng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có lịch đặt nào");
                }
            });

            menuStrip.Items.Add("Yêu cầu vệ sinh", Properties.Resources.clean, (sender, e) =>
            {
                try
                {

                    if (lastRow == null && dataGridView.Rows[0] != null)
                    {
                        lastRow = dataGridView.Rows[0];
                    }
                    if (lastRow != null)
                    {
                        RoomDTO roomDTO = RoomB.GetRoom(lastRow.Cells["RId"].Value.ToString());
                        if (roomDTO.RStatus != "Cleaning")
                        {
                            roomDTO.RStatus = "Cleaning";
                            RoomB.UpdateRoom(roomDTO);
                            UC_ViewTableMode_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Phòng đang được dọn vệ sinh");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });

            menuStrip.Items.Add("Trả phòng", null, (sender, e) =>
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lastRow = dataGridView.Rows[e.RowIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCurrentList(RoomB.GetAllRooms());
        }
    }
}
