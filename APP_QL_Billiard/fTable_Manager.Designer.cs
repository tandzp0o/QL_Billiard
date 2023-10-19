
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
            this.pn_Left = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatusBan = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.namePage = new System.Windows.Forms.Label();
            this.pn_Content = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pn_Top.SuspendLayout();
            this.pn_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.Controls.Add(this.btnSignOut);
            this.pn_Left.Controls.Add(this.btnKho);
            this.pn_Left.Controls.Add(this.btnHistory);
            this.pn_Left.Controls.Add(this.btnStatusBan);
            this.pn_Left.Controls.Add(this.btnThucDon);
            this.pn_Left.Controls.Add(this.picLogo);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(290, 931);
            this.pn_Left.TabIndex = 3;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Wheat;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.Location = new System.Drawing.Point(0, 860);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(290, 71);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(0, 561);
            this.btnKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(290, 71);
            this.btnKho.TabIndex = 4;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(0, 482);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(290, 71);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnStatusBan
            // 
            this.btnStatusBan.Location = new System.Drawing.Point(0, 404);
            this.btnStatusBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatusBan.Name = "btnStatusBan";
            this.btnStatusBan.Size = new System.Drawing.Size(290, 71);
            this.btnStatusBan.TabIndex = 2;
            this.btnStatusBan.Text = "Tình Trạng Bàn";
            this.btnStatusBan.UseVisualStyleBackColor = true;
            // 
            // btnThucDon
            // 
            this.btnThucDon.Location = new System.Drawing.Point(0, 325);
            this.btnThucDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(290, 71);
            this.btnThucDon.TabIndex = 1;
            this.btnThucDon.Text = "Menu";
            this.btnThucDon.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::APP_QL_Billiard.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(290, 281);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.namePage);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(290, 0);
            this.pn_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(1349, 118);
            this.pn_Top.TabIndex = 2;
            // 
            // namePage
            // 
            this.namePage.AutoSize = true;
            this.namePage.Location = new System.Drawing.Point(80, 40);
            this.namePage.Name = "namePage";
            this.namePage.Size = new System.Drawing.Size(51, 20);
            this.namePage.TabIndex = 0;
            this.namePage.Text = "label1";
            // 
            // pn_Content
            // 
            this.pn_Content.Controls.Add(this.flpTable);
            this.pn_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Content.Location = new System.Drawing.Point(290, 118);
            this.pn_Content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(1349, 813);
            this.pn_Content.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(15, 7);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(807, 759);
            this.flpTable.TabIndex = 0;
            // 
            // fTable_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 931);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.pn_Left);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTable_Manager";
            this.Text = "Phần Mềm Quản Lý Billiard";
            this.pn_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.pn_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStatusBan;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label namePage;
        private System.Windows.Forms.Panel pn_Content;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}