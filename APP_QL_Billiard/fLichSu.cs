using APP_QL_Billiard.DAO;
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
            string query = "select TaiKhoan from Account";
            DataTable a = DataProvider.Instance.ExcuteQuery(query);
            cbbNhanVien.DataSource = a;
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "TaiKhoan";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

        }
    }
}
