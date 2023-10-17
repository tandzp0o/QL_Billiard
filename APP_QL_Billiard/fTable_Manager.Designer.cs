
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
            this.pn_Top = new System.Windows.Forms.Panel();
            this.pn_Content = new System.Windows.Forms.Panel();
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
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(283, 635);
            this.pn_Left.TabIndex = 0;
            // 
            // pn_Top
            // 
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.Location = new System.Drawing.Point(283, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(979, 94);
            this.pn_Top.TabIndex = 1;
            // 
            // pn_Content
            // 
            this.pn_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Content.Location = new System.Drawing.Point(283, 94);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(979, 541);
            this.pn_Content.TabIndex = 2;
            // 
            // fTable_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 635);
            this.Controls.Add(this.pn_Content);
            this.Controls.Add(this.pn_Top);
            this.Controls.Add(this.pn_Left);
            this.Name = "fTable_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Billiard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billiardToolStripMenuItem;
        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Panel pn_Content;
    }
}