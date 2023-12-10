﻿using System;
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


        public Ban Ban1 { get; set; }
        public fFunction_Ban()
        {
            InitializeComponent();

        }
        public fFunction_Ban(Ban a)
        {
            InitializeComponent();
            Ban1 = a;
        }

        public void ShowBill(string id)
        {
          
            List<ThucDon> ListChiTietBill = ThucDonDAO.Instance.GetListMenuByTable(id);

         
            DataTable dataTable = new DataTable();


            dataTable.Columns.Add("Tên món", typeof(string));
            dataTable.Columns.Add("Đơn vị tính", typeof(string));
            dataTable.Columns.Add("Gía", typeof(double));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Tạm tính", typeof(double));

        
            foreach (ThucDon item in ListChiTietBill)
            {
             
                dataTable.Rows.Add(item.Name.ToString(), item.Unit.ToString(), item.Price.ToString(), item.Amount.ToString(), item.TotalPrice.ToString());
            }
            dgvMenu.DataSource = dataTable;
            dgvMenu.Columns["Tên món"].Width = 150;  // Độ rộng mong muốn
            dgvMenu.Columns["Đơn vị tính"].Width = 60;
            dgvMenu.Columns["Gía"].Width = 60;
            dgvMenu.Columns["Số lượng"].Width = 50;
            dgvMenu.Columns["Tạm tính"].Width = 120;
        }
        public void reLoad()
        {
            if (Ban1 != null)
            {
                txt_TenBan.Text = Ban1.Name;
                txtTimeStart.Text = Ban1.GioBD.ToString("HH:mm:ss   dd/MM/yyyy");
                if (Ban1.Status == 2 || Ban1.Status == 3) //1hd 2 trong 3 dat truoc
                {
                    btnEnd.Enabled = false;
                    btnStart.Enabled = true;
                    btnChange.Enabled = false;
                    txtTimeStart.Text = "";
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
            txtTimeStart.Text = Ban1.GioBD.ToString("HH:mm:ss   dd/MM/yyyy");
            txtTimeEnd.Text = "";
            Ban1.Status = 1;
            btnTinh.Enabled = false;
            //Them phuong thuc push data vao SQL
            string query = "  UPDATE Ban SET GioBatDau = '@gioBD' ";
            query = query.Replace("@gioBD", DateTime.Now.ToString());
            int k = DataProvider.Instance.ExcuteNonQuery(query);

            this.reLoad();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            var date = DateTime.Now;
            Ban1.GioKT = date;
            txtTimeEnd.Text = Ban1.GioKT.ToString("HH:mm:ss   dd/MM/yyyy");
            Ban1.Status = 1;
            txtTimeEnd.Enabled = false;
            btnTinh.Enabled = true;
            //Them phuong thuc push data vao SQL
            string query = "  UPDATE Ban SET GioKetThuc = '@gioKT' ";
            query = query.Replace("@gioKT", DateTime.Now.ToString());
            int k = DataProvider.Instance.ExcuteNonQuery(query);
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
            f_ThanhToan thanhToanForm = new f_ThanhToan(Ban1.ID);
            thanhToanForm.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đổi bàn?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Chọn bàn đi");
            }
        }

    }
}
