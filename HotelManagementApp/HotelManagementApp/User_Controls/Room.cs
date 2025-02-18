using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp.User_Controls
{
    public partial class Room : UserControl
    {
        function function = new function();

        String query;

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Room";
            DataSet dataSet = function.getData(query);
            dataGridView.DataSource = dataSet.Tables[0];
        }
    }
}
