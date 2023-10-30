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

namespace APP_QL_Billiard
{
    public partial class f_ListThucDon : Form
    {
        public f_ListThucDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.png; *.bmp;)|*.jpg; *.gif; *.jpeg; *.png; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string imgPath = Path.Combine(projectDirectory, "HinhMatHang");

            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }
            File.Copy(txtPic.Text, Path.Combine(imgPath, Path.GetFileName(txtPic.Text)), true);
            string imgName = Path.GetFileName(txtPic.Text);
        }
    }
}
