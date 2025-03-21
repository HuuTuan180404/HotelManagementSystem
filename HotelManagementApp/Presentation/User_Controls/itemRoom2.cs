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
        }

        private void itemRoom2_Load(object sender, EventArgs e)
        {
            if (RoomDTO != null)
            {
                lbRoom.Text = RoomDTO.RId.ToString();
                lbType.Text = string.Format("{0,-8}: {1}", "Type", RoomDTO.RType);
                lbStatus.Text = string.Format("{0,-8}: {1}", "Status", RoomDTO.RStatus);
            }
            foreach (Control ctrl in this.Controls)
            {
                gunaToolTip_Room.SetToolTip(ctrl, "dads");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void itemRoom2_MouseHover(object sender, EventArgs e)
        {
            gunaToolTip_Room.SetToolTip((Control)sender, "dads");
        }
    }
}
