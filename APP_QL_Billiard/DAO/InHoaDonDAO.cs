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
            string query = "Select Ban.TenBan from Ban where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<string>(query, new object[] { maBan });
            return result != null ? (string)result : string.Empty;
        }

        public string GetMaHoaDon(string maBan)
        {
            string query = "Select MaHoaDon from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<string>(query, new object[] { maBan });
            return result != null ? (string)result : string.Empty;
        }

        public string GetTenThuNgan(string maBan)
        {
            string query = "Select HoTen from Account where TaiKhoan = (Select TaiKhoan from HoaDon where MaBan = @maBan)";
            object result = dataProvider.ExcuteScalar<string>(query, new object[] { maBan });
            return result != null ? (string)result : string.Empty;
        }

        public DateTime GetGioBatDau(string maBan)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<DateTime>(query, new object[] { maBan });
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DateTime GetGioKetThuc(string maBan)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<DateTime>(query, new object[] { maBan });
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia,
         SoLuongDat * Gia as N'Thành tiền'
         from ChiTietHoaDon
         inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
         inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
         where HoaDon.MaBan = @maBan";
            return dataProvider.ExcuteQuery(query, new object[] { maBan });
        }

        public double GetTienDichVu(string maBan)
        {
            string query = "Select sum(SoLuongDat * Gia) from ChiTietHoaDon inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<double>(query, new object[] { maBan });
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        public double GetTongTienGio(string maBan)
        {
            string query = "Select (DATEDIFF(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0) * Gia from HoaDon inner join Ban on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<double>(query, new object[] { maBan });
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        public double GetGiamGia(string maBan)
        {
            string query = "Select IsMember from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<string>(query, new object[] { maBan });

            double giamGia = 0;

            if (result != null && result != DBNull.Value)
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
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<double>(query, new object[] { maBan });
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        public double GetGiaGio(string maBan)
        {
            string query = "Select Gia from Ban join HoaDon on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<double>(query, new object[] { maBan });
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }
    }
}
