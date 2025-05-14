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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtIconSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeViewMode = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAllRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvailableRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnOccupiedRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UC_ViewFloorMode = new Presentation.User_Controls.UC_ViewFloorMode();
            this.UC_ViewTableMode = new Presentation.User_Controls.UC_ViewTableMode();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeViewMode)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 679);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UC_ViewFloorMode);
            this.panel4.Controls.Add(this.UC_ViewTableMode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(878, 519);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddRoom);
            this.panel3.Controls.Add(this.txtIconSearch);
            this.panel3.Controls.Add(this.comboboxStatus);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnChangeViewMode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 80);
            this.panel3.TabIndex = 21;
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
            this.btnAddRoom.Location = new System.Drawing.Point(736, 20);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(69, 45);
            this.btnAddRoom.TabIndex = 13;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtIconSearch
            // 
            this.txtIconSearch.AutoRoundedCorners = true;
            this.txtIconSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIconSearch.CustomizableEdges.BottomLeft = false;
            this.txtIconSearch.CustomizableEdges.TopLeft = false;
            this.txtIconSearch.DefaultText = "";
            this.txtIconSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIconSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIconSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIconSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIconSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIconSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIconSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIconSearch.IconRight = global::Presentation.Properties.Resources.find1;
            this.txtIconSearch.Location = new System.Drawing.Point(313, 26);
            this.txtIconSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtIconSearch.Name = "txtIconSearch";
            this.txtIconSearch.PlaceholderText = "";
            this.txtIconSearch.ReadOnly = true;
            this.txtIconSearch.SelectedText = "";
            this.txtIconSearch.Size = new System.Drawing.Size(32, 32);
            this.txtIconSearch.TabIndex = 20;
            this.txtIconSearch.Click += new System.EventHandler(this.txtIconSearch_Click);
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
            this.comboboxStatus.Location = new System.Drawing.Point(425, 24);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(194, 36);
            this.comboboxStatus.TabIndex = 12;
            this.comboboxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboboxStatus_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.CustomizableEdges.BottomRight = false;
            this.txtSearch.CustomizableEdges.TopRight = false;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(33, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(280, 32);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.IconRightClick += new System.EventHandler(this.txtSearch_IconRightClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnChangeViewMode
            // 
            this.btnChangeViewMode.Image = global::Presentation.Properties.Resources.mode_table1;
            this.btnChangeViewMode.Location = new System.Drawing.Point(824, 30);
            this.btnChangeViewMode.Name = "btnChangeViewMode";
            this.btnChangeViewMode.Size = new System.Drawing.Size(24, 24);
            this.btnChangeViewMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeViewMode.TabIndex = 15;
            this.btnChangeViewMode.TabStop = false;
            this.btnChangeViewMode.Click += new System.EventHandler(this.btnChangeViewMode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 80);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.bed2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAllRoom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAvailableRoom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOccupiedRoom, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(538, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 80);
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
            this.btnAllRoom.Size = new System.Drawing.Size(107, 74);
            this.btnAllRoom.TabIndex = 3;
            this.btnAllRoom.Tag = "0";
            this.btnAllRoom.Text = "Tất cả";
            this.btnAllRoom.TextFormatNoPrefix = true;
            this.btnAllRoom.Tile = true;
            this.btnAllRoom.Click += new System.EventHandler(this.btnAllRoom_Click);
            // 
            // btnAvailableRoom
            // 
            this.btnAvailableRoom.AutoRoundedCorners = true;
            this.btnAvailableRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailableRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvailableRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvailableRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvailableRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAvailableRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableRoom.ForeColor = System.Drawing.Color.White;
            this.btnAvailableRoom.Image = global::Presentation.Properties.Resources.flag;
            this.btnAvailableRoom.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAvailableRoom.Location = new System.Drawing.Point(116, 3);
            this.btnAvailableRoom.Name = "btnAvailableRoom";
            this.btnAvailableRoom.Size = new System.Drawing.Size(107, 74);
            this.btnAvailableRoom.TabIndex = 2;
            this.btnAvailableRoom.Tag = "Available";
            this.btnAvailableRoom.Text = "Phòng trống";
            this.btnAvailableRoom.TextFormatNoPrefix = true;
            this.btnAvailableRoom.Tile = true;
            this.btnAvailableRoom.Click += new System.EventHandler(this.btnAvailabelRoom_Click);
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
            this.btnOccupiedRoom.Location = new System.Drawing.Point(229, 3);
            this.btnOccupiedRoom.Name = "btnOccupiedRoom";
            this.btnOccupiedRoom.Size = new System.Drawing.Size(108, 74);
            this.btnOccupiedRoom.TabIndex = 1;
            this.btnOccupiedRoom.Tag = "Occupied";
            this.btnOccupiedRoom.Text = "Có khách";
            this.btnOccupiedRoom.TextFormatNoPrefix = true;
            this.btnOccupiedRoom.Tile = true;
            this.btnOccupiedRoom.Click += new System.EventHandler(this.btnOccupiedRoom_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(43, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(456, 63);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "ROOM MANAGEMENT";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UC_ViewFloorMode
            // 
            this.UC_ViewFloorMode.BackColor = System.Drawing.Color.White;
            this.UC_ViewFloorMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_ViewFloorMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_ViewFloorMode.Location = new System.Drawing.Point(0, 0);
            this.UC_ViewFloorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_ViewFloorMode.Name = "UC_ViewFloorMode";
            this.UC_ViewFloorMode.Size = new System.Drawing.Size(878, 519);
            this.UC_ViewFloorMode.TabIndex = 16;
            // 
            // UC_ViewTableMode
            // 
            this.UC_ViewTableMode.BackColor = System.Drawing.Color.White;
            this.UC_ViewTableMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_ViewTableMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UC_ViewTableMode.Location = new System.Drawing.Point(0, 0);
            this.UC_ViewTableMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_ViewTableMode.Name = "UC_ViewTableMode";
            this.UC_ViewTableMode.Size = new System.Drawing.Size(878, 519);
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
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeViewMode)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.PictureBox btnChangeViewMode;
        private UC_ViewTableMode UC_ViewTableMode;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnOccupiedRoom;
        private Guna.UI2.WinForms.Guna2Button btnAvailableRoom;
        private Guna.UI2.WinForms.Guna2Button btnAllRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private UC_ViewFloorMode UC_ViewFloorMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtIconSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
