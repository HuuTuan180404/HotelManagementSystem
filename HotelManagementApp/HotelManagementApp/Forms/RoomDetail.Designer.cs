namespace HotelManagementApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetail));
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.numbeOfBed = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.floor = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numberOfRoom = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.numberOfPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupboxPreview = new System.Windows.Forms.GroupBox();
            this.lbStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.lbNote = new MaterialSkin.Controls.MaterialLabel();
            this.lbPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbPeople = new MaterialSkin.Controls.MaterialLabel();
            this.lbRooType = new MaterialSkin.Controls.MaterialLabel();
            this.lbFloor = new MaterialSkin.Controls.MaterialLabel();
            this.lbBed = new MaterialSkin.Controls.MaterialLabel();
            this.lbRoom = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.note = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.toolTipRoomDetail = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.comboboxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbeOfBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeople)).BeginInit();
            this.groupboxPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.materialLabel1);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(945, 79);
            this.panelTitle.TabIndex = 19;
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
            this.materialLabel1.Size = new System.Drawing.Size(308, 58);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "ROOM DETAIL";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(883, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numbeOfBed
            // 
            this.numbeOfBed.BackColor = System.Drawing.Color.Transparent;
            this.numbeOfBed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numbeOfBed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numbeOfBed.Location = new System.Drawing.Point(242, 338);
            this.numbeOfBed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numbeOfBed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbeOfBed.Name = "numbeOfBed";
            this.numbeOfBed.Size = new System.Drawing.Size(160, 36);
            this.numbeOfBed.TabIndex = 36;
            this.numbeOfBed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbeOfBed.ValueChanged += new System.EventHandler(this.numbeOfBed_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(88, 344);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(133, 24);
            this.materialLabel8.TabIndex = 35;
            this.materialLabel8.Text = "Number of bed";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.floor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.floor.Location = new System.Drawing.Point(660, 256);
            this.floor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(160, 36);
            this.floor.TabIndex = 34;
            this.floor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floor.ValueChanged += new System.EventHandler(this.floor_ValueChanged);
            // 
            // numberOfRoom
            // 
            this.numberOfRoom.BackColor = System.Drawing.Color.Transparent;
            this.numberOfRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberOfRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numberOfRoom.Location = new System.Drawing.Point(242, 256);
            this.numberOfRoom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfRoom.Name = "numberOfRoom";
            this.numberOfRoom.Size = new System.Drawing.Size(160, 36);
            this.numberOfRoom.TabIndex = 33;
            this.numberOfRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfRoom.ValueChanged += new System.EventHandler(this.numberOfRoom_ValueChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(75, 262);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(146, 24);
            this.materialLabel7.TabIndex = 32;
            this.materialLabel7.Text = "Number of room";
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(660, 420);
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(160, 36);
            this.price.TabIndex = 29;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.BackColor = System.Drawing.Color.Transparent;
            this.numberOfPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberOfPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numberOfPeople.Location = new System.Drawing.Point(660, 338);
            this.numberOfPeople.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(160, 36);
            this.numberOfPeople.TabIndex = 28;
            this.numberOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeople.ValueChanged += new System.EventHandler(this.numberOfPeople_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(491, 344);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(160, 24);
            this.materialLabel6.TabIndex = 27;
            this.materialLabel6.Text = "Number of people";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(607, 508);
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
            this.materialLabel3.Location = new System.Drawing.Point(604, 426);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Price";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(605, 262);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 24);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Floor";
            // 
            // groupboxPreview
            // 
            this.groupboxPreview.Controls.Add(this.lbStatus);
            this.groupboxPreview.Controls.Add(this.materialLabel18);
            this.groupboxPreview.Controls.Add(this.lbNote);
            this.groupboxPreview.Controls.Add(this.lbPrice);
            this.groupboxPreview.Controls.Add(this.lbPeople);
            this.groupboxPreview.Controls.Add(this.lbRooType);
            this.groupboxPreview.Controls.Add(this.lbFloor);
            this.groupboxPreview.Controls.Add(this.lbBed);
            this.groupboxPreview.Controls.Add(this.lbRoom);
            this.groupboxPreview.Controls.Add(this.materialLabel15);
            this.groupboxPreview.Controls.Add(this.materialLabel14);
            this.groupboxPreview.Controls.Add(this.materialLabel13);
            this.groupboxPreview.Controls.Add(this.materialLabel12);
            this.groupboxPreview.Controls.Add(this.materialLabel11);
            this.groupboxPreview.Controls.Add(this.materialLabel10);
            this.groupboxPreview.Controls.Add(this.materialLabel9);
            this.groupboxPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupboxPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPreview.Location = new System.Drawing.Point(0, 79);
            this.groupboxPreview.Name = "groupboxPreview";
            this.groupboxPreview.Size = new System.Drawing.Size(945, 128);
            this.groupboxPreview.TabIndex = 38;
            this.groupboxPreview.TabStop = false;
            this.groupboxPreview.Text = "Preview";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.Depth = 0;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbStatus.Location = new System.Drawing.Point(679, 83);
            this.lbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(88, 19);
            this.lbStatus.TabIndex = 48;
            this.lbStatus.Text = "100";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel18.Location = new System.Drawing.Point(677, 49);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(92, 24);
            this.materialLabel18.TabIndex = 47;
            this.materialLabel18.Text = "Tình trạng";
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNote.Depth = 0;
            this.lbNote.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNote.Location = new System.Drawing.Point(790, 83);
            this.lbNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(120, 42);
            this.lbNote.TabIndex = 46;
            this.lbNote.Text = "ghi chú";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.Depth = 0;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbPrice.Location = new System.Drawing.Point(582, 83);
            this.lbPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 19);
            this.lbPrice.TabIndex = 45;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPeople
            // 
            this.lbPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeople.Depth = 0;
            this.lbPeople.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbPeople.Location = new System.Drawing.Point(507, 83);
            this.lbPeople.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(33, 19);
            this.lbPeople.TabIndex = 44;
            this.lbPeople.Text = "3";
            this.lbPeople.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRooType
            // 
            this.lbRooType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRooType.Depth = 0;
            this.lbRooType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbRooType.Location = new System.Drawing.Point(147, 83);
            this.lbRooType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRooType.Name = "lbRooType";
            this.lbRooType.Size = new System.Drawing.Size(95, 19);
            this.lbRooType.TabIndex = 43;
            this.lbRooType.Text = "Single";
            this.lbRooType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFloor.Depth = 0;
            this.lbFloor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFloor.Location = new System.Drawing.Point(378, 83);
            this.lbFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(98, 19);
            this.lbFloor.TabIndex = 42;
            this.lbFloor.Text = "Floor - 0";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBed
            // 
            this.lbBed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBed.Depth = 0;
            this.lbBed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBed.Location = new System.Drawing.Point(300, 83);
            this.lbBed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(48, 19);
            this.lbBed.TabIndex = 41;
            this.lbBed.Text = "3";
            this.lbBed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRoom
            // 
            this.lbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRoom.Depth = 0;
            this.lbRoom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbRoom.Location = new System.Drawing.Point(39, 83);
            this.lbRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(89, 19);
            this.lbRoom.TabIndex = 40;
            this.lbRoom.Text = "Roo001";
            this.lbRoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(816, 49);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(68, 24);
            this.materialLabel15.TabIndex = 39;
            this.materialLabel15.Text = "Ghi chú";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(145, 49);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(99, 24);
            this.materialLabel14.TabIndex = 38;
            this.materialLabel14.Text = "Loại phòng";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(404, 49);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(46, 24);
            this.materialLabel13.TabIndex = 37;
            this.materialLabel13.Text = "Tầng";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(596, 49);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(31, 24);
            this.materialLabel12.TabIndex = 36;
            this.materialLabel12.Text = "Giá";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(277, 49);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(94, 24);
            this.materialLabel11.TabIndex = 35;
            this.materialLabel11.Text = "Số Giường";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(483, 49);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(80, 24);
            this.materialLabel10.TabIndex = 34;
            this.materialLabel10.Text = "Số người";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(54, 49);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(58, 24);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Phòng";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(125, 426);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 24);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Room type";
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
            this.note.Location = new System.Drawing.Point(660, 502);
            this.note.Name = "note";
            this.note.PasswordChar = '\0';
            this.note.PlaceholderText = "";
            this.note.SelectedText = "";
            this.note.Size = new System.Drawing.Size(160, 36);
            this.note.TabIndex = 41;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::HotelManagementApp.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(404, 582);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::HotelManagementApp.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(485, 582);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
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
            this.comboboxRoomType.Location = new System.Drawing.Point(242, 420);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(160, 36);
            this.comboboxRoomType.TabIndex = 44;
            this.comboboxRoomType.SelectedValueChanged += new System.EventHandler(this.comboboxRoomType_SelectedValueChanged);
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
            this.comboboxStatus.Location = new System.Drawing.Point(242, 502);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(160, 36);
            this.comboboxStatus.TabIndex = 46;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(162, 508);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(59, 24);
            this.materialLabel16.TabIndex = 45;
            this.materialLabel16.Text = "Status";
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 656);
            this.Controls.Add(this.comboboxStatus);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.comboboxRoomType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.note);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupboxPreview);
            this.Controls.Add(this.numbeOfBed);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.numberOfRoom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.numberOfPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomDetail";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbeOfBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeople)).EndInit();
            this.groupboxPreview.ResumeLayout(false);
            this.groupboxPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private System.Windows.Forms.PictureBox btnExit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numbeOfBed;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private Guna.UI2.WinForms.Guna2NumericUpDown floor;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberOfRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberOfPeople;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel lbRoom;
        private MaterialSkin.Controls.MaterialLabel lbNote;
        private MaterialSkin.Controls.MaterialLabel lbPrice;
        private MaterialSkin.Controls.MaterialLabel lbPeople;
        private MaterialSkin.Controls.MaterialLabel lbRooType;
        private MaterialSkin.Controls.MaterialLabel lbFloor;
        private MaterialSkin.Controls.MaterialLabel lbBed;
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
    }
}