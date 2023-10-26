﻿using System;
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

        public string GetTenBan(int maHoaDon)
        {
            string query = "Select Ban.TenBan from Ban join HoaDon on Ban.MaBan = HoaDon.MaBan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (string)result : "";
        }

        public string GetMaHoaDon(int maHoaDon)
        {
            string query = "Select MaHoaDon from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? result.ToString() : "";
        }

        public string GetTenThuNgan(int maHoaDon)
        {
            string query = "Select HoTen from Account where TaiKhoan = (Select TaiKhoan from HoaDon where MaHoaDon = @maHoaDon)";
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    con.Close();
                    return result != null ? (string)result : "";
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

        public DataTable GetHoaDonChiTiet(int maHoaDon)
        {
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia,
                 SoLuongDat * Gia as N'Thành tiền'
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

        public double GetTienDichVu(int maHoaDon)
        {
            string query = "Select sum(SoLuongDat * Gia) from ChiTietHoaDon inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public double GetTongTienGio(int maHoaDon)
        {
            string query = "Select (DATEDIFF(minute, HoaDon.GioBatDau, HoaDon.GioKetThuc) / 60.0) * Gia from HoaDon inner join Ban on HoaDon.MaBan = Ban.MaBan where HoaDon.MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? Convert.ToDouble(result) : 0;
        }

        public double GetGiamGia(int maHoaDon)
        {
            string query = "Select IsMember from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            if (result == null || result is DBNull)
                return 0;
            else if ((bool)result == false)
                return 20;
            else
                return 25;
        }

        public double GetTongTien(int maHoaDon)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }

        public double GetGiaGio(int maHoaDon)
        {
            string query = "Select Gia from Ban join HoaDon on HoaDon.MaBan = Ban.MaBan where MaHoaDon = @maHoaDon";
            object result = ExecuteScalar(query, maHoaDon);
            return result != null ? (double)result : 0;
        }
    }
}
