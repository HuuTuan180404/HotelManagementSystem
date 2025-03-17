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

namespace Presentation.User_Controls
{
    public partial class itemRoom : UserControl
    {
        public static bool IS_SELECTED = false;
        public static string ID = null;


        public itemRoom()
        {
            InitializeComponent();
        }


        private void itemRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void registerClickEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Click += Control_Click;
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            click();
        }

        private void itemRoom_Click(object sender, EventArgs e)
        {
            click();
        }

        private void click()
        {
            
        }
    }
}
