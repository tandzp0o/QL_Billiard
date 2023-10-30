
namespace APP_QL_Billiard
{
    partial class fTable_Manager
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnStatusBan = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.namePage = new System.Windows.Forms.Label();
            this.GioHeThong = new System.Windows.Forms.Label();
            this.table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TenNhanVien = new System.Windows.Forms.Label();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.Controls.Add(this.btnHistory);
            this.pn_Left.Controls.Add(this.btnKho);
            this.pn_Left.Controls.Add(this.btnStatusBan);
            this.pn_Left.Controls.Add(this.btnThucDon);
            this.pn_Left.Controls.Add(this.btnSignOut);
            this.pn_Left.Controls.Add(this.picLogo);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(195, 659);
            this.pn_Left.TabIndex = 3;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Wheat;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.Location = new System.Drawing.Point(0, 613);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(195, 46);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::APP_QL_Billiard.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(194, 183);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.TenNhanVien);
            this.pn_Top.Controls.Add(this.GioHeThong);
            this.pn_Top.Controls.Add(this.namePage);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(195, 0);
            this.pn_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1128, 77);
            this.pn_Top.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(0, 276);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(194, 40);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnKho
            // 
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.Location = new System.Drawing.Point(0, 320);
            this.btnKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(194, 40);
            this.btnKho.TabIndex = 11;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnStatusBan
            // 
            this.btnStatusBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusBan.Location = new System.Drawing.Point(0, 232);
            this.btnStatusBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatusBan.Name = "btnStatusBan";
            this.btnStatusBan.Size = new System.Drawing.Size(194, 40);
            this.btnStatusBan.TabIndex = 9;
            this.btnStatusBan.Text = "Tình Trạng Bàn";
            this.btnStatusBan.UseVisualStyleBackColor = true;
            this.btnStatusBan.Click += new System.EventHandler(this.btnStatusBan_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucDon.Location = new System.Drawing.Point(0, 188);
            this.btnThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(194, 40);
            this.btnThucDon.TabIndex = 8;
            this.btnThucDon.Text = "Menu";
            this.btnThucDon.UseVisualStyleBackColor = true;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // namePage
            // 
            this.namePage.AutoSize = true;
            this.namePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePage.Location = new System.Drawing.Point(50, 25);
            this.namePage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePage.Name = "namePage";
            this.namePage.Size = new System.Drawing.Size(85, 31);
            this.namePage.TabIndex = 5;
            this.namePage.Text = "Menu";
            // 
            // GioHeThong
            // 
            this.GioHeThong.AutoSize = true;
            this.GioHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioHeThong.Location = new System.Drawing.Point(956, 9);
            this.GioHeThong.Name = "GioHeThong";
            this.GioHeThong.Size = new System.Drawing.Size(76, 25);
            this.GioHeThong.TabIndex = 6;
            this.GioHeThong.Text = "label1";
            // 
            // table_panel
            // 
            this.table_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.table_panel.ColumnCount = 2;
            this.table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_panel.Location = new System.Drawing.Point(195, 77);
            this.table_panel.Margin = new System.Windows.Forms.Padding(2);
            this.table_panel.Name = "table_panel";
            this.table_panel.RowCount = 1;
            this.table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_panel.Size = new System.Drawing.Size(1128, 582);
            this.table_panel.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSize = true;
            this.TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.Location = new System.Drawing.Point(956, 52);
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Size = new System.Drawing.Size(76, 25);
            this.TenNhanVien.TabIndex = 7;
            this.TenNhanVien.Text = "label1";
            // 
            // fTable_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 659);
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.pn_Left);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fTable_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Billiard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTable_Manager_Load);
            this.pn_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnStatusBan;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Label namePage;
        private System.Windows.Forms.Label GioHeThong;
        private System.Windows.Forms.TableLayoutPanel table_panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TenNhanVien;
    }
}