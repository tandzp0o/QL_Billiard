﻿
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
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billiardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatusBan = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.namePage = new System.Windows.Forms.Label();
            this.pn_Content = new System.Windows.Forms.Panel();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
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
            this.pn_Left.Controls.Add(this.btnSignOut);
            this.pn_Left.Controls.Add(this.btnThongKe);
            this.pn_Left.Controls.Add(this.btnEmployee);
            this.pn_Left.Controls.Add(this.btnKho);
            this.pn_Left.Controls.Add(this.btnHistory);
            this.pn_Left.Controls.Add(this.btnStatusBan);
            this.pn_Left.Controls.Add(this.btnThucDon);
            this.pn_Left.Controls.Add(this.picLogo);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(258, 745);
            this.pn_Left.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Wheat;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.Location = new System.Drawing.Point(0, 688);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(258, 57);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(0, 575);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(258, 57);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(0, 512);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(258, 57);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(0, 449);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(258, 57);
            this.btnKho.TabIndex = 4;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(0, 386);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(258, 57);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnStatusBan
            // 
            this.btnStatusBan.Location = new System.Drawing.Point(0, 323);
            this.btnStatusBan.Name = "btnStatusBan";
            this.btnStatusBan.Size = new System.Drawing.Size(258, 57);
            this.btnStatusBan.TabIndex = 2;
            this.btnStatusBan.Text = "Tình Trạng Bàn";
            this.btnStatusBan.UseVisualStyleBackColor = true;
            this.btnStatusBan.Click += new System.EventHandler(this.btnStatusBan_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.Location = new System.Drawing.Point(0, 260);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(258, 57);
            this.btnThucDon.TabIndex = 1;
            this.btnThucDon.Text = "Menu";
            this.btnThucDon.UseVisualStyleBackColor = true;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::APP_QL_Billiard.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(258, 225);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.namePage);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(258, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1199, 94);
            this.pn_Top.TabIndex = 1;
            // 
            // namePage
            // 
            this.namePage.AutoSize = true;
            this.namePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePage.Location = new System.Drawing.Point(71, 32);
            this.namePage.Name = "namePage";
            this.namePage.Size = new System.Drawing.Size(218, 39);
            this.namePage.TabIndex = 0;
            this.namePage.Text = "Menu Admin";
            // 
            // pn_Content
            // 
            this.pn_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Content.Location = new System.Drawing.Point(258, 94);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(1199, 651);
            this.pn_Content.TabIndex = 2;
            // 
            // fTable_Manager_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 745);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.pn_Left);
            this.Name = "fTable_Manager_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Billiard";
            this.Load += new System.EventHandler(this.fTable_Manager_Load);
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
        private System.Windows.Forms.Panel pn_Content;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStatusBan;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label namePage;
    }
}