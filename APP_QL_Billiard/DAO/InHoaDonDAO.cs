using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APP_QL_Billiard.DAO
{
    public class InHoaDonDAO
    {
        private DataProvider dataProvider;

        public InHoaDonDAO()
        {
            dataProvider = DataProvider.Instance;
        }

        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public string GetMaHoaDon(string maBan)
        {
            string query = "Select MaHoaDon from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public string GetTenThuNgan(string maBan)
        {
            string query = "Select A.HoTen from Account A, HoaDon H where A.TaiKhoan = H.TaiKhoan and H.MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public DateTime GetGioBatDau(string maBan)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public DateTime GetGioKetThuc(string maBan)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia, SoLuongDat * Gia as N'Thành tiền'
                           from ChiTietHoaDon
                           inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                           inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                           where HoaDon.MaBan = '" + maBan + "'";
            return dataProvider.getDataTable(query);
        }

        public double GetTienDichVu(string maBan)
        {
            string query = @"Select sum(SoLuongDat * Gia) from ChiTietHoaDon 
							 inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon 
							 inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
							 where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetTongTienGio(string maBan)
        {
            string query = "Select (DATEDIFF(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0) * Gia from HoaDon inner join Ban on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetGiamGia(string maBan)
        {
            string query = "Select IsMember from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
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
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

        public double GetGiaGio(string maBan)
        {
            string query = "Select Gia from Ban join HoaDon on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToDouble(result.Rows[0][0].ToString());
        }

    }
}
