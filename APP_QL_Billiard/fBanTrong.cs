using APP_QL_Billiard.DBconnect;
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
    public partial class fBanTrong : Form
    {
        public string maBan;

        private Label name;
        public fBanTrong()
        {
            InitializeComponent();
        }

        private void fBanTrong_Load(object sender, EventArgs e)
        {
            string q = "select * from Ban where TrangThai = 2";
            DataTable dt = DBConnect.Instance.ExcuteQuery(q);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                name = new Label();
                name.BorderStyle = BorderStyle.FixedSingle;
                name.Tag = dt.Rows[i]["MaBan"].ToString();
                name.Text = dt.Rows[i]["TenBan"].ToString();
                flowLayoutPanel1.Controls.Add(name);
                name.Click += new EventHandler(OnClick);
            }    
        }

        public void OnClick(object sender, EventArgs e) // hiển thị thông tin của bàn đã click
        {
            maBan = ((Label)sender).Tag.ToString();
            string q = "select TenBan from Ban where MaBan = '" + maBan + "'";
            string ten = DBConnect.Instance.ExcuteScalar<string>(q);
            MessageBox.Show("chuyển sang bàn:" + ten);
        }
    }
}
