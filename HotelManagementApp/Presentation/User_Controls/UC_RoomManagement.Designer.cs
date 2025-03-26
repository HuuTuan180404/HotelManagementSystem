namespace Presentation.User_Controls
{
    partial class UC_RoomManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeViewMode = new System.Windows.Forms.PictureBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAllRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvailabelRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnOccupiedRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UC_ViewFloorMode = new Presentation.User_Controls.UC_ViewFloorMode();
            this.UC_ViewTableMode = new Presentation.User_Controls.UC_ViewTableMode();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeViewMode)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnChangeViewMode);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.comboboxStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UC_ViewFloorMode);
            this.panel1.Controls.Add(this.UC_ViewTableMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 679);
            this.panel1.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::Presentation.Properties.Resources.find1;
            this.txtSearch.Location = new System.Drawing.Point(51, 96);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(280, 32);
            this.txtSearch.TabIndex = 19;
            // 
            // btnChangeViewMode
            // 
            this.btnChangeViewMode.Image = global::Presentation.Properties.Resources.mode_table1;
            this.btnChangeViewMode.Location = new System.Drawing.Point(841, 100);
            this.btnChangeViewMode.Name = "btnChangeViewMode";
            this.btnChangeViewMode.Size = new System.Drawing.Size(24, 24);
            this.btnChangeViewMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeViewMode.TabIndex = 15;
            this.btnChangeViewMode.TabStop = false;
            this.btnChangeViewMode.Click += new System.EventHandler(this.btnChangeViewMode_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderRadius = 21;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(672, 90);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(69, 45);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AutoRoundedCorners = true;
            this.btnAddRoom.BorderRadius = 21;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(753, 90);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(69, 45);
            this.btnAddRoom.TabIndex = 13;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // comboboxStatus
            // 
            this.comboboxStatus.AutoRoundedCorners = true;
            this.comboboxStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboboxStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.comboboxStatus.BorderRadius = 17;
            this.comboboxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.comboboxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.comboboxStatus.ItemHeight = 30;
            this.comboboxStatus.Location = new System.Drawing.Point(442, 94);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(194, 36);
            this.comboboxStatus.TabIndex = 12;
            this.comboboxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboboxStatus_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 80);
            this.panel2.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAllRoom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAvailabelRoom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOccupiedRoom, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(565, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 80);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnAllRoom
            // 
            this.btnAllRoom.AutoRoundedCorners = true;
            this.btnAllRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAllRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRoom.ForeColor = System.Drawing.Color.White;
            this.btnAllRoom.Image = global::Presentation.Properties.Resources.home;
            this.btnAllRoom.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAllRoom.Location = new System.Drawing.Point(3, 3);
            this.btnAllRoom.Name = "btnAllRoom";
            this.btnAllRoom.Size = new System.Drawing.Size(98, 74);
            this.btnAllRoom.TabIndex = 3;
            this.btnAllRoom.Text = "Tất cả";
            this.btnAllRoom.TextFormatNoPrefix = true;
            this.btnAllRoom.Tile = true;
            this.btnAllRoom.Click += new System.EventHandler(this.btnAllRoom_Click);
            // 
            // btnAvailabelRoom
            // 
            this.btnAvailabelRoom.AutoRoundedCorners = true;
            this.btnAvailabelRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailabelRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailabelRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvailabelRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvailabelRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAvailabelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailabelRoom.ForeColor = System.Drawing.Color.White;
            this.btnAvailabelRoom.Image = global::Presentation.Properties.Resources.flag;
            this.btnAvailabelRoom.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAvailabelRoom.Location = new System.Drawing.Point(107, 3);
            this.btnAvailabelRoom.Name = "btnAvailabelRoom";
            this.btnAvailabelRoom.Size = new System.Drawing.Size(98, 74);
            this.btnAvailabelRoom.TabIndex = 2;
            this.btnAvailabelRoom.Text = "Phòng trống";
            this.btnAvailabelRoom.TextFormatNoPrefix = true;
            this.btnAvailabelRoom.Tile = true;
            this.btnAvailabelRoom.Click += new System.EventHandler(this.btnAvailabelRoom_Click);
            // 
            // btnOccupiedRoom
            // 
            this.btnOccupiedRoom.AutoRoundedCorners = true;
            this.btnOccupiedRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOccupiedRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOccupiedRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOccupiedRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOccupiedRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOccupiedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupiedRoom.ForeColor = System.Drawing.Color.White;
            this.btnOccupiedRoom.Image = global::Presentation.Properties.Resources.heart;
            this.btnOccupiedRoom.ImageSize = new System.Drawing.Size(26, 26);
            this.btnOccupiedRoom.Location = new System.Drawing.Point(211, 3);
            this.btnOccupiedRoom.Name = "btnOccupiedRoom";
            this.btnOccupiedRoom.Size = new System.Drawing.Size(99, 74);
            this.btnOccupiedRoom.TabIndex = 1;
            this.btnOccupiedRoom.Text = "Có khách";
            this.btnOccupiedRoom.TextFormatNoPrefix = true;
            this.btnOccupiedRoom.Tile = true;
            this.btnOccupiedRoom.Click += new System.EventHandler(this.btnOccupiedRoom_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(398, 47);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "ROOM MANAGEMENT";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_ViewFloorMode
            // 
            this.UC_ViewFloorMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_ViewFloorMode.BackColor = System.Drawing.Color.White;
            this.UC_ViewFloorMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_ViewFloorMode.Location = new System.Drawing.Point(19, 144);
            this.UC_ViewFloorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_ViewFloorMode.Name = "UC_ViewFloorMode";
            this.UC_ViewFloorMode.Size = new System.Drawing.Size(835, 507);
            this.UC_ViewFloorMode.TabIndex = 16;
            // 
            // UC_ViewTableMode
            // 
            this.UC_ViewTableMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_ViewTableMode.BackColor = System.Drawing.Color.White;
            this.UC_ViewTableMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_ViewTableMode.Location = new System.Drawing.Point(19, 144);
            this.UC_ViewTableMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_ViewTableMode.Name = "UC_ViewTableMode";
            this.UC_ViewTableMode.Size = new System.Drawing.Size(835, 507);
            this.UC_ViewTableMode.TabIndex = 17;
            // 
            // UC_RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "UC_RoomManagement";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(890, 691);
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeViewMode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxStatus;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.PictureBox btnChangeViewMode;
        private UC_ViewTableMode UC_ViewTableMode;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnOccupiedRoom;
        private Guna.UI2.WinForms.Guna2Button btnAvailabelRoom;
        private Guna.UI2.WinForms.Guna2Button btnAllRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private UC_ViewFloorMode UC_ViewFloorMode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
