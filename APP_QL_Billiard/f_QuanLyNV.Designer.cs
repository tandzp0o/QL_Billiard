namespace APP_QL_Billiard
{
    partial class f_QuanLyNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_QuanLyNV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_tinhTrang = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.gb_ttnv = new System.Windows.Forms.GroupBox();
            this.lb_tinhTrang = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_tk = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            this.gb_ttnv.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Avatar.Image")));
            this.pb_Avatar.Location = new System.Drawing.Point(998, 12);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(222, 204);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 0;
            this.pb_Avatar.TabStop = false;
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.AllowUserToAddRows = false;
            this.dgv_dsnv.AllowUserToDeleteRows = false;
            this.dgv_dsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsnv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsnv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.HoTen,
            this.SDT,
            this.TinhTrang});
            this.dgv_dsnv.Location = new System.Drawing.Point(12, 222);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersVisible = false;
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(980, 469);
            this.dgv_dsnv.TabIndex = 1;
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Location = new System.Drawing.Point(192, 47);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(240, 35);
            this.txt_taiKhoan.TabIndex = 2;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(192, 124);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(240, 35);
            this.txt_hoTen.TabIndex = 3;
            // 
            // txt_tinhTrang
            // 
            this.txt_tinhTrang.Location = new System.Drawing.Point(694, 124);
            this.txt_tinhTrang.Name = "txt_tinhTrang";
            this.txt_tinhTrang.Size = new System.Drawing.Size(240, 35);
            this.txt_tinhTrang.TabIndex = 4;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(694, 51);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(240, 35);
            this.txt_sdt.TabIndex = 5;
            // 
            // gb_ttnv
            // 
            this.gb_ttnv.Controls.Add(this.lb_tinhTrang);
            this.gb_ttnv.Controls.Add(this.lb_sdt);
            this.gb_ttnv.Controls.Add(this.lb_hoTen);
            this.gb_ttnv.Controls.Add(this.lb_tk);
            this.gb_ttnv.Controls.Add(this.txt_sdt);
            this.gb_ttnv.Controls.Add(this.txt_tinhTrang);
            this.gb_ttnv.Controls.Add(this.txt_hoTen);
            this.gb_ttnv.Controls.Add(this.txt_taiKhoan);
            this.gb_ttnv.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ttnv.Location = new System.Drawing.Point(12, 12);
            this.gb_ttnv.Name = "gb_ttnv";
            this.gb_ttnv.Size = new System.Drawing.Size(980, 204);
            this.gb_ttnv.TabIndex = 6;
            this.gb_ttnv.TabStop = false;
            this.gb_ttnv.Text = "Thông tin nhân viên";
            // 
            // lb_tinhTrang
            // 
            this.lb_tinhTrang.AutoSize = true;
            this.lb_tinhTrang.Location = new System.Drawing.Point(532, 127);
            this.lb_tinhTrang.Name = "lb_tinhTrang";
            this.lb_tinhTrang.Size = new System.Drawing.Size(125, 28);
            this.lb_tinhTrang.TabIndex = 9;
            this.lb_tinhTrang.Text = "Tình trạng:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(595, 54);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(62, 28);
            this.lb_sdt.TabIndex = 8;
            this.lb_sdt.Text = "SDT:";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Location = new System.Drawing.Point(79, 127);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(88, 28);
            this.lb_hoTen.TabIndex = 7;
            this.lb_hoTen.Text = "Họ tên:";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.Location = new System.Drawing.Point(49, 54);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(118, 28);
            this.lb_tk.TabIndex = 6;
            this.lb_tk.Text = "Tài khoản:";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(1027, 363);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(173, 63);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.Location = new System.Drawing.Point(1027, 478);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(173, 63);
            this.btn_capNhat.TabIndex = 8;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // f_QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.gb_ttnv);
            this.Controls.Add(this.dgv_dsnv);
            this.Controls.Add(this.pb_Avatar);
            this.Name = "f_QuanLyNV";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            this.gb_ttnv.ResumeLayout(false);
            this.gb_ttnv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_tinhTrang;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.GroupBox gb_ttnv;
        private System.Windows.Forms.Label lb_tinhTrang;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}