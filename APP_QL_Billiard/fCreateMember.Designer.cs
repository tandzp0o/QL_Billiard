
namespace APP_QL_Billiard
{
    partial class fCreateMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRef = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvDSMember = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMember)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 26);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 30);
            this.txtPhone.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 30);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(428, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Đăng Ký";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "SĐT:";
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRef.Location = new System.Drawing.Point(428, 78);
            this.btnRef.Margin = new System.Windows.Forms.Padding(5);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(124, 51);
            this.btnRef.TabIndex = 5;
            this.btnRef.Text = "Nhập Lại";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 143);
            this.panel1.TabIndex = 6;
            // 
            // dtgvDSMember
            // 
            this.dtgvDSMember.AllowUserToAddRows = false;
            this.dtgvDSMember.AllowUserToDeleteRows = false;
            this.dtgvDSMember.AllowUserToResizeColumns = false;
            this.dtgvDSMember.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dtgvDSMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDSMember.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDSMember.Location = new System.Drawing.Point(12, 221);
            this.dtgvDSMember.Name = "dtgvDSMember";
            this.dtgvDSMember.ReadOnly = true;
            this.dtgvDSMember.RowHeadersVisible = false;
            this.dtgvDSMember.RowHeadersWidth = 51;
            this.dtgvDSMember.Size = new System.Drawing.Size(604, 555);
            this.dtgvDSMember.TabIndex = 6;
            this.dtgvDSMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSMember_CellClick);
            this.dtgvDSMember.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDSMember_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh Sách Các Thành Viên Của CLB:";
            // 
            // fCreateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 798);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDSMember);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fCreateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCreateMember";
            this.Load += new System.EventHandler(this.fCreateMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvDSMember;
    }
}