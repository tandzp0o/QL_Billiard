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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ThanhToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_GBD = new System.Windows.Forms.Label();
            this.lb_GKT = new System.Windows.Forms.Label();
            this.lb_TgSD = new System.Windows.Forms.Label();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.dgv_ThanhToan = new System.Windows.Forms.DataGridView();
            this.MatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Member = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Title.Location = new System.Drawing.Point(162, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(214, 64);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "HOÁ ĐƠN BÀN\r\n           ";
            // 
            // lb_GBD
            // 
            this.lb_GBD.AutoSize = true;
            this.lb_GBD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GBD.Location = new System.Drawing.Point(10, 415);
            this.lb_GBD.Name = "lb_GBD";
            this.lb_GBD.Size = new System.Drawing.Size(96, 19);
            this.lb_GBD.TabIndex = 2;
            this.lb_GBD.Text = "Giờ bắt đầu: ";
            // 
            // lb_GKT
            // 
            this.lb_GKT.AutoSize = true;
            this.lb_GKT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GKT.Location = new System.Drawing.Point(10, 445);
            this.lb_GKT.Name = "lb_GKT";
            this.lb_GKT.Size = new System.Drawing.Size(102, 19);
            this.lb_GKT.TabIndex = 3;
            this.lb_GKT.Text = "Giờ kết thúc: ";
            // 
            // lb_TgSD
            // 
            this.lb_TgSD.AutoSize = true;
            this.lb_TgSD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TgSD.Location = new System.Drawing.Point(10, 475);
            this.lb_TgSD.Name = "lb_TgSD";
            this.lb_TgSD.Size = new System.Drawing.Size(137, 19);
            this.lb_TgSD.TabIndex = 4;
            this.lb_TgSD.Text = "Thời gian sử dụng: ";
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.Location = new System.Drawing.Point(14, 578);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(55, 19);
            this.lb_GiamGia.TabIndex = 5;
            this.lb_GiamGia.Text = "Giảm: ";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(14, 608);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(82, 19);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng tiền: ";
            // 
            // btn_InHD
            // 
            this.btn_InHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_InHD.Image")));
            this.btn_InHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHD.Location = new System.Drawing.Point(358, 646);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(119, 44);
            this.btn_InHD.TabIndex = 8;
            this.btn_InHD.Text = "In hoá đơn";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // dgv_ThanhToan
            // 
            this.dgv_ThanhToan.AllowUserToAddRows = false;
            this.dgv_ThanhToan.AllowUserToDeleteRows = false;
            this.dgv_ThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatHang,
            this.SL,
            this.DVT,
            this.Gia});
            this.dgv_ThanhToan.Location = new System.Drawing.Point(12, 43);
            this.dgv_ThanhToan.Name = "dgv_ThanhToan";
            this.dgv_ThanhToan.ReadOnly = true;
            this.dgv_ThanhToan.RowHeadersVisible = false;
            this.dgv_ThanhToan.RowHeadersWidth = 51;
            this.dgv_ThanhToan.RowTemplate.Height = 24;
            this.dgv_ThanhToan.Size = new System.Drawing.Size(463, 369);
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
            // cb_Member
            // 
            this.cb_Member.FormattingEnabled = true;
            this.cb_Member.Items.AddRange(new object[] {
            "Khách vãng lai",
            "Học sinh/Sinh Viên",
            "VIP"});
            this.cb_Member.Location = new System.Drawing.Point(12, 525);
            this.cb_Member.Name = "cb_Member";
            this.cb_Member.Size = new System.Drawing.Size(293, 23);
            this.cb_Member.TabIndex = 10;
            this.cb_Member.SelectedIndexChanged += new System.EventHandler(this.cb_Member_SelectedIndexChanged);
            // 
            // f_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 702);
            this.Controls.Add(this.cb_Member);
            this.Controls.Add(this.dgv_ThanhToan);
            this.Controls.Add(this.btn_InHD);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_ThanhToan_FormClosing);
            this.Load += new System.EventHandler(this.f_ThanhToan_Load);
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
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.DataGridView dgv_ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.ComboBox cb_Member;
    }
}