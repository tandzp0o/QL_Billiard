﻿namespace APP_QL_Billiard
{
    partial class fFunction_Ban
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
            System.Windows.Forms.Label label2;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.txt_TenBan = new System.Windows.Forms.TextBox();
            this.NameTable = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(357, -37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 13);
            label2.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnTinh);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_TenBan);
            this.panel1.Controls.Add(this.NameTable);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtGio);
            this.panel1.Controls.Add(this.txtTimeStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTimeEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 684);
            this.panel1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "MENU ĐÃ GỌI:";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtGia.Location = new System.Drawing.Point(167, 594);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(216, 32);
            this.txtGia.TabIndex = 46;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = global::APP_QL_Billiard.Properties.Resources.exchange;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.Location = new System.Drawing.Point(29, 278);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(289, 69);
            this.btnChange.TabIndex = 42;
            this.btnChange.Text = "Chuyển bàn";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Teal;
            this.btnTinh.Enabled = false;
            this.btnTinh.FlatAppearance.BorderSize = 0;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.White;
            this.btnTinh.Image = global::APP_QL_Billiard.Properties.Resources.time_;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinh.Location = new System.Drawing.Point(29, 419);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(289, 69);
            this.btnTinh.TabIndex = 38;
            this.btnTinh.Text = "Tính giờ";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMenu);
            this.panel2.Location = new System.Drawing.Point(364, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 420);
            this.panel2.TabIndex = 54;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(422, 417);
            this.dgvMenu.TabIndex = 0;
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBan.Location = new System.Drawing.Point(100, 22);
            this.txt_TenBan.Multiline = true;
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.ReadOnly = true;
            this.txt_TenBan.Size = new System.Drawing.Size(126, 45);
            this.txt_TenBan.TabIndex = 53;
            // 
            // NameTable
            // 
            this.NameTable.AllowDrop = true;
            this.NameTable.AutoSize = true;
            this.NameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTable.Location = new System.Drawing.Point(23, 22);
            this.NameTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameTable.Name = "NameTable";
            this.NameTable.Size = new System.Drawing.Size(72, 29);
            this.NameTable.TabIndex = 51;
            this.NameTable.Text = "BÀN:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Red;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Image = global::APP_QL_Billiard.Properties.Resources.dollar_flat;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(461, 536);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(318, 90);
            this.btnPay.TabIndex = 47;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtGio
            // 
            this.txtGio.BackColor = System.Drawing.Color.White;
            this.txtGio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(167, 536);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(216, 32);
            this.txtGio.TabIndex = 43;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.Location = new System.Drawing.Point(29, 102);
            this.txtTimeStart.Multiline = true;
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.ReadOnly = true;
            this.txtTimeStart.Size = new System.Drawing.Size(161, 53);
            this.txtTimeStart.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(24, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tổng tiền: ";
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEnd.Location = new System.Drawing.Point(29, 188);
            this.txtTimeEnd.Multiline = true;
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.ReadOnly = true;
            this.txtTimeEnd.Size = new System.Drawing.Size(161, 53);
            this.txtTimeEnd.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số giờ chơi:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::APP_QL_Billiard.Properties.Resources.play;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(205, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 54);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Salmon;
            this.btnEnd.Enabled = false;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Image = global::APP_QL_Billiard.Properties.Resources.end;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(205, 185);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(113, 56);
            this.btnEnd.TabIndex = 37;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // fFunction_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fFunction_Ban";
            this.Text = "ChiTietBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameTable;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMenu;
    }
}