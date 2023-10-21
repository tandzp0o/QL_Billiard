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

        public void formContent(Form content, Panel x)
        {
            if(child != null)
            {
                child.Close();
            }
            child = content;
            content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;
            x.Controls.Add(content);
            x.Tag = content;
            content.BringToFront();
            content.Show();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            namePage.Text = btnThucDon.Text + " Admin";
        }

        private void btnStatusBan_Click(object sender, EventArgs e)
        {
            namePage.Text = btnStatusBan.Text;

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            namePage.Text = btnHistory.Text;

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            namePage.Text = btnKho.Text;
            formContent(new f_NhapHang(),pn_Right);
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
