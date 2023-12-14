using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard
{
    public partial class fFunction_Ban : Form
    {


        public Ban Ban1 { get; set; }
        public fFunction_Ban()
        {
            InitializeComponent();


        }
        public fFunction_Ban(Ban a)
        {
            InitializeComponent();
            Ban1 = a;
        }

        public void ShowBill(string id)
        {

            List<ThucDon> ListChiTietBill = ThucDonDAO.Instance.GetListMenuByTable(id);
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Tên món", typeof(string));
            dataTable.Columns.Add("Đơn vị tính", typeof(string));
            dataTable.Columns.Add("Gía", typeof(double));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Tạm tính", typeof(double));

            foreach (ThucDon item in ListChiTietBill)
            {
                dataTable.Rows.Add(item.Name.ToString(), item.Unit.ToString(), item.Price.ToString(), item.Amount.ToString(), item.TotalPrice.ToString());
            }
            dgvMenu.DataSource = dataTable;
            dgvMenu.Columns["Tên món"].Width = 150;  // Độ rộng mong muốn
            dgvMenu.Columns["Đơn vị tính"].Width = 60;
            dgvMenu.Columns["Gía"].Width = 60;
            dgvMenu.Columns["Số lượng"].Width = 50;
            dgvMenu.Columns["Tạm tính"].Width = 120;
        }
        public void reLoad()
        {
            if (Ban1 != null)
            {
                txt_TenBan.Text = Ban1.Name.ToString();
                txtTimeStart.Text = Ban1.GioBD.ToString("HH:mm:ss   dd/MM/yyyy");
                if (Ban1.Status == 2 || Ban1.Status == 3) //1hd 2 trong 3 dat truoc
                {
                    btnEnd.Enabled = false;
                    btnStart.Enabled = true;
                    btnChange.Enabled = false;
                    txtTimeStart.Text = "";
                    txtTimeEnd.Text = "";
                    if (string.Compare(Ban1.Type, "Lỗ") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                        //CHEN PIC CUA LOAI BAN BIDA
                    }
                    else if (string.Compare(Ban1.Type, "Lip") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                    else //Carom
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                }
                else
                {
                    string query = "select GioBatDau from HoaDon where MaBan ='" + Ban1.ID + "' and GioKetThuc IS NULL";
                    string a = DBConnect.Instance.ExcuteScalar<string>(query);
                    txtTimeStart.Text = a;

                    btnChange.Enabled = true;
                    txtTimeStart.Enabled = false;
                    btnStart.Enabled = false;
                    btnEnd.Enabled = true;

                    if (string.Compare(Ban1.Type, "Lỗ") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.; // kHUC NAY SE CHEN PIC CUA LOAI BAN BIDA
                    }
                    else if (string.Compare(Ban1.Type, "Lip") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                    else //Carom
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                }
            }


        }
        //public void updateBan(Ban b)
        //{
        //    new BanDAO().updateBan(b);
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtTimeStart.Text = Ban1.GioBD.ToString("HH:mm:ss   dd/MM/yyyy");
            txtTimeEnd.Text = "";
            Ban1.Status = 1;
            btnTinh.Enabled = false;
            string insertHoaDonQuery = "INSERT INTO HoaDon (MaBan, GioBatDau) VALUES ('@maBan', '@gioBD')";
            insertHoaDonQuery = insertHoaDonQuery.Replace("@maBan", Ban1.ID);
            insertHoaDonQuery = insertHoaDonQuery.Replace("@gioBD", date.ToString("HH:mm:ss   dd/MM/yyyy")); // Định dạng ngày giờ cho SQL

            int result = DBConnect.Instance.ExcuteNonQuery(insertHoaDonQuery);

            // Thêm trường Status của bảng Ban vào câu truy vấn UPDATE
            string updateBanStatusQuery = "UPDATE Ban SET TrangThai = 1 WHERE MaBan = '@maBan'";
            updateBanStatusQuery = updateBanStatusQuery.Replace("@maBan", Ban1.ID);
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery);

            if (result > 0)
            {
                MessageBox.Show("Đã tạo hóa đơn mới cho bàn " + Ban1.ID);
                Ban1.GioBD = date;
                this.reLoad();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi tạo hóa đơn.");
            }
            this.reLoad();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            Ban1.GioKT = date;
            txtTimeEnd.Text = Ban1.GioKT.ToString("yyyy-MM-dd HH:mm:ss");
            Ban1.Status = 1;
            txtTimeEnd.Enabled = false;
            btnTinh.Enabled = true;

            string updateBanStatusQuery = "UPDATE Ban SET TrangThai = 2 WHERE MaBan = '@maBan'";
            updateBanStatusQuery = updateBanStatusQuery.Replace("@maBan", Ban1.ID);
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery);

            string query = "select MaHoaDon from HoaDon where MaBan ='" + Ban1.ID + "' and GioKetThuc IS NULL";
            string a = DBConnect.Instance.ExcuteScalar<string>(query);

            string updateBanStatusQuery1 = "UPDATE HOADON SET GioKetThuc = '"+date.ToString()+ "' WHERE MaHoaDon = '@maHD'";
            updateBanStatusQuery1 = updateBanStatusQuery1.Replace("@maHD",a);
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery1);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string query = "select GioBatDau from HoaDon where MaBan ='" + Ban1.ID + "'";
            DateTime a = DBConnect.Instance.ExcuteScalar<DateTime>(query);
            string query1 = "select GioKetThuc from HoaDon where MaBan ='" + Ban1.ID + "'";
            DateTime b = DBConnect.Instance.ExcuteScalar<DateTime>(query1);

            DateTime date = a;
            DateTime date2 = b;
            double m = (date2 - date).TotalMinutes;

            int hour = (int)(m / 60);

            int minute = (int)(m % 60);

            txtGio.Text = hour + " giờ " + minute + " phút";

            string query2 = "SELECT Gia FROM Ban WHERE MaBan = '" + Ban1.ID + "' ";
            int c = DBConnect.Instance.ExcuteScalar<int>(query2);
            int gia = (int)(m * c) / 60;
            txtGia.Text = gia + ".00 VND";
            btnPay.Enabled = true;

            //Them phuong thuc push data vao SQL
            string query3 = "select MaHoaDon from HoaDon where MaBan ='" + Ban1.ID + "' and GioKetThuc IS NULL";
            string mahd = DBConnect.Instance.ExcuteScalar<string>(query3);

            string updateHoaDonQuery = "UPDATE HoaDon SET ThoiGianChoi='" + (int)m + "' WHERE MaHoaDon = '@maHD'";
            updateHoaDonQuery = updateHoaDonQuery.Replace("@maHD", mahd);
            updateHoaDonQuery = updateHoaDonQuery.Replace("@gioKT", date2.ToString("yyyy-MM-dd HH:mm:ss")); // Định dạng ngày giờ cho SQL
            DBConnect.Instance.ExcuteNonQuery(updateHoaDonQuery);

            int tt = (int)gia;
            string updateHoaDonQuery1 = "UPDATE HoaDon SET ThanhToan = '" + tt + "',TaiKhoan='" + Account.Instance.TaiKhoan + "' WHERE MaHoaDon = '@maHD'";
            updateHoaDonQuery1 = updateHoaDonQuery1.Replace("@maHD", mahd);
            DBConnect.Instance.ExcuteNonQuery(updateHoaDonQuery1);

            string updateBanStatusQuery2 = "UPDATE Ban SET TrangThai = 2 WHERE MaBan = '@maBan'";
            updateBanStatusQuery2 = updateBanStatusQuery2.Replace("@maBan", Ban1.ID);
            DBConnect.Instance.ExcuteNonQuery(updateBanStatusQuery2);
            this.reLoad();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            f_ThanhToan thanhToanForm = new f_ThanhToan(Ban1.ID);
            thanhToanForm.Show();
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
                MessageBox.Show("Chọn bàn đi");
            }
        }

    }
}
