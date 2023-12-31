﻿using APP_QL_Billiard.DBconnect;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard
{
    public partial class fTable_Manager : Form
    {
        public fTable_Manager()
        {
            InitializeComponent();
         
        }

        public Form child;
        public Form child2;

        public void formContent(Form content, Form content2, TableLayoutPanel x, TableLayoutPanel y = null)
        {
            if (child != null && child2 != null)
            {
                child.Close();
                child2.Close();
            }
            child = content;
            child2 = content;
            content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;
            content2.TopLevel = false;
            content2.FormBorderStyle = FormBorderStyle.None;
            content2.Dock = DockStyle.Fill;
            x.Controls.Add(content);
            x.Tag = content;
            if (y != null)
            {
                y.Controls.Add(content2);
                y.Tag = content2;
            }
            content.BringToFront();
            content.Show();
            content2.BringToFront();
            content2.Show();
        }

        private void pn_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Account.Instance.TaiKhoan = string.Empty;
            Account.Instance.MatKhau = string.Empty;
            Account.Instance.HoTen = string.Empty;
            Account.Instance.SDT = string.Empty;
            Account.Instance.IsQuanLy = false;
            this.Close();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            namePage.Text = btnThucDon.Text;

        }

        private void btnStatusBan_Click(object sender, EventArgs e)
        {
            fFunction_Ban f = new fFunction_Ban();
            namePage.Text = btnStatusBan.Text;
            table_panel.Controls.Clear();
            formContent(f, new f_ListTable(f), table_panel, table_panel);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            namePage.Text = btnHistory.Text;
            table_panel.Controls.Clear();
            formContent(new fLichSu(), new Form(), table_panel);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            namePage.Text = btnKho.Text;
            table_panel.Controls.Clear();
            formContent(new f_NhapHang(), new f_ListThucDon() , table_panel, table_panel);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GioHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string query = "dbo.TrangThaiBan";
            DBConnect.Instance.ExecuteProcedure(query);
        }

        private void fTable_Manager_Load(object sender, EventArgs e)
        {
            GioHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            TenNhanVien.Text = "Nhân Viên: " + Account.Instance.HoTen;

            string query = "dbo.TrangThaiBan";
            DBConnect.Instance.ExecuteProcedure(query);
        }

        private void btnDKMember_Click(object sender, EventArgs e)
        {
            namePage.Text = btnDKMember.Text;
            table_panel.Controls.Clear();
            formContent(new fCreateMember(), new Form(), table_panel, null);
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            fListDatTruoc f = new fListDatTruoc();

            namePage.Text = btnDatTruoc.Text;
            table_panel.Controls.Clear();
            formContent(new fDatTruoc(f), f, table_panel, table_panel);
        }

        private void fTable_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
