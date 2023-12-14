using APP_QL_Billiard.DBconnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard
{
    public partial class f_QuanLyNV : Form
    {
        public DataTable GetAllEmployees()
        {
            string sql = "select TaiKhoan, HoTen, SDT, TinhTrang from Account";
            return DBConnect.Instance.getDataTable(sql);
        }

        public int AddEmployee(string taiKhoan, string matkhau, string hoTen, string sdt, string tinhTrang)
        {
            string sql = "insert into Account (TaiKhoan, MatKhau, HoTen, SDT, TinhTrang) VALUES ('" + taiKhoan + "', " + matkhau + ", N'" + hoTen + "', '" + sdt + "', N'" + tinhTrang + "')";
            return DBConnect.Instance.executeNonQuery(sql);
        }

        public int UpdateEmployee(string taiKhoan, string hoTen, string sdt, string tinhTrang)
        {
            string sql = "update Account set HoTen = N'" + hoTen + "', SDT = '" + sdt + "', TinhTrang = N'" + tinhTrang + "' WHERE TaiKhoan = '" + taiKhoan + "'";
            return DBConnect.Instance.executeNonQuery(sql);
        }
        //private NhanVienDAO nv;
        public f_QuanLyNV()
        {
            InitializeComponent();
            LoadDataToDGV();
        }

        private void ClearTextBoxes()
        {
            txt_taiKhoan.Text = "";
            txt_hoTen.Text = "";
            txt_sdt.Text = "";
            txt_tinhTrang.Text = "";
        }

        private void EnableTextBoxes()
        {
            txt_taiKhoan.Enabled = true;
            txt_hoTen.Enabled = true;
            txt_sdt.Enabled = true;
            txt_tinhTrang.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            txt_taiKhoan.Enabled = false;
            txt_hoTen.Enabled = false;
            txt_sdt.Enabled = false;
            txt_tinhTrang.Enabled = false;
        }

        private void f_QuanLyNV_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToDGV()
        {
            dgv_dsnv.DataSource = GetAllEmployees();
        }

        private void dgv_dsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsnv.Rows[e.RowIndex];
                txt_taiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                txt_hoTen.Text = row.Cells["HoTen"].Value.ToString();
                txt_sdt.Text = row.Cells["SDT"].Value.ToString();
                txt_tinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            txt_matKhau.Enabled = true;
            txt_taiKhoan.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_taiKhoan.Text;
            string matkhau = txt_matKhau.Text;
            string hoTen = txt_hoTen.Text;
            string sdt = txt_sdt.Text;
            string tinhTrang = txt_tinhTrang.Text;

            AddEmployee(taiKhoan, matkhau, hoTen, sdt, tinhTrang);
            LoadDataToDGV();
            ClearTextBoxes();
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_taiKhoan.Text;
            string hoTen = txt_hoTen.Text;
            string sdt = txt_sdt.Text;
            string tinhTrang = txt_tinhTrang.Text;

            UpdateEmployee(taiKhoan, hoTen, sdt, tinhTrang);
            LoadDataToDGV();
            ClearTextBoxes();
        }
        
    }
}
