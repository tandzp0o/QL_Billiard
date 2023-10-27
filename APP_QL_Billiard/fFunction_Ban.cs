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
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard
{
    public partial class fFunction_Ban : Form
    {
        public Ban Ban1 { get;  set;}
        public fFunction_Ban( )
        {
            InitializeComponent();
            
        }
        public fFunction_Ban(Ban a)
        {
            InitializeComponent();
            Ban1 = a;
        }

        public void fFunction_Ban_Load(object sender, EventArgs e)
        {
                lbl_NV.Text = "Nguyễn Văn A";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txt_Time.Text = currentTime.ToString("HH:mm:ss");
        }


        public void reLoad()
        {
            if (Ban1 != null)
            {
                lbl_NV.Text = "Nguyễn Văn A";
                txt_TenBan.Text = Ban1.Name;


                if (Ban1.Status == 2 || Ban1.Status == 3) //1hd 2 trong 3 dat truoc
                {
                    btnEnd.Enabled = false;
                    btnStart.Enabled = true;
                    btnChange.Enabled = false;
                    txtTimeEnd.Text = "";
                    txtTimeEnd.Text = "";
                    if (string.Compare(Ban1.Type, "Lỗ") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.; // kHUC NAY SE CHEN PIC CUA LOAI BAN BIDA
                    }
                    else if (string.Compare(Ban1.Type, "Lip") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                    else //Carom
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                }
                else
                {
                   
                    btnChange.Enabled = true;
                    txtTimeStart.Enabled = false;
                    btnStart.Enabled = false;
                    btnEnd.Enabled = true;
                   
                    if (string.Compare(Ban1.Type, "Lỗ") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.; // kHUC NAY SE CHEN PIC CUA LOAI BAN BIDA
                    }
                    else if (string.Compare(Ban1.Type, "Lip") == 0)
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                    else //Carom
                    {
                        //picBan.Image = global::Bida.Properties.Resources.;
                    }
                }
            }
        }
        //public void updateBan(Ban b)
        //{
        //    new BanDAO().updateBan(b);
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Ban1.GioBD = date;
            txtTimeStart.Text = Ban1.GioBD.ToString("HH:mm   dd/MM/yyyy");
            txtTimeEnd.Text = "";
            Ban1.Status = 1;
            btnTinh.Enabled = false;
            //Them phuong thuc push data vao SQL
            this.reLoad();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            var date = DateTime.Now;
            Ban1.GioKT = date;
            txtTimeEnd.Text = Ban1.GioKT.ToString("HH:mm   dd/MM/yyyy");
            Ban1.Status = 1;
            txtTimeEnd.Enabled = false;
            btnTinh.Enabled = true;
            //Them phuong thuc push data vao SQL
            this.reLoad();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            
                DateTime date = Ban1.GioBD;
                DateTime date2 = Ban1.GioKT;
                double m = (date2 - date).TotalMinutes;

                int hour = (int)(m / 60);

                int minute = (int)(m % 60);

                txtGio.Text = hour + " giờ " + minute + " phút";

                int gia = (int)(m * 2000) / 60;
               txtGia.Text = gia + ".000 VND";
                btnPay.Enabled = true;
            this.reLoad();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string tenBan = txt_TenBan.Text;
            DateTime gioBatDau = Ban1.GioBD;
            DateTime gioKetThuc = Ban1.GioKT;
            string tenNV = lbl_NV.Text;

            ThanhToanDAO dao = new ThanhToanDAO();
            string maBan = dao.GetMaBan(tenBan);
            string taiKhoan = dao.GetTaiKhoan(tenNV);

            dao.LuuHoaDon(maBan, gioBatDau, gioKetThuc, taiKhoan);

            f_ThanhToan thanhToanForm = new f_ThanhToan(Ban1.ID);
            thanhToanForm.Show();
            this.Hide();
        }
    }
}
