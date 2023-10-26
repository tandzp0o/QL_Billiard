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
            lb_Ngay.Text += DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaSo.Text += inHoaDonDAO.GetMaHoaDon(maHoaDon);
            lb_ThuNgan.Text += inHoaDonDAO.GetTenThuNgan(maHoaDon);
            lb_InLuc.Text += DateTime.Now.ToString("HH:mm");
            lb_GBD.Text += inHoaDonDAO.GetGioBatDau(maHoaDon).ToString("HH:mm");
            lb_GKT.Text += inHoaDonDAO.GetGioKetThuc(maHoaDon).ToString("HH:mm");
            DataTable dt = inHoaDonDAO.GetHoaDonChiTiet(maHoaDon);
            dgv_InHD.DataSource = dt;
            lb_TienDV.Text += inHoaDonDAO.GetTienDichVu(maHoaDon).ToString() + " VND";
            lb_TongTienGio.Text += inHoaDonDAO.GetTongTienGio(maHoaDon).ToString() + " VND";
            lb_GiamGia.Text += inHoaDonDAO.GetGiamGia(maHoaDon).ToString() + "%";
            lb_TongTien.Text += inHoaDonDAO.GetTongTien(maHoaDon).ToString() + " VND";
            lb_TienGio.Text += inHoaDonDAO.GetGiaGio(maHoaDon).ToString() + "/1h";
        }
    }
}
