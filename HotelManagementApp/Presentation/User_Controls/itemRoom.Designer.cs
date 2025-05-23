﻿namespace Presentation.User_Controls
{
    partial class itemRoom
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
            this.room_id = new System.Windows.Forms.Label();
            this.bed = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.Label();
            this.guests = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // room_id
            // 
            this.room_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_id.Location = new System.Drawing.Point(0, 0);
            this.room_id.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.room_id.Name = "room_id";
            this.room_id.Size = new System.Drawing.Size(68, 55);
            this.room_id.TabIndex = 0;
            this.room_id.Text = "0-10";
            this.room_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bed
            // 
            this.bed.BackColor = System.Drawing.Color.Transparent;
            this.bed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bed.Location = new System.Drawing.Point(286, -2);
            this.bed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bed.Name = "bed";
            this.bed.Size = new System.Drawing.Size(63, 27);
            this.bed.TabIndex = 1;
            this.bed.Text = "Bed: 2";
            this.bed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(71, 1);
            this.type.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(140, 27);
            this.type.TabIndex = 2;
            this.type.Text = "Type: Family";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(68, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 55);
            this.panel1.TabIndex = 3;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(348, -2);
            this.price.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(115, 27);
            this.price.TabIndex = 4;
            this.price.Text = "Price: 100.00";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guests
            // 
            this.guests.BackColor = System.Drawing.Color.Transparent;
            this.guests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guests.Location = new System.Drawing.Point(197, -2);
            this.guests.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.guests.Name = "guests";
            this.guests.Size = new System.Drawing.Size(89, 27);
            this.guests.TabIndex = 5;
            this.guests.Text = "Guests: 5";
            this.guests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(73, 29);
            this.description.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(407, 27);
            this.description.TabIndex = 6;
            this.description.Text = "Description: ";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.price);
            this.Controls.Add(this.bed);
            this.Controls.Add(this.guests);
            this.Controls.Add(this.description);
            this.Controls.Add(this.room_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.type);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(22, 7, 0, 0);
            this.Name = "itemRoom";
            this.Padding = new System.Windows.Forms.Padding(98, 7, 8, 7);
            this.Size = new System.Drawing.Size(459, 55);
            this.Load += new System.EventHandler(this.itemRoom_Load);
            this.Click += new System.EventHandler(this.itemRoom_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label room_id;
        private System.Windows.Forms.Label bed;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label guests;
        private System.Windows.Forms.Label description;
    }
}
