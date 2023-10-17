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
        private string conStr = "Data Source=ADMIN-PC;Initial Catalog=Ql_Billiard;Persist Security Info=True;User ID=sa;Password=123";
        public DateTime GetGioBatDau(int maHoaDon)
        {
            string query = "SELECT GioBatDau FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (DateTime)result;
                    }
                    con.Close();
                }
            }
            return DateTime.MinValue;
        }

        public DateTime GetGioKetThuc(int maHoaDon)
        {
            string query = "SELECT GioKetThuc FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (DateTime)result;
                    }
                    con.Close();
                }
            }
            return DateTime.MinValue;
        }

        public int GetThoiGianSuDung(int maHoaDon)
        {
            string query = "SELECT ThoiGianChoi FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    con.Close();
                }
            }
            return 0;
        }

        public int GetGiamGia(int maHoaDon)
        {
            string query = "SELECT IsMember FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        bool? isMember = result as bool?;
                        if (isMember == null) return 0;
                        if (isMember == false) return 20;
                        if (isMember == true) return 25;
                    }
                    con.Close();
                }
            }
            return 0;
        }

        public double GetTongTien(int maHoaDon)
        {
            string query = "SELECT TongTien FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToDouble(result);
                    }
                    con.Close();
                }
            }
            return 0;
        }
    }
}
