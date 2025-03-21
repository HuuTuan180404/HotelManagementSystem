namespace Presentation.Forms
{
    partial class RoomDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetail));
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupboxPreview = new System.Windows.Forms.GroupBox();
            this.groupboxType = new Guna.UI2.WinForms.Guna2GroupBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.lbBedCount = new MaterialSkin.Controls.MaterialLabel();
            this.lbMaxGuests = new MaterialSkin.Controls.MaterialLabel();
            this.lbStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.lbDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lbPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbNo = new MaterialSkin.Controls.MaterialLabel();
            this.lbFloor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.note = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.toolTipRoomDetail = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.comboboxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupboxPreview.SuspendLayout();
            this.groupboxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.materialLabel1);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1226, 128);
            this.panelTitle.TabIndex = 19;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(18, 19);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(308, 58);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "ROOM DETAIL";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1132, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 81);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "0";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(266, 536);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(238, 36);
            this.price.TabIndex = 29;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(742, 546);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 24);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Note";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(166, 546);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Price";
            // 
            // groupboxPreview
            // 
            this.groupboxPreview.Controls.Add(this.groupboxType);
            this.groupboxPreview.Controls.Add(this.lbStatus);
            this.groupboxPreview.Controls.Add(this.materialLabel18);
            this.groupboxPreview.Controls.Add(this.lbDescription);
            this.groupboxPreview.Controls.Add(this.lbPrice);
            this.groupboxPreview.Controls.Add(this.lbNo);
            this.groupboxPreview.Controls.Add(this.lbFloor);
            this.groupboxPreview.Controls.Add(this.materialLabel15);
            this.groupboxPreview.Controls.Add(this.materialLabel14);
            this.groupboxPreview.Controls.Add(this.materialLabel12);
            this.groupboxPreview.Controls.Add(this.materialLabel9);
            this.groupboxPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupboxPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPreview.Location = new System.Drawing.Point(0, 128);
            this.groupboxPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxPreview.Name = "groupboxPreview";
            this.groupboxPreview.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxPreview.Size = new System.Drawing.Size(1226, 244);
            this.groupboxPreview.TabIndex = 38;
            this.groupboxPreview.TabStop = false;
            this.groupboxPreview.Text = "Preview";
            // 
            // groupboxType
            // 
            this.groupboxType.BorderColor = System.Drawing.Color.Gray;
            this.groupboxType.BorderRadius = 23;
            this.groupboxType.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.groupboxType.Controls.Add(this.materialLabel10);
            this.groupboxType.Controls.Add(this.materialLabel13);
            this.groupboxType.Controls.Add(this.lbBedCount);
            this.groupboxType.Controls.Add(this.lbMaxGuests);
            this.groupboxType.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupboxType.FillColor = System.Drawing.Color.Transparent;
            this.groupboxType.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxType.ForeColor = System.Drawing.Color.Black;
            this.groupboxType.Location = new System.Drawing.Point(333, 39);
            this.groupboxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxType.Name = "groupboxType";
            this.groupboxType.Size = new System.Drawing.Size(339, 186);
            this.groupboxType.TabIndex = 49;
            this.groupboxType.Text = "Loại";
            this.groupboxType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(206, 62);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(80, 24);
            this.materialLabel10.TabIndex = 34;
            this.materialLabel10.Text = "Số người";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(44, 62);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(91, 24);
            this.materialLabel13.TabIndex = 37;
            this.materialLabel13.Text = "Số giường";
            // 
            // lbBedCount
            // 
            this.lbBedCount.Depth = 0;
            this.lbBedCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBedCount.Location = new System.Drawing.Point(35, 130);
            this.lbBedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBedCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(108, 31);
            this.lbBedCount.TabIndex = 42;
            this.lbBedCount.Text = "3";
            this.lbBedCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMaxGuests
            // 
            this.lbMaxGuests.Depth = 0;
            this.lbMaxGuests.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbMaxGuests.Location = new System.Drawing.Point(192, 130);
            this.lbMaxGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaxGuests.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMaxGuests.Name = "lbMaxGuests";
            this.lbMaxGuests.Size = new System.Drawing.Size(108, 31);
            this.lbMaxGuests.TabIndex = 44;
            this.lbMaxGuests.Text = "3";
            this.lbMaxGuests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.Depth = 0;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbStatus.Location = new System.Drawing.Point(720, 157);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(168, 31);
            this.lbStatus.TabIndex = 48;
            this.lbStatus.Text = "Available";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel18.Location = new System.Drawing.Point(735, 99);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(92, 24);
            this.materialLabel18.TabIndex = 47;
            this.materialLabel18.Text = "Trạng thái";
            // 
            // lbDescription
            // 
            this.lbDescription.Depth = 0;
            this.lbDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbDescription.Location = new System.Drawing.Point(1016, 157);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(180, 68);
            this.lbDescription.TabIndex = 46;
            this.lbDescription.Text = "mô tả";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Depth = 0;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbPrice.Location = new System.Drawing.Point(915, 157);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(87, 31);
            this.lbPrice.TabIndex = 45;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNo
            // 
            this.lbNo.Depth = 0;
            this.lbNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNo.Location = new System.Drawing.Point(156, 162);
            this.lbNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(142, 31);
            this.lbNo.TabIndex = 43;
            this.lbNo.Text = "2";
            this.lbNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.Depth = 0;
            this.lbFloor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFloor.Location = new System.Drawing.Point(20, 162);
            this.lbFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(134, 31);
            this.lbFloor.TabIndex = 40;
            this.lbFloor.Text = "1";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(1066, 99);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(53, 24);
            this.materialLabel15.TabIndex = 39;
            this.materialLabel15.Text = "Mô tả";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(183, 104);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(58, 24);
            this.materialLabel14.TabIndex = 38;
            this.materialLabel14.Text = "Phòng";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(936, 99);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(31, 24);
            this.materialLabel12.TabIndex = 36;
            this.materialLabel12.Text = "Giá";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(51, 104);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(46, 24);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Tầng";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(93, 434);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 24);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Room type";
            // 
            // note
            // 
            this.note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.note.DefaultText = "z";
            this.note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.note.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.note.Location = new System.Drawing.Point(822, 536);
            this.note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.note.Name = "note";
            this.note.PlaceholderText = "";
            this.note.SelectedText = "";
            this.note.Size = new System.Drawing.Size(238, 36);
            this.note.TabIndex = 41;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(484, 808);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 81);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(606, 808);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 81);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // toolTipRoomDetail
            // 
            this.toolTipRoomDetail.AllowLinksHandling = true;
            this.toolTipRoomDetail.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // comboboxRoomType
            // 
            this.comboboxRoomType.BackColor = System.Drawing.Color.Transparent;
            this.comboboxRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxRoomType.ItemHeight = 30;
            this.comboboxRoomType.Location = new System.Drawing.Point(268, 424);
            this.comboboxRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(238, 36);
            this.comboboxRoomType.TabIndex = 44;
            this.comboboxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboboxRoomType_SelectedIndexChanged);
            // 
            // comboboxStatus
            // 
            this.comboboxStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboboxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxStatus.ItemHeight = 30;
            this.comboboxStatus.Location = new System.Drawing.Point(822, 424);
            this.comboboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(238, 36);
            this.comboboxStatus.TabIndex = 46;
            this.comboboxStatus.SelectedValueChanged += new System.EventHandler(this.comboboxStatus_SelectedValueChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(720, 434);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(59, 24);
            this.materialLabel16.TabIndex = 45;
            this.materialLabel16.Text = "Status";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 827);
            this.Controls.Add(this.comboboxStatus);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.comboboxRoomType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.note);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupboxPreview);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.price);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomDetail";
            this.Load += new System.EventHandler(this.RoomDetail_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupboxPreview.ResumeLayout(false);
            this.groupboxPreview.PerformLayout();
            this.groupboxType.ResumeLayout(false);
            this.groupboxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private System.Windows.Forms.PictureBox btnExit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox groupboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel lbFloor;
        private MaterialSkin.Controls.MaterialLabel lbDescription;
        private MaterialSkin.Controls.MaterialLabel lbPrice;
        private MaterialSkin.Controls.MaterialLabel lbMaxGuests;
        private MaterialSkin.Controls.MaterialLabel lbNo;
        private MaterialSkin.Controls.MaterialLabel lbBedCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2TextBox note;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTipRoomDetail;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxRoomType;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel lbStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private Guna.UI2.WinForms.Guna2GroupBox groupboxType;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}