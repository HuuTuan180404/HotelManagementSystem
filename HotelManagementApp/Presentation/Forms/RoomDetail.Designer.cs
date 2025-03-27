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
            this.lbTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupboxPreview = new System.Windows.Forms.GroupBox();
            this.lbRoomId = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbRoomDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lbMaxGuests = new MaterialSkin.Controls.MaterialLabel();
            this.lbBedCount = new MaterialSkin.Controls.MaterialLabel();
            this.lbStatusDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.lbType = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.note = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolTipRoomDetail = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.comboboxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboboxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lbTypeDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupboxPreview.SuspendLayout();
            this.lbRoomId.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(780, 75);
            this.panelTitle.TabIndex = 19;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Depth = 0;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(308, 58);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "ROOM DETAIL";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(722, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 41);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "-1";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(168, 458);
            this.price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price.Name = "price";
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(185, 36);
            this.price.TabIndex = 29;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(422, 462);
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
            this.materialLabel3.Location = new System.Drawing.Point(104, 462);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Price";
            // 
            // groupboxPreview
            // 
            this.groupboxPreview.Controls.Add(this.lbRoomId);
            this.groupboxPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupboxPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPreview.Location = new System.Drawing.Point(0, 75);
            this.groupboxPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupboxPreview.Name = "groupboxPreview";
            this.groupboxPreview.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupboxPreview.Size = new System.Drawing.Size(780, 259);
            this.groupboxPreview.TabIndex = 38;
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
            this.lbRoomId.Location = new System.Drawing.Point(31, 40);
            this.lbRoomId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(719, 209);
            this.lbRoomId.TabIndex = 51;
            this.lbRoomId.Text = "mã phòng";
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
            this.tableLayoutPanel4.Controls.Add(this.materialLabel1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbTypeDescription, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbPrice, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbRoomDescription, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbMaxGuests, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbBedCount, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbStatusDescription, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.materialLabel8, 5, 0);
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
            this.lbRoomDescription.Text = "mô tả";
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
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.materialLabel8, 2);
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(510, 1);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.tableLayoutPanel4.SetRowSpan(this.materialLabel8, 2);
            this.materialLabel8.Size = new System.Drawing.Size(208, 93);
            this.materialLabel8.TabIndex = 57;
            this.materialLabel8.Text = "Mô tả phòng";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(106, 383);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 24);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Type";
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
            this.note.Location = new System.Drawing.Point(484, 458);
            this.note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.note.Name = "note";
            this.note.PlaceholderText = "";
            this.note.SelectedText = "";
            this.note.Size = new System.Drawing.Size(185, 36);
            this.note.TabIndex = 41;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
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
            this.comboboxRoomType.Location = new System.Drawing.Point(170, 378);
            this.comboboxRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(186, 36);
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
            this.comboboxStatus.Location = new System.Drawing.Point(484, 378);
            this.comboboxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(186, 36);
            this.comboboxStatus.TabIndex = 46;
            this.comboboxStatus.SelectedValueChanged += new System.EventHandler(this.comboboxStatus_SelectedValueChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(405, 383);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdate.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUpdate.Image = global::Presentation.Properties.Resources.done;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.Location = new System.Drawing.Point(566, 525);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(76, 76);
            this.btnUpdate.Size = new System.Drawing.Size(64, 64);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnDelete.Image = global::Presentation.Properties.Resources.delete;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.Location = new System.Drawing.Point(639, 525);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(76, 76);
            this.btnDelete.Size = new System.Drawing.Size(64, 64);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(132, 47);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(157, 43);
            this.materialLabel6.TabIndex = 78;
            this.materialLabel6.Text = "Chú thích";
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(295, 1);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.tableLayoutPanel4.SetRowSpan(this.materialLabel1, 2);
            this.materialLabel1.Size = new System.Drawing.Size(71, 93);
            this.materialLabel1.TabIndex = 81;
            this.materialLabel1.Text = "Giá";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 631);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboboxStatus);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.comboboxRoomType);
            this.Controls.Add(this.note);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupboxPreview);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.price);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lbRoomId.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private System.Windows.Forms.PictureBox btnExit;
        private MaterialSkin.Controls.MaterialLabel lbTitle;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox groupboxPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2TextBox note;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTipRoomDetail;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxRoomType;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private Guna.UI2.WinForms.Guna2GroupBox lbRoomId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel lbType;
        private MaterialSkin.Controls.MaterialLabel lbStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel lbRoomDescription;
        private MaterialSkin.Controls.MaterialLabel lbMaxGuests;
        private MaterialSkin.Controls.MaterialLabel lbBedCount;
        private MaterialSkin.Controls.MaterialLabel lbStatusDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbTypeDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lbPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}