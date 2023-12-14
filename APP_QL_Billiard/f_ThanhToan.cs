using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard
{
    public partial class f_ThanhToan : Form
    {

        public string GetTenBan(string maBan)
        {
            string query = "Select Ban.TenBan from Ban where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return result.Rows[0][0].ToString();
        }

        public DataTable GetHoaDonChiTiet(string maBan)
        {
            string query = @"Select TenThucDon, SoLuongDat, DonViTinh, Gia
                           from ChiTietHoaDon
                           inner join ThucDon on ChiTietHoaDon.MaThucDon = ThucDon.MaThucDon
                           inner join HoaDon on ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                           where HoaDon.MaBan = '" + maBan + "'";
            return DBConnect.Instance.getDataTable(query);
        }

        public DateTime GetGioBatDau(string maBan)
        {
            string query = "Select HoaDon.GioBatDau from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public DateTime GetGioKetThuc(string maBan)
        {
            string query = "Select HoaDon.GioKetThuc from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToDateTime(result.Rows[0][0].ToString());
        }

        public int GetThoiGianSuDung(string maBan)
        {
            string query = "Select HoaDon.ThoiGianChoi from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
            return Convert.ToInt32(result.Rows[0][0].ToString());
        }

        public void CapNhatIsMember(string maBan, string isMember)
        {
            string query = "Update HoaDon set IsMember = N'" + isMember + "' where MaBan = '" + maBan + "'";
            DBConnect.Instance.executeNonQuery(query);
        }

        public double GetTongTien(string maBan)
        {
            string query = "Select HoaDon.TongTien from HoaDon where MaBan = '" + maBan + "'";
            DataTable result = DBConnect.Instance.getDataTable(query);
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
            DBConnect.Instance.executeNonQuery(query);
        }

        string maBan;

        public f_ThanhToan()
        {
            InitializeComponent();
        }

        public f_ThanhToan(string maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
        }

        private void f_ThanhToan_Load(object sender, EventArgs e)
        {
            CapNhatThongTinHoaDon();
        }

        private void CapNhatThongTinHoaDon()
        {
            string tenBan = GetTenBan(maBan);
            lb_Title.Text = "Hoá đơn " + tenBan;

            DataTable dt = GetHoaDonChiTiet(maBan);
            dgv_ThanhToan.DataSource = dt;

            DateTime gioBatDau = GetGioBatDau(maBan);
            lb_GBD.Text = "Giờ bắt đầu: " + gioBatDau.ToString("HH:mm");

            DateTime gioKetThuc = GetGioKetThuc(maBan);
            lb_GKT.Text = "Giờ kết thúc: " + gioKetThuc.ToString("HH:mm");

            int thoiGianSuDung = GetThoiGianSuDung(maBan);
            lb_TgSD.Text = "Thời gian sử dụng: " + thoiGianSuDung.ToString() + " phút";

            double tongTien = GetTongTien(maBan);
            lb_TongTien.Text = "Tổng tiền: " + tongTien.ToString() + " VND";
        }

        private void cb_Member_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string ismember = comboBox.SelectedItem.ToString();

            double giamGia = 0;

            if (ismember == "Khách vãng lai")
            {
                giamGia = 0;
            }
            else if (ismember == "Học sinh/Sinh viên")
            {
                giamGia = 20;
            }
            else if (ismember == "VIP")
            {
                giamGia = 25;
            }

            lb_GiamGia.Text = "Giảm: " + giamGia.ToString() + "%";

            CapNhatIsMember(maBan, ismember);
            CapNhatThongTinHoaDon();
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            f_InHD fInHD = new f_InHD(maBan);
            fInHD.Hide();
            fInHD.ShowDialog();
        }

        private void f_ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.No == r)
            {
                e.Cancel = true;
            }
        }
    }
}