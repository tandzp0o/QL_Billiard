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

namespace APP_QL_Billiard
{
    public partial class fListDatTruoc : Form
    {
        public fListDatTruoc()
        {
            InitializeComponent();
        }

        private void btnWatchAll_Click(object sender, EventArgs e)
        {
            string query = "select TenBan, ThoiGianToi, NgayDat from DatTruoc dt, Ban b where dt.MaBan = b.MaBan and dt.TrangThai = 0";
            loaddtgv(query);
        }

        public void loaddtgv(string query)
        {
            DataTable a = DataProvider.Instance.ExcuteQuery(query);
            dtgvDatTruoc.DataSource = a;
            dtgvDatTruoc.Columns[0].HeaderText = "Tên Bàn";
            dtgvDatTruoc.Columns[1].HeaderText = "Giờ Tới";
            dtgvDatTruoc.Columns[2].HeaderText = "Ngày Đặt";
        }

        private void fListDatTruoc_Load(object sender, EventArgs e)
        {
            string query = "select TenBan, ThoiGianToi, NgayDat from DatTruoc dt, Ban b where dt.MaBan = b.MaBan and dt.TrangThai = 0";
            loaddtgv(query);
            dateTimePicker1.Text = "00:00";
            dateTimePicker2.Text = "00:00";
        }

        private void btnWatchFrom_Click(object sender, EventArgs e)
        {
            string query = "select TenBan, ThoiGianToi, NgayDat from DatTruoc dt, Ban b where dt.MaBan = b.MaBan and ThoiGianToi >='" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and ThoiGianToi <='" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'";
            loaddtgv(query);
        }
    }
}
