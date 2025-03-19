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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchCustom = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchCustom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCustomerType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPage3
            // 
            this.btnPage3.Location = new System.Drawing.Point(108, 2);
            this.btnPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(29, 30);
            this.btnPage3.TabIndex = 47;
            this.btnPage3.Text = "3";
            this.btnPage3.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            this.btnPage1.Location = new System.Drawing.Point(38, 2);
            this.btnPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(29, 30);
            this.btnPage1.TabIndex = 45;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 2);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 30);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(3, 2);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(29, 30);
            this.btnPrev.TabIndex = 43;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // cboPageSize
            // 
            this.cboPageSize.FormattingEnabled = true;
            this.cboPageSize.Location = new System.Drawing.Point(178, 2);
            this.cboPageSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(127, 24);
            this.cboPageSize.TabIndex = 42;
            // 
            // CType
            // 
            this.CType.HeaderText = "CType";
            this.CType.MinimumWidth = 6;
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            // 
            // CAddress
            // 
            this.CAddress.HeaderText = "CAddress";
            this.CAddress.MinimumWidth = 6;
            this.CAddress.Name = "CAddress";
            this.CAddress.ReadOnly = true;
            // 
            // CEmail
            // 
            this.CEmail.HeaderText = "CEmail";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            // 
            // CPhone
            // 
            this.CPhone.HeaderText = "CPhone";
            this.CPhone.MinimumWidth = 6;
            this.CPhone.Name = "CPhone";
            this.CPhone.ReadOnly = true;
            // 
            // CGender
            // 
            this.CGender.HeaderText = "CGender";
            this.CGender.MinimumWidth = 6;
            this.CGender.Name = "CGender";
            this.CGender.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.HeaderText = "CName";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CID
            // 
            this.CID.HeaderText = "CID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AllowUserToAddRows = false;
            this.dtgCustomer.AllowUserToDeleteRows = false;
            this.dtgCustomer.AllowUserToResizeColumns = false;
            this.dtgCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCustomer.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgCustomer.ColumnHeadersHeight = 40;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.CID,
            this.CName,
            this.CGender,
            this.CPhone,
            this.CEmail,
            this.CAddress,
            this.CType});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCustomer.Location = new System.Drawing.Point(26, 236);
            this.dtgCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersVisible = false;
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 24;
            this.dtgCustomer.Size = new System.Drawing.Size(1091, 474);
            this.dtgCustomer.TabIndex = 40;
            this.dtgCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCustomer.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dtgCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgCustomer.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgCustomer.ThemeStyle.ReadOnly = false;
            this.dtgCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dtgCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.AutoRoundedCorners = true;
            this.btnEditCustomer.BorderRadius = 22;
            this.btnEditCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(951, 174);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(127, 46);
            this.btnEditCustomer.TabIndex = 39;
            this.btnEditCustomer.Text = "Edit";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoRoundedCorners = true;
            this.btnAddCustomer.BorderRadius = 22;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(816, 174);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(127, 46);
            this.btnAddCustomer.TabIndex = 38;
            this.btnAddCustomer.Text = "+ Add";
            // 
            // btnSearchCustom
            // 
            this.btnSearchCustom.BorderRadius = 8;
            this.btnSearchCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchCustom.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustom.Image = global::Presentation.Properties.Resources.find_svgrepo_com;
            this.btnSearchCustom.Location = new System.Drawing.Point(472, 137);
            this.btnSearchCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCustom.Name = "btnSearchCustom";
            this.btnSearchCustom.Size = new System.Drawing.Size(51, 49);
            this.btnSearchCustom.TabIndex = 37;
            // 
            // txtSearchCustom
            // 
            this.txtSearchCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustom.DefaultText = "Tìm kiếm...";
            this.txtSearchCustom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustom.Location = new System.Drawing.Point(265, 137);
            this.txtSearchCustom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustom.Name = "txtSearchCustom";
            this.txtSearchCustom.PasswordChar = '\0';
            this.txtSearchCustom.PlaceholderText = "";
            this.txtSearchCustom.SelectedText = "";
            this.txtSearchCustom.Size = new System.Drawing.Size(229, 48);
            this.txtSearchCustom.TabIndex = 36;
            this.txtSearchCustom.Enter += new System.EventHandler(this.txtSearchCustom_Enter);
            this.txtSearchCustom.Leave += new System.EventHandler(this.txtSearchCustom_Leave);
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.AutoResize = false;
            this.cbCustomerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCustomerType.Depth = 0;
            this.cbCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCustomerType.DropDownHeight = 174;
            this.cbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerType.DropDownWidth = 121;
            this.cbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Hint = "Chọn nhóm khách hàng";
            this.cbCustomerType.IntegralHeight = false;
            this.cbCustomerType.ItemHeight = 43;
            this.cbCustomerType.Items.AddRange(new object[] {
            "Khách lẻ",
            "Khách nhóm",
            "Khách Vip"});
            this.cbCustomerType.Location = new System.Drawing.Point(26, 136);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCustomerType.MaxDropDownItems = 4;
            this.cbCustomerType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(233, 49);
            this.cbCustomerType.StartIndex = 0;
            this.cbCustomerType.TabIndex = 35;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(16, 33);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(594, 58);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "CUSTOMER MANAGEMENT";
            // 
            // btnPage2
            // 
            this.btnPage2.Location = new System.Drawing.Point(73, 2);
            this.btnPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(29, 30);
            this.btnPage2.TabIndex = 46;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPrev);
            this.flowLayoutPanel1.Controls.Add(this.btnPage1);
            this.flowLayoutPanel1.Controls.Add(this.btnPage2);
            this.flowLayoutPanel1.Controls.Add(this.btnPage3);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.cboPageSize);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(800, 728);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 51);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // UC_CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnSearchCustom);
            this.Controls.Add(this.txtSearchCustom);
            this.Controls.Add(this.cbCustomerType);
            this.Name = "UC_CustomerManagement";
            this.Size = new System.Drawing.Size(1134, 836);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private Guna.UI2.WinForms.Guna2DataGridView dtgCustomer;
        private Guna.UI2.WinForms.Guna2Button btnEditCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSearchCustom;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustom;
        private MaterialSkin.Controls.MaterialComboBox cbCustomerType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
