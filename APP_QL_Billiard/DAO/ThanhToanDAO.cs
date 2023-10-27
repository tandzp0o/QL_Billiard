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
        public object ExecuteScalar(string query, object paramValue)
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

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia
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

        public int GetThoiGianSuDung(string maBan)
        {
            string query = "Select HoaDon.ThoiGianChoi from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (int)result : 0;
        }

        public void UpdateIsMember(string maBan, bool? isMember)
        {
            string query = "Update HoaDon set IsMember = @isMember where MaBan = @maBan";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBan", maBan);
                    cmd.Parameters.AddWithValue("@isMember", (object)isMember ?? DBNull.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = @maBan";
            object result = ExecuteScalar(query, maBan);
            return result != null ? (double)result : 0;
        }

        public void UpdateHoaDonTaiKhoan(string maBan, string taiKhoan)
        {
            string query = "Update HoaDon set TaiKhoan = @taiKhoan where MaBan = @maBan";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maBan", maBan);
                    cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}