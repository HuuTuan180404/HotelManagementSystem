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
            SetupCharts();
            BieuDoCot(); 
            BieuDoTron();
        }

        private void SetupCharts()
        {
            // Thiết lập biểu đồ cột
            chartColumn.ChartAreas[0].AxisX.Title = "Tháng";
            chartColumn.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chartColumn.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 10);
            chartColumn.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 10);
            chartColumn.ChartAreas[0].BackColor = Color.White;
            chartColumn.ChartAreas[0].BorderColor = Color.LightGray;
            chartColumn.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 9);
            chartColumn.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 9);
            chartColumn.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            // Thiết lập biểu đồ tròn
            chartTron.Series[0].Label = "#PERCENT{P0}";
            chartTron.Series[0].Font = new Font("Arial", 9);
            chartTron.ChartAreas[0].BackColor = Color.White;
            chartTron.ChartAreas[0].BorderColor = Color.LightGray;
            chartTron.Legends[0].Font = new Font("Arial", 9);
        }

        private void BieuDoCot()
        {
            var dt = PaymentB.ThongKe();

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
            chartColumn.ChartAreas[0].AxisX.Maximum = 12;
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

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            cboYear.DataSource = GetYearsFromDB();
            var months = new List<object> { "Tất cả" };
            months.AddRange(Enumerable.Range(1, 12).Cast<object>());
            cboMonth.DataSource = months;
            cboYear.SelectedIndexChanged += FilterChanged;
            cboMonth.SelectedIndexChanged += FilterChanged;
            chartTron.MouseClick += chartTron_MouseClick;
            btnExport.Click += btnExport_Click;
            if (cboYear.Items.Count > 0) cboYear.SelectedIndex = 0;
            if (cboMonth.Items.Count > 0) cboMonth.SelectedIndex = 0;
        }

        private List<int> GetYearsFromDB()
        {
            PaymentB paymentB = new PaymentB();
            return paymentB.GetYearsWithPayments();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem == null || cboMonth.SelectedItem == null)
                return;
            int year = Convert.ToInt32(cboYear.SelectedItem);
            int month = 0;
            if (cboMonth.SelectedItem.ToString() != "Tất cả")
                month = Convert.ToInt32(cboMonth.SelectedItem);
            CapNhatBieuDoVaBang(year, month);
        }

        private void CapNhatBieuDoVaBang(int year, int month)
        {
            BieuDoCot(year, month);
        }

        private void BieuDoCot(int year, int month)
        {
            var dt = PaymentB.ThongKe(year, month);
            chartColumn.Series.Clear();
            Series doanhThuSeries = new Series("Doanh thu");
            doanhThuSeries.ChartType = SeriesChartType.Column;
            doanhThuSeries.Color = Color.FromArgb(33, 150, 243);
            doanhThuSeries.BorderWidth = 2;
            List<decimal> doanhThu = Enumerable.Repeat(0m, 12).ToList();
            foreach (var item in dt)
            {
                int monthVal = item.Item1;
                decimal total = item.Item2;
                if (monthVal > 0 && monthVal <= 12)
                    doanhThu[monthVal - 1] = total;
            }
            for (int i = 0; i < doanhThu.Count; i++)
            {
                doanhThuSeries.Points.AddXY($"{i + 1}", doanhThu[i]);
            }
            chartColumn.Series.Add(doanhThuSeries);
            chartColumn.ChartAreas[0].AxisX.Minimum = 0;
            chartColumn.ChartAreas[0].AxisX.Maximum = 12;
            chartColumn.ChartAreas[0].AxisX.Interval = 1;
            chartColumn.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartColumn.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            doanhThuSeries.Label = "#VAL{N0}";
            doanhThuSeries.LabelAngle = -90;
        }

        private void BieuDoTron(int year, int month, string quarter)
        {
            var tk = RoomB.ThongKe(); // List<Tuple<string, int>> hoặc List<RoomDTO>
            // Giả sử tk có trường Year, Month
            var filtered = tk;
            if (tk.Count > 0 && tk[0].GetType().GetProperty("Year") != null)
            {
                filtered = tk.Where(x => (int)x.GetType().GetProperty("Year").GetValue(x) == year).ToList();
                // Nếu muốn lọc thêm theo tháng/quý thì bổ sung ở đây
            }
            chartTron.Series.Clear();
            var series = new Series("Số lượng phòng theo trạng thái");
            series.ChartType = SeriesChartType.Pie;
            series.BorderWidth = 2;
            Dictionary<string, Color> statusColors = new Dictionary<string, Color>
            {
                { "Available", Color.FromArgb(76, 175, 80) },
                { "Cleaning", Color.FromArgb(255, 193, 7) },
                { "Maintenance", Color.FromArgb(33, 150, 243) },
                { "Occupied", Color.FromArgb(244, 67, 54) },
                { "Reserved", Color.FromArgb(255, 152, 0) },
                { "Other", Color.Gray }
            };
            foreach (var item in filtered)
            {
                string status = item.GetType().GetProperty("Item1") != null ? item.GetType().GetProperty("Item1").GetValue(item)?.ToString() : "Other";
                int value = item.GetType().GetProperty("Item2") != null ? (int)item.GetType().GetProperty("Item2").GetValue(item) : 0;
                int pointIndex = series.Points.AddXY(status, value);
                if (statusColors.ContainsKey(status))
                    series.Points[pointIndex].Color = statusColors[status];
                else
                    series.Points[pointIndex].Color = Color.Gray;
            }
            chartTron.Series.Add(series);
            chartTron.Legends[0].Docking = Docking.Bottom;
            chartTron.Legends[0].Alignment = StringAlignment.Center;
        }

        private void CapNhatBangChiTiet(int year, int month, string quarter)
        {
            // Lọc danh sách phòng theo bộ lọc thời gian nếu RoomDTO có trường Year/Month
            var rooms = RoomB.GetAllRooms();
            if (rooms.Count > 0 && rooms[0].GetType().GetProperty("Year") != null)
            {
                rooms = rooms.Where(r => (int)r.GetType().GetProperty("Year").GetValue(r) == year).ToList();
                // Nếu muốn lọc thêm theo tháng/quý thì bổ sung ở đây
            }
            dgvRoomDetail.DataSource = rooms;
        }

        private void chartTron_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chartTron.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = result.PointIndex;
                string status = chartTron.Series[0].Points[pointIndex].AxisLabel;
                // Lấy danh sách phòng theo trạng thái
                var rooms = RoomB.GetAllRooms().Where(r => r.RStatus == status).ToList();
                dgvRoomDetail.DataSource = rooms;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn xuất dữ liệu nào?\nYes: Xuất bảng chi tiết\nNo: Xuất biểu đồ doanh thu", "Xuất báo cáo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.csv";
                sfd.Title = "Xuất báo cáo";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (result == DialogResult.Yes)
                    {
                        ExportDataGridViewToCSV(dgvRoomDetail, sfd.FileName);
                    }
                    else if (result == DialogResult.No)
                    {
                        ExportChartColumnToCSV(sfd.FileName);
                    }
                    MessageBox.Show("Xuất báo cáo thành công!");
                }
            }
        }

        private void ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            var sb = new StringBuilder();
            // Header
            var headers = dgv.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText)));
            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value?.ToString())));
                }
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private void ExportChartColumnToCSV(string filePath)
        {
            var sb = new StringBuilder();
            // Thêm ngày xuất file
            sb.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            // Header
            sb.AppendLine("Tháng;Doanh thu");
            if (chartColumn.Series.Count > 0)
            {
                foreach (var point in chartColumn.Series[0].Points)
                {
                    string month = point.AxisLabel;
                    // Xuất số liệu không có dấu phẩy phần nghìn
                    string value = point.YValues[0].ToString("0");
                    sb.AppendLine($"{month};{value}");
                }
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

                                 
    }
}
