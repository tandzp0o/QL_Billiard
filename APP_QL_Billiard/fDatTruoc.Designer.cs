
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 124);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.LightCoral;
            this.btnRef.Location = new System.Drawing.Point(285, 519);
            this.btnRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(137, 70);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "Đặt Lại";
            this.btnRef.UseVisualStyleBackColor = false;
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDo.Location = new System.Drawing.Point(55, 519);
            this.btnDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(140, 70);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Xác Nhận";
            this.btnDo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bàn Trống:";
            // 
            // cbbEmptyTable
            // 
            this.cbbEmptyTable.FormattingEnabled = true;
            this.cbbEmptyTable.Location = new System.Drawing.Point(160, 441);
            this.cbbEmptyTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEmptyTable.Name = "cbbEmptyTable";
            this.cbbEmptyTable.Size = new System.Drawing.Size(274, 28);
            this.cbbEmptyTable.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Loại Bàn:";
            // 
            // cbbTypeTable
            // 
            this.cbbTypeTable.FormattingEnabled = true;
            this.cbbTypeTable.Location = new System.Drawing.Point(160, 366);
            this.cbbTypeTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeTable.Name = "cbbTypeTable";
            this.cbbTypeTable.Size = new System.Drawing.Size(274, 28);
            this.cbbTypeTable.TabIndex = 3;
            this.cbbTypeTable.SelectedIndexChanged += new System.EventHandler(this.cbbTypeTable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giờ Tới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đặt Bàn Trước";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(160, 225);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(274, 27);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 294);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // fDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 618);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbEmptyTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbTypeTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDatTruoc";
            this.Text = "fDatTruoc";
            this.Load += new System.EventHandler(this.fDatTruoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}