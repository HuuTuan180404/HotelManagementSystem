namespace HotelManagementApp.Forms
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.comboboxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.note = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.floor = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numRoom = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.editType = new System.Windows.Forms.PictureBox();
            this.editStatus = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupboxPreview.SuspendLayout();
            this.groupboxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.materialLabel1);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(817, 79);
            this.panelTitle.TabIndex = 47;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(12, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 58);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "ADD";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(755, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
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
            this.groupboxPreview.Location = new System.Drawing.Point(0, 79);
            this.groupboxPreview.Name = "groupboxPreview";
            this.groupboxPreview.Size = new System.Drawing.Size(817, 201);
            this.groupboxPreview.TabIndex = 66;
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
            this.groupboxType.Location = new System.Drawing.Point(222, 42);
            this.groupboxType.Name = "groupboxType";
            this.groupboxType.Size = new System.Drawing.Size(226, 147);
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
            this.materialLabel10.Location = new System.Drawing.Point(127, 60);
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
            this.materialLabel13.Location = new System.Drawing.Point(19, 60);
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
            this.lbBedCount.Location = new System.Drawing.Point(28, 102);
            this.lbBedCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(72, 19);
            this.lbBedCount.TabIndex = 42;
            this.lbBedCount.Text = "3";
            this.lbBedCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMaxGuests
            // 
            this.lbMaxGuests.Depth = 0;
            this.lbMaxGuests.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbMaxGuests.Location = new System.Drawing.Point(131, 102);
            this.lbMaxGuests.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMaxGuests.Name = "lbMaxGuests";
            this.lbMaxGuests.Size = new System.Drawing.Size(72, 19);
            this.lbMaxGuests.TabIndex = 44;
            this.lbMaxGuests.Text = "3";
            this.lbMaxGuests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.Depth = 0;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbStatus.Location = new System.Drawing.Point(480, 138);
            this.lbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(112, 19);
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
            this.materialLabel18.Location = new System.Drawing.Point(490, 102);
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
            this.lbDescription.Location = new System.Drawing.Point(677, 138);
            this.lbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(120, 42);
            this.lbDescription.TabIndex = 46;
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Depth = 0;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbPrice.Location = new System.Drawing.Point(610, 138);
            this.lbPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 19);
            this.lbPrice.TabIndex = 45;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNo
            // 
            this.lbNo.Depth = 0;
            this.lbNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNo.Location = new System.Drawing.Point(104, 138);
            this.lbNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(95, 19);
            this.lbNo.TabIndex = 43;
            this.lbNo.Text = "1";
            this.lbNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.Depth = 0;
            this.lbFloor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFloor.Location = new System.Drawing.Point(13, 138);
            this.lbFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(89, 19);
            this.lbFloor.TabIndex = 40;
            this.lbFloor.Text = "0";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(711, 102);
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
            this.materialLabel14.Location = new System.Drawing.Point(122, 102);
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
            this.materialLabel12.Location = new System.Drawing.Point(624, 102);
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
            this.materialLabel9.Location = new System.Drawing.Point(34, 102);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(46, 24);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Tầng";
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
            this.comboboxStatus.Location = new System.Drawing.Point(187, 450);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(135, 36);
            this.comboboxStatus.TabIndex = 78;
            this.comboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboboxStatus_SelectedIndexChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(119, 456);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(59, 24);
            this.materialLabel16.TabIndex = 77;
            this.materialLabel16.Text = "Status";
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
            this.comboboxRoomType.Location = new System.Drawing.Point(187, 387);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(135, 36);
            this.comboboxRoomType.TabIndex = 76;
            this.comboboxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboboxRoomType_SelectedIndexChanged);
            // 
            // note
            // 
            this.note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.note.DefaultText = "";
            this.note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.note.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.note.Location = new System.Drawing.Point(556, 450);
            this.note.Name = "note";
            this.note.PasswordChar = '\0';
            this.note.PlaceholderText = "";
            this.note.SelectedText = "";
            this.note.Size = new System.Drawing.Size(160, 36);
            this.note.TabIndex = 75;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(70, 393);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 24);
            this.materialLabel5.TabIndex = 74;
            this.materialLabel5.Text = "Room type";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.floor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.floor.Location = new System.Drawing.Point(187, 324);
            this.floor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(160, 36);
            this.floor.TabIndex = 73;
            this.floor.ValueChanged += new System.EventHandler(this.floor_ValueChanged);
            this.floor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.floor_KeyUp);
            // 
            // numRoom
            // 
            this.numRoom.BackColor = System.Drawing.Color.Transparent;
            this.numRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRoom.Location = new System.Drawing.Point(556, 324);
            this.numRoom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoom.Name = "numRoom";
            this.numRoom.Size = new System.Drawing.Size(160, 36);
            this.numRoom.TabIndex = 72;
            this.numRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoom.ValueChanged += new System.EventHandler(this.numRoom_ValueChanged);
            this.numRoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numRoom_KeyUp);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(120, 330);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 24);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "Floor";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(401, 330);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(146, 24);
            this.materialLabel7.TabIndex = 71;
            this.materialLabel7.Text = "Number of room";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(495, 393);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 68;
            this.materialLabel3.Text = "Price";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(503, 456);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 24);
            this.materialLabel4.TabIndex = 69;
            this.materialLabel4.Text = "Note";
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
            this.price.Location = new System.Drawing.Point(556, 387);
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(160, 36);
            this.price.TabIndex = 70;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(375, 521);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 79;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editType
            // 
            this.editType.Image = ((System.Drawing.Image)(resources.GetObject("editType.Image")));
            this.editType.Location = new System.Drawing.Point(324, 403);
            this.editType.Name = "editType";
            this.editType.Size = new System.Drawing.Size(20, 20);
            this.editType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editType.TabIndex = 80;
            this.editType.TabStop = false;
            this.editType.Click += new System.EventHandler(this.editType_Click);
            // 
            // editStatus
            // 
            this.editStatus.Image = ((System.Drawing.Image)(resources.GetObject("editStatus.Image")));
            this.editStatus.Location = new System.Drawing.Point(324, 466);
            this.editStatus.Name = "editStatus";
            this.editStatus.Size = new System.Drawing.Size(20, 20);
            this.editStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editStatus.TabIndex = 81;
            this.editStatus.TabStop = false;
            this.editStatus.Click += new System.EventHandler(this.editStatus_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 591);
            this.Controls.Add(this.editStatus);
            this.Controls.Add(this.editType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboboxStatus);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.comboboxRoomType);
            this.Controls.Add(this.note);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.numRoom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.groupboxPreview);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupboxPreview.ResumeLayout(false);
            this.groupboxPreview.PerformLayout();
            this.groupboxType.ResumeLayout(false);
            this.groupboxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupboxPreview;
        private Guna.UI2.WinForms.Guna2GroupBox groupboxType;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel lbBedCount;
        private MaterialSkin.Controls.MaterialLabel lbMaxGuests;
        private MaterialSkin.Controls.MaterialLabel lbStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel lbDescription;
        private MaterialSkin.Controls.MaterialLabel lbPrice;
        private MaterialSkin.Controls.MaterialLabel lbNo;
        private MaterialSkin.Controls.MaterialLabel lbFloor;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxRoomType;
        private Guna.UI2.WinForms.Guna2TextBox note;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2NumericUpDown floor;
        private Guna.UI2.WinForms.Guna2NumericUpDown numRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private System.Windows.Forms.PictureBox editType;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox editStatus;
    }
}