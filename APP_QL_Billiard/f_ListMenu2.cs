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
using System.Data;
using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.Properties;
using System.Xml.Linq;
using System.Collections;
using System.IO;

namespace APP_QL_Billiard
{
    public partial class f_ListMenu2 : Form
    {
        private PictureBox pic;
        private Label rate;
        private Label name;
        // tạo ra các button chứa ảnh sản phẩm
        public int soLoaiSanPham()
        {
            string q = "select count(*) from ThucDon";
            int sl = DBConnect.Instance.getResult_ExecuteScalar(q);
            return sl;
        }

        public void load_SP()
        {
            string q = "select Hinh, TenThucDon, Gia, MaThucDon from ThucDon";
            DataTable dt = DBConnect.Instance.ExcuteQuery(q);
            int sl = soLoaiSanPham();
            int i = 0;
            while(sl > 0)
            {
                //pic
                pic = new PictureBox();
                pic.Height = 200;
                pic.Width = 200;
                pic.BackgroundImageLayout = ImageLayout.Tile;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Tag = dt.Rows[i]["MaThucDon"].ToString();
                // name
                name = new Label();
                name.Text = dt.Rows[i]["TenThucDon"].ToString();
                name.BackColor = Color.ForestGreen;
                name.Dock = DockStyle.Bottom;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Tag = dt.Rows[i]["MaThucDon"].ToString();
                //rate
                rate = new Label();
                rate.Text = dt.Rows[i]["Gia"].ToString();
                rate.Width = 50;
                rate.BackColor = Color.ForestGreen;
                rate.TextAlign = ContentAlignment.MiddleCenter;
                rate.Tag = dt.Rows[i]["MaThucDon"].ToString();

                pic.Controls.Add(rate);
                pic.Controls.Add(name);
                //
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                pic.BackgroundImage = new Bitmap(projectDirectory + "\\HinhMatHang\\" + dt.Rows[i]["Hinh"].ToString() +"");
                fPanel.Controls.Add(pic);
                pic.Click += new EventHandler(OnClick);
                sl--;
                i++;
            }    
        }

        public void load_Cbb()
        {
            comboBox1.SelectedIndex = -1;
            string query = "select * from Ban where TrangThai = 1";
            DataTable a = DBConnect.Instance.ExcuteQuery(query);
            comboBox1.DataSource = a;
            comboBox1.DisplayMember = "TenBan";
            comboBox1.ValueMember = "MaBan";
        }

        /*public void load_DTGV()
        {
            string qMaHD = "select MaHoaDon from HoaDon where GioKetThuc is null and MaBan ='" + comboBox1.SelectedValue.ToString() + "'"; // hoá đơn mới
            string MaHD = DBConnect.Instance.ExcuteScalar<string>(qMaHD);
            string q = "select TenThucDon, SoLuongDat, Gia*SoLuongDat from ChiTietHoaDon ct join ThucDon td on ct.MaThucDon = td.MaThucDon and MaHoaDon = '" + MaHD + "'"; // chi tiết hoá đơn của hoá đơn mới
            DataTable a = DBConnect.Instance.ExcuteQuery(q);
            int stt= 1;
            foreach(DataRow dr in a.Rows)
            {
                dataGridView1.Rows.Add(stt, dr[0], dr[1], btnIncrease, btnReduce, dr[2]);
                stt++; 
            }    
        }*/

        public void OnClick(object sender, EventArgs e) // thêm món vào chi tiết hoá đơn
        {
            // Lấy mã thực đơn từ tag của PictureBox
            string maThucDon = ((PictureBox)sender).Tag.ToString();

            // Lấy mã hóa đơn của bàn hiện tại từ comboBox1
            string maBan = comboBox1.SelectedValue.ToString();
            string maHD = GetMaHoaDonDangMo(maBan);

            // Kiểm tra xem món đã có trong chi tiết hóa đơn hay chưa
            bool tonTai = KiemTraMonTonTai(maHD, maThucDon);

            if (tonTai)
            {
                // Cập nhật số lượng món đã có
                CapNhatSoLuongMon(maHD, maThucDon);
            }
            else
            {
                // Thêm món mới vào chi tiết hóa đơn
                ThemMoiMonVaoHoaDon(maHD, maThucDon);
            }

            // Cập nhật lại datagridview hiển thị chi tiết hóa đơn
            CapNhatHienThiChiTietHoaDon(maHD);
        }

        // cover onclick
        // Hàm lấy mã hóa đơn đang mở của bàn được chọn
        private string GetMaHoaDonDangMo(string maBan)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE GioKetThuc IS NULL AND MaBan = '" + maBan + "'";
            string maHD = DBConnect.Instance.ExcuteScalar<string>(query);
            return maHD;
        }

        // Hàm kiểm tra xem món đã có trong chi tiết hóa đơn hay chưa
        private bool KiemTraMonTonTai(string maHD, string maThucDon)
        {
            string query = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon = '" + maHD + "' AND MaThucDon = '" + maThucDon + "'";
            DataTable dt = DBConnect.Instance.ExcuteQuery(query);
            return dt.Rows.Count > 0;
        }

        // Hàm cập nhật số lượng món đã có
        private void CapNhatSoLuongMon(string maHD, string maThucDon)
        {
            string query = "UPDATE ChiTietHoaDon SET SoLuongDat = SoLuongDat + 1 WHERE MaHoaDon = '" + maHD + "' AND MaThucDon = '" + maThucDon + "'";
            DBConnect.Instance.executeNonQuery(query);
        }

        // Hàm thêm món mới vào chi tiết hóa đơn
        private void ThemMoiMonVaoHoaDon(string maHD, string maThucDon)
        {
            string query = "INSERT INTO ChiTietHoaDon(MaHoaDon, MaThucDon, SoLuongDat) VALUES ('" + maHD + "', '" + maThucDon + "', 1)";
            DBConnect.Instance.executeNonQuery(query);
        }

        // Hàm cập nhật hiển thị chi tiết hóa đơn
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

                string[] rowData = new string[] { stt.ToString(), tenThucDon, soLuongDat.ToString(), btnIncrease.ToString(), btnReduce.ToString(), thanhTien.ToString("0,000") };
                dataGridView1.Rows.Add(rowData);
                stt++;
            }
            if (maHD != null)
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
            }
        }
        // end cover onclick


        public f_ListMenu2()
        {
            InitializeComponent();
        }

        private void f_ListMenu2_Load(object sender, EventArgs e)
        {
            load_SP();
            load_Cbb();
            //load_DTGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // từ cbb đã lấy ra dc hoá đơn của bàn đó
            string qMaHD = "select MaHoaDon from HoaDon where GioKetThuc is null and MaBan ='" + comboBox1.SelectedValue.ToString() + "'";
            string MaHD = DBConnect.Instance.ExcuteScalar<string>(qMaHD);
            // lấy dc mã thực đơn và số lượng 
            int kq=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // thêm vào chi tiết hoá đơn với 3 tham số
                string q = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucDon, SoLuongDat) VALUES ("+MaHD+", '" + row.Cells[1].Value.ToString() +"', " + row.Cells[3].Value.ToString() + ")";
                kq = DBConnect.Instance.executeNonQuery(q);
            }   
            if(kq > 0) { MessageBox.Show("Thêm thành công"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maBan = comboBox1.SelectedValue.ToString();
            string maHD = GetMaHoaDonDangMo(maBan);
            CapNhatHienThiChiTietHoaDon(maHD);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maBan = comboBox1.SelectedValue.ToString();
            string maHD = GetMaHoaDonDangMo(maBan);

            string maTD = DBConnect.Instance.ExcuteScalar<string>("select MaThucDon from ThucDon where TenThucDon = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ");
            string maCTHD = DBConnect.Instance.ExcuteScalar<string>("select MaChiTietHoaDon from ChiTietHoaDon ct join ThucDon td on ct.MaThucDon = td.MaThucDon and MaHoaDon = 4 and ct.MaThucDon ='" + maTD + "'");
            
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnIncrease")
            {
                // cập nhật số lượng
                string q = "update ChiTietHoaDon set SoLuongDat += 1 where MaChiTietHoaDon = " + maCTHD + "";
                DBConnect.Instance.executeNonQuery(q);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnReduce")
            {
                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) == 1)
                {
                    string qr = "delete ChiTietHoaDon where MaChiTietHoaDon = '" + maCTHD + "'";
                    DBConnect.Instance.executeNonQuery(qr);
                }
                else
                {
                    // cập nhật số lượng
                    string q = "update ChiTietHoaDon set SoLuongDat -= 1 where MaChiTietHoaDon = " + maCTHD + "";
                    DBConnect.Instance.executeNonQuery(q);
                }
            }
            CapNhatHienThiChiTietHoaDon(maHD);
        }
    }
}
