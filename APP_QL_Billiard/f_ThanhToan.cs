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

namespace APP_QL_Billiard
{
    public partial class f_ThanhToan : Form
    {
        ThanhToanDAO thanhToanDAO = new ThanhToanDAO();
        int maHoaDon = 1;

        public f_ThanhToan()
        {
            InitializeComponent();
        }

        private void CapNhatThongTinHoaDon()
        {
            string tenBan = thanhToanDAO.GetTenBan(maHoaDon);
            lb_Title.Text = "Hoá đơn " + tenBan;

            DataTable dt = thanhToanDAO.GetHoaDonChiTiet(maHoaDon);
            dgv_ThanhToan.DataSource = dt;

            DateTime gioBatDau = thanhToanDAO.GetGioBatDau(maHoaDon);
            lb_GBD.Text = "Giờ bắt đầu: " + gioBatDau.ToString("HH:mm");

            DateTime gioKetThuc = thanhToanDAO.GetGioKetThuc(maHoaDon);
            lb_GKT.Text = "Giờ kết thúc: " + gioKetThuc.ToString("HH:mm");

            int thoiGianSuDung = thanhToanDAO.GetThoiGianSuDung(maHoaDon);
            lb_TgSD.Text = "Thời gian sử dụng: " + thoiGianSuDung.ToString() + " phút";

            double tongTien = thanhToanDAO.GetTongTien(maHoaDon);
            lb_TongTien.Text = "Tổng tiền: " + tongTien.ToString() + " VND";
        }

        private void chk_KT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_KT.Checked)
            {
                chk_SV.Checked = false;
                chk_VIP.Checked = false;
                thanhToanDAO.UpdateIsMember(maHoaDon, null);
                lb_GiamGia.Text = "Giảm: 0%";
                CapNhatThongTinHoaDon();
            }
        }

        private void chk_SV_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SV.Checked)
            {
                chk_KT.Checked = false;
                chk_VIP.Checked = false;
                thanhToanDAO.UpdateIsMember(maHoaDon, false);
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
                thanhToanDAO.UpdateIsMember(maHoaDon, true);
                lb_GiamGia.Text = "Giảm: 25%";
                CapNhatThongTinHoaDon();
            }
        }

        private void f_ThanhToan_Load(object sender, EventArgs e)
        {
            CapNhatThongTinHoaDon();
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            f_InHD fInHD = new f_InHD(maHoaDon);
            fInHD.Show();
        }
    }
}
