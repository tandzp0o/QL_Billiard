﻿using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard
{
    public partial class f_ListMenu : Form
    {
        private string selectedValue;
        public f_ListMenu()
        {
            InitializeComponent();
            LoadMenu();
            selectedValue = string.Empty;
            cboBan.SelectedValueChanged += CboBan_SelectedValueChanged;
            loadCboTable();
        }

        public f_ListMenu F { get; set; }
        public f_ListMenu(f_ListMenu f)
        {
            F = f;
            InitializeComponent();
            LoadMenu();
        
        }

        #region Method
        void LoadMenu()
        {
            List<ListThucDon> thucDonList = ThucDonDAO.Instance.LoadMenuListForOrder();
            foreach (ListThucDon item in thucDonList)
            {
                Button btn = new Button() { Width = ThucDonDAO.MenuWidth, Height = ThucDonDAO.MenuHeight };
                btn.Text = item.Name + Environment.NewLine + item.Unit + Environment.NewLine + item.Price;
                btn.Margin = new Padding(18);
                btn.Tag = item;
                //Chèn ảnh

                btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 2;
                flp_Menu.Controls.Add(btn);
            }
        }

    
        private void Btn_Click(object sender, EventArgs e)
        {

            //Button btn = (Button)sender;
            //f_ListMenu fSent = F;
            //string idFood = ((sender as Button).Tag as Menu).Name;
            //fSent.loaddgv_Order(tableID);
            //fSent.Activate();

        }
        public void loaddgv_Order(string id)
        {

            List<ThucDon> ListChiTietBill = ThucDonDAO.Instance.GetListMenuByTable(id);


            DataTable dataTable = new DataTable();


            dataTable.Columns.Add("Tên món", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Gía", typeof(int));
            dataTable.Columns.Add("Tổng tiền", typeof(int));


            foreach (ThucDon item in ListChiTietBill)
            {

                dataTable.Rows.Add(item.Name.ToString(),  item.Amount.ToString(),item.Price,item.TotalPrice);
            }
            dgv_Order.DataSource = dataTable;
            dgv_Order.Columns["Tên món"].Width = 200;  // Độ rộng mong muốn
            dgv_Order.Columns["Số lượng"].Width = 50;
            dgv_Order.Columns["Gía"].Width = 70;
            dgv_Order.Columns["Tổng tiền"].Width = 90;

        }

        private void CboBan_SelectedValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị mới từ ComboBox và gán vào biến
            ComboBox comboBox = (ComboBox)sender;
            selectedValue = comboBox.SelectedValue.ToString();

            // Thực hiện các hành động khác tùy thuộc vào giá trị được chọn
            // Ví dụ: cập nhật DataGridView
            loaddgv_Order(selectedValue);
        }
        public void loadCboTable()
        {
            DataSet ds = new DataSet();
            string sql = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(sql, env.conStr);
            da.Fill(ds, "Ban");
            cboBan.DataSource = ds.Tables[0];
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
           
        }

        #endregion

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    fFunction_Ban fSent = F;


        //    fSent.Ban1 = (Ban)btn.Tag;
        //    fSent.Activate();
        //    fSent.reLoad();
        //}
        private void flpTable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.flp_Menu.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            PointF pf1 = new PointF(465f, 0f);
            PointF pf2 = new PointF(465f, flp_Menu.Height * 60f / 9);
            e.Graphics.DrawLine(p, pf1, pf2);
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {

        }
    }
}