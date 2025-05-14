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
        RoomB RoomBusiness = new RoomB();

        private List<RoomDTO> currentList = null;

        public event EventHandler DataChanged;

        public UC_ViewFloorMode()
        {
            InitializeComponent();
            currentList = RoomBusiness.GetAllRooms();
        }

        public void UC_ViewFloorMode_Load(object sender, EventArgs e)
        {
            currentList = RoomBusiness.GetAllRooms();
            LoadRooms();
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
                                itemFloor.Width = flowLayoutPanel.Width;
                                flowLayoutPanel.Controls.Add(itemFloor);

                                listFloor = null;
                                listFloor = new List<RoomDTO>();
                                listFloor.Add(room);
                            }
                        }
                    }

                }
                itemFloor = new itemFloor(listFloor);
                itemFloor.Width = flowLayoutPanel.Width;
                flowLayoutPanel.Controls.Add(itemFloor);
            }
        }

        public void SetCurrentList(List<RoomDTO> list)
        {
            this.currentList = list;
            LoadRooms();
        }

    }
}
