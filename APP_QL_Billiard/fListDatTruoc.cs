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
            string query = "select MaBan, ThoiGianToi, NgayDat from DatTruoc";
            DataTable a = DataProvider.Instance.ExcuteQuery(query);
            dtgvDatTruoc.DataSource = a;
        }
    }
}
