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
            DataSet ds = new DataSet();
            string sql = "Select t.Thang, ISNULL(DoanhThu, 0) as 'DoanhThu', ISNULL(c.Chi,0) as 'Chi' from dbo.DoanhThu() t, dbo.Chi() c where t.Thang = c.Thang";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds);
            chartTC.DataSource = ds;
            chartTC.Titles["Title1"].Text = "Biểu đồ thu chi theo từng tháng";
            chartTC.ChartAreas[0].AxisX.Maximum = 12;
            chartTC.ChartAreas[0].AxisX.Title = "Tháng";
            chartTC.ChartAreas[0].AxisY.Title = "VND";
            chartTC.Series["Thu"].XValueMember = "Thang";
            chartTC.Series["Chi"].XValueMember = "Thang";
            chartTC.Series["Thu"].YValueMembers = "DoanhThu";
            chartTC.Series["Chi"].YValueMembers = "Chi";
        }
        void loadDoanhThu()
        {
            DataSet ds = new DataSet();
            string sql = "Select Thang, ISNULL(dbo.DoanhThuThang(Thang), 0) - ISNULL(dbo.ChiThang(Thang),0) as DoanhThu from dbo.DoanhThu()";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds);
            chartDT.DataSource = ds;
            chartDT.Titles["Title1"].Text = "Biểu đồ doanh thu theo từng tháng";
            chartDT.ChartAreas[0].AxisX.Maximum = 12;
            chartDT.ChartAreas[0].AxisX.Title = "Tháng";
            chartDT.ChartAreas[0].AxisY.Title = "VND";
            chartDT.Series["s1"].XValueMember = "Thang";
            chartDT.Series["s1"].YValueMembers = "DoanhThu";
        }
        private void f_ThongKe_Load(object sender, EventArgs e)
        {
            loadTiLeDatBan();
            loadThuChi();
            loadDoanhThu();
        }
    }
}
