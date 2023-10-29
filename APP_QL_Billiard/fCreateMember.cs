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
using System.Text.RegularExpressions;

namespace APP_QL_Billiard
{
    public partial class fCreateMember : Form
    {
        public fCreateMember()
        {
            InitializeComponent();
        }

        public TextBox SDT { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0-9]");
            if (phoneNumpattern.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
            string sql = "insert into KhachHang(Ten, Phone) values (N'"+txtName.Text+"', '"+txtPhone.Text+"')";
            int k = DataProvider.Instance.ExcuteNonQuery(sql);
            if(k != 0)
            {
                MessageBox.Show("Ok");
            }    
        }

        private void fCreateMember_Load(object sender, EventArgs e)
        {
            if (SDT != null)
                txtPhone.Text = SDT.Text;
        }
    }
}
