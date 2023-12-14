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
using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.Properties;


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
                if(AccountDAO.Instance.CheckADM())
                {
                    fTable_Manager_ADM f = new fTable_Manager_ADM();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fTable_Manager f1 = new fTable_Manager();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
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
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtMK.UseSystemPasswordChar == true)
            {
                txtMK.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.action_display_password_512;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.action_hide_password;

            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text == string.Empty)
            {
                pictureBox1.Visible = false;
            }
            else
                pictureBox1.Visible = true;
        }
    }
}
