using System.Drawing;

namespace HotelManagementApp
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_forgetPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_show = new System.Windows.Forms.PictureBox();
            this.img_hide = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minus = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::HotelManagementApp.Properties.Resources.img_bg;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.lb_forgetPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.img_show);
            this.groupBox1.Controls.Add(this.img_hide);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(360, 640);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogIn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(108)))), ((int)(((byte)(109)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(66, 354);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(266, 26);
            this.tb_username.TabIndex = 10;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(66, 425);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(228, 26);
            this.tb_password.TabIndex = 9;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lb_forgetPassword
            // 
            this.lb_forgetPassword.AutoSize = true;
            this.lb_forgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgetPassword.ForeColor = System.Drawing.Color.White;
            this.lb_forgetPassword.Location = new System.Drawing.Point(124, 597);
            this.lb_forgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_forgetPassword.Name = "lb_forgetPassword";
            this.lb_forgetPassword.Size = new System.Drawing.Size(153, 20);
            this.lb_forgetPassword.TabIndex = 8;
            this.lb_forgetPassword.Text = "Forget password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // img_show
            // 
            this.img_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_show.Image = global::HotelManagementApp.Properties.Resources.show_password;
            this.img_show.Location = new System.Drawing.Point(294, 425);
            this.img_show.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.img_show.Name = "img_show";
            this.img_show.Size = new System.Drawing.Size(37, 26);
            this.img_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_show.TabIndex = 5;
            this.img_show.TabStop = false;
            this.img_show.Click += new System.EventHandler(this.img_show_Click);
            this.img_show.MouseHover += new System.EventHandler(this.img_show_MouseHover);
            // 
            // img_hide
            // 
            this.img_hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_hide.Image = global::HotelManagementApp.Properties.Resources.hide_password;
            this.img_hide.Location = new System.Drawing.Point(294, 425);
            this.img_hide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.img_hide.Name = "img_hide";
            this.img_hide.Size = new System.Drawing.Size(37, 26);
            this.img_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_hide.TabIndex = 4;
            this.img_hide.TabStop = false;
            this.img_hide.Click += new System.EventHandler(this.img_hide_Click);
            this.img_hide.MouseHover += new System.EventHandler(this.img_hide_MouseHover);
            // 
            // pic_close
            // 
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(715, 13);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(50, 50);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 9;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minus
            // 
            this.pic_minus.Image = ((System.Drawing.Image)(resources.GetObject("pic_minus.Image")));
            this.pic_minus.Location = new System.Drawing.Point(659, 12);
            this.pic_minus.Name = "pic_minus";
            this.pic_minus.Size = new System.Drawing.Size(50, 50);
            this.pic_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minus.TabIndex = 10;
            this.pic_minus.TabStop = false;
            this.pic_minus.Click += new System.EventHandler(this.pic_minus_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 715);
            this.ControlBox = false;
            this.Controls.Add(this.pic_minus);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox img_hide;
        private System.Windows.Forms.PictureBox img_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_forgetPassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minus;
    }
}

