using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using DataTransferObject;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using Presentation.Forms;


namespace Presentation.User_Controls
{
    public partial class itemRoom2 : UserControl
    {
        RoomDTO RoomDTO;

        private itemRoom2()
        {
            InitializeComponent();
        }

        public itemRoom2(RoomDTO roomDTO) : this()
        {
            this.RoomDTO = roomDTO;
            if (RoomDTO != null)
            {
                lbRoom.Text = RoomDTO.RId.ToString();
                lbType.Text = string.Format("{0,-8}: {1}", "Type", RoomDTO.RType);
                lbStatus.Text = string.Format("{0,-8}: {1}", "Status", RoomDTO.RStatus);
            }
            foreach (Control ctrl in this.Controls)
            {
                gunaToolTip_Room.SetToolTip(ctrl, "dads");
                ctrl.Click += Ctrl_Click;
            }
            btnMenu.Click-= Ctrl_Click;
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            RoomDetail roomDetail = new RoomDetail(RoomDTO);
            roomDetail.ShowDialog();
        }

       

        private void itemRoom2_MouseHover(object sender, EventArgs e)
        {
            gunaToolTip_Room.SetToolTip((Control)sender, "dads");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
