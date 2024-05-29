
namespace APP_QL_Billiard
{
    partial class fTable_Manager_ADM
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
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billiardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.btnDKMember = new System.Windows.Forms.Button();
            this.btnDatTruoc = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnStatusBan = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.TenNhanVien = new System.Windows.Forms.Label();
            this.GioHeThong = new System.Windows.Forms.Label();
            this.namePage = new System.Windows.Forms.Label();
            this.table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.bànToolStripMenuItem.Text = "Bàn";
            // 
            // billiardToolStripMenuItem
            // 
            this.billiardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànToolStripMenuItem});
            this.billiardToolStripMenuItem.Name = "billiardToolStripMenuItem";
            this.billiardToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.billiardToolStripMenuItem.Text = "Billiard";
            // 
            // pn_Left
            // 
            this.pn_Left.Controls.Add(this.btnDKMember);
            this.pn_Left.Controls.Add(this.btnDatTruoc);
            this.pn_Left.Controls.Add(this.btnThongKe);
            this.pn_Left.Controls.Add(this.btnSignOut);
            this.pn_Left.Controls.Add(this.btnHistory);
            this.pn_Left.Controls.Add(this.btnKho);
            this.pn_Left.Controls.Add(this.btnStatusBan);
            this.pn_Left.Controls.Add(this.btnEmployee);
            this.pn_Left.Controls.Add(this.btnThucDon);
            this.pn_Left.Controls.Add(this.picLogo);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(194, 661);
            this.pn_Left.TabIndex = 0;
            // 
            // btnDKMember
            // 
            this.btnDKMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKMember.Location = new System.Drawing.Point(0, 319);
            this.btnDKMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnDKMember.Name = "btnDKMember";
            this.btnDKMember.Size = new System.Drawing.Size(194, 40);
            this.btnDKMember.TabIndex = 4;
            this.btnDKMember.Text = "Đăng Ký Thành Viên";
            this.btnDKMember.UseVisualStyleBackColor = true;
            this.btnDKMember.Click += new System.EventHandler(this.btnDKMember_Click);
            // 
            // btnDatTruoc
            // 
            this.btnDatTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTruoc.Location = new System.Drawing.Point(0, 275);
            this.btnDatTruoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatTruoc.Name = "btnDatTruoc";
            this.btnDatTruoc.Size = new System.Drawing.Size(194, 40);
            this.btnDatTruoc.TabIndex = 3;
            this.btnDatTruoc.Text = "Đặt Trước";
            this.btnDatTruoc.UseVisualStyleBackColor = true;
            this.btnDatTruoc.Click += new System.EventHandler(this.btnDatTruoc_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(0, 495);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(194, 40);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Wheat;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.Location = new System.Drawing.Point(0, 615);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(194, 46);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(0, 363);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(194, 40);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnKho
            // 
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.Location = new System.Drawing.Point(0, 407);
            this.btnKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(194, 40);
            this.btnKho.TabIndex = 6;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnStatusBan
            // 
            this.btnStatusBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusBan.Location = new System.Drawing.Point(0, 231);
            this.btnStatusBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatusBan.Name = "btnStatusBan";
            this.btnStatusBan.Size = new System.Drawing.Size(194, 40);
            this.btnStatusBan.TabIndex = 2;
            this.btnStatusBan.Text = "Tình Trạng Bàn";
            this.btnStatusBan.UseVisualStyleBackColor = true;
            this.btnStatusBan.Click += new System.EventHandler(this.btnStatusBan_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(0, 451);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(194, 40);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucDon.Location = new System.Drawing.Point(0, 187);
            this.btnThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(194, 40);
            this.btnThucDon.TabIndex = 1;
            this.btnThucDon.Text = "Menu";
            this.btnThucDon.UseVisualStyleBackColor = true;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            this.btnThucDon.MouseHover += new System.EventHandler(this.btnThucDon_MouseHover);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::APP_QL_Billiard.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
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
            this.pn_Top.Location = new System.Drawing.Point(194, 0);
            this.pn_Top.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1130, 76);
            this.pn_Top.TabIndex = 1;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSize = true;
            this.TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.Location = new System.Drawing.Point(958, 49);
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Size = new System.Drawing.Size(76, 25);
            this.TenNhanVien.TabIndex = 2;
            this.TenNhanVien.Text = "label1";
            // 
            // GioHeThong
            // 
            this.GioHeThong.AutoSize = true;
            this.GioHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioHeThong.Location = new System.Drawing.Point(958, 9);
            this.GioHeThong.Name = "GioHeThong";
            this.GioHeThong.Size = new System.Drawing.Size(76, 25);
            this.GioHeThong.TabIndex = 1;
            this.GioHeThong.Text = "label1";
            // 
            // namePage
            // 
            this.namePage.AutoSize = true;
            this.namePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePage.Location = new System.Drawing.Point(53, 26);
            this.namePage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePage.Name = "namePage";
            this.namePage.Size = new System.Drawing.Size(174, 31);
            this.namePage.TabIndex = 0;
            this.namePage.Text = "Menu Admin";
            // 
            // table_panel
            // 
            this.table_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.table_panel.ColumnCount = 1;
            this.table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_panel.Location = new System.Drawing.Point(194, 76);
            this.table_panel.Margin = new System.Windows.Forms.Padding(2);
            this.table_panel.Name = "table_panel";
            this.table_panel.RowCount = 1;
            this.table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_panel.Size = new System.Drawing.Size(1130, 585);
            this.table_panel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fTable_Manager_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.pn_Left);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTable_Manager_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Billiard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTable_Manager_ADM_FormClosing);
            this.Load += new System.EventHandler(this.fTable_Manager_ADM_Load);
            this.pn_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billiardToolStripMenuItem;
        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStatusBan;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label namePage;
        private System.Windows.Forms.Button btnDatTruoc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TableLayoutPanel table_panel;
        private System.Windows.Forms.Button btnDKMember;
        private System.Windows.Forms.Label GioHeThong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TenNhanVien;
    }
}