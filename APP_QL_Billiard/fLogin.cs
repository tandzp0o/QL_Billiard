using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using APP_QL_Billiard.DAO;

namespace APP_QL_Billiard
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }


        public bool Login(string tk, string mk)
        {
            return AccountDAO.Instance.Login(tk, mk);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtTK.Text, txtMK.Text))
            {
                if(AccountDAO.Instance.CheckADM(txtTK.Text))
                {
                    fTable_Manager_ADM f = new fTable_Manager_ADM();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fTable_Manager f1 = new fTable_Manager();
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
