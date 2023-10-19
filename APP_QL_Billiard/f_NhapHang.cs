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
using System.Data;
using System.Data.SqlClient;

namespace APP_QL_Billiard
{
    public partial class f_NhapHang : Form
    {
        public f_NhapHang()
        {
            InitializeComponent();
        }

        void loadMH()
        {
            DataSet ds = new DataSet();
            string sql = "select * from thucdon";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds, "ThucDon");
            cbbMH.DataSource = ds.Tables[0];
            cbbMH.DisplayMember = "TenThucDon";
            cbbMH.ValueMember = "MaThucDon";
        }
        private void f_NhapHang_Load(object sender, EventArgs e)
        {
            loadMH();
        }
    }
}
