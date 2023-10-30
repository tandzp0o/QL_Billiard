namespace APP_QL_Billiard
{
    partial class f_ListMenu
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
            this.flp_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.cboBan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Menu
            // 
            this.flp_Menu.AutoScroll = true;
            this.flp_Menu.Location = new System.Drawing.Point(65, 67);
            this.flp_Menu.Name = "flp_Menu";
            this.flp_Menu.Size = new System.Drawing.Size(555, 303);
            this.flp_Menu.TabIndex = 0;
            // 
            // dgv_Order
            // 
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Location = new System.Drawing.Point(705, 102);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 62;
            this.dgv_Order.RowTemplate.Height = 28;
            this.dgv_Order.Size = new System.Drawing.Size(240, 150);
            this.dgv_Order.TabIndex = 1;
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(705, 37);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(169, 28);
            this.cboBan.TabIndex = 2;
            // 
            // f_ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 585);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.flp_Menu);
            this.Name = "f_ListMenu";
            this.Text = "f_ListMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Menu;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.ComboBox cboBan;
    }
}