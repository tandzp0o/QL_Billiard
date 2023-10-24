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

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
               
            if(txtSDT.Text.Trim().Length>0 && !Char.IsDigit(txtSDT.Text[txtSDT.Text.Length -1]))
            {
                MessageBox.Show("Hãy Nhập Số", "Thông Báo");
                txtSDT.Text = txtSDT.Text.Substring(0,txtSDT.Text.Length-1);
                txtSDT.SelectionStart = txtSDT.Text.Length;
            }    
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

        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            GioToi.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);
            cbbTypeTable.SelectedIndex = 0;
        }
    }
}
