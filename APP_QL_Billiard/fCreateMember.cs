﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_QL_Billiard.DBconnect;
using System.Text.RegularExpressions;

namespace APP_QL_Billiard
{
    public partial class fCreateMember : Form
    {
        public fCreateMember()
        {
            InitializeComponent();
        }

        public TextBox SDT { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0-9]");
            if (phoneNumpattern.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
            string sql = "insert into KhachHang(Ten, Phone) values (N'" + txtName.Text + "', '" + txtPhone.Text + "')";
            int k = DBConnect.Instance.ExcuteNonQuery(sql);
            if (k != 0)
            {
                MessageBox.Show("Ok");
            }
        }

        private void fCreateMember_Load(object sender, EventArgs e)
        {
            if (SDT != null)
                txtPhone.Text = SDT.Text;
            string query = "select * from KhachHang";
            DataTable dt = DBConnect.Instance.ExcuteQuery(query);
            dtgvDSMember.DataSource = dt;
            dtgvDSMember.Columns[0].HeaderText = "Số Điện Thoại";
            dtgvDSMember.Columns[1].HeaderText = "Tên Khách Hàng";
            txtPhone.Focus();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
        }

        private void dtgvDSMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDSMember.Rows[e.RowIndex];
                row.Selected = true;
                if (dtgvDSMember.SelectedRows != null)
                {
                    txtPhone.Text = dtgvDSMember.SelectedRows[0].Cells[0].Value.ToString();
                    txtName.Text = dtgvDSMember.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }

    }
}
