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
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace APP_QL_Billiard
{
    public partial class f_NhapHang : Form
    {
        public f_NhapHang()
        {
            InitializeComponent();
        }

        public f_ListThucDon F { get; set; }

        public f_NhapHang(f_ListThucDon f)
        {
            InitializeComponent();
            F = f;
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
            this.gbNH.Click += new EventHandler(gbNH_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDG.Text != string.Empty && txtSL.Text != string.Empty)
            {
                foreach (var item in cts)
                {
                    if(item.MaThucDon == cbbMH.SelectedValue.ToString())
                    {
                        MessageBox.Show("Đã tồn tại mặt hàng trong phiếu nhập này");
                        return;
                    }    
                }
                btnEdit.Visible = false;
                CTPN ctpn = new CTPN();
                ctpn.MaThucDon = cbbMH.SelectedValue.ToString();
                ctpn.SoLuong = int.Parse(txtSL.Text);
                ctpn.DonGia = int.Parse(txtDG.Text);
                cts.Add(ctpn);
                string[] row = { this.cbbMH.GetItemText(this.cbbMH.SelectedItem), ctpn.DonGia.ToString(), ctpn.SoLuong.ToString() };
                ListViewItem listViewI = new ListViewItem(row);
                listView1.Items.Add(listViewI);
                txtDG.Clear();
                txtSL.Clear();
                cbbMH.SelectedIndex = 0;
            }
            else MessageBox.Show("Vui lòng điền vào chỗ trống");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                CtpnDAO ctpnDAO = new CtpnDAO();
                if (ctpnDAO.addToCTPN(cts) != 0)
                {
                    btnAdd.Visible = true;
                    btnEdit.Visible = false;
                    cbbMH.Enabled = true;
                    txtDG.Clear();
                    txtSL.Clear();
                    cts.Clear();
                    listView1.Items.Clear();
                    cbbMH.SelectedIndex = 0;
                    F.loadThucDon();
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Thêm không thành công");
            }
            else MessageBox.Show("Không có thực đơn trong phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private ListViewItem listViewItem;

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.GetItemAt(e.X, e.Y) is ListViewItem)
            {
                if(e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
                listViewItem = listView1.GetItemAt(e.X, e.Y);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = cbbMH.FindStringExact(listViewItem.SubItems[0].Text);
                DataRowView drv = (DataRowView)cbbMH.Items[index];
                var cbbi = drv[0].ToString();
                foreach (var i in cts)
                {
                    if (i.MaThucDon == cbbi)
                    {
                        i.MaThucDon = cbbMH.SelectedValue.ToString();
                        i.SoLuong = int.Parse(txtSL.Text);
                        i.DonGia = int.Parse(txtDG.Text);
                        string[] row = { this.cbbMH.GetItemText(this.cbbMH.SelectedItem), i.DonGia.ToString(), i.SoLuong.ToString() };
                        for (int j = 0; j < row.Length; j++)
                        {
                            listView1.SelectedItems[0].SubItems[j].Text = row[j];
                        }
                        MessageBox.Show("Sửa thành công");
                        gbNH_Click(sender, e);
                        txtDG.Clear();
                        txtSL.Clear();
                        cbbMH.SelectedIndex = 0;
                        break;
                    }
                }
            }
            else MessageBox.Show("Cần chọn 1 dòng để sửa");
        }

        private void listView1_Leave(object sender, EventArgs e)
        {
              
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnAdd.Visible = false;
            int index = cbbMH.FindStringExact(listViewItem.SubItems[0].Text);
            cbbMH.SelectedIndex = index;
            txtDG.Text = listViewItem.SubItems[1].Text;
            txtSL.Text = listViewItem.SubItems[2].Text;
            cbbMH.Enabled = false;
        }

        private void f_NhapHang_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnAdd.Visible = true;
            cbbMH.Enabled = true;
        }

        private void cbbMH_Click(object sender, EventArgs e)
        {
            
        }
        private void gbNH_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items[listView1.SelectedIndices[0]].Selected = false;
            }
            btnEdit.Visible = false;
            btnAdd.Visible = true;
            cbbMH.Enabled = true;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cts.RemoveAt(listView1.SelectedIndices[0]);
            listView1.Items[listView1.SelectedIndices[0]].Remove();
        }
    }
}
