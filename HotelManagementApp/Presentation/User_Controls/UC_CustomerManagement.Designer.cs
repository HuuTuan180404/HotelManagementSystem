namespace Presentation.User_Controls
{
    partial class UC_CustomerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLayoutCard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRevenue = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbRegular = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlTotalCustomer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbTotalCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlNewCustomer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbNewCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlCustomerVIP = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbCustomerVIP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cboCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btAddCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tbLayoutCard.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlTotalCustomer.SuspendLayout();
            this.pnlNewCustomer.SuspendLayout();
            this.pnlCustomerVIP.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(632, 82);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "CUSTOMER MANAGEMENT";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.tbLayoutCard);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(1600, 278);
            this.pnlHeader.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUSTOMER MANAGEMENT";
            // 
            // tbLayoutCard
            // 
            this.tbLayoutCard.ColumnCount = 4;
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutCard.Controls.Add(this.pnlRevenue, 3, 0);
            this.tbLayoutCard.Controls.Add(this.pnlTotalCustomer, 0, 0);
            this.tbLayoutCard.Controls.Add(this.pnlNewCustomer, 2, 0);
            this.tbLayoutCard.Controls.Add(this.pnlCustomerVIP, 1, 0);
            this.tbLayoutCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLayoutCard.Location = new System.Drawing.Point(20, 124);
            this.tbLayoutCard.Name = "tbLayoutCard";
            this.tbLayoutCard.Padding = new System.Windows.Forms.Padding(10);
            this.tbLayoutCard.RowCount = 1;
            this.tbLayoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutCard.Size = new System.Drawing.Size(1560, 134);
            this.tbLayoutCard.TabIndex = 1;
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.Transparent;
            this.pnlRevenue.Controls.Add(this.lbRegular);
            this.pnlRevenue.Controls.Add(this.guna2HtmlLabel4);
            this.pnlRevenue.FillColor = System.Drawing.Color.White;
            this.pnlRevenue.Location = new System.Drawing.Point(1169, 14);
            this.pnlRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Radius = 10;
            this.pnlRevenue.ShadowColor = System.Drawing.Color.Black;
            this.pnlRevenue.ShadowDepth = 5;
            this.pnlRevenue.Size = new System.Drawing.Size(377, 106);
            this.pnlRevenue.TabIndex = 11;
            this.pnlRevenue.Click += new System.EventHandler(this.pnlRevenue_Click);
            // 
            // lbRegular
            // 
            this.lbRegular.BackColor = System.Drawing.Color.Transparent;
            this.lbRegular.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegular.Location = new System.Drawing.Point(340, 29);
            this.lbRegular.Margin = new System.Windows.Forms.Padding(4);
            this.lbRegular.Name = "lbRegular";
            this.lbRegular.Size = new System.Drawing.Size(22, 47);
            this.lbRegular.TabIndex = 1;
            this.lbRegular.Text = "0";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(20, 18);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(700, 59);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "KHÁCH HÀNG THƯỜNG";
            // 
            // pnlTotalCustomer
            // 
            this.pnlTotalCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlTotalCustomer.Controls.Add(this.lbTotalCustomer);
            this.pnlTotalCustomer.Controls.Add(this.guna2HtmlLabel2);
            this.pnlTotalCustomer.FillColor = System.Drawing.Color.White;
            this.pnlTotalCustomer.Location = new System.Drawing.Point(14, 14);
            this.pnlTotalCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotalCustomer.Name = "pnlTotalCustomer";
            this.pnlTotalCustomer.Radius = 10;
            this.pnlTotalCustomer.ShadowColor = System.Drawing.Color.Black;
            this.pnlTotalCustomer.ShadowDepth = 5;
            this.pnlTotalCustomer.Size = new System.Drawing.Size(377, 106);
            this.pnlTotalCustomer.TabIndex = 8;
            this.pnlTotalCustomer.Click += new System.EventHandler(this.pnlTotalCustomer_Click);
            // 
            // lbTotalCustomer
            // 
            this.lbTotalCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalCustomer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCustomer.Location = new System.Drawing.Point(310, 28);
            this.lbTotalCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.lbTotalCustomer.Name = "lbTotalCustomer";
            this.lbTotalCustomer.Size = new System.Drawing.Size(63, 48);
            this.lbTotalCustomer.TabIndex = 1;
            this.lbTotalCustomer.Text = "150";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(20, 18);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(568, 59);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "TỔNG KHÁCH HÀNG";
            // 
            // pnlNewCustomer
            // 
            this.pnlNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlNewCustomer.Controls.Add(this.lbNewCustomer);
            this.pnlNewCustomer.Controls.Add(this.guna2HtmlLabel5);
            this.pnlNewCustomer.FillColor = System.Drawing.Color.White;
            this.pnlNewCustomer.Location = new System.Drawing.Point(784, 14);
            this.pnlNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNewCustomer.Name = "pnlNewCustomer";
            this.pnlNewCustomer.Radius = 10;
            this.pnlNewCustomer.ShadowColor = System.Drawing.Color.Black;
            this.pnlNewCustomer.ShadowDepth = 5;
            this.pnlNewCustomer.Size = new System.Drawing.Size(377, 106);
            this.pnlNewCustomer.TabIndex = 10;
            this.pnlNewCustomer.Click += new System.EventHandler(this.pnlNewCustomer_Click);
            // 
            // lbNewCustomer
            // 
            this.lbNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lbNewCustomer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewCustomer.Location = new System.Drawing.Point(330, 29);
            this.lbNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.lbNewCustomer.Name = "lbNewCustomer";
            this.lbNewCustomer.Size = new System.Drawing.Size(43, 48);
            this.lbNewCustomer.TabIndex = 1;
            this.lbNewCustomer.Text = "25";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(20, 18);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(545, 59);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "KHÁCH HÀNG MỚI";
            // 
            // pnlCustomerVIP
            // 
            this.pnlCustomerVIP.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomerVIP.Controls.Add(this.lbCustomerVIP);
            this.pnlCustomerVIP.Controls.Add(this.guna2HtmlLabel3);
            this.pnlCustomerVIP.FillColor = System.Drawing.Color.White;
            this.pnlCustomerVIP.Location = new System.Drawing.Point(399, 14);
            this.pnlCustomerVIP.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomerVIP.Name = "pnlCustomerVIP";
            this.pnlCustomerVIP.Radius = 10;
            this.pnlCustomerVIP.ShadowColor = System.Drawing.Color.Black;
            this.pnlCustomerVIP.ShadowDepth = 5;
            this.pnlCustomerVIP.Size = new System.Drawing.Size(377, 106);
            this.pnlCustomerVIP.TabIndex = 9;
            this.pnlCustomerVIP.Click += new System.EventHandler(this.pnlCustomerVIP_Click);
            // 
            // lbCustomerVIP
            // 
            this.lbCustomerVIP.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomerVIP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerVIP.Location = new System.Drawing.Point(330, 29);
            this.lbCustomerVIP.Margin = new System.Windows.Forms.Padding(4);
            this.lbCustomerVIP.Name = "lbCustomerVIP";
            this.lbCustomerVIP.Size = new System.Drawing.Size(43, 48);
            this.lbCustomerVIP.TabIndex = 1;
            this.lbCustomerVIP.Text = "45";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(20, 18);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(448, 59);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "KHÁCH HÀNG VIP";
            // 
            // pnlFilter
            // 
            this.pnlFilter.AutoSize = true;
            this.pnlFilter.Controls.Add(this.cboCustomerType);
            this.pnlFilter.Controls.Add(this.btAddCustomer);
            this.pnlFilter.Controls.Add(this.btDelete);
            this.pnlFilter.Controls.Add(this.txtSearchCustomer);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 278);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1600, 80);
            this.pnlFilter.TabIndex = 8;
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.BackColor = System.Drawing.Color.White;
            this.cboCustomerType.BorderColor = System.Drawing.Color.White;
            this.cboCustomerType.BorderRadius = 8;
            this.cboCustomerType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.cboCustomerType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.cboCustomerType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.cboCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCustomerType.DropDownHeight = 150;
            this.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.cboCustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.cboCustomerType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cboCustomerType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.cboCustomerType.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboCustomerType.IntegralHeight = false;
            this.cboCustomerType.ItemHeight = 30;
            this.cboCustomerType.Items.AddRange(new object[] {
            "Loại khách hàng",
            "VIP",
            "Regular",
            "New"});
            this.cboCustomerType.Location = new System.Drawing.Point(505, 15);
            this.cboCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.cboCustomerType.MaxDropDownItems = 5;
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(199, 36);
            this.cboCustomerType.StartIndex = 0;
            this.cboCustomerType.TabIndex = 0;
            this.cboCustomerType.SelectedIndexChanged += new System.EventHandler(this.cboCustomerType_SelectedIndexChanged);
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.BorderRadius = 8;
            this.btAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddCustomer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.btAddCustomer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(151)))), ((int)(((byte)(245)))));
            this.btAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btAddCustomer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btAddCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(151)))), ((int)(((byte)(245)))));
            this.btAddCustomer.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.btAddCustomer.Location = new System.Drawing.Point(1282, 15);
            this.btAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(153, 43);
            this.btAddCustomer.TabIndex = 7;
            this.btAddCustomer.Text = "Thêm";
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // btDelete
            // 
            this.btDelete.BorderRadius = 8;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.btDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(151)))), ((int)(((byte)(245)))));
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(151)))), ((int)(((byte)(245)))));
            this.btDelete.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(233)))));
            this.btDelete.Location = new System.Drawing.Point(1443, 15);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(153, 43);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BorderRadius = 8;
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.IconRight = global::Presentation.Properties.Resources.find1;
            this.txtSearchCustomer.Location = new System.Drawing.Point(4, 10);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PlaceholderText = "Tìm kiếm...";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(493, 55);
            this.txtSearchCustomer.TabIndex = 5;
            this.txtSearchCustomer.IconRightClick += new System.EventHandler(this.txtSearchCustomer_IconRightClick);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 4;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.Location = new System.Drawing.Point(0, 358);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(8);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(1600, 627);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCustomers.ThemeStyle.ReadOnly = false;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CustomerManagement";
            this.Size = new System.Drawing.Size(1600, 985);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tbLayoutCard.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlTotalCustomer.ResumeLayout(false);
            this.pnlTotalCustomer.PerformLayout();
            this.pnlNewCustomer.ResumeLayout(false);
            this.pnlNewCustomer.PerformLayout();
            this.pnlCustomerVIP.ResumeLayout(false);
            this.pnlCustomerVIP.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbLayoutCard;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRegular;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTotalCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTotalCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlNewCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNewCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCustomerVIP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbCustomerVIP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cboCustomerType;
        private Guna.UI2.WinForms.Guna2GradientButton btAddCustomer;
        private Guna.UI2.WinForms.Guna2GradientButton btDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
    }
}
