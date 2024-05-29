using APP_QL_Billiard.DBconnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace APP_QL_Billiard
{
    public partial class f_ListTable2 : Form
    {
        private PictureBox pic;
        private Label rate;
        private Label name;
        private string maBan;
        public f_ListTable2()
        {
            InitializeComponent();
        }

        public int soBan()
        {
            string q = "select count(*) from Ban";
            int sl = DBConnect.Instance.getResult_ExecuteScalar(q);
            return sl;
        }

        public void setStyleLabel(Label label, int i)
        {
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            if (i == 1)
            {
                label.Text = "Hoạt động";
                label.BackColor = Color.LightGreen;
            }
            else if (i == 2)
            {
                label.Text = "Trống";
                label.BackColor = Color.White;
            }
            else
            {
                label.Text = "Đặt trước";
                label.BackColor = Color.LightYellow;
            }
        }

        public void setStylePic_AddItem(Label l, PictureBox p)
        {
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Controls.Add(l);
        }

        public void load_Ban()
        {
            // clear all item

            fPanel.Controls.Clear();
            string q = "select Maban, TenBan, LoaiBan, TrangThai, Gia from Ban";
            DataTable dt = DBConnect.Instance.ExcuteQuery(q);
            int sl = soBan();
            int i = 0;
            Label n1 = new Label();
            Label n2 = new Label();
            Label n3 = new Label();
            setStyleLabel(n1, 1);
            setStyleLabel(n2, 2);
            setStyleLabel(n3, 3);
            setStylePic_AddItem(n1, pic1);
            setStylePic_AddItem(n2, pic2);
            setStylePic_AddItem(n3, pic3);

            while (sl > 0)
            {
                //pic
                pic = new PictureBox();
                pic.Height = 200;
                pic.Width = 170;
                pic.BackgroundImageLayout = ImageLayout.Tile;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Tag = dt.Rows[i]["Maban"].ToString();
                // name
                name = new Label();
                name.Text = dt.Rows[i]["TenBan"].ToString();
                if (int.Parse(dt.Rows[i]["TrangThai"].ToString()) == 1) // hoạt động
                {
                    name.BackColor = Color.LightGreen;
                }
                else if (int.Parse(dt.Rows[i]["TrangThai"].ToString()) == 2) // trống
                {
                    name.BackColor = Color.White;
                }
                else // đặt trước
                {
                    name.BackColor = Color.LightYellow;
                }
                name.Dock = DockStyle.Fill;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Tag = dt.Rows[i]["MaBan"].ToString();
                //rate
                rate = new Label();
                rate.Text = dt.Rows[i]["Gia"].ToString();
                rate.Width = 50;
                rate.BackColor = Color.ForestGreen;
                rate.TextAlign = ContentAlignment.BottomCenter;
                rate.Tag = dt.Rows[i]["MaBan"].ToString();

                pic.Controls.Add(rate);
                pic.Controls.Add(name);
                //
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                //pic.BackgroundImage = new Bitmap(projectDirectory + "\\HinhMatHang\\" + dt.Rows[i]["Hinh"].ToString() + "");
                fPanel.Controls.Add(pic);
                name.Click += new EventHandler(OnClick);
                sl--;
                i++;
            }
        }

        public void OnClick(object sender, EventArgs e) // hiển thị thông tin của bàn đã click
        {
            maBan = ((Label)sender).Tag.ToString();
            string query = "select * from Ban where MaBan = '" + maBan + "'";
            DataTable dt = DBConnect.Instance.ExcuteQuery(query);
            txt_TenBan.Text = dt.Rows[0]["TenBan"].ToString();
            thongTinHoaDonDangMo(maBan);
            // hiển thị giờ bắt đầu
        }

        private void thongTinHoaDonDangMo(string maBan)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE GioKetThuc IS NULL AND MaBan = '" + maBan + "'";
            string maHD = DBConnect.Instance.ExcuteScalar<string>(query);
            if (maHD != null)
            {
                /*// tao hoa don moi
                string q = "INSERT INTO HoaDon (MaBan, GioBatDau, TaiKhoan) VALUES ('" + maBan + "', '', '"+Account.Instance.TaiKhoan.ToString()+"')";
                maHD = DBConnect.Instance.ExcuteScalar<string>(q);*/
                btnEnd.Enabled = true;
                CapNhatHienThiChiTietHoaDon(maHD);
                string q2 = "select * from HoaDon where MaHoaDon = '" + maHD + "'";
                DataTable dt = DBConnect.Instance.ExcuteQuery(q2);
                if (dt.Rows[0]["GioBatDau"].ToString() != null)
                {
                    txtTimeStart.Text = dt.Rows[0]["GioBatDau"].ToString();
                }
                else
                {
                    txtTimeStart.Text = "";
                }
            }
            else
            {
                txtTimeStart.Text = string.Empty;
                txtTimeEnd.Text = string.Empty;
                txtGioChoi.Text = string.Empty;
                txtTongTien.Text = string.Empty;
                dataGridView1.Rows.Clear();
            }
        } 

        private void CapNhatHienThiChiTietHoaDon(string maHD)
        {
            // Xóa dữ liệu cũ trong datagridview
            dataGridView1.Rows.Clear();

            // Truy vấn chi tiết hóa đơn
            string query = "SELECT TenThucDon, SoLuongDat, Gia * SoLuongDat AS ThanhTien FROM ChiTietHoaDon ct JOIN ThucDon td ON ct.MaThucDon = td.MaThucDon WHERE MaHoaDon = '" + maHD + "'";
            DataTable dtChiTietHoaDon = DBConnect.Instance.ExcuteQuery(query);
            int stt = 1;
            // Hiển thị dữ liệu chi tiết hóa đơn lên datagridview
            foreach (DataRow row in dtChiTietHoaDon.Rows)
            {

                string tenThucDon = row["TenThucDon"].ToString();
                int soLuongDat = Convert.ToInt32(row["SoLuongDat"]);
                decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);

                string[] rowData = new string[] { stt.ToString(), tenThucDon, soLuongDat.ToString(), thanhTien.ToString("0,000") };
                dataGridView1.Rows.Add(rowData);
                stt++;
            }
            /*if (maHD != null)
            {
                string tt = "SELECT SUM(SoLuongDat * Gia) AS total_amount FROM ChiTietHoaDon ct join ThucDon td on ct.MaThucDon = td.MaThucDon and MaHoaDon = '" + maHD + "'";
                DataTable ttt = DBConnect.Instance.ExcuteQuery(tt);
                if (!ttt.Rows[0].IsNull(0))
                {
                    decimal tongThanhTien = Convert.ToDecimal(ttt.Rows[0][0]);
                    // Định dạng số tiền với dấu phẩy và đơn vị tiền tệ Việt Nam
                    label2.Text = "Tổng Thành Tiền: " + tongThanhTien.ToString("0,000") + "Đ";
                }
                else
                    label2.Text = "Tổng Thành Tiền: 0Đ";
            }*/
        }

        private void f_ListTable2_Load(object sender, EventArgs e)
        {
            load_Ban();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // có hoá đơn và đã kết thúc
            string q = " select * from Ban b join HoaDon hd on b.MaBan = hd.MaBan and b.TenBan = '"+txt_TenBan.Text+"' and hd.GioKetThuc IS NOT NULL";
            DataTable dt = DBConnect.Instance.ExcuteQuery(q);
            if (dt.Rows.Count == 0)
            {
             

                DateTime date = DateTime.Now;
                txtTimeStart.Text = date.ToString("HH:mm:ss dd/MM/yyyy");
                txtTimeEnd.Text = "";
                string insertHoaDonQuery = "INSERT INTO HoaDon (MaBan, GioBatDau, TaiKhoan) VALUES ('"+maBan+"','"+date.ToString()+"','"+ Account.Instance.TaiKhoan + "')";
                //insertHoaDonQuery = insertHoaDonQuery.Replace("@gioBD", date.ToString("HH:mm:ss MM/dd/yyyy")); // Định dạng ngày giờ cho SQL

                int result = DBConnect.Instance.ExcuteNonQuery(insertHoaDonQuery);

                // Thêm trường Status của bảng Ban vào câu truy vấn UPDATE
                string updateBanStatusQuery = "UPDATE Ban SET TrangThai = 1 WHERE MaBan = '"+maBan+"'";
                DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery);

                if (result > 0)
                {
                    MessageBox.Show("Đã tạo hóa đơn mới cho bàn " + maBan);
                    txtTimeStart.Text = date.ToString();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi tạo hóa đơn.");
                }
                load_Ban();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtTimeEnd.Text = date.ToString();
            txtTimeEnd.Enabled = false;

            /*string updateBanStatusQuery = "UPDATE Ban SET TrangThai = 2 WHERE MaBan = '"+maBan+"'";
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery);*/

            // update GioKetThuc

            string query = "select MaHoaDon from HoaDon where MaBan ='" + maBan + "' and GioKetThuc IS NULL";
            string mahd = DBConnect.Instance.ExcuteScalar<string>(query);

            string updateBanStatusQuery1 = "UPDATE HOADON SET GioKetThuc = '" + date.ToString() + "' WHERE MaHoaDon = '"+mahd+"'";
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery1);

            //////////////////////////////////////////// tính giờ chơi
            string q = "select GioBatDau from HoaDon where MaHoaDon ='" + mahd + "'";
            DateTime a = DBConnect.Instance.ExcuteScalar<DateTime>(q);
            string q2 = "select GioKetThuc from HoaDon where MaHoaDon ='" + mahd + "'";
            DateTime b = DBConnect.Instance.ExcuteScalar<DateTime>(q2);

            DateTime date1 = a;
            DateTime date2 = b;
            double m = (date2 - date1).TotalMinutes;

            int hour = (int)(m / 60);

            int minute = (int)(m % 60);

            txtGioChoi.Text = hour + " giờ " + minute + " phút";

            string query2 = "SELECT Gia FROM Ban WHERE MaBan = '" + maBan + "' ";
            int c = DBConnect.Instance.ExcuteScalar<int>(query2);
            int gia = (int)(m * c) / 60;
            txtTongTien.Text = gia + "VND";
            btnThanhToan.Enabled = true;

            string updateHoaDonQuery = "UPDATE HoaDon SET ThoiGianChoi='" + (int)m + "' WHERE MaHoaDon = '"+mahd+"'";
            //updateHoaDonQuery = updateHoaDonQuery.Replace("@gioKT", date2.ToString("HH:mm:ss MM/dd/yyyy")); // Định dạng ngày giờ cho SQL
            DBConnect.Instance.ExcuteNonQuery(updateHoaDonQuery);

            int tt = (int)gia;
            string updateHoaDonQuery1 = "UPDATE HoaDon SET ThanhToan = '" + tt + "',TaiKhoan='" + Account.Instance.TaiKhoan + "' WHERE MaHoaDon = '"+mahd+"'";
            DBConnect.Instance.ExcuteNonQuery(updateHoaDonQuery1);

            string updateBanStatusQuery2 = "UPDATE Ban SET TrangThai = 2 WHERE MaBan = '"+maBan+"'";
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery2);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đổi bàn?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                fBanTrong f = new fBanTrong();
                f.ShowDialog();
                string mb = f.maBan;
                string qr = "Update HoaDon set MaBan = '" + mb + "' where MaBan = '" + maBan + "'";
                DBConnect.Instance.ExcuteNonQuery(qr);
                // set trạng thái
                string qs = "update Ban set TrangThai = 2 where MaBan = '" + maBan + "'";
                DBConnect.Instance.executeNonQuery(qs);
                string qs2 = "update Ban set TrangThai = 1 where MaBan = '" + mb + "'";
                DBConnect.Instance.executeNonQuery(qs2);
                load_Ban();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            f_ThanhToan thanhToanForm = new f_ThanhToan(maBan);
            thanhToanForm.Show();
        }
    }
}
