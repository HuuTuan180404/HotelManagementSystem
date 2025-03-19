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

        public itemFloor(List<RoomDTO> listRooms)
        {
            InitializeComponent();
            this.listRooms = listRooms;
        }

        private void itemFloor_Load(object sender, EventArgs e)
        {
            lbFloor.Text = listRooms[0].RId;
            foreach (var item in listRooms)
            {
                itemRoom2 itemRoom2 = new itemRoom2(item);
                flowLayout.Controls.Add(itemRoom2);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
