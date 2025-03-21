namespace Presentation.User_Controls
{
    partial class UC_BookingManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.titleID = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityBeds = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityGuests = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pricePerNight = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rooNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeCheckOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeCheckIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bookingStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.gender = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 896);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.btnAdd.Image = global::Presentation.Properties.Resources.add;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.Location = new System.Drawing.Point(691, 765);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.titleID);
            this.guna2GroupBox1.Controls.Add(this.groupBox3);
            this.guna2GroupBox1.Controls.Add(this.groupBox2);
            this.guna2GroupBox1.Controls.Add(this.groupBox1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(779, 124);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(839, 721);
            this.guna2GroupBox1.TabIndex = 14;
            this.guna2GroupBox1.Text = "Booking Detail";
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.guna2GroupBox1.UseTransparentBackground = true;
            // 
            // titleID
            // 
            this.titleID.AutoRoundedCorners = true;
            this.titleID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.titleID.BorderRadius = 22;
            this.titleID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleID.DefaultText = "ID: 2";
            this.titleID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.titleID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleID.ForeColor = System.Drawing.Color.White;
            this.titleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleID.Location = new System.Drawing.Point(22, 58);
            this.titleID.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.titleID.Name = "titleID";
            this.titleID.PlaceholderText = "";
            this.titleID.ReadOnly = true;
            this.titleID.SelectedText = "";
            this.titleID.Size = new System.Drawing.Size(93, 47);
            this.titleID.TabIndex = 3;
            this.titleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.quantityBeds);
            this.groupBox3.Controls.Add(this.quantityGuests);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.roomType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pricePerNight);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rooNo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(533, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(291, 353);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(91, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Guests";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(110, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bed";
            // 
            // quantityBeds
            // 
            this.quantityBeds.AutoRoundedCorners = true;
            this.quantityBeds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.quantityBeds.BorderRadius = 20;
            this.quantityBeds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityBeds.DefaultText = "Roo002";
            this.quantityBeds.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityBeds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityBeds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityBeds.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityBeds.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBeds.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBeds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.quantityBeds.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBeds.Location = new System.Drawing.Point(152, 210);
            this.quantityBeds.Margin = new System.Windows.Forms.Padding(6);
            this.quantityBeds.Name = "quantityBeds";
            this.quantityBeds.PlaceholderText = "";
            this.quantityBeds.ReadOnly = true;
            this.quantityBeds.SelectedText = "";
            this.quantityBeds.Size = new System.Drawing.Size(114, 43);
            this.quantityBeds.TabIndex = 14;
            this.quantityBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityGuests
            // 
            this.quantityGuests.AutoRoundedCorners = true;
            this.quantityGuests.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.quantityGuests.BorderRadius = 20;
            this.quantityGuests.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityGuests.DefaultText = "Roo002";
            this.quantityGuests.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityGuests.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityGuests.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityGuests.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityGuests.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.quantityGuests.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityGuests.Location = new System.Drawing.Point(152, 286);
            this.quantityGuests.Margin = new System.Windows.Forms.Padding(6);
            this.quantityGuests.Name = "quantityGuests";
            this.quantityGuests.PlaceholderText = "";
            this.quantityGuests.ReadOnly = true;
            this.quantityGuests.SelectedText = "";
            this.quantityGuests.Size = new System.Drawing.Size(114, 43);
            this.quantityGuests.TabIndex = 13;
            this.quantityGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(24, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Type";
            // 
            // roomType
            // 
            this.roomType.AutoRoundedCorners = true;
            this.roomType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.roomType.BorderRadius = 20;
            this.roomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomType.DefaultText = "type";
            this.roomType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.roomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.Location = new System.Drawing.Point(71, 155);
            this.roomType.Margin = new System.Windows.Forms.Padding(6);
            this.roomType.Name = "roomType";
            this.roomType.PlaceholderText = "";
            this.roomType.ReadOnly = true;
            this.roomType.SelectedText = "";
            this.roomType.Size = new System.Drawing.Size(195, 43);
            this.roomType.TabIndex = 11;
            this.roomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(153, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price/Night";
            // 
            // pricePerNight
            // 
            this.pricePerNight.AutoRoundedCorners = true;
            this.pricePerNight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.pricePerNight.BorderRadius = 20;
            this.pricePerNight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricePerNight.DefaultText = "Roo002";
            this.pricePerNight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pricePerNight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pricePerNight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricePerNight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricePerNight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricePerNight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.pricePerNight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricePerNight.Location = new System.Drawing.Point(153, 74);
            this.pricePerNight.Margin = new System.Windows.Forms.Padding(6);
            this.pricePerNight.Name = "pricePerNight";
            this.pricePerNight.PlaceholderText = "";
            this.pricePerNight.ReadOnly = true;
            this.pricePerNight.SelectedText = "";
            this.pricePerNight.Size = new System.Drawing.Size(114, 43);
            this.pricePerNight.TabIndex = 9;
            this.pricePerNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "RooNo";
            // 
            // rooNo
            // 
            this.rooNo.AutoRoundedCorners = true;
            this.rooNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.rooNo.BorderRadius = 20;
            this.rooNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rooNo.DefaultText = "Roo002";
            this.rooNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rooNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rooNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rooNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rooNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rooNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.rooNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rooNo.Location = new System.Drawing.Point(18, 74);
            this.rooNo.Margin = new System.Windows.Forms.Padding(6);
            this.rooNo.Name = "rooNo";
            this.rooNo.PlaceholderText = "";
            this.rooNo.ReadOnly = true;
            this.rooNo.SelectedText = "";
            this.rooNo.Size = new System.Drawing.Size(114, 43);
            this.rooNo.TabIndex = 7;
            this.rooNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeCheckOut);
            this.groupBox2.Controls.Add(this.timeCheckIn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bookingStatus);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(762, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Information";
            // 
            // timeCheckOut
            // 
            this.timeCheckOut.AutoRoundedCorners = true;
            this.timeCheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.timeCheckOut.BorderRadius = 20;
            this.timeCheckOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeCheckOut.DefaultText = "time2";
            this.timeCheckOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeCheckOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeCheckOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.timeCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeCheckOut.Location = new System.Drawing.Point(265, 78);
            this.timeCheckOut.Margin = new System.Windows.Forms.Padding(6);
            this.timeCheckOut.Name = "timeCheckOut";
            this.timeCheckOut.PlaceholderText = "";
            this.timeCheckOut.ReadOnly = true;
            this.timeCheckOut.SelectedText = "";
            this.timeCheckOut.Size = new System.Drawing.Size(227, 43);
            this.timeCheckOut.TabIndex = 23;
            this.timeCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeCheckIn
            // 
            this.timeCheckIn.AutoRoundedCorners = true;
            this.timeCheckIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.timeCheckIn.BorderRadius = 20;
            this.timeCheckIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeCheckIn.DefaultText = "time1";
            this.timeCheckIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeCheckIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeCheckIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.timeCheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeCheckIn.Location = new System.Drawing.Point(16, 78);
            this.timeCheckIn.Margin = new System.Windows.Forms.Padding(6);
            this.timeCheckIn.Name = "timeCheckIn";
            this.timeCheckIn.PlaceholderText = "";
            this.timeCheckIn.ReadOnly = true;
            this.timeCheckIn.SelectedText = "";
            this.timeCheckIn.Size = new System.Drawing.Size(227, 43);
            this.timeCheckIn.TabIndex = 22;
            this.timeCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(265, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Time CheckOut";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(16, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Time CheckIn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(512, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Status";
            // 
            // bookingStatus
            // 
            this.bookingStatus.AutoRoundedCorners = true;
            this.bookingStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.bookingStatus.BorderRadius = 20;
            this.bookingStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookingStatus.DefaultText = "status";
            this.bookingStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookingStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookingStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.bookingStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingStatus.Location = new System.Drawing.Point(512, 78);
            this.bookingStatus.Margin = new System.Windows.Forms.Padding(6);
            this.bookingStatus.Name = "bookingStatus";
            this.bookingStatus.PlaceholderText = "";
            this.bookingStatus.ReadOnly = true;
            this.bookingStatus.SelectedText = "";
            this.bookingStatus.Size = new System.Drawing.Size(227, 43);
            this.bookingStatus.TabIndex = 13;
            this.bookingStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.customerID);
            this.groupBox1.Controls.Add(this.fullName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(512, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(258, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoRoundedCorners = true;
            this.phoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.phoneNumber.BorderRadius = 20;
            this.phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumber.DefaultText = "0364626275";
            this.phoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.phoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumber.Location = new System.Drawing.Point(9, 183);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.PlaceholderText = "";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.SelectedText = "";
            this.phoneNumber.Size = new System.Drawing.Size(188, 43);
            this.phoneNumber.TabIndex = 3;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender
            // 
            this.gender.AutoRoundedCorners = true;
            this.gender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.gender.BorderRadius = 20;
            this.gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender.DefaultText = "Nam";
            this.gender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender.Location = new System.Drawing.Point(258, 183);
            this.gender.Margin = new System.Windows.Forms.Padding(6);
            this.gender.Name = "gender";
            this.gender.PlaceholderText = "";
            this.gender.ReadOnly = true;
            this.gender.SelectedText = "";
            this.gender.Size = new System.Drawing.Size(114, 43);
            this.gender.TabIndex = 2;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerID
            // 
            this.customerID.AutoRoundedCorners = true;
            this.customerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.customerID.BorderRadius = 20;
            this.customerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerID.DefaultText = "052204013042";
            this.customerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.customerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerID.Location = new System.Drawing.Point(258, 77);
            this.customerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID.Name = "customerID";
            this.customerID.PlaceholderText = "";
            this.customerID.ReadOnly = true;
            this.customerID.SelectedText = "";
            this.customerID.Size = new System.Drawing.Size(227, 43);
            this.customerID.TabIndex = 1;
            this.customerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullName
            // 
            this.fullName.AutoRoundedCorners = true;
            this.fullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.fullName.BorderRadius = 20;
            this.fullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullName.DefaultText = "nguyễn hữu tuấn";
            this.fullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.fullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullName.Location = new System.Drawing.Point(9, 77);
            this.fullName.Margin = new System.Windows.Forms.Padding(6);
            this.fullName.Name = "fullName";
            this.fullName.PlaceholderText = "";
            this.fullName.ReadOnly = true;
            this.fullName.SelectedText = "";
            this.fullName.Size = new System.Drawing.Size(227, 43);
            this.fullName.TabIndex = 0;
            this.fullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(25, 24);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(549, 58);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "BOOKING MANAGEMENT";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dataGridView.Location = new System.Drawing.Point(4, 124);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.Size = new System.Drawing.Size(767, 721);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(170)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView.ThemeStyle.ReadOnly = true;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(95)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 43;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_BookingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_BookingManagement";
            this.Size = new System.Drawing.Size(1627, 896);
            this.Load += new System.EventHandler(this.UC_BookingManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox fullName;
        private Guna.UI2.WinForms.Guna2TextBox customerID;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox rooNo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox pricePerNight;
        private Guna.UI2.WinForms.Guna2TextBox quantityBeds;
        private Guna.UI2.WinForms.Guna2TextBox quantityGuests;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox roomType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox bookingStatus;
        private Guna.UI2.WinForms.Guna2TextBox titleID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private Guna.UI2.WinForms.Guna2TextBox timeCheckOut;
        private Guna.UI2.WinForms.Guna2TextBox timeCheckIn;
    }
}
