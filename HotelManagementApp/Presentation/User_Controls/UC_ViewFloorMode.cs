using Business;
using DataTransferObject;
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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.User_Controls
{
    public partial class UC_ViewFloorMode : UserControl
    {
        RoomBusiness RoomBusiness = new RoomBusiness();

        private List<RoomDTO> currentList = null;
        public UC_ViewFloorMode()
        {
            InitializeComponent();
            FilterByString("");
        }

        private void UC_ViewFloorMode_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        public void FIlterByStatus(string status)
        {
            if (status.Trim() == "")
            {
                this.currentList = RoomBusiness.GetAllRooms();
            }
            else
            {
                this.currentList = RoomBusiness.GetAllRooms(status);
            }
            LoadRooms();
        }

        public void FilterByString(string s)
        {
            if (this.currentList != null && this.currentList.Count > 0)
            {
                this.currentList = this.currentList.Where(x => x.Display().IndexOf(s) >= 0).ToList();
                LoadRooms();
            }
        }

        private void LoadRooms()
        {
            if (this.currentList == null || this.currentList.Count == 0) return;

            flowLayoutPanel.Controls.Clear();
            if (this.currentList.Count > 0)
            {
                this.currentList.Sort((a, b) => a.RId.CompareTo(b.RId));
                itemFloor itemFloor = null;
                List<RoomDTO> listFloor = null;
                if (this.currentList != null)
                {
                    foreach (RoomDTO room in this.currentList)
                    {
                        if (listFloor == null)
                        {
                            listFloor = new List<RoomDTO>();
                            listFloor.Add(room);
                        }
                        else
                        {
                            int idFloor = listFloor[0].getNumberOfFloor();
                            if (room.getNumberOfFloor() == idFloor)
                            {
                                listFloor.Add(room);
                            }
                            else
                            {
                                itemFloor = new itemFloor(listFloor);
                                flowLayoutPanel.Controls.Add(itemFloor);

                                listFloor = null;
                                listFloor = new List<RoomDTO>();
                                listFloor.Add(room);
                            }
                        }
                    }

                }
                itemFloor = new itemFloor(listFloor);
                flowLayoutPanel.Controls.Add(itemFloor);
            }
        }

    }
}
