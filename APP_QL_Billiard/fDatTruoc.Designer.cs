
namespace APP_QL_Billiard
{
    partial class fDatTruoc
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
            this.NgayHienTai = new System.Windows.Forms.DateTimePicker();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbEmptyTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTypeTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.GioToi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NgayHienTai
            // 
            this.NgayHienTai.Checked = false;
            this.NgayHienTai.CustomFormat = "MM/dd/yyyy";
            this.NgayHienTai.Enabled = false;
            this.NgayHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayHienTai.Location = new System.Drawing.Point(138, 63);
            this.NgayHienTai.Margin = new System.Windows.Forms.Padding(4);
            this.NgayHienTai.Name = "NgayHienTai";
            this.NgayHienTai.Size = new System.Drawing.Size(268, 26);
            this.NgayHienTai.TabIndex = 25;
            this.NgayHienTai.Visible = false;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.LightCoral;
            this.btnRef.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRef.Location = new System.Drawing.Point(237, 476);
            this.btnRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(169, 70);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "Đặt Lại";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDo.Location = new System.Drawing.Point(22, 476);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(169, 70);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Xác Nhận";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bàn Trống:";
            // 
            // cbbEmptyTable
            // 
            this.cbbEmptyTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmptyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEmptyTable.FormattingEnabled = true;
            this.cbbEmptyTable.Location = new System.Drawing.Point(138, 396);
            this.cbbEmptyTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEmptyTable.Name = "cbbEmptyTable";
            this.cbbEmptyTable.Size = new System.Drawing.Size(268, 28);
            this.cbbEmptyTable.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Loại Bàn:";
            // 
            // cbbTypeTable
            // 
            this.cbbTypeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeTable.FormattingEnabled = true;
            this.cbbTypeTable.Location = new System.Drawing.Point(138, 321);
            this.cbbTypeTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeTable.Name = "cbbTypeTable";
            this.cbbTypeTable.Size = new System.Drawing.Size(268, 28);
            this.cbbTypeTable.TabIndex = 3;
            this.cbbTypeTable.SelectedIndexChanged += new System.EventHandler(this.cbbTypeTable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giờ Tới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(113, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đặt Bàn Trước";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(138, 122);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(268, 26);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // GioToi
            // 
            this.GioToi.Checked = false;
            this.GioToi.CustomFormat = "      HH:mm     |     dd/MM/yyyy";
            this.GioToi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GioToi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GioToi.Location = new System.Drawing.Point(138, 251);
            this.GioToi.Name = "GioToi";
            this.GioToi.ShowUpDown = true;
            this.GioToi.Size = new System.Drawing.Size(268, 23);
            this.GioToi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NgayHienTai);
            this.panel1.Controls.Add(this.GioToi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.cbbTypeTable);
            this.panel1.Controls.Add(this.btnDo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbEmptyTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 569);
            this.panel1.TabIndex = 26;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(138, 182);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(268, 26);
            this.txtTenKH.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Khách Hàng:";
            // 
            // fDatTruoc
            // 
            this.AcceptButton = this.btnDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRef;
            this.ClientSize = new System.Drawing.Size(461, 593);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDatTruoc";
            this.Text = "fDatTruoc";
            this.Load += new System.EventHandler(this.fDatTruoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker NgayHienTai;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbEmptyTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTypeTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker GioToi;
    }
}