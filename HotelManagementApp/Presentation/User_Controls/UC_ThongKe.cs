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
using System.IO;
using DataTransferObject;
using DocumentFormat.OpenXml.Bibliography;

namespace Presentation.User_Controls
{
    public partial class UC_ThongKe : UserControl
    {
        PaymentB PaymentB;
        RoomB RoomB;
        ServiceB ServiceB;

        public UC_ThongKe()
        {
            InitializeComponent();
            PaymentB = new PaymentB();
            RoomB = new RoomB();
            ServiceB = new ServiceB();
            SetupCharts();
            BieuDoTron();
        }

        private void SetupCharts()
        {
            // Thiết lập biểu đồ cột Doanh thu phòng
            chartColumn.ChartAreas[0].AxisX.Title = "Tháng";
            chartColumn.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chartColumn.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10);
            chartColumn.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10);
            chartColumn.ChartAreas[0].BackColor = Color.White;
            chartColumn.ChartAreas[0].BorderColor = Color.LightGray;
            chartColumn.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 9);
            chartColumn.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 9);
            chartColumn.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartColumn.Titles.Clear();
            chartColumn.Titles.Add("Doanh thu dịch vụ phòng");
            chartColumn.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            chartColumn.Titles[0].ForeColor = Color.DarkBlue;
            chartColumn.Titles[0].Alignment = ContentAlignment.TopCenter;

            // Thiết lập biểu đồ tròn
            chartTron.Series[0].Label = "#PERCENT{P0}";
            chartTron.Series[0].Font = new Font("Arial", 9);
            chartTron.ChartAreas[0].BackColor = Color.White;
            chartTron.ChartAreas[0].BorderColor = Color.LightGray;
            chartTron.Legends[0].Font = new Font("Arial", 9);

            // biểu đồ cột doanh thu dịch vụ
            columnDoanhThuDV.ChartAreas[0].AxisX.Minimum = 0;
            columnDoanhThuDV.ChartAreas[0].AxisX.Maximum = 13;
            columnDoanhThuDV.ChartAreas[0].AxisX.Interval = 1;
            columnDoanhThuDV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            columnDoanhThuDV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            columnDoanhThuDV.Titles.Clear();
            columnDoanhThuDV.Titles.Add("Doanh thu của các dịch vụ");
            columnDoanhThuDV.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            columnDoanhThuDV.Titles[0].ForeColor = Color.DarkBlue;
            columnDoanhThuDV.Titles[0].Alignment = ContentAlignment.TopCenter;
            columnDoanhThuDV.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            columnDoanhThuDV.ChartAreas[0].AxisY.MajorGrid.Enabled = false;// Thêm nhãn giá trị
        }

        private void BieuDoCot(int year)
        {
            var dt = PaymentB.ThongKe(year);

            chartColumn.Series.Clear();

            // Tạo series mới
            Series doanhThuSeries = new Series("Doanh thu");
            doanhThuSeries.ChartType = SeriesChartType.Column;
            doanhThuSeries.Color = Color.FromArgb(33, 150, 243); // Màu xanh dương
            doanhThuSeries.BorderWidth = 2;

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
            chartColumn.ChartAreas[0].AxisX.Maximum = 13;
            chartColumn.ChartAreas[0].AxisX.Interval = 1;
            chartColumn.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartColumn.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Thêm nhãn giá trị
            doanhThuSeries.Label = "#VAL{N0}";
            doanhThuSeries.LabelAngle = -90;
        }

        private void BieuDoTron()
        {
            var tk = RoomB.ThongKe();

            chartTron.Series.Clear();
            var series = new Series("Số lượng phòng theo trạng thái");
            series.ChartType = SeriesChartType.Pie;
            series.BorderWidth = 2;

            // Định nghĩa màu sắc cho từng trạng thái (giữ nguyên tên lấy từ DB)
            Dictionary<string, Color> statusColors = new Dictionary<string, Color>
            {
                { "Available", Color.FromArgb(76, 175, 80) },      // Xanh lá
                { "Cleaning", Color.FromArgb(255, 193, 7) },       // Vàng
                { "Maintenance", Color.FromArgb(33, 150, 243) },   // Xanh dương
                { "Occupied", Color.FromArgb(244, 67, 54) },       // Đỏ
                { "Reserved", Color.FromArgb(255, 152, 0) },       // Cam
                { "Other", Color.Gray }                            // Trạng thái khác
            };

            foreach (var item in tk)
            {
                int pointIndex = series.Points.AddXY(item.Item1, item.Item2);
                if (statusColors.ContainsKey(item.Item1))
                {
                    series.Points[pointIndex].Color = statusColors[item.Item1];
                }
                else
                {
                    series.Points[pointIndex].Color = Color.Gray; // Mặc định cho trạng thái chưa định nghĩa
                }
            }

            chartTron.Series.Add(series);

            // Thêm chú thích
            chartTron.Legends[0].Docking = Docking.Bottom;
            chartTron.Legends[0].Alignment = StringAlignment.Center;
        }

        private void DoanhThuDichVu(int nam)
        {
            List<DoanhThuDichVuDTO> list = ServiceB.LayDoanhThuDichVu(nam);

            if (list != null)
            {
                columnDoanhThuDV.Series.Clear();

                // Tạo series mới
                Series doanhThuSeries = new Series("Doanh thu");
                doanhThuSeries.ChartType = SeriesChartType.Column;
                doanhThuSeries.Color = Color.FromArgb(33, 150, 243); // Màu xanh dương
                doanhThuSeries.BorderWidth = 2;

                // Thêm dữ liệu
                List<decimal> doanhThu = Enumerable.Repeat(0m, 12).ToList();
                foreach (var item in list)
                    doanhThu[item.month - 1] = item.Total;

                for (int i = 0; i < doanhThu.Count; i++)
                    doanhThuSeries.Points.AddXY($"{i + 1}", doanhThu[i]);

                columnDoanhThuDV.Series.Add(doanhThuSeries);
                doanhThuSeries.Label = "#VAL{N0}";
                doanhThuSeries.LabelAngle = -90;
            }
        }

        private void HienThiDoanhThu(int year)
        {
            var dt = PaymentB.ThongKe(year);
            decimal doanhThu = 0;
            foreach (var x in dt)
            {
                doanhThu += x.Item2;
            }

            lbTongDoanhThu.Text = $"{doanhThu}";

            var data = ServiceB.LayDoanhThuDichVu(year);
            doanhThu = 0;
            foreach (var x in data)
            {
                doanhThu += x.Total;
            }

            lbDoanhThuCuaDichVu.Text = $"{doanhThu}";

            lbDoanhThuCuaPhong.Text = $"{Convert.ToDecimal(lbTongDoanhThu.Text) - Convert.ToDecimal(lbDoanhThuCuaDichVu.Text)}";

            // chỉnh giao diện
            int X = 0;
            int Y = 0;

            X = cardTotal.Width - lbTongDoanhThu.Width - 5;
            Y = cardTotal.Height - lbTongDoanhThu.Height - 5;
            lbTongDoanhThu.Location = new Point(X, Y);


            X = cardDVPhong.Width - lbDoanhThuCuaPhong.Width - 5;
            Y = cardDVPhong.Height - lbDoanhThuCuaPhong.Height - 5;
            lbDoanhThuCuaPhong.Location = new Point(X, Y);

            X = cardDVDV.Width - lbDoanhThuCuaDichVu.Width - 5;
            Y = cardDVDV.Height - lbDoanhThuCuaDichVu.Height - 5;
            lbDoanhThuCuaDichVu.Location = new Point(X, Y);
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            var data = PaymentB.GetYearsWithPayments();
            cboYear.DataSource = data;
            cboYear.SelectedIndexChanged += FilterChanged;
            if (cboYear.Items.Count > 0)
            {
                cboYear.SelectedIndex = 0;
                int x = Convert.ToInt32(cboYear.SelectedItem);
                DoanhThuDichVu(x);
                BieuDoCot(x);
                HienThiDoanhThu(x);
            }
            ChinhKichThuoc();
        }

        private void ChinhKichThuoc()
        {
            panel5.Height = panel3.Height / 2;
            chartColumn.Width = panelBieuDoPhong.Width / 2;
            columnDoanhThuDV.Width = panel8.Width / 2;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cboYear.SelectedItem);
            DoanhThuDichVu(x);
            BieuDoCot(x);
            HienThiDoanhThu(x);
        }
    }
}
