using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_QL_Billiard.DTO;
using APP_QL_Billiard.DAO;

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

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            namePage.Text = btnThucDon.Text + " Admin";
            table_panel.Controls.Clear();
            //formContent(new f_ListMenu(),new Form(), table_panel);

        }

        private void btnStatusBan_Click(object sender, EventArgs e)
        {
            fFunction_Ban f = new fFunction_Ban();
            namePage.Text = btnStatusBan.Text;
            table_panel.Controls.Clear();
            formContent(f,new f_ListTable(f), table_panel, table_panel);
        }
        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            fListDatTruoc f = new fListDatTruoc();

            namePage.Text = btnDatTruoc.Text;
            table_panel.Controls.Clear();
            formContent(new fDatTruoc(f), f, table_panel, table_panel);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            namePage.Text = btnHistory.Text;
            table_panel.Controls.Clear();
            formContent(new fLichSu(),new Form(), table_panel);

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            f_ListThucDon f = new f_ListThucDon();
            namePage.Text = btnKho.Text;
            table_panel.Controls.Clear();
            formContent(new f_NhapHang(f), f, table_panel, table_panel);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            namePage.Text = btnEmployee.Text;
            table_panel.Controls.Clear();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
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
            DataProvider.Instance.ExecuteProcedure(query);
        }

        private void fTable_Manager_ADM_Load(object sender, EventArgs e)
        {
            GioHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            TenNhanVien.Text = "Nhân Viên: " + AccountDAO.Instance.HoTen;

            string query = "dbo.TrangThaiBan";
            DataProvider.Instance.ExecuteProcedure(query);
        }

        private void btnDKMember_Click(object sender, EventArgs e)
        {
            namePage.Text = btnDKMember.Text;
            table_panel.Controls.Clear();
            formContent(new fCreateMember(), new Form(), table_panel, null);

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.TaiKhoan = string.Empty;
            AccountDAO.Instance.MatKhau = string.Empty;
            AccountDAO.Instance.HoTen = string.Empty;
            AccountDAO.Instance.SDT = string.Empty;
            AccountDAO.Instance.IsQuanLy = false;
            this.Close();
        }
    }
}
