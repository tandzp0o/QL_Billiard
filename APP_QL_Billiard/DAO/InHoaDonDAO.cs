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
        private object ExecuteScalar(string query, object paramValue)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBan", paramValue);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    return result;
                }
            }
        }

        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (string)result : "";
        }

        public string GetMaHoaDon(string maBan)
        {
            string query = "Select MaHoaDon from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? result.ToString() : "";
        }

        public string GetTenThuNgan(string maBan)
        {
            string query = "Select HoTen from Account where TaiKhoan = (Select TaiKhoan from HoaDon where MaBan = @maBan)";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBan", maBan);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    return result != null ? (string)result : "";
                }
            }
        }

        public DateTime GetGioBatDau(string maBan)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DateTime GetGioKetThuc(string maBan)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia,
                         SoLuongDat * Gia as N'Thành tiền'
                         from ChiTietHoaDon
                         inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                         inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                         where HoaDon.MaBan = @maBan";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBan", maBan);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public double GetTienDichVu(string maBan)
        {
            string query = "Select sum(SoLuongDat * Gia) from ChiTietHoaDon inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (double)result : 0;
        }

        public double GetTongTienGio(string maBan)
        {
            string query = "Select (DATEDIFF(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0) * Gia from HoaDon inner join Ban on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? Convert.ToDouble(result) : 0;
        }

        public double GetGiamGia(string maBan)
        {
            string query = "Select IsMember from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            if (result == null || result is DBNull)
                return 0;
            else if ((bool)result == false)
                return 20;
            else
                return 25;
        }

        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (double)result : 0;
        }

        public double GetGiaGio(string maBan)
        {
            string query = "Select Gia from Ban join HoaDon on HoaDon.MaBan = Ban.MaBan where HoaDon.MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (double)result : 0;
        }
    }
}
