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
    public partial class fLichSu : Form
    {
        public fLichSu()
        {
            InitializeComponent();
        }

        private void fLichSu_Load(object sender, EventArgs e)
        {
            string query1 = "";
            if(AccountDAO.Instance.IsQuanLy)
            {
                string query = "select TaiKhoan from Account";
                DataTable a = DBConnect.Instance.ExcuteQuery(query);
                DataRow b = a.NewRow();
                b[0] = "Tất Cả";
                a.Rows.InsertAt(b,0);
                cbbNhanVien.DataSource = a;
                cbbNhanVien.DisplayMember = "HoTen";
                cbbNhanVien.ValueMember = "TaiKhoan";
                query1 = "select * from HoaDon";
            }    
            else
            {
                cbbNhanVien.Items.Add(AccountDAO.Instance.TaiKhoan);
                query1 = "select * from HoaDon where TaiKhoan = '"+ AccountDAO.Instance.TaiKhoan + "'";
            }    
            dataGridView1_Load(query1);
            cbbNhanVien.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string query = ""; 
            if(cbbNhanVien.SelectedIndex == 0 && AccountDAO.Instance.IsQuanLy)
            {
                query = "select * from HoaDon where GioKetThuc >= '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and GioKetThuc <= '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'";

            }
            else
            {
                query = "select * from HoaDon where GioKetThuc >= '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and GioKetThuc <= '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' and TaiKhoan = '"+cbbNhanVien.SelectedValue+"'";
            }    
            dataGridView1_Load(query);
        }

        private void dataGridView1_Load(string query)
        {
            DataTable a = DBConnect.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = a;
            dataGridView1.Columns[0].HeaderText = "Mã Hoá Đơn";
            dataGridView1.Columns[1].HeaderText = "Mã Bàn";
            dataGridView1.Columns[2].HeaderText = "Giờ Bắt Đầu";
            dataGridView1.Columns[3].HeaderText = "Giờ Kết Thúc";
            dataGridView1.Columns[4].HeaderText = "Thời Gian Chơi";
            dataGridView1.Columns[5].HeaderText = "Tiền Thanh Toán";
            dataGridView1.Columns[6].HeaderText = "Khách Hàng";
            dataGridView1.Columns[7].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[8].HeaderText = "Tài Khoản Thanh Toán";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string query = "select * from HoaDon";
            dataGridView1_Load(query);
        }
    }
}
