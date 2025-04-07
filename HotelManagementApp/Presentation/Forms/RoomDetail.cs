using System;
using Business;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using DataTransferObject;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Presentation.Forms
{
    public partial class RoomDetail : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private RoomDTO RoomDTO;
        private RoomDTO roomDTOVirtual;
        RoomB RoomBusiness = new RoomB();

        private RoomDetail()
        {
            InitializeComponent();
            LoadComboboxRoomType();
            LoadComboboxStatus();
        }

        public RoomDetail(RoomDTO roomDTO) : this()
        {
            RoomDTO = roomDTO;
            roomDTOVirtual = roomDTO.Clone();
        }

        private void RoomDetail_Load(object sender, EventArgs e)
        {
            lbRoomId.Text = this.RoomDTO.RId;
            lbBedCount.Text = this.RoomDTO.RTBedCount.ToString();
            lbMaxGuests.Text = this.RoomDTO.RTMaxGuests.ToString();
            lbPrice.Text = this.RoomDTO.RPricePerNight.ToString();
            lbTypeDescription.Text = this.RoomDTO.RTypeDescription;
            lbStatusDescription.Text = this.RoomDTO.RStatusDescription;
            lbRoomDescription.Text = this.RoomDTO.RDescription;
            comboboxRoomType.SelectedItem = this.RoomDTO.RType;
            comboboxStatus.SelectedItem = this.RoomDTO.RStatus;
            price.Text = this.RoomDTO.RPricePerNight.ToString();
            note.Text = this.RoomDTO.RDescription;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadComboboxRoomType()
        {
            comboboxRoomType.Items.Clear();
            var types = RoomBusiness.GetAllRoomTypes().Select(x => x.RType).ToList();
            foreach (var item in types)
                comboboxRoomType.Items.Add(item.ToString());
        }

        private void LoadComboboxStatus()
        {
            comboboxStatus.Items.Clear();
            var states = RoomBusiness.GetAllRoomStates().Select(x => x.RStatus).ToList();
            foreach (var item in states)
                comboboxStatus.Items.Add(item.ToString());
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(sender, e);
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void comboboxRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            lbType.Text = comboboxRoomType.SelectedItem.ToString();
            roomDTOVirtual.RType = lbType.Text;
            update_or_done();
            RoomDTO roomDTO = RoomBusiness.GetType(lbType.Text);
            if (roomDTO != null)
            {
                lbBedCount.Text = roomDTO.RTBedCount.ToString();
                lbMaxGuests.Text = roomDTO.RTMaxGuests.ToString();
                lbPrice.Text = roomDTO.RPricePerNight.ToString();
                lbTypeDescription.Text = roomDTO.RTypeDescription;
            }
        }

        private void comboboxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            lbStatus.Text = comboboxStatus.SelectedItem.ToString();
            roomDTOVirtual.RStatus = lbStatus.Text;
            update_or_done();
            RoomDTO roomDTO = RoomBusiness.GetStatus(lbStatus.Text);
            if (roomDTO != null)
            {
                lbStatusDescription.Text = roomDTO.RStatusDescription;
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            lbPrice.Text = price.Text;
            roomDTOVirtual.RPricePerNight = Convert.ToDecimal(lbPrice.Text);
            update_or_done();
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            lbRoomDescription.Text = note.Text;
            roomDTOVirtual.RDescription = lbRoomDescription.Text;
            update_or_done();
        }

        private void update_or_done()
        {
            bool isbtnDone = RoomDTO.compareRoom(roomDTOVirtual);
            if (isbtnDone) btnUpdate.Image = Properties.Resources.done;
            else btnUpdate.Image = Properties.Resources.update;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isUpdate = RoomDTO.compareRoom(roomDTOVirtual);
            if (!isUpdate)
            {
                if (alert("Bạn chắc chắn muốn cập nhật phòng này ?"))
                    if (RoomBusiness.UpdateRoom(roomDTOVirtual))
                        MessageBox.Show("Cập nhật phòng thành công!",
                            "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Không tìm thấy phòng này!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (alert("Bạn chắc chắn muốn xóa phòng này ?"))
                if (RoomBusiness.DeleteRoom(lbRoomId.Text))
                {
                    MessageBox.Show("Xóa phòng thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Không tìm thấy phòng để xóa!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        private bool alert(string message)
        {
            DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return true;
            return false;
        }
    }
}
