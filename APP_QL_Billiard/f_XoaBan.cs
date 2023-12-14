using APP_QL_Billiard.DBconnect;
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

namespace APP_QL_Billiard
{
    public partial class f_XoaBan : Form
    {
        public f_XoaBan()
        {
            InitializeComponent();
        }

      

        public void loadCboTable()
        {
            DataSet ds = new DataSet();
            string sql = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds, "Ban");
            cboTenBan.DataSource = ds.Tables[0];
            cboTenBan.DisplayMember = "TenBan";
            cboTenBan.ValueMember = "MaBan";
        }

        private void f_XoaBan_Load(object sender, EventArgs e)
        {

            loadCboTable();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maBanCanXoa = cboTenBan.SelectedValue.ToString();
            string sql = "DELETE FROM Ban WHERE MaBan = N'" + maBanCanXoa + "'";
            int kq = DBConnect.Instance.ExcuteNonQuery(sql);

            if (kq != 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
