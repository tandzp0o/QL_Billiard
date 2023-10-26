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
    public partial class f_InHD : Form
    {
        InHoaDonDAO inHoaDonDAO = new InHoaDonDAO();
        int maHoaDon;

        public f_InHD(int maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void f_InHD_Load(object sender, EventArgs e)
        {
            lb_Title.Text += inHoaDonDAO.GetTenBan(maHoaDon);
            lb_Ngay.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaSo.Text = "Mã số: " + inHoaDonDAO.GetMaHoaDon(maHoaDon);
            lb_ThuNgan.Text = "Thu Ngân: " + inHoaDonDAO.GetTenThuNgan(maHoaDon);
            lb_InLuc.Text = "In lúc: " + DateTime.Now.ToString("HH:mm");
            lb_GBD.Text = "Giờ bắt đầu: " + inHoaDonDAO.GetGioBatDau(maHoaDon).ToString("HH:mm");
            lb_GKT.Text = "Giờ kết thúc: " + inHoaDonDAO.GetGioKetThuc(maHoaDon).ToString("HH:mm");
            DataTable dt = inHoaDonDAO.GetHoaDonChiTiet(maHoaDon);
            dgv_InHD.DataSource = dt;
            lb_TienDV.Text = "Tiền dịch vụ: " + inHoaDonDAO.GetTienDichVu(maHoaDon).ToString() + " VND";
            lb_TongTienGio.Text = "Tổng tiền giờ: " + inHoaDonDAO.GetTongTienGio(maHoaDon).ToString() + " VND";
            lb_GiamGia.Text = "Giảm giá: " + inHoaDonDAO.GetGiamGia(maHoaDon).ToString() + "%";
            lb_TongTien.Text = "Tổng tiền: " + inHoaDonDAO.GetTongTien(maHoaDon).ToString() + " VND";
            lb_TienGio.Text = "Giá giờ: " + inHoaDonDAO.GetGiaGio(maHoaDon).ToString() + "/1h";
        }
    }
}
