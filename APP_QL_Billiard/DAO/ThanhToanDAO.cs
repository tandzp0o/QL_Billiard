using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APP_QL_Billiard.DAO
{
    public class ThanhToanDAO
    {
        public object ExecuteScalar(string query, int maHoaDon)
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

        public string GetTenBan(int maHoaDon)
        {
            string query = "Select Ban.TenBan from Ban join HoaDon on Ban.MaBan = HoaDon.MaBan where HoaDon.MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (string)result : "";
        }

        public DataTable GetHoaDonChiTiet(int maHoaDon)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia
                         from ChiTietHoaDon
                         inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                         inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                         where ChiTietHoaDon.MaHoaDon = @maHoaDon";
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

        public DateTime GetGioBatDau(int maHoaDon)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public DateTime GetGioKetThuc(int maHoaDon)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (DateTime)result : DateTime.MinValue;
        }

        public int GetThoiGianSuDung(int maHoaDon)
        {
            string query = "Select HoaDon.ThoiGianChoi from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (int)result : 0;
        }

        public void UpdateIsMember(int maHoaDon, bool? isMember)
        {
            string query = "Update HoaDon set IsMember = @isMember where MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@isMember", (object)isMember ?? DBNull.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public double GetTongTien(int maHoaDon)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public void UpdateHoaDonTaiKhoan(int maHoaDon, string taiKhoan)
        {
            string query = "Update HoaDon set TaiKhoan = @taiKhoan where MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}