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
using APP_QL_Billiard.DBconnect;

namespace APP_QL_Billiard
{
    public partial class f_InHD : Form
    {
        InHoaDonDAO inHoaDonDAO = new InHoaDonDAO();
        string maBan;

        public f_InHD()
        {
            InitializeComponent();
        }

        public f_InHD(string maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
        }

        private void f_InHD_Load(object sender, EventArgs e)
        {
            lb_Title.Text += inHoaDonDAO.GetTenBan(maBan);
            lb_Ngay.Text += DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaSo.Text += inHoaDonDAO.GetMaHoaDon(maBan);
            lb_ThuNgan.Text += inHoaDonDAO.GetTenThuNgan(maBan);
            lb_InLuc.Text += DateTime.Now.ToString("HH:mm");
            lb_GBD.Text += inHoaDonDAO.GetGioBatDau(maBan);
            lb_GKT.Text += inHoaDonDAO.GetGioKetThuc(maBan);
            DataTable dt = inHoaDonDAO.GetHoaDonChiTiet(maBan);
            dgv_InHD.DataSource = dt;
            lb_TienDV.Text += inHoaDonDAO.GetTienDichVu(maBan).ToString() + " VND";
            lb_TongTienGio.Text += inHoaDonDAO.GetTongTienGio(maBan).ToString() + " VND";
            lb_GiamGia.Text += inHoaDonDAO.GetGiamGia(maBan).ToString() + "%";
            lb_TongTien.Text += inHoaDonDAO.GetTongTien(maBan).ToString() + " VND";
            lb_TienGio.Text += inHoaDonDAO.GetGiaGio(maBan).ToString() + "/1h";
        }
    }
}
