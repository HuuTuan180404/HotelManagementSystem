namespace Presentation.User_Controls
{
    partial class UC_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblRoomDetail = new System.Windows.Forms.Label();
            this.dgvRoomDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(137, 51);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(90, 24);
            this.cboYear.TabIndex = 3;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(237, 51);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(90, 24);
            this.cboMonth.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(25, 51);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(87, 25);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Lọc theo";
            // 
            // lblRoomDetail
            // 
            this.lblRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetail.Location = new System.Drawing.Point(25, 101);
            this.lblRoomDetail.Name = "lblRoomDetail";
            this.lblRoomDetail.Size = new System.Drawing.Size(250, 30);
            this.lblRoomDetail.TabIndex = 7;
            this.lblRoomDetail.Text = "Chi tiết phòng theo trạng thái";
            // 
            // dgvRoomDetail
            // 
            this.dgvRoomDetail.AllowUserToAddRows = false;
            this.dgvRoomDetail.AllowUserToDeleteRows = false;
            this.dgvRoomDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoomDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomDetail.Location = new System.Drawing.Point(25, 141);
            this.dgvRoomDetail.Name = "dgvRoomDetail";
            this.dgvRoomDetail.ReadOnly = true;
            this.dgvRoomDetail.RowHeadersWidth = 51;
            this.dgvRoomDetail.RowTemplate.Height = 24;
            this.dgvRoomDetail.Size = new System.Drawing.Size(750, 220);
            this.dgvRoomDetail.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartTron);
            this.panel1.Controls.Add(this.chartColumn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(761, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 844);
            this.panel1.TabIndex = 2;
            // 
            // chartTron
            // 
            chartArea9.Name = "ChartArea1";
            this.chartTron.ChartAreas.Add(chartArea9);
            this.chartTron.Dock = System.Windows.Forms.DockStyle.Top;
            legend9.Name = "Legend1";
            this.chartTron.Legends.Add(legend9);
            this.chartTron.Location = new System.Drawing.Point(0, 400);
            this.chartTron.Margin = new System.Windows.Forms.Padding(4);
            this.chartTron.Name = "chartTron";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartTron.Series.Add(series9);
            this.chartTron.Size = new System.Drawing.Size(851, 400);
            this.chartTron.TabIndex = 2;
            this.chartTron.Text = "chart2";
            this.chartTron.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartTron_MouseClick);
            // 
            // chartColumn
            // 
            chartArea10.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea10);
            this.chartColumn.Dock = System.Windows.Forms.DockStyle.Top;
            legend10.Name = "Legend1";
            this.chartColumn.Legends.Add(legend10);
            this.chartColumn.Location = new System.Drawing.Point(0, 0);
            this.chartColumn.Margin = new System.Windows.Forms.Padding(4);
            this.chartColumn.Name = "chartColumn";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartColumn.Series.Add(series10);
            this.chartColumn.Size = new System.Drawing.Size(851, 400);
            this.chartColumn.TabIndex = 1;
            this.chartColumn.Text = "chart1";
            // 
            // btnExport
            // 
            this.btnExport.AutoRoundedCorners = true;
            this.btnExport.BorderRadius = 21;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(616, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(159, 45);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Xuất báo cáo";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvRoomDetail);
            this.Controls.Add(this.lblRoomDetail);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1612, 844);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblRoomDetail;
        private System.Windows.Forms.DataGridView dgvRoomDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTron;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}
