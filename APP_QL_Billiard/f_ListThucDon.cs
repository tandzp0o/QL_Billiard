using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using APP_QL_Billiard.DAO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_QL_Billiard
{
    public partial class f_ListThucDon : Form
    {
        public f_ListThucDon()
        {
            InitializeComponent();
        }
        
        public void loadThucDon()
        {
            DataSet ds = new DataSet();
            string sql = "Select MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia, Hinh from ThucDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds);
            dgvThucDon.DataSource = ds.Tables[0];
            dgvThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvThucDon.Columns[1].HeaderText = "Tên thực đơn";
            dgvThucDon.Columns[2].HeaderText = "Đơn vị tính";
            dgvThucDon.Columns[3].HeaderText = "Số lượng";
            dgvThucDon.Columns[4].HeaderText = "Đơn giá";
            dgvThucDon.Columns[5].HeaderText = "Hình ảnh";
        }
        void loadDonViTinh()
        {
            DataSet ds = new DataSet();
            string sql = "Select distinct DonViTinh from thucdon";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds);
            cbbDVT.DataSource = ds.Tables[0];
            cbbDVT.DisplayMember = "DonViTinh";
            cbbDVT.ValueMember = "DonViTinh";
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.png; *.bmp;)|*.jpg; *.gif; *.jpeg; *.png; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
                txtPicName.Text = Path.GetFileName(txtPic.Text);
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPrice.Name == string.Empty)
            {
                MessageBox.Show("Vui lòng điền vào các trường trống", "Thông báo");
                return;
            }
            if(txtPic.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập hình ảnh", "Thông báo");
                return;
            }    
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string imgPath = Path.Combine(projectDirectory, "HinhMatHang");

            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }
            File.Copy(txtPic.Text, Path.Combine(imgPath, Path.GetFileName(txtPic.Text)), true);
            string imgName = Path.GetFileName(txtPic.Text);
            string ma = DataProvider.Instance.ExcuteScalar<string>("Select top 1 MaThucDon from thucdon order by MaThucDon desc");
            int stt = int.Parse(ma.Substring(ma.Length - 2));
            stt++;
            if (stt < 10)
                ma = ma.Substring(0, 2) + "0" + stt;
            else
                ma = ma.Substring(0, 2) + stt;
            string sql = "INSERT INTO ThucDon (MaThucDon, TenThucDon, DonViTinh, SoLuong, Gia, Hinh) VALUES ('"+ma+"', N'"+txtName.Text+"', N'"+cbbDVT.SelectedValue.ToString()+"', "+txtSL.Text+", "+txtPrice.Text+", '"+imgName+"')";
            int kq = DataProvider.Instance.ExcuteNonQuery(sql);
            if(kq > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
            loadThucDon();
            loadDonViTinh();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void f_ListThucDon_Load(object sender, EventArgs e)
        {
            loadThucDon();
            loadDonViTinh();
            dgvThucDon.ClearSelection();
        }

        void clearAll()
        {
            txtPic.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPicName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtSL.Text = string.Empty;
            cbbDVT.SelectedIndex = 0;
            pictureBox1.Image = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
            btnEdit.Visible = false;
        }

        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                clearAll();
                txtName.Text = dgvThucDon.SelectedRows[0].Cells[1].Value.ToString();
                txtPrice.Text = dgvThucDon.SelectedRows[0].Cells[4].Value.ToString();
                txtSL.Text = dgvThucDon.SelectedRows[0].Cells[3].Value.ToString();
                int index = cbbDVT.FindStringExact(dgvThucDon.SelectedRows[0].Cells[2].Value.ToString());
                cbbDVT.SelectedIndex = index;
                txtPicName.Text = dgvThucDon.SelectedRows[0].Cells[5].Value.ToString();
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string imgPath = Path.Combine(projectDirectory, "HinhMatHang", txtPicName.Text);
                if(File.Exists(imgPath))
                {
                    txtPic.Text = imgPath;
                    pictureBox1.Image = Image.FromFile(imgPath);
                }    
            }
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clearAll();
                txtName.Text = dgvThucDon.SelectedRows[0].Cells[1].Value.ToString();
                txtPrice.Text = dgvThucDon.SelectedRows[0].Cells[4].Value.ToString();
                txtSL.Text = dgvThucDon.SelectedRows[0].Cells[3].Value.ToString();
                int index = cbbDVT.FindStringExact(dgvThucDon.SelectedRows[0].Cells[2].Value.ToString());
                cbbDVT.SelectedIndex = index;
                txtPicName.Text = dgvThucDon.SelectedRows[0].Cells[5].Value.ToString();
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string imgPath = Path.Combine(projectDirectory, "HinhMatHang", txtPicName.Text);
                if (File.Exists(imgPath))
                {
                    txtPic.Text = imgPath;
                    pictureBox1.Image = Image.FromFile(imgPath);
                }
                btnEdit.Visible = true;
            }
        }

        private void f_ListThucDon_Click(object sender, EventArgs e)
        {
            dgvThucDon.ClearSelection();
            clearAll();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dgvThucDon.ClearSelection();
            clearAll();
        }

        private void f_ListThucDon_Leave(object sender, EventArgs e)
        {
            dgvThucDon.ClearSelection();
            clearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPic.Text != string.Empty)
                {
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    string imgPath = Path.Combine(projectDirectory, "HinhMatHang");

                    if (!Directory.Exists(imgPath))
                    {
                        Directory.CreateDirectory(imgPath);
                    }
                    File.Copy(txtPic.Text, Path.Combine(imgPath, Path.GetFileName(txtPic.Text)), true);
                }
                string sql = "update ThucDon set TenThucDon = N'" + txtName.Text + "', DonViTinh = N'" + cbbDVT.SelectedValue.ToString() + "', SoLuong = " + txtSL.Text + ", Gia = " + txtPrice.Text + ", Hinh = N'" + txtPicName.Text + "' where MaThucDon = '" + dgvThucDon.SelectedRows[0].Cells[0].Value.ToString() + "'";
                int kq = DataProvider.Instance.ExcuteNonQuery(sql);
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                }
                loadThucDon();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo");
            }
        }
    }
}
