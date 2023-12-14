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
            this.dgv_OrderFood = new System.Windows.Forms.DataGridView();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.txt_Mon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderFood)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Menu
            // 
            this.flp_Menu.AutoScroll = true;
            this.flp_Menu.Location = new System.Drawing.Point(43, 44);
            this.flp_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.flp_Menu.Name = "flp_Menu";
            this.flp_Menu.Size = new System.Drawing.Size(410, 422);
            this.flp_Menu.TabIndex = 0;
            // 
            // dgv_OrderFood
            // 
            this.dgv_OrderFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderFood.Location = new System.Drawing.Point(550, 95);
            this.dgv_OrderFood.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_OrderFood.Name = "dgv_OrderFood";
            this.dgv_OrderFood.RowHeadersWidth = 62;
            this.dgv_OrderFood.RowTemplate.Height = 28;
            this.dgv_OrderFood.Size = new System.Drawing.Size(489, 371);
            this.dgv_OrderFood.TabIndex = 1;
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(550, 44);
            this.cboBan.Margin = new System.Windows.Forms.Padding(2);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(131, 21);
            this.cboBan.TabIndex = 2;
            this.cboBan.SelectedValueChanged += new System.EventHandler(this.cboBan_SelectedValueChanged);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(757, 68);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFood.TabIndex = 3;
            this.btn_AddFood.Text = "Thêm Món";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            // 
            // txt_Mon
            // 
            this.txt_Mon.Location = new System.Drawing.Point(550, 70);
            this.txt_Mon.Name = "txt_Mon";
            this.txt_Mon.Size = new System.Drawing.Size(190, 20);
            this.txt_Mon.TabIndex = 4;
            // 
            // f_ListMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 686);
            this.Controls.Add(this.txt_Mon);
            this.Controls.Add(this.btn_AddFood);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.dgv_OrderFood);
            this.Controls.Add(this.flp_Menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_ListMenu";
            this.Text = "f_ListMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Menu;
        private System.Windows.Forms.DataGridView dgv_OrderFood;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.TextBox txt_Mon;
    }
}