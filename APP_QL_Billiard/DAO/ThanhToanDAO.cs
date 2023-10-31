using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace APP_QL_Billiard.DAO
{
    public class ThanhToanDAO
    {
        private DataProvider dataProvider;

        public ThanhToanDAO()
        {
            dataProvider = DataProvider.Instance;
        }

        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<string>(query, new object[] { maBan });
            return result != null ? (string)result : string.Empty;
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia
                     from ChiTietHoaDon
                     inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                     inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                     where HoaDon.MaBan = @maBan";
            return dataProvider.ExcuteQuery(query, new object[] { maBan });
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

        public int GetThoiGianSuDung(string maBan)
        {
            string query = "Select HoaDon.ThoiGianChoi from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<int>(query, new object[] { maBan });
            return result != null ? (int)result : 0;
        }

        public void UpdateIsMember(string maBan, string isMember)
        {
            string query = "Update HoaDon set IsMember = @isMember where MaBan = @maBan";
            dataProvider.ExcuteNonQuery(query, new object[] { isMember, maBan });
        }

        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = @maBan";
            object result = dataProvider.ExcuteScalar<double>(query, new object[] { maBan });
            return result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        public void UpdateHoaDonTaiKhoan(string maBan, string taiKhoan)
        {
            string query = "Update HoaDon set TaiKhoan = @taiKhoan where MaBan = @maBan";
            dataProvider.ExcuteNonQuery(query, new object[] { maBan, taiKhoan });
        }
    }
}