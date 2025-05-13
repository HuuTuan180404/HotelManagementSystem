using Business;
using Presentation.Forms;
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
using System.Windows.Forms.DataVisualization.Charting;
using ZXing;

namespace Presentation.User_Controls
{
    public partial class UC_ThongKe : UserControl
    {
        PaymentB PaymentB;
        RoomB RoomB;
        public UC_ThongKe()
        {
            InitializeComponent();
            PaymentB = new PaymentB();
            RoomB = new RoomB();
            BieuDoCot(); BieuDoTron();
        }

        private void BieuDoCot()
        {
            var dt = PaymentB.ThongKe();


            chartColumn.Series.Clear();

            // Tạo series mới
            Series doanhThuSeries = new Series("Doanh thu");
            doanhThuSeries.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu
            List<decimal> doanhThu = Enumerable.Repeat(0m, 12).ToList();
            foreach (var item in dt)
            {
                int month = item.Item1;
                decimal total = item.Item2;
                doanhThu[month - 1] = total;
            }

            for (int i = 0; i < doanhThu.Count; i++)
            {
                doanhThuSeries.Points.AddXY($"{i + 1}", doanhThu[i]);
            }

            // Thêm series vào chart
            chartColumn.Series.Add(doanhThuSeries);

            // Tuỳ chỉnh trục X
            chartColumn.ChartAreas[0].AxisX.Minimum = 0;
            chartColumn.ChartAreas[0].AxisX.Maximum = 12;
            chartColumn.ChartAreas[0].AxisX.Interval = 1;
            chartColumn.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartColumn.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chartColumn.ChartAreas[0].AxisX.Title = "Tháng";
            chartColumn.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
        }

        private void BieuDoTron()
        {
            var tk = RoomB.ThongKe();

            chartTron.Series.Clear();
            var series = new Series("Số lượng phòng theo trạng thái");
            series.ChartType = SeriesChartType.Pie;

            foreach (var item in tk)
            {
                series.Points.AddXY(item.Item1, item.Item2);
            }

            chartTron.Series.Add(series);

        }
    }
}
