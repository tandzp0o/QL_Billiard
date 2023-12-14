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
        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public string GetMaHoaDon(string maBan)
        {
            string query = "Select MaHoaDon from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public string GetTenThuNgan(string maBan)
        {
            string query = "Select A.HoTen from Account A, HoaDon H where A.TaiKhoan = H.TaiKhoan and H.MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public DateTime GetGioBatDau(string maBan)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public DateTime GetGioKetThuc(string maBan)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia, SoLuongDat * Gia as N'Thành tiền'
                           from ChiTietHoaDon
                           inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                           inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                           where HoaDon.MaBan = '" + maBan + "'";
            return DBConnect.Instance.getDataTable(query);
        }

        public double GetTienDichVu(string maBan)
        {
            string query = @"Select sum(SoLuongDat * Gia) from ChiTietHoaDon 
							 inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon 
							 inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
							 where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetTongTienGio(string maBan)
        {
            string query = "Select (DATEDIFF(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0) * Gia from HoaDon inner join Ban on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetGiamGia(string maBan)
        {
            string query = "Select IsMember from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            double giamGia = 0;
            if (result != null)
            {
                string isMember = result.ToString();

                if (isMember == "Khách vãng lai")
                {
                    giamGia = 0;
                }
                else if (isMember == "Học sinh/Sinh viên")
                {
                    giamGia = 20;
                }
                else if (isMember == "VIP")
                {
                    giamGia = 25;
                }
            }
            return giamGia;
        }


        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetGiaGio(string maBan)
        {
            string query = "Select Gia from Ban join HoaDon on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

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
            lb_Title.Text += GetTenBan(maBan);
            lb_Ngay.Text += DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaSo.Text += GetMaHoaDon(maBan);
            lb_ThuNgan.Text += GetTenThuNgan(maBan);
            lb_InLuc.Text += DateTime.Now.ToString("HH:mm");
            lb_GBD.Text += GetGioBatDau(maBan);
            lb_GKT.Text += GetGioKetThuc(maBan);
            DataTable dt = GetHoaDonChiTiet(maBan);
            dgv_InHD.DataSource = dt;
            lb_TienDV.Text += GetTienDichVu(maBan).ToString() + " VND";
            lb_TongTienGio.Text += GetTongTienGio(maBan).ToString() + " VND";
            lb_GiamGia.Text += GetGiamGia(maBan).ToString() + "%";
            lb_TongTien.Text += GetTongTien(maBan).ToString() + " VND";
            lb_TienGio.Text += GetGiaGio(maBan).ToString() + "/1h";
        }
    }
}
