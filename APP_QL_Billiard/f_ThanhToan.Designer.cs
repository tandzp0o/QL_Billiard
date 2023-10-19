namespace APP_QL_Billiard
{
    partial class f_ThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_GBD = new System.Windows.Forms.Label();
            this.lb_GKT = new System.Windows.Forms.Label();
            this.lb_TgSD = new System.Windows.Forms.Label();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.gb_DoiTuong = new System.Windows.Forms.GroupBox();
            this.chk_VIP = new System.Windows.Forms.CheckBox();
            this.chk_KT = new System.Windows.Forms.CheckBox();
            this.chk_SV = new System.Windows.Forms.CheckBox();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.dgv_ThanhToan = new System.Windows.Forms.DataGridView();
            this.MatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DoiTuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(150, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(172, 32);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Hoá đơn bàn";
            // 
            // lb_GBD
            // 
            this.lb_GBD.AutoSize = true;
            this.lb_GBD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GBD.Location = new System.Drawing.Point(10, 172);
            this.lb_GBD.Name = "lb_GBD";
            this.lb_GBD.Size = new System.Drawing.Size(92, 19);
            this.lb_GBD.TabIndex = 2;
            this.lb_GBD.Text = "Giờ bắt đầu:";
            // 
            // lb_GKT
            // 
            this.lb_GKT.AutoSize = true;
            this.lb_GKT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GKT.Location = new System.Drawing.Point(10, 202);
            this.lb_GKT.Name = "lb_GKT";
            this.lb_GKT.Size = new System.Drawing.Size(98, 19);
            this.lb_GKT.TabIndex = 3;
            this.lb_GKT.Text = "Giờ kết thúc:";
            // 
            // lb_TgSD
            // 
            this.lb_TgSD.AutoSize = true;
            this.lb_TgSD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TgSD.Location = new System.Drawing.Point(10, 232);
            this.lb_TgSD.Name = "lb_TgSD";
            this.lb_TgSD.Size = new System.Drawing.Size(133, 19);
            this.lb_TgSD.TabIndex = 4;
            this.lb_TgSD.Text = "Thời gian sử dụng:";
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.Location = new System.Drawing.Point(14, 335);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(51, 19);
            this.lb_GiamGia.TabIndex = 5;
            this.lb_GiamGia.Text = "Giảm:";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(14, 365);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(78, 19);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền:";
            // 
            // gb_DoiTuong
            // 
            this.gb_DoiTuong.Controls.Add(this.chk_VIP);
            this.gb_DoiTuong.Controls.Add(this.chk_KT);
            this.gb_DoiTuong.Controls.Add(this.chk_SV);
            this.gb_DoiTuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DoiTuong.Location = new System.Drawing.Point(14, 262);
            this.gb_DoiTuong.Name = "gb_DoiTuong";
            this.gb_DoiTuong.Size = new System.Drawing.Size(360, 62);
            this.gb_DoiTuong.TabIndex = 7;
            this.gb_DoiTuong.TabStop = false;
            this.gb_DoiTuong.Text = "Đối tượng";
            // 
            // chk_VIP
            // 
            this.chk_VIP.AutoSize = true;
            this.chk_VIP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_VIP.Location = new System.Drawing.Point(296, 26);
            this.chk_VIP.Name = "chk_VIP";
            this.chk_VIP.Size = new System.Drawing.Size(57, 23);
            this.chk_VIP.TabIndex = 9;
            this.chk_VIP.Text = "VIP";
            this.chk_VIP.UseVisualStyleBackColor = true;
            this.chk_VIP.CheckedChanged += new System.EventHandler(this.chk_VIP_CheckedChanged);
            // 
            // chk_KT
            // 
            this.chk_KT.AutoSize = true;
            this.chk_KT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_KT.Location = new System.Drawing.Point(6, 26);
            this.chk_KT.Name = "chk_KT";
            this.chk_KT.Size = new System.Drawing.Size(125, 23);
            this.chk_KT.TabIndex = 0;
            this.chk_KT.Text = "Khách thường";
            this.chk_KT.UseVisualStyleBackColor = true;
            this.chk_KT.CheckedChanged += new System.EventHandler(this.chk_KT_CheckedChanged);
            // 
            // chk_SV
            // 
            this.chk_SV.AutoSize = true;
            this.chk_SV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SV.Location = new System.Drawing.Point(167, 26);
            this.chk_SV.Name = "chk_SV";
            this.chk_SV.Size = new System.Drawing.Size(93, 23);
            this.chk_SV.TabIndex = 8;
            this.chk_SV.Text = "Sinh viên";
            this.chk_SV.UseVisualStyleBackColor = true;
            this.chk_SV.CheckedChanged += new System.EventHandler(this.chk_SV_CheckedChanged);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Location = new System.Drawing.Point(378, 410);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(99, 37);
            this.btn_InHD.TabIndex = 8;
            this.btn_InHD.Text = "In hoá đơn";
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // dgv_ThanhToan
            // 
            this.dgv_ThanhToan.AllowUserToAddRows = false;
            this.dgv_ThanhToan.AllowUserToDeleteRows = false;
            this.dgv_ThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThanhToan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatHang,
            this.SL,
            this.DVT,
            this.Gia});
            this.dgv_ThanhToan.Location = new System.Drawing.Point(14, 55);
            this.dgv_ThanhToan.Name = "dgv_ThanhToan";
            this.dgv_ThanhToan.ReadOnly = true;
            this.dgv_ThanhToan.RowHeadersVisible = false;
            this.dgv_ThanhToan.RowHeadersWidth = 51;
            this.dgv_ThanhToan.RowTemplate.Height = 24;
            this.dgv_ThanhToan.Size = new System.Drawing.Size(463, 92);
            this.dgv_ThanhToan.TabIndex = 9;
            // 
            // MatHang
            // 
            this.MatHang.DataPropertyName = "TenThucDon";
            this.MatHang.HeaderText = "Mặt hàng";
            this.MatHang.MinimumWidth = 6;
            this.MatHang.Name = "MatHang";
            this.MatHang.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuongDat";
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DonViTinh";
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // f_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 459);
            this.Controls.Add(this.dgv_ThanhToan);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.gb_DoiTuong);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.lb_GiamGia);
            this.Controls.Add(this.lb_TgSD);
            this.Controls.Add(this.lb_GKT);
            this.Controls.Add(this.lb_GBD);
            this.Controls.Add(this.lb_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_ThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.f_ThanhToan_Load);
            this.gb_DoiTuong.ResumeLayout(false);
            this.gb_DoiTuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_GBD;
        private System.Windows.Forms.Label lb_GKT;
        private System.Windows.Forms.Label lb_TgSD;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.GroupBox gb_DoiTuong;
        private System.Windows.Forms.CheckBox chk_KT;
        private System.Windows.Forms.CheckBox chk_SV;
        private System.Windows.Forms.CheckBox chk_VIP;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.DataGridView dgv_ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}