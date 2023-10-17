using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using APP_QL_Billiard.DAO;

namespace APP_QL_Billiard
{
    public partial class f_ThanhToan : Form
    {
        private int currentHoaDon;
        private ThanhToanDAO tt;

        public f_ThanhToan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DateTime gioBatDau = tt.GetGioBatDau(currentHoaDon);
            lb_GBD.Text = "Giờ bắt đầu: " + gioBatDau.ToString("HH:mm");

            DateTime gioKetThuc = tt.GetGioKetThuc(currentHoaDon);
            lb_GKT.Text = "Giờ kết thúc: " + gioKetThuc.ToString("HH:mm");

            int giamGia = tt.GetGiamGia(currentHoaDon);
            lb_GiamGia.Text = "Giảm giá: " + giamGia.ToString() + "%";

            double tongTien = tt.GetTongTien(currentHoaDon);
            lb_TongTien.Text = "Tổng tiền: " + tongTien.ToString();
        }

        private void f_ThanhToan_Load(object sender, EventArgs e)
        {
            tt = new ThanhToanDAO();
            currentHoaDon = 2;
            LoadData();
        }
    }
}
