namespace HotelManagementApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sideBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelLogout = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLogout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picLogout = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTime = new MaterialSkin.Controls.MaterialLabel();
            this.uC_CustomerManagement1 = new Presentation.User_Controls.UC_CustomerManagement();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.panelRoomManagement = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_BookingManagement1 = new HotelManagementApp.User_Controls.UC_BookingManagement();
            this.UC_RoomManagement = new HotelManagementApp.User_Controls.UC_RoomManagement();
            this.UC_BookingManagement = new HotelManagementApp.User_Controls.UC_BookingManagement();
            this.UC_CustomerManagement = new Presentation.User_Controls.UC_CustomerManagement();
            this.UC_EmployeeManagement = new Presentation.User_Controls.UC_EmployeeManagement();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sideBar.SuspendLayout();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            this.panelRoomManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.panelLogout);
            this.sideBar.Controls.Add(this.btnMenu);
            this.sideBar.Controls.Add(this.guna2Button1);
            this.sideBar.Controls.Add(this.btnBooking);
            this.sideBar.Controls.Add(this.btnEmployee);
            this.sideBar.Controls.Add(this.btnRoom);
            this.sideBar.Controls.Add(this.btnCustomer);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar.MaximumSize = new System.Drawing.Size(333, 1006);
            this.sideBar.MinimumSize = new System.Drawing.Size(107, 1006);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(107, 1006);
            this.sideBar.TabIndex = 17;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.lbLogout);
            this.panelLogout.Controls.Add(this.picLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogout.Location = new System.Drawing.Point(0, 937);
            this.panelLogout.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(107, 69);
            this.panelLogout.TabIndex = 24;
            this.panelLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelLogout_MouseClick);
            // 
            // lbLogout
            // 
            this.lbLogout.BackColor = System.Drawing.Color.Transparent;
            this.lbLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.lbLogout.Location = new System.Drawing.Point(137, 18);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(102, 37);
            this.lbLogout.TabIndex = 1;
            this.lbLogout.Text = "LOGOUT";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // picLogout
            // 
            this.picLogout.ImageRotate = 0F;
            this.picLogout.Location = new System.Drawing.Point(28, 16);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(44, 42);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 0;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.Location = new System.Drawing.Point(24, 180);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 55);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 25;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseTransparentBackground = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(21, 635);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(393, 55);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Services";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // btnBooking
            // 
            this.btnBooking.AutoRoundedCorners = true;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.BorderRadius = 26;
            this.btnBooking.BorderThickness = 1;
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooking.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBooking.Location = new System.Drawing.Point(21, 373);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(393, 55);
            this.btnBooking.TabIndex = 21;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseTransparentBackground = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AutoRoundedCorners = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(21, 548);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(393, 55);
            this.btnEmployee.TabIndex = 20;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseTransparentBackground = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.AutoRoundedCorners = true;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.BorderRadius = 26;
            this.btnRoom.BorderThickness = 1;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.Checked = true;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRoom.Location = new System.Drawing.Point(21, 282);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(393, 55);
            this.btnRoom.TabIndex = 19;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseTransparentBackground = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoRoundedCorners = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.BorderRadius = 26;
            this.btnCustomer.BorderThickness = 1;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomer.Location = new System.Drawing.Point(21, 460);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(393, 55);
            this.btnCustomer.TabIndex = 16;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseTransparentBackground = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbTime);
            this.guna2Panel1.Controls.Add(this.uC_CustomerManagement1);
            this.guna2Panel1.Controls.Add(this.pic_close);
            this.guna2Panel1.Controls.Add(this.pic_minus);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(107, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1835, 97);
            this.guna2Panel1.TabIndex = 18;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Depth = 0;
            this.lbTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTime.Location = new System.Drawing.Point(91, 39);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(174, 19);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "giờ, thứ ngày tháng nam";
            // 
            // uC_CustomerManagement1
            // 
            this.uC_CustomerManagement1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerManagement1.Location = new System.Drawing.Point(0, 97);
            this.uC_CustomerManagement1.Name = "uC_CustomerManagement1";
            this.uC_CustomerManagement1.Size = new System.Drawing.Size(1134, 836);
            this.uC_CustomerManagement1.TabIndex = 2;
            // 
            // pic_close
            // 
            this.pic_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(1753, 15);
            this.pic_close.Margin = new System.Windows.Forms.Padding(4);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(67, 62);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minus
            // 
            this.pic_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minus.Image = ((System.Drawing.Image)(resources.GetObject("pic_minus.Image")));
            this.pic_minus.Location = new System.Drawing.Point(1678, 15);
            this.pic_minus.Margin = new System.Windows.Forms.Padding(4);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(67, 62);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 12;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // panelRoomManagement
            // 
            this.panelRoomManagement.Controls.Add(this.uC_BookingManagement1);
            this.panelRoomManagement.Controls.Add(this.UC_RoomManagement);
            this.panelRoomManagement.Controls.Add(this.UC_BookingManagement);
            this.panelRoomManagement.Controls.Add(this.UC_CustomerManagement);
            this.panelRoomManagement.Controls.Add(this.UC_EmployeeManagement);
            this.panelRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomManagement.Location = new System.Drawing.Point(107, 97);
            this.panelRoomManagement.Margin = new System.Windows.Forms.Padding(4);
            this.panelRoomManagement.Name = "panelRoomManagement";
            this.panelRoomManagement.Size = new System.Drawing.Size(1835, 909);
            this.panelRoomManagement.TabIndex = 19;
            // 
            // uC_BookingManagement1
            // 
            this.uC_BookingManagement1.BackColor = System.Drawing.Color.White;
            this.uC_BookingManagement1.Location = new System.Drawing.Point(584, 108);
            this.uC_BookingManagement1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_BookingManagement1.Name = "uC_BookingManagement1";
            this.uC_BookingManagement1.Size = new System.Drawing.Size(177, 8);
            this.uC_BookingManagement1.TabIndex = 3;
            // 
            // UC_RoomManagement
            // 
            this.UC_RoomManagement.BackColor = System.Drawing.Color.White;
            this.UC_RoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_RoomManagement.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_RoomManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_RoomManagement.Margin = new System.Windows.Forms.Padding(4);
            this.UC_RoomManagement.Name = "UC_RoomManagement";
            this.UC_RoomManagement.Size = new System.Drawing.Size(1835, 909);
            this.UC_RoomManagement.TabIndex = 0;
            // 
            // UC_BookingManagement
            // 
            this.UC_BookingManagement.BackColor = System.Drawing.Color.White;
            this.UC_BookingManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_BookingManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_BookingManagement.Margin = new System.Windows.Forms.Padding(5);
            this.UC_BookingManagement.Name = "UC_BookingManagement";
            this.UC_BookingManagement.Size = new System.Drawing.Size(1835, 909);
            this.UC_BookingManagement.TabIndex = 1;
            // 
            // UC_CustomerManagement
            // 
            this.UC_CustomerManagement.BackColor = System.Drawing.Color.White;
            this.UC_CustomerManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_CustomerManagement.Name = "UC_CustomerManagement";
            this.UC_CustomerManagement.Size = new System.Drawing.Size(1134, 836);
            this.UC_CustomerManagement.TabIndex = 4;
            // 
            // UC_EmployeeManagement
            // 
            this.UC_EmployeeManagement.Location = new System.Drawing.Point(0, 0);
            this.UC_EmployeeManagement.Name = "UC_EmployeeManagement";
            this.UC_EmployeeManagement.Size = new System.Drawing.Size(1958, 973);
            this.UC_EmployeeManagement.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1006);
            this.Controls.Add(this.panelRoomManagement);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideBar.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            this.panelRoomManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_minus;
        private System.Windows.Forms.PictureBox pic_close;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel sideBar;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelRoomManagement;
        private User_Controls.UC_RoomManagement UC_RoomManagement;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private MaterialSkin.Controls.MaterialLabel lbTime;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Panel panelLogout;
        private Guna.UI2.WinForms.Guna2PictureBox picLogout;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLogout;
        private User_Controls.UC_BookingManagement UC_BookingManagement;
        private Guna.UI2.WinForms.Guna2PictureBox btnMenu;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Presentation.User_Controls.UC_CustomerManagement uC_CustomerManagement1;
        private User_Controls.UC_BookingManagement uC_BookingManagement1;
        private Presentation.User_Controls.UC_CustomerManagement UC_CustomerManagement;
        private Presentation.User_Controls.UC_EmployeeManagement UC_EmployeeManagement;
    }
}