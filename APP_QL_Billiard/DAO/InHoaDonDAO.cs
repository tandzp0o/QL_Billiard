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
        public string GetTenBan(int maHoaDon)
        {
            string query = "Select TenBan from HoaDon join Ban on HoaDon.MaBan = Ban.MaBan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (string)result : "";
        }

        public DateTime GetGioBatDau(int maHoaDon)
        {
            string query = "Select GioBatDau from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DateTime GetGioKetThuc(int maHoaDon)
        {
            string query = "Select GioKetThuc from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public double GetGiamGia(int maHoaDon)
        {
            string query = "Select IsMember from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            if (result == null)
                return 0;
            else if ((bool)result == false)
                return 20;
            else
                return 25;
        }

        public double GetTongTien(int maHoaDon)
        {
            string query = "Select ThanhToan from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public string GetTenThuNgan(int maHoaDon)
        {
            string query = "Select Account.TaiKhoan from LapHoaDon join Account on LapHoaDon.TaiKhoan = Account.TaiKhoan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (string)result : "";
        }

        public double GetTienDichVu(int maHoaDon)
        {
            string query = "Select SUM(SoLuongDat * Gia) from ChiTietHoaDon join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public double GetTongTienGio(int maHoaDon)
        {
            string query = "Select (DATEDIFF(MINUTE, GioBatDau, GioKetThuc)/60.0) * Gia from HoaDon join Ban on HoaDon.MaBan = Ban.MaBan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? Convert.ToDouble(result) : 0;
        }

        public double GetGiaGio(int maHoaDon)
        {
            string query = "Select Gia from HoaDon join Ban on HoaDon.MaBan = Ban.MaBan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public DataTable GetHoaDonChiTiet(int maHoaDon)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                string query = @"SELECT TenThucDon, SoLuongDat, DonViTinh, Gia,
                         SoLuongDat * Gia AS ThanhTien,
                         CASE
                             WHEN IsMember IS NULL THEN ThanhToan
                             WHEN IsMember = 0 THEN ThanhToan * 0.8
                             WHEN IsMember = 1 THEN ThanhToan * 0.75
                         END AS ThanhToan
                         FROM ChiTietHoaDon
                         JOIN ThucDon ON ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                         JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                         WHERE ChiTietHoaDon.MaHoaDon = @maHoaDon";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        private object ExecuteScalar(string query, int maHoaDon)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    return result;
                }
            }
        }
    }
}
