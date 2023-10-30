using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_QL_Billiard.DAO;
using System.Text.RegularExpressions;

namespace APP_QL_Billiard
{
    public partial class fCreateMember : Form
    {
        public fCreateMember()
        {
            InitializeComponent();
        }

        public TextBox SDT { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0-9]");
            if (phoneNumpattern.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
            string sql = "insert into KhachHang(Ten, Phone) values (N'"+txtName.Text+"', '"+txtPhone.Text+"')";
            int k = DataProvider.Instance.ExcuteNonQuery(sql);
            if(k != 0)
            {
                MessageBox.Show("Ok");
            }    
        }

        private void fCreateMember_Load(object sender, EventArgs e)
        {
            if (SDT != null)
                txtPhone.Text = SDT.Text;
            string query = "select * from KhachHang";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            dtgvDSMember.DataSource = dt;
            txtPhone.Focus();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "delete DatTruoc where TrangThai = 1 or TrangThai = 2";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string query1 = "select count(*) from DatTruoc where Phone ="+txtPhone.Text;
            int k = DataProvider.Instance.ExcuteNonQuery(query);
            if(k <= 0 || k == null)
            {
                string query2 = "delete KhachHang where Phone = "+txtPhone.Text;
                DataTable a = DataProvider.Instance.ExcuteQuery(query);
            }
            string query3 = "select * from KhachHang";
            DataTable a2 = DataProvider.Instance.ExcuteQuery(query);
            dtgvDSMember.DataSource = a2;

        }

        private void dtgvDSMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDSMember.Rows[e.RowIndex];
                row.Selected = true;
            }
        }

        private void dtgvDSMember_MouseClick(object sender, MouseEventArgs e)
        {
            if(dtgvDSMember.SelectedRows != null)
            txtPhone.Text = dtgvDSMember.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dtgvDSMember.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
