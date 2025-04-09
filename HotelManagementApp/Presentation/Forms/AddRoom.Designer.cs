namespace Presentation.Forms
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
            this.editType = new System.Windows.Forms.PictureBox();
            this.editStatus = new System.Windows.Forms.PictureBox();
            this.groupboxPreview = new System.Windows.Forms.GroupBox();
            this.lbRoomId = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lbTypeDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lbRoomDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lbMaxGuests = new MaterialSkin.Controls.MaterialLabel();
            this.lbBedCount = new MaterialSkin.Controls.MaterialLabel();
            this.lbStatusDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.lbStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.lbType = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStatus)).BeginInit();
            this.groupboxPreview.SuspendLayout();
            this.lbRoomId.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(757, 73);
            this.panelTitle.TabIndex = 47;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(13, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.btnExit.Location = new System.Drawing.Point(684, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 58);
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
            this.comboboxStatus.Location = new System.Drawing.Point(109, 583);
            this.comboboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(200, 36);
            this.comboboxStatus.TabIndex = 78;
            this.comboboxStatus.SelectedValueChanged += new System.EventHandler(this.comboboxStatus_SelectedValueChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(109, 562);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.comboboxRoomType.Location = new System.Drawing.Point(109, 481);
            this.comboboxRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(200, 36);
            this.comboboxRoomType.TabIndex = 76;
            this.comboboxRoomType.SelectedValueChanged += new System.EventHandler(this.comboboxRoomType_SelectedValueChanged);
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
            this.note.Location = new System.Drawing.Point(408, 583);
            this.note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.note.Name = "note";
            this.note.PlaceholderText = "";
            this.note.SelectedText = "";
            this.note.Size = new System.Drawing.Size(200, 36);
            this.note.TabIndex = 75;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(109, 458);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.floor.Location = new System.Drawing.Point(109, 379);
            this.floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.floor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(200, 36);
            this.floor.TabIndex = 73;
            this.floor.ValueChanged += new System.EventHandler(this.floor_ValueChanged);
            // 
            // numRoom
            // 
            this.numRoom.BackColor = System.Drawing.Color.Transparent;
            this.numRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRoom.Location = new System.Drawing.Point(408, 379);
            this.numRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numRoom.Size = new System.Drawing.Size(200, 36);
            this.numRoom.TabIndex = 72;
            this.numRoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoom.ValueChanged += new System.EventHandler(this.numRoom_ValueChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(109, 358);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.materialLabel7.Location = new System.Drawing.Point(408, 358);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.materialLabel3.Location = new System.Drawing.Point(408, 458);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.materialLabel4.Location = new System.Drawing.Point(408, 562);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.price.Location = new System.Drawing.Point(408, 481);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(200, 36);
            this.price.TabIndex = 70;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // editType
            // 
            this.editType.Image = ((System.Drawing.Image)(resources.GetObject("editType.Image")));
            this.editType.Location = new System.Drawing.Point(208, 463);
            this.editType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editType.Name = "editType";
            this.editType.Size = new System.Drawing.Size(15, 15);
            this.editType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editType.TabIndex = 80;
            this.editType.TabStop = false;
            // 
            // editStatus
            // 
            this.editStatus.Image = ((System.Drawing.Image)(resources.GetObject("editStatus.Image")));
            this.editStatus.Location = new System.Drawing.Point(173, 567);
            this.editStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editStatus.Name = "editStatus";
            this.editStatus.Size = new System.Drawing.Size(15, 15);
            this.editStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editStatus.TabIndex = 81;
            this.editStatus.TabStop = false;
            // 
            // groupboxPreview
            // 
            this.groupboxPreview.Controls.Add(this.lbRoomId);
            this.groupboxPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupboxPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPreview.Location = new System.Drawing.Point(0, 73);
            this.groupboxPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupboxPreview.Name = "groupboxPreview";
            this.groupboxPreview.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupboxPreview.Size = new System.Drawing.Size(757, 259);
            this.groupboxPreview.TabIndex = 82;
            this.groupboxPreview.TabStop = false;
            this.groupboxPreview.Text = "Preview";
            // 
            // lbRoomId
            // 
            this.lbRoomId.BorderColor = System.Drawing.Color.Gray;
            this.lbRoomId.BorderRadius = 23;
            this.lbRoomId.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lbRoomId.Controls.Add(this.tableLayoutPanel4);
            this.lbRoomId.CustomBorderColor = System.Drawing.Color.Transparent;
            this.lbRoomId.FillColor = System.Drawing.Color.Transparent;
            this.lbRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomId.ForeColor = System.Drawing.Color.Black;
            this.lbRoomId.Location = new System.Drawing.Point(18, 40);
            this.lbRoomId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(719, 209);
            this.lbRoomId.TabIndex = 51;
            this.lbRoomId.Text = "Roo0-1";
            this.lbRoomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.179416F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.356546F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.39833F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.02785F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88873F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31415F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31415F));
            this.tableLayoutPanel4.Controls.Add(this.materialLabel6, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbTypeDescription, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel8, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbPrice, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbRoomDescription, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbMaxGuests, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbBedCount, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbStatusDescription, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel9, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbStatus, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel14, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel22, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbType, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.85207F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.36095F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.78698F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(719, 169);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(295, 1);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.tableLayoutPanel4.SetRowSpan(this.materialLabel6, 2);
            this.materialLabel6.Size = new System.Drawing.Size(71, 93);
            this.materialLabel6.TabIndex = 81;
            this.materialLabel6.Text = "Giá";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTypeDescription
            // 
            this.lbTypeDescription.Depth = 0;
            this.lbTypeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTypeDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTypeDescription.Location = new System.Drawing.Point(132, 99);
            this.lbTypeDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbTypeDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTypeDescription.Name = "lbTypeDescription";
            this.lbTypeDescription.Size = new System.Drawing.Size(157, 65);
            this.lbTypeDescription.TabIndex = 80;
            this.lbTypeDescription.Text = "3";
            this.lbTypeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(132, 47);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(157, 43);
            this.materialLabel8.TabIndex = 78;
            this.materialLabel8.Text = "Chú thích";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Depth = 0;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbPrice.Location = new System.Drawing.Point(301, 101);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(6);
            this.lbPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(59, 61);
            this.lbPrice.TabIndex = 75;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRoomDescription
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.lbRoomDescription, 2);
            this.lbRoomDescription.Depth = 0;
            this.lbRoomDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoomDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbRoomDescription.Location = new System.Drawing.Point(510, 95);
            this.lbRoomDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lbRoomDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRoomDescription.Name = "lbRoomDescription";
            this.lbRoomDescription.Size = new System.Drawing.Size(208, 73);
            this.lbRoomDescription.TabIndex = 68;
            this.lbRoomDescription.Text = "---";
            this.lbRoomDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaxGuests
            // 
            this.lbMaxGuests.Depth = 0;
            this.lbMaxGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMaxGuests.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbMaxGuests.Location = new System.Drawing.Point(72, 99);
            this.lbMaxGuests.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbMaxGuests.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMaxGuests.Name = "lbMaxGuests";
            this.lbMaxGuests.Size = new System.Drawing.Size(49, 65);
            this.lbMaxGuests.TabIndex = 65;
            this.lbMaxGuests.Text = "3";
            this.lbMaxGuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBedCount
            // 
            this.lbBedCount.Depth = 0;
            this.lbBedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBedCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbBedCount.Location = new System.Drawing.Point(6, 99);
            this.lbBedCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbBedCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbBedCount.Name = "lbBedCount";
            this.lbBedCount.Size = new System.Drawing.Size(55, 65);
            this.lbBedCount.TabIndex = 64;
            this.lbBedCount.Text = "3";
            this.lbBedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatusDescription
            // 
            this.lbStatusDescription.Depth = 0;
            this.lbStatusDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatusDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbStatusDescription.Location = new System.Drawing.Point(373, 101);
            this.lbStatusDescription.Margin = new System.Windows.Forms.Padding(6);
            this.lbStatusDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStatusDescription.Name = "lbStatusDescription";
            this.lbStatusDescription.Size = new System.Drawing.Size(130, 61);
            this.lbStatusDescription.TabIndex = 63;
            this.lbStatusDescription.Text = "Available";
            this.lbStatusDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.materialLabel9, 2);
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(510, 1);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.tableLayoutPanel4.SetRowSpan(this.materialLabel9, 2);
            this.materialLabel9.Size = new System.Drawing.Size(208, 93);
            this.materialLabel9.TabIndex = 57;
            this.materialLabel9.Text = "Mô tả phòng";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Depth = 0;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbStatus.Location = new System.Drawing.Point(367, 1);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStatus.Name = "lbStatus";
            this.tableLayoutPanel4.SetRowSpan(this.lbStatus, 2);
            this.lbStatus.Size = new System.Drawing.Size(142, 93);
            this.lbStatus.TabIndex = 56;
            this.lbStatus.Text = "Trạng thái";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel14.Location = new System.Drawing.Point(73, 49);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(6);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(47, 39);
            this.materialLabel14.TabIndex = 53;
            this.materialLabel14.Text = "Số người";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel22.Location = new System.Drawing.Point(7, 49);
            this.materialLabel22.Margin = new System.Windows.Forms.Padding(6);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(53, 39);
            this.materialLabel22.TabIndex = 52;
            this.materialLabel22.Text = "Số giường";
            this.materialLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.lbType, 3);
            this.lbType.Depth = 0;
            this.lbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbType.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbType.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbType.Location = new System.Drawing.Point(1, 1);
            this.lbType.Margin = new System.Windows.Forms.Padding(0);
            this.lbType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(293, 41);
            this.lbType.TabIndex = 37;
            this.lbType.Text = "Loại phòng";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnAdd.Image = global::Presentation.Properties.Resources.add;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.Location = new System.Drawing.Point(693, 595);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(76, 76);
            this.btnAdd.Size = new System.Drawing.Size(64, 64);
            this.btnAdd.TabIndex = 83;
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(757, 660);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupboxPreview);
            this.Controls.Add(this.editStatus);
            this.Controls.Add(this.editType);
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
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editStatus)).EndInit();
            this.groupboxPreview.ResumeLayout(false);
            this.lbRoomId.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolTip toolTip;
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
        private System.Windows.Forms.PictureBox editStatus;
        private System.Windows.Forms.GroupBox groupboxPreview;
        private Guna.UI2.WinForms.Guna2GroupBox lbRoomId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lbTypeDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbPrice;
        private MaterialSkin.Controls.MaterialLabel lbRoomDescription;
        private MaterialSkin.Controls.MaterialLabel lbMaxGuests;
        private MaterialSkin.Controls.MaterialLabel lbBedCount;
        private MaterialSkin.Controls.MaterialLabel lbStatusDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lbStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel lbType;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
    }
}