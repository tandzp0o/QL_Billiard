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
    public partial class f_TaoBan : Form
    {
        public f_TaoBan()
        {
            InitializeComponent();
        }

        void loadCbbLoaiBan()
        {
            string sql = "Select distinct LoaiBan from Ban";
            DataTable dt = DBConnect.Instance.ExcuteQuery(sql);
            cbbLoaiBan.DataSource = dt;
            cbbLoaiBan.DisplayMember = "LoaiBan";
            cbbLoaiBan.ValueMember = "LoaiBan";
        }
        private void f_TaoBan_Load(object sender, EventArgs e)
        {
            loadCbbLoaiBan();

        }

        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ", "đ"};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", "d"};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Ban = RemoveUnicode(cbbLoaiBan.SelectedValue.ToString());
            string ma = DBConnect.Instance.ExcuteScalar<string>("Select top 1 MaBan from Ban where LoaiBan = N'" + cbbLoaiBan.SelectedValue.ToString() + "' order by MaBan desc");
            string lastTwo = ma.Substring(ma.Length - 2);
            int stt = int.Parse(lastTwo);
            stt++;
            if (stt < 10)
            {
                lastTwo = "0" + stt; 
            }
            else
            {
                lastTwo = stt.ToString();
            }
            string maban = Ban.Substring(0, 2) + lastTwo;
            string tenban = "Bàn " + cbbLoaiBan.SelectedValue.ToString() + " " + stt;
            string sql = "insert into Ban(MaBan, TenBan, LoaiBan, gia, trangthai) values ('" + maban + "', N'" + tenban + "', N'" + cbbLoaiBan.SelectedValue.ToString() + "', " + textBox1.Text + ", 2)";
            int kq = DBConnect.Instance.ExcuteNonQuery(sql);
            if (kq != 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm không công", "Thông báo");
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
