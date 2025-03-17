using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Presentation.Forms;

namespace Presentation.Forms
{
    public partial class EmployeeManagement : Form
    {
        ContextMenuStrip filterMenu;
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void ApplyFilter(string type)
        {
            MessageBox.Show($"Lọc theo: {type}", "Thông báo");
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            filterMenu = new ContextMenuStrip();

            // Thêm các tùy chọn lọc
            filterMenu.Items.Add("Lọc theo Tên", null,null);
            //filterMenu.Items.Add("Lọc theo Ngày", null, (s, e) => ApplyFilter("Date"));
            //filterMenu.Items.Add("Lọc theo Trạng thái", null, (s, e) => ApplyFilter("Status"));

            // Gán ContextMenuStrip cho Button

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterMenu.Show(btnFilter, new Point(0, btnFilter.Height));
        }
    }
}
