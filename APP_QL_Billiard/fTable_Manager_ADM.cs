using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using APP_QL_Billiard.DBconnect;

namespace APP_QL_Billiard
{
    public partial class fTable_Manager_ADM : Form
    {

        //public static List<ListThucDon.> = new List<ListThucDon>();
        public fTable_Manager_ADM()
        {
            InitializeComponent();
        }

        public Form child;
        public Form child2;

        public void formContent(Form content, Form content2, TableLayoutPanel x, TableLayoutPanel y = null)
        {
            if(child != null && child2 != null)
            {
                child.Close();
                child2.Close();
            }
            child = content;
            child2 = content;
            content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;
            content2.TopLevel = false;
            content2.FormBorderStyle = FormBorderStyle.None;
            content2.Dock = DockStyle.Fill;
            x.Controls.Add(content);
            x.Tag = content;
            if(y != null)
            {
                y.Controls.Add(content2);
                y.Tag = content2;
            }    
            content.BringToFront();
            content.Show();
            content2.BringToFront();
            content2.Show();
        }
        public void form1Content(Form content, TableLayoutPanel panel)
        {
            // Close any existing forms in the panel(s)
            if (panel.Controls.Count > 0)
            {
                foreach (Control existingForm in panel.Controls)
                {
                    if (existingForm is Form)
                    {
                        ((Form)existingForm).Close();
                    }
                }
            }

            // Set properties for the new form
            content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;

            // Add the form to the panel
            panel.Controls.Add(content);
            panel.Tag = content;

            // Bring the form to front and show it
            content.BringToFront();
            content.Show();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            table_panel.ColumnCount = 1;
            namePage.Text = btnThucDon.Text + " Admin";
            table_panel.Controls.Clear();
            form1Content(new f_ListMenu2(), table_panel);

        }

        private void btnStatusBan_Click(object sender, EventArgs e)
        {
            table_panel.ColumnCount = 1;
            fFunction_Ban f = new fFunction_Ban();
            namePage.Text = btnStatusBan.Text;
            table_panel.Controls.Clear();
            form1Content(new f_ListTable2(), table_panel);
        }
        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            table_panel.ColumnCount = 2;
            fListDatTruoc f = new fListDatTruoc();

            namePage.Text = btnDatTruoc.Text;
            table_panel.Controls.Clear();
            formContent(new fDatTruoc(f), f, table_panel, table_panel);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //table_panel.ColumnCount = 2;
            namePage.Text = btnHistory.Text;
            table_panel.Controls.Clear();
            formContent(new fLichSu(),new Form(), table_panel);

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            table_panel.ColumnCount = 2;
            f_ListThucDon f = new f_ListThucDon();
            namePage.Text = btnKho.Text;
            table_panel.Controls.Clear();
            formContent(new f_NhapHang(f), f, table_panel, table_panel);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //table_panel.ColumnCount = 2;
            f_QuanLyNV f = new f_QuanLyNV();
            namePage.Text = btnEmployee.Text;
            table_panel.Controls.Clear();
            formContent(new f_QuanLyNV(), new Form(), table_panel);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            table_panel.ColumnCount = 2;
            namePage.Text = btnThongKe.Text;
            table_panel.Controls.Clear();
            formContent(new f_ThongKe(), new f_DoanhThu(), table_panel, table_panel);

        }


        private void btnThucDon_MouseHover(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GioHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string query = "dbo.TrangThaiBan";
            DBConnect.Instance.ExecuteProcedure(query);
        }

        private void fTable_Manager_ADM_Load(object sender, EventArgs e)
        {
            // hiện trang đầu
            table_panel.ColumnCount=1;
            form1Content(new f_ListMenu2(), table_panel);
            GioHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            TenNhanVien.Text = "Nhân Viên: " + Account.Instance.HoTen;

            string query = "dbo.TrangThaiBan";
            DBConnect.Instance.ExecuteProcedure(query);
        }

        private void btnDKMember_Click(object sender, EventArgs e)
        {
            namePage.Text = btnDKMember.Text;
            table_panel.Controls.Clear();
            formContent(new fCreateMember(), new Form(), table_panel, null);

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Account.Instance.TaiKhoan = string.Empty;
            Account.Instance.MatKhau = string.Empty;
            Account.Instance.HoTen = string.Empty;
            Account.Instance.SDT = string.Empty;
            Account.Instance.IsQuanLy = false;
            this.Close();
        }

        private void fTable_Manager_ADM_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
