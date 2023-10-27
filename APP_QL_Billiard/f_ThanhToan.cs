using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using APP_QL_Billiard.DAO;
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard
{
    public partial class f_ThanhToan : Form
    {
        ThanhToanDAO thanhToanDAO = new ThanhToanDAO();
        string maBan;

        public f_ThanhToan()
        {
            InitializeComponent();
        }

        public f_ThanhToan(string maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
        }

        private void f_ThanhToan_Load(object sender, EventArgs e)
        {
            CapNhatThongTinHoaDon();
        }

        private void CapNhatThongTinHoaDon()
        {
            string tenBan = thanhToanDAO.GetTenBan(maBan);
            lb_Title.Text = "HOÁ ĐƠN BÀN " + tenBan;

            DataTable dt = thanhToanDAO.GetHoaDonChiTiet(maBan);
            dgv_ThanhToan.DataSource = dt;

            DateTime gioBatDau = thanhToanDAO.GetGioBatDau(maBan);
            lb_GBD.Text = "Giờ bắt đầu: " + gioBatDau.ToString("HH:mm");

            DateTime gioKetThuc = thanhToanDAO.GetGioKetThuc(maBan);
            lb_GKT.Text = "Giờ kết thúc: " + gioKetThuc.ToString("HH:mm");

            int thoiGianSuDung = thanhToanDAO.GetThoiGianSuDung(maBan);
            lb_TgSD.Text = "Thời gian sử dụng: " + thoiGianSuDung.ToString() + " phút";

            double tongTien = thanhToanDAO.GetTongTien(maBan);
            lb_TongTien.Text = "Tổng tiền: " + tongTien.ToString() + " VND";
        }

        private void chk_KT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_KT.Checked)
            {
                chk_SV.Checked = false;
                chk_VIP.Checked = false;
                thanhToanDAO.UpdateIsMember(maBan, null);
                lb_GiamGia.Text = "Giảm 0%";
                CapNhatThongTinHoaDon();
            }
        }

        private void chk_SV_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SV.Checked)
            {
                chk_KT.Checked = false;
                chk_VIP.Checked = false;
                thanhToanDAO.UpdateIsMember(maBan, false);
                lb_GiamGia.Text = "Giảm: 20%";
                CapNhatThongTinHoaDon();
            }
        }

        private void chk_VIP_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_VIP.Checked)
            {
                chk_KT.Checked = false;
                chk_SV.Checked = false;
                thanhToanDAO.UpdateIsMember(maBan, true);
                lb_GiamGia.Text = "Giảm: 25%";
                CapNhatThongTinHoaDon();
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            string maTaiKhoan = "user";
            thanhToanDAO.UpdateHoaDonTaiKhoan(maBan, maTaiKhoan);
            f_InHD fInHD = new f_InHD(maBan);
            this.Hide();
            fInHD.ShowDialog();
            this.Show();
        }

        private void f_ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.No == r)
            {
                e.Cancel = true;
            }
        }
    }
}