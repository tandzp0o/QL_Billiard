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
    public partial class f_UpdateBan : Form
    {
        public f_UpdateBan()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maBanCanCapNhat = cboBan.SelectedValue.ToString();
            float giaMoi = float.Parse(txt_Gia.Text);
            string sql = "UPDATE Ban SET GIA= '" + giaMoi + "' WHERE MaBan = N'" + maBanCanCapNhat + "'";
            int kq = DBConnect.Instance.ExcuteNonQuery(sql);

            if (kq != 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
                this.Close();
            }
        }
        void loadCbbLoaiBan()
        {
            DataSet ds = new DataSet();
            string sql = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds, "Ban");
            cboBan.DataSource = ds.Tables[0];
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }

        private void f_UpdateBan_Load(object sender, EventArgs e)
        {
            loadCbbLoaiBan();
        }
    }
}
