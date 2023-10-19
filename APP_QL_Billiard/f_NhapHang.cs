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
using APP_QL_Billiard.DTO;
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

        List<CTPN> cts = new List<CTPN>();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CTPN ctpn = new CTPN();
            ctpn.MaThucDon = cbbMH.SelectedValue.ToString();
            ctpn.SoLuong = int.Parse(txtSL.Text);
            ctpn.DonGia = int.Parse(txtDG.Text);
            cts.Add(ctpn);
            string[] row = { this.cbbMH.GetItemText(this.cbbMH.SelectedItem), ctpn.DonGia.ToString(), ctpn.SoLuong.ToString() };
            ListViewItem listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CtpnDAO ctpnDAO = new CtpnDAO();
            if (ctpnDAO.addToCTPN(cts) != 0)
            {
                txtDG.Clear();
                txtSL.Clear();
                cts.Clear();
                listView1.Items.Clear();
                cbbMH.SelectedIndex = 0;
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Thêm không thành công");
        }
    }
}
