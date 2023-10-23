using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace APP_QL_Billiard
{
    public partial class f_ThongKe : Form
    {
        public f_ThongKe()
        {
            InitializeComponent();
        }
        void loadTiLeDatBan()
        {
            DataSet ds = new DataSet();
            string sql = "select * from dbo.TinhTyLeDatBan() where TyLeDatBan > 0";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds);
            chartDB.Titles["Title1"].Text = "Tỉ lệ đặt bàn";
            chartDB.DataSource = ds;
            chartDB.Series["s1"].LabelFormat = "#";
            chartDB.Series["s1"].Label = "#PERCENT";
            chartDB.Series["s1"].LegendText = "#VALX";
            chartDB.Series["s1"].XValueMember = "LoaiBan";
            chartDB.Series["s1"].YValueMembers = "TyLeDatBan";
        }
        void loadThuChi()
        {
            DataSet ds1 = new DataSet();
            string sql = "Select";
        }
        private void f_ThongKe_Load(object sender, EventArgs e)
        {
            loadTiLeDatBan();
        }
    }
}
