using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard
{
    public partial class fTable_Manager_ADM : Form
    {
        public fTable_Manager_ADM()
        {
            InitializeComponent();
        }

        public Form child;
        public Form child2;

        public void formContent(Form content, Form content2, Panel x, Panel y)
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
            y.Controls.Add(content2);
            y.Tag = content2;
            content.BringToFront();
            content.Show();
            content2.BringToFront();
            content2.Show();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            namePage.Text = btnThucDon.Text + " Admin";
        }

        private void btnStatusBan_Click(object sender, EventArgs e)
        {
            namePage.Text = btnStatusBan.Text;
            formContent(new f_ListTable(), new fChiTietBan(), pn_center, pn_Right);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            namePage.Text = btnHistory.Text;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            namePage.Text = btnKho.Text;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            namePage.Text = btnEmployee.Text;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            namePage.Text = btnThongKe.Text;

        }
    }
}
