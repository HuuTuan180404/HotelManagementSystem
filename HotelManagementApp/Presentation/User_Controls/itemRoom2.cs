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
        public itemRoom2(RoomDTO roomDTO)
        {
            InitializeComponent();
            this.RoomDTO = roomDTO;
        }

        private void itemRoom2_Load(object sender, EventArgs e)
        {
            lbRoom.Text = RoomDTO.RId.ToString();
            lbType.Text = "Type: " + RoomDTO.RType.ToString();
            lbStatus.Text = "Status: " + RoomDTO.RStatus.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void itemRoom2_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
