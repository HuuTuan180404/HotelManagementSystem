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

namespace Presentation.User_Controls
{
    public partial class UC_ViewFloorMode : UserControl
    {
        RoomBusiness RoomBusiness = new RoomBusiness();
        public UC_ViewFloorMode()
        {
            InitializeComponent();
        }

        private void UC_ViewFloorMode_Load(object sender, EventArgs e)
        {
            List<RoomDTO> list = RoomBusiness.GetAllRooms();
            if (list.Count > 0)
            {
                list.Sort((a, b) => a.RId.CompareTo(b.RId));

                itemFloor itemFloor = null;

                List<RoomDTO> listFloor = null;

                if (list != null)
                {
                    foreach (RoomDTO room in list)
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
