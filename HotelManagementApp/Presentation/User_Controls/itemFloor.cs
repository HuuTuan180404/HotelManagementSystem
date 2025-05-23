﻿using Business;
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
    public partial class itemFloor : UserControl
    {

        List<RoomDTO> listRooms;
        public event EventHandler DataChanged;
        RoomB RoomB;

        public itemFloor(List<RoomDTO> listRooms)
        {
            InitializeComponent();
            RoomB = new RoomB();
            this.listRooms = listRooms;
            FirstLoad();
        }

        private void FirstLoad()
        {
            lbFloor.Text = listRooms[0].getNumberOfFloor().ToString();
            DataRoomsChanged(null, null);
        }

        private void DataRoomsChanged(object sender, EventArgs e)
        {
            flowLayout.Controls.Clear();
            listRooms = RoomB.GetRoomsFilterByFloor(Convert.ToInt32(lbFloor.Text));
            foreach (var item in listRooms)
            {
                itemRoom2 itemRoom2 = new itemRoom2(item);
                itemRoom2.DataChanged += DataRoomsChanged;
                flowLayout.Controls.Add(itemRoom2);
            }
        }

    }
}
