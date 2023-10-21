namespace APP_QL_Billiard
{
    partial class ChiTietBan
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
            this.bttSave = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBan = new System.Windows.Forms.PictureBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(536, -58);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 20);
            label2.TabIndex = 40;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.Teal;
            this.bttSave.FlatAppearance.BorderSize = 0;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.White;
            this.bttSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSave.Location = new System.Drawing.Point(577, 170);
            this.bttSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(96, 45);
            this.bttSave.TabIndex = 48;
            this.bttSave.Text = "Lưu";
            this.bttSave.UseVisualStyleBackColor = false;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtGia.Location = new System.Drawing.Point(238, 494);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(433, 53);
            this.txtGia.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(2, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 43);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tổng tiền : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số giờ chơi : ";
            // 
            // txtGio
            // 
            this.txtGio.BackColor = System.Drawing.Color.White;
            this.txtGio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(238, 410);
            this.txtGio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(433, 46);
            this.txtGio.TabIndex = 43;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(-24, -59);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 66);
            this.btnBack.TabIndex = 39;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEnd.Location = new System.Drawing.Point(13, 307);
            this.txtTimeEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimeEnd.Multiline = true;
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.ReadOnly = true;
            this.txtTimeEnd.Size = new System.Drawing.Size(214, 46);
            this.txtTimeEnd.TabIndex = 36;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.Location = new System.Drawing.Point(13, 236);
            this.txtTimeStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimeStart.Multiline = true;
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.ReadOnly = true;
            this.txtTimeStart.Size = new System.Drawing.Size(214, 46);
            this.txtTimeStart.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::APP_QL_Billiard.Properties.Resources.add_user;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(504, 170);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 45);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Teal;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Image = global::APP_QL_Billiard.Properties.Resources.dollar_flat;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(610, 619);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(268, 88);
            this.btnPay.TabIndex = 47;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Teal;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = global::APP_QL_Billiard.Properties.Resources.exchange;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChange.Location = new System.Drawing.Point(740, 33);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(138, 111);
            this.btnChange.TabIndex = 42;
            this.btnChange.Text = "Chuyển bàn";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChange.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_QL_Billiard.Properties.Resources.Manager;
            this.pictureBox1.Location = new System.Drawing.Point(932, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 49);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Teal;
            this.btnTinh.Enabled = false;
            this.btnTinh.FlatAppearance.BorderSize = 0;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.White;
            this.btnTinh.Image = global::APP_QL_Billiard.Properties.Resources.time_;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinh.Location = new System.Drawing.Point(438, 304);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(236, 48);
            this.btnTinh.TabIndex = 38;
            this.btnTinh.Text = "Tính giờ";
            this.btnTinh.UseVisualStyleBackColor = false;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Teal;
            this.btnEnd.Enabled = false;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Image = global::APP_QL_Billiard.Properties.Resources.end;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(238, 307);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(160, 48);
            this.btnEnd.TabIndex = 37;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnd.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Teal;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::APP_QL_Billiard.Properties.Resources.play;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(238, 236);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 48);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // picBan
            // 
            this.picBan.Location = new System.Drawing.Point(100, 0);
            this.picBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBan.Name = "picBan";
            this.picBan.Size = new System.Drawing.Size(150, 182);
            this.picBan.TabIndex = 33;
            this.picBan.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hien NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Hien ngay he thong";
            // 
            // ChiTietBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 759);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.picBan);
            this.Name = "ChiTietBan";
            this.Text = "ChiTietBan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.PictureBox picBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}