using Business;
using DataTransferObject;
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
    public partial class UC_ViewFloorMode : UserControl
    {
        RoomB RoomB = new RoomB();
        List<RoomDTO> list;
        public UC_ViewFloorMode()
        {
            InitializeComponent();
        }

        private void UC_ViewFloorMode_Load(object sender, EventArgs e)
        {
            List<RoomDTO> list = RoomB.getAllRooms();
            list.Sort((a, b) => a.RId.CompareTo(b.RId));

            List<RoomDTO> listFloor = null;

            int numberOfFloor = 0;

            foreach (var room in list)
            {
                if (listFloor == null)
                {
                    listFloor = new List<RoomDTO>();
                }
                if (listFloor.Count == 0)
                {
                    listFloor.Add(room);
                }
                else
                {
                    numberOfFloor = listFloor[0].getNumberOfFloor();
                    if (room.getNumberOfFloor() == numberOfFloor)
                    {
                        listFloor.Add(room);
                    }
                }
            }

            itemFloor itemFloor = new itemFloor(list);
            itemFloor.Location = new Point(10, 10);
            this.Controls.Add(itemFloor);
        }
    }
}
