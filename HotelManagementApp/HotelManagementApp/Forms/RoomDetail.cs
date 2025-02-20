using HotelManagementApp.Classes;
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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;


namespace HotelManagementApp.Forms
{
    public partial class RoomDetail : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private function function = new function();

        private ClassRoom classRoom;

        public string SelectedOption { get; private set; }

        public RoomDetail(ClassRoom classRoom)
        {
            InitializeComponent();
            this.classRoom = classRoom;
            groupboxPreview.Text += "ID: ";
            initPreview();
            floor.Maximum = ConfigManager.getTotalFloors();
            comboboxRoomType.DataSource = Enum.GetValues(typeof(EnumRoomType));
            comboboxStatus.DataSource = Enum.GetValues(typeof(EnumRoomStatus));
            initControls();
        }

        private void initPreview()
        {
            lbRoom.Text = classRoom.RooNo;
            lbRooType.Text = classRoom.RooType;
            lbBed.Text = classRoom.RooBed + "";
            lbFloor.Text = classRoom.RooFloor == 0 ? "Trệt" : classRoom.RooFloor + "";
            lbPeople.Text = classRoom.RooCustomer + "";
            lbPrice.Text = classRoom.RooPrice + "";
            lbNote.Text = classRoom.RooNote;
            lbStatus.Text = classRoom.RooStatus;
        }

        private void initControls()
        {
            string s = classRoom.RooNo;
            s = s.Substring(3);

            s = s.Substring((classRoom.RooFloor + "").Length + 1);

            numberOfRoom.Value = Int32.Parse(s);

            floor.Value = classRoom.RooFloor;
            numbeOfBed.Value = classRoom.RooBed;

            numberOfPeople.Value = classRoom.RooCustomer;

            EnumRoomType roomType;
            Enum.TryParse(classRoom.RooType, out roomType);
            comboboxRoomType.SelectedItem = roomType;

            price.Text = classRoom.RooPrice + "";

            EnumRoomStatus roomStatus;
            Enum.TryParse(classRoom.RooStatus, out roomStatus);
            comboboxStatus.SelectedItem = roomStatus;

            note.Text = classRoom.RooNote;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnUpdate, "Update room");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTipRoomDetail.SetToolTip(btnDelete, "Delete room");
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            lbNote.Text = note.Text;
        }

        private void numberOfRoom_ValueChanged(object sender, EventArgs e)
        {
            lbRoom.Text = "Roo" + floor.Value + "0" + numberOfRoom.Value;
        }

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            lbRoom.Text = "Roo" + floor.Value + "0" + numberOfRoom.Value;
        }

        private void numbeOfBed_ValueChanged(object sender, EventArgs e)
        {
            lbBed.Text = numbeOfBed.Value.ToString();
        }

        private void numberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            lbPeople.Text = numberOfPeople.Value.ToString();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            lbPrice.Text = price.Text;
        }

        private void comboboxRoomType_SelectedValueChanged(object sender, EventArgs e)
        {
            lbRooType.Text = comboboxRoomType.SelectedValue.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (alert())
            {
                string query = "DELETE FROM Rooms WHERE RooNo=@RooNo";

                SqlCommand sqlCommand = new SqlCommand(query);
                sqlCommand.Parameters.AddWithValue("@RooNo", lbRoom.Text);
                if (function.editRecord(sqlCommand, "Deleted"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool alert()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tiếp tục?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (alert())
            {
                string numFloor = floor.Text;
                string numRoom = numberOfRoom.Text;
                string rooNo = "Roo" + numFloor + "0" + numRoom;

                string numBed = numbeOfBed.Text;
                string numPeople = numberOfPeople.Text;
                string type = comboboxRoomType.Text;
                string price = this.price.Text;
                string Status = comboboxStatus.Text;
                string Note = this.note.Text;

                string query = @"
                    UPDATE Rooms
                    SET RooNo = @RooNo,
                        RooType = @RooType,
                        RooBed = @RooBed,
                        RooFloor = @RooFloor,
                        RooCustomer = @RooCustomer,
                        RooPrice = @RooPrice,
                        RooStatus = @RooStatus,
                        RooNote = @RooNote                        
                    WHERE RooID = @RooID";

                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@RooNo", rooNo); 
                command.Parameters.AddWithValue("@RooType", type);
                command.Parameters.AddWithValue("@RooBed", numBed);
                command.Parameters.AddWithValue("@RooFloor", numFloor);
                command.Parameters.AddWithValue("@RooCustomer", numPeople);
                command.Parameters.AddWithValue("@RooPrice", price);
                command.Parameters.AddWithValue("@RooStatus", Status);
                command.Parameters.AddWithValue("@RooNote", Note);
                command.Parameters.AddWithValue("@RooID", classRoom.RooID);

                if (function.editRecord(command, "Update"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
