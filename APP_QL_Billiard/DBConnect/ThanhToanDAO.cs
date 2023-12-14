using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace APP_QL_Billiard.DBconnect
{
    public class ThanhToanDAO
    {
        private DBConnect dataProvider;

        public ThanhToanDAO()
        {
            dataProvider = DBConnect.Instance;
        }

        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia
                           from ChiTietHoaDon
                           inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                           inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                           where HoaDon.MaBan = '" + maBan + "'";
            return dataProvider.getDataTable(query);
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

        public int GetThoiGianSuDung(string maBan)
        {
            string query = "Select HoaDon.ThoiGianChoi from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            return Convert.ToInt32(result.Rows[0][0].ToString());
        }

        public void CapNhatIsMember(string maBan, string isMember)
        {
            string query = "Update HoaDon set IsMember = N'" + isMember + "' where MaBan = '" + maBan + "'";
            dataProvider.executeNonQuery(query);
        }

        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = dataProvider.getDataTable(query);
            double tongTien = 0;
            if (double.TryParse(result.Rows[0][0].ToString(), out tongTien))
            {
                return tongTien;
            }
            else
            {
                return 0;
            }
        }

        public void CapNhatHoaDonTaiKhoan(string maBan, string taiKhoan)
        {
            string query = "Update HoaDon set TaiKhoan = @taiKhoan where MaBan = '" + maBan + "'";
            dataProvider.executeNonQuery(query);
        }
    }
}