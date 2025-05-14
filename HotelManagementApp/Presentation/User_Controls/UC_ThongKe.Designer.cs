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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblRoomDetail = new System.Windows.Forms.Label();
            this.dgvRoomDetail = new System.Windows.Forms.DataGridView();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tieuDeCharColumn = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cboYear.Location = new System.Drawing.Point(106, 415);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(68, 21);
            this.cboYear.TabIndex = 3;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(181, 415);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(68, 21);
            this.cboMonth.TabIndex = 4;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(22, 415);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(71, 20);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Lọc theo";
            // 
            // lblRoomDetail
            // 
            this.lblRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetail.Location = new System.Drawing.Point(22, 456);
            this.lblRoomDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomDetail.Name = "lblRoomDetail";
            this.lblRoomDetail.Size = new System.Drawing.Size(188, 24);
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
            this.dgvRoomDetail.Location = new System.Drawing.Point(22, 489);
            this.dgvRoomDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoomDetail.Name = "dgvRoomDetail";
            this.dgvRoomDetail.ReadOnly = true;
            this.dgvRoomDetail.RowHeadersWidth = 51;
            this.dgvRoomDetail.RowTemplate.Height = 24;
            this.dgvRoomDetail.Size = new System.Drawing.Size(562, 179);
            this.dgvRoomDetail.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.AutoRoundedCorners = true;
            this.btnExport.BorderRadius = 17;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1075, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 37);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Xuất báo cáo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 63);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.tieuDeCharColumn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 51);
            this.panel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartTron);
            this.panel1.Controls.Add(this.chartColumn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 290);
            this.panel1.TabIndex = 18;
            // 
            // chartTron
            // 
            this.chartTron.BorderlineColor = System.Drawing.Color.Black;
            chartArea15.Name = "ChartArea1";
            this.chartTron.ChartAreas.Add(chartArea15);
            this.chartTron.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            this.chartTron.Legends.Add(legend15);
            this.chartTron.Location = new System.Drawing.Point(638, 0);
            this.chartTron.Name = "chartTron";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chartTron.Series.Add(series15);
            this.chartTron.Size = new System.Drawing.Size(571, 290);
            this.chartTron.TabIndex = 2;
            this.chartTron.Text = "chart2";
            // 
            // chartColumn
            // 
            this.chartColumn.BorderlineColor = System.Drawing.Color.Black;
            this.chartColumn.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea16.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea16);
            this.chartColumn.Dock = System.Windows.Forms.DockStyle.Left;
            legend16.Name = "Legend1";
            this.chartColumn.Legends.Add(legend16);
            this.chartColumn.Location = new System.Drawing.Point(0, 0);
            this.chartColumn.Name = "chartColumn";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartColumn.Series.Add(series16);
            this.chartColumn.Size = new System.Drawing.Size(638, 290);
            this.chartColumn.TabIndex = 1;
            this.chartColumn.Text = "chart1";
            // 
            // tieuDeCharColumn
            // 
            this.tieuDeCharColumn.Depth = 0;
            this.tieuDeCharColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tieuDeCharColumn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tieuDeCharColumn.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.tieuDeCharColumn.Location = new System.Drawing.Point(0, 0);
            this.tieuDeCharColumn.MouseState = MaterialSkin.MouseState.HOVER;
            this.tieuDeCharColumn.Name = "tieuDeCharColumn";
            this.tieuDeCharColumn.Size = new System.Drawing.Size(638, 51);
            this.tieuDeCharColumn.TabIndex = 0;
            this.tieuDeCharColumn.Text = "Doanh thu từng tháng";
            this.tieuDeCharColumn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(638, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(571, 51);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Tổng quan về trạng thái phòng";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.overview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(85, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(261, 63);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "OVERVIEW";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvRoomDetail);
            this.Controls.Add(this.lblRoomDetail);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1209, 686);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTron;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
        private MaterialSkin.Controls.MaterialLabel tieuDeCharColumn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
