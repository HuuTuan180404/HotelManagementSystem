namespace Presentation.Forms
{
    partial class AddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooking));
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectGender = new MaterialSkin.Controls.MaterialComboBox();
            this.btnQR = new System.Windows.Forms.PictureBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateCheckout = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeCheckout = new System.Windows.Forms.MaskedTextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateCheckin = new System.Windows.Forms.MaskedTextBox();
            this.timeCheckin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.floor = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.comboboxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClearFilter = new System.Windows.Forms.PictureBox();
            this.timer_for_select_room = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elip_for_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer_btnFilter34 = new System.Windows.Forms.Timer(this.components);
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.materialLabel1);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1277, 79);
            this.panelTitle.TabIndex = 48;
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
            this.materialLabel1.Size = new System.Drawing.Size(174, 58);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Booking";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1216, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(44, 59);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(23, 30);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "ID";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(354, 59);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 30);
            this.guna2HtmlLabel2.TabIndex = 50;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(16, 355);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(51, 30);
            this.guna2HtmlLabel3.TabIndex = 51;
            this.guna2HtmlLabel3.Text = "Email";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(5, 207);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(62, 30);
            this.guna2HtmlLabel4.TabIndex = 52;
            this.guna2HtmlLabel4.Text = "Phone";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(341, 207);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(70, 30);
            this.guna2HtmlLabel5.TabIndex = 53;
            this.guna2HtmlLabel5.Text = "Gender";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(335, 355);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(76, 30);
            this.guna2HtmlLabel6.TabIndex = 54;
            this.guna2HtmlLabel6.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectGender);
            this.groupBox1.Controls.Add(this.btnQR);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(684, 486);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // selectGender
            // 
            this.selectGender.AutoResize = false;
            this.selectGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectGender.Depth = 0;
            this.selectGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectGender.DropDownHeight = 174;
            this.selectGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectGender.DropDownWidth = 121;
            this.selectGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectGender.FormattingEnabled = true;
            this.selectGender.IntegralHeight = false;
            this.selectGender.ItemHeight = 43;
            this.selectGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.selectGender.Location = new System.Drawing.Point(427, 198);
            this.selectGender.MaxDropDownItems = 4;
            this.selectGender.MouseState = MaterialSkin.MouseState.OUT;
            this.selectGender.Name = "selectGender";
            this.selectGender.Size = new System.Drawing.Size(121, 49);
            this.selectGender.StartIndex = 0;
            this.selectGender.TabIndex = 62;
            // 
            // btnQR
            // 
            this.btnQR.Image = ((System.Drawing.Image)(resources.GetObject("btnQR.Image")));
            this.btnQR.Location = new System.Drawing.Point(635, 432);
            this.btnQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(34, 35);
            this.btnQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQR.TabIndex = 61;
            this.btnQR.TabStop = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(427, 339);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Your Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(250, 63);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 60;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(73, 339);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "xxx@gmail.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 63);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 59;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(427, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Full Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 63);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 56;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(73, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Your ID";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(250, 63);
            this.txtId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtId.TabIndex = 55;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.IconRightClick += new System.EventHandler(this.txtId_IconRightClick);
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(73, 191);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone Number";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(250, 63);
            this.txtPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPhone.TabIndex = 58;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guna2Panel2);
            this.groupBox3.Controls.Add(this.guna2Panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(593, 486);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.dateCheckout);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.timeCheckout);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel2.Controls.Add(this.dateCheckin);
            this.guna2Panel2.Controls.Add(this.timeCheckin);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(17, 46);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(555, 147);
            this.guna2Panel2.TabIndex = 99;
            // 
            // dateCheckout
            // 
            this.dateCheckout.BeepOnError = true;
            this.dateCheckout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateCheckout.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dateCheckout.HideSelection = false;
            this.dateCheckout.Location = new System.Drawing.Point(342, 95);
            this.dateCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCheckout.Mask = "00/00/0000";
            this.dateCheckout.Name = "dateCheckout";
            this.dateCheckout.Size = new System.Drawing.Size(88, 24);
            this.dateCheckout.TabIndex = 58;
            this.dateCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateCheckout.ValidatingType = typeof(System.DateTime);
            this.dateCheckout.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.dateCheckout_TypeValidationCompleted);
            this.dateCheckout.Click += new System.EventHandler(this.dateCheckout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Date (dd/mm/yyyy)";
            // 
            // timeCheckout
            // 
            this.timeCheckout.BeepOnError = true;
            this.timeCheckout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCheckout.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.timeCheckout.HideSelection = false;
            this.timeCheckout.Location = new System.Drawing.Point(218, 95);
            this.timeCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeCheckout.Mask = "00:00";
            this.timeCheckout.Name = "timeCheckout";
            this.timeCheckout.Size = new System.Drawing.Size(63, 24);
            this.timeCheckout.TabIndex = 57;
            this.timeCheckout.Text = "1200";
            this.timeCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCheckout.ValidatingType = typeof(System.DateTime);
            this.timeCheckout.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.timeCheckout_TypeValidationCompleted);
            this.timeCheckout.Click += new System.EventHandler(this.timeCheckout_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(69, 40);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(131, 30);
            this.guna2HtmlLabel7.TabIndex = 51;
            this.guna2HtmlLabel7.Text = "Time check-in";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(55, 92);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(145, 30);
            this.guna2HtmlLabel8.TabIndex = 52;
            this.guna2HtmlLabel8.Text = "Time check-out";
            // 
            // dateCheckin
            // 
            this.dateCheckin.BeepOnError = true;
            this.dateCheckin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateCheckin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dateCheckin.HideSelection = false;
            this.dateCheckin.Location = new System.Drawing.Point(342, 43);
            this.dateCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCheckin.Mask = "00/00/0000";
            this.dateCheckin.Name = "dateCheckin";
            this.dateCheckin.Size = new System.Drawing.Size(88, 24);
            this.dateCheckin.TabIndex = 55;
            this.dateCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateCheckin.ValidatingType = typeof(System.DateTime);
            this.dateCheckin.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.dateCheckin_TypeValidationCompleted);
            this.dateCheckin.Click += new System.EventHandler(this.dateCheckin_Click);
            // 
            // timeCheckin
            // 
            this.timeCheckin.BeepOnError = true;
            this.timeCheckin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCheckin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.timeCheckin.HideSelection = false;
            this.timeCheckin.Location = new System.Drawing.Point(218, 43);
            this.timeCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeCheckin.Mask = "00:00";
            this.timeCheckin.Name = "timeCheckin";
            this.timeCheckin.Size = new System.Drawing.Size(63, 24);
            this.timeCheckin.TabIndex = 53;
            this.timeCheckin.Text = "1200";
            this.timeCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeCheckin.ValidatingType = typeof(System.DateTime);
            this.timeCheckin.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.timeCheckin_TypeValidationCompleted);
            this.timeCheckin.Click += new System.EventHandler(this.timeCheckin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Time (HH:mm)";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.btnConfirm);
            this.guna2Panel1.Controls.Add(this.materialLabel2);
            this.guna2Panel1.Controls.Add(this.floor);
            this.guna2Panel1.Controls.Add(this.materialLabel5);
            this.guna2Panel1.Controls.Add(this.comboboxRoomType);
            this.guna2Panel1.Controls.Add(this.btnClearFilter);
            this.guna2Panel1.Location = new System.Drawing.Point(17, 203);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(555, 264);
            this.guna2Panel1.TabIndex = 98;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(27, 101);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.MaximumSize = new System.Drawing.Size(514, 173);
            this.flowLayoutPanel.MinimumSize = new System.Drawing.Size(514, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(514, 0);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowItem);
            this.panel1.Location = new System.Drawing.Point(22, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 56);
            this.panel1.TabIndex = 4;
            // 
            // btnShowItem
            // 
            this.btnShowItem.AutoRoundedCorners = true;
            this.btnShowItem.BorderRadius = 27;
            this.btnShowItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnShowItem.ForeColor = System.Drawing.Color.White;
            this.btnShowItem.Image = global::Presentation.Properties.Resources.left;
            this.btnShowItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowItem.Location = new System.Drawing.Point(0, 0);
            this.btnShowItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Padding = new System.Windows.Forms.Padding(17, 0, 43, 0);
            this.btnShowItem.Size = new System.Drawing.Size(478, 56);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.Text = "Select";
            this.btnShowItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowItem.Leave += new System.EventHandler(this.btnShowItem_Leave);
            this.btnShowItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowItem_MouseDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnConfirm.BorderRadius = 25;
            this.btnConfirm.BorderThickness = 1;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnConfirm.Location = new System.Drawing.Point(361, 194);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 52);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(62, 135);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 24);
            this.materialLabel2.TabIndex = 81;
            this.materialLabel2.Text = "Floor";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.floor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.floor.Location = new System.Drawing.Point(124, 132);
            this.floor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.floor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(63, 31);
            this.floor.TabIndex = 86;
            this.floor.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.floor.ValueChanged += new System.EventHandler(this.floor_ValueChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(242, 135);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 24);
            this.materialLabel5.TabIndex = 87;
            this.materialLabel5.Text = "Type";
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
            this.comboboxRoomType.Location = new System.Drawing.Point(294, 129);
            this.comboboxRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboboxRoomType.Name = "comboboxRoomType";
            this.comboboxRoomType.Size = new System.Drawing.Size(166, 36);
            this.comboboxRoomType.TabIndex = 88;
            this.comboboxRoomType.SelectedValueChanged += new System.EventHandler(this.comboboxRoomType_SelectedValueChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(511, 60);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(26, 26);
            this.btnClearFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearFilter.TabIndex = 89;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.Visible = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            this.btnClearFilter.MouseHover += new System.EventHandler(this.btnClearFilter_MouseHover);
            // 
            // timer_for_select_room
            // 
            this.timer_for_select_room.Interval = 10;
            this.timer_for_select_room.Tick += new System.EventHandler(this.timer_for_select_room_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 486);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(684, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 486);
            this.panel3.TabIndex = 64;
            // 
            // elip_for_form
            // 
            this.elip_for_form.BorderRadius = 20;
            this.elip_for_form.TargetControl = this;
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Interval = 3000;
            this.timeoutTimer.Tick += new System.EventHandler(this.TimeoutTimer_Tick);
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooking";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnShowItem;
        private System.Windows.Forms.Timer timer_for_select_room;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.MaskedTextBox timeCheckin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateCheckin;
        private System.Windows.Forms.MaskedTextBox dateCheckout;
        private System.Windows.Forms.MaskedTextBox timeCheckout;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxRoomType;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Guna.UI2.WinForms.Guna2NumericUpDown floor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Guna.UI2.WinForms.Guna2Elipse elip_for_form;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox btnClearFilter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox btnQR;
        private System.Windows.Forms.Timer timer_btnFilter34;
        private MaterialSkin.Controls.MaterialComboBox selectGender;
        private System.Windows.Forms.Timer timeoutTimer;
    }
}