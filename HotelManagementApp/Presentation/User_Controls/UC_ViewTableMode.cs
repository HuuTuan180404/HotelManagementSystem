using Business;
using Presentation.Forms;
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
    public partial class UC_ViewTableMode : UserControl
    {
        RoomB RoomB = new RoomB();
        public UC_ViewTableMode()
        {
            InitializeComponent();
        }

        private void UC_ViewTableMode_Load(object sender, EventArgs e)
        {
            loadDataFor_dataGridView();
        }

        private void loadDataFor_dataGridView()
        {
            dataGridView.DataSource = RoomB.getDataSetDetailAllRooms().Tables[0];
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                RoomDetail roomDetail = new RoomDetail(RoomB.getInfoRoom(row.Cells["RId"].Value.ToString()));
                roomDetail.ShowDialog();
            }
        }
    }
}
