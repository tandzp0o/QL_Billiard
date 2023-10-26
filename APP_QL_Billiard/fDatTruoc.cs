using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using APP_QL_Billiard.DAO;

namespace APP_QL_Billiard
{
    public partial class fDatTruoc : Form
    {
        public fDatTruoc()
        {
            InitializeComponent();
        }

        private void fDatTruoc_Load(object sender, EventArgs e)
        {
            GioToi.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);
            List<string> loai = new List<string> {"Chọn", "Lỗ", "Lip", "Carom"};
            cbbTypeTable.DataSource = loai;
            cbbTypeTable.DisplayMember = "TypeTable";
        }

        private void cbbTypeTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Ban where LoaiBan = N'" + cbbTypeTable.SelectedItem.ToString() + "' and TrangThai = 2";
            DataTable a = DataProvider.Instance.ExcuteQuery(query);   
            cbbEmptyTable.DataSource = a;
            cbbEmptyTable.DisplayMember = "TenBan";
            cbbEmptyTable.ValueMember = "MaBan";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text == string.Empty || cbbTypeTable.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin","Thông Báo");
                return;
            }    
            if (txtMaKH.Text != string.Empty)
            {
                if (GioToi.Value.TimeOfDay < DateTime.Now.TimeOfDay)
                    NgayHienTai.Value = NgayHienTai.Value.AddDays(1);
                string query = "insert into DatTruoc values (" + txtMaKH.Text + ", '" + cbbEmptyTable.SelectedValue.ToString() + "','" + NgayHienTai.Value.ToString("MM/dd/yyyy") +" "+ GioToi.Text + "' ,'" + DateTime.Now.ToString("MM/dd/yyyy") + "' )";
                int k = DataProvider.Instance.ExcuteNonQuery(query);
                if (NgayHienTai.Value > DateTime.Now)
                    NgayHienTai.Value = DateTime.Now;
                if (k != 0)
                {
                    MessageBox.Show("Đặt thành công");
                }
                else
                    MessageBox.Show("Đặt không thành công");
            }
            else
            {
                DialogResult r = MessageBox.Show("chưa có khách hàng, bạn có muốn đăng ký thành viên mới?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(r == DialogResult.Yes)
                {
                    fCreateMember a = new fCreateMember();
                    a.SDT = txtSDT;
                    a.Show();
                }    
            }    
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            GioToi.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);
            cbbTypeTable.SelectedIndex = 0;
        }


        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string query = "select * from KhachHang where Phone = '" + txtSDT.Text + "'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if(dt.Rows.Count != 0)
            {
                txtTenKH.Text = dt.Rows[0].Field<string>("Ten");
                txtMaKH.Text = dt.Rows[0].Field<int>("Id").ToString();
            }    
        }

        private void GioToi_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
