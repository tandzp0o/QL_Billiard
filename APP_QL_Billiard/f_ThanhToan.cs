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
using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard
{
    public partial class f_ThanhToan : Form
    {
        ThanhToanDAO thanhToanDAO = new ThanhToanDAO();
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
            string tenBan = thanhToanDAO.GetTenBan(maBan);
            lb_Title.Text = "Hoá đơn " + tenBan;

            DataTable dt = thanhToanDAO.GetHoaDonChiTiet(maBan);
            dgv_ThanhToan.DataSource = dt;

            DateTime gioBatDau = thanhToanDAO.GetGioBatDau(maBan);
            lb_GBD.Text = "Giờ bắt đầu: " + gioBatDau.ToString("HH:mm");

            DateTime gioKetThuc = thanhToanDAO.GetGioKetThuc(maBan);
            lb_GKT.Text = "Giờ kết thúc: " + gioKetThuc.ToString("HH:mm");

            int thoiGianSuDung = thanhToanDAO.GetThoiGianSuDung(maBan);
            lb_TgSD.Text = "Thời gian sử dụng: " + thoiGianSuDung.ToString() + " phút";

            double tongTien = thanhToanDAO.GetTongTien(maBan);
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

            thanhToanDAO.CapNhatIsMember(maBan, ismember);
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