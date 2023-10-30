﻿using APP_QL_Billiard.DAO;
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
        public f_ListMenu()
        {
            InitializeComponent();
            LoadMenu();
            loadCboTable();
        }

        public fFunction_Ban F { get; set; }
        public f_ListMenu(fFunction_Ban f)
        {
            F = f;
            InitializeComponent();
            LoadMenu();
            
        }

        #region Method
        void LoadMenu()
        {
            List<ThucDon> thucDonList = ThucDonDAO.Instance.LoadMenuList();
            foreach (ThucDon item in thucDonList)
            {
                Button btn = new Button() { Width = ThucDonDAO.MenuWidth, Height = ThucDonDAO.MenuHeight };
                btn.Text = item.Name + Environment.NewLine + item.Unit + Environment.NewLine + item.Price;
                btn.Margin = new Padding(18);
                btn.Tag = item;
                //Chèn ảnh


                //btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 2;
                flp_Menu.Controls.Add(btn);
            }
        }

        public void loaddgv(string query)
        {
            DataTable a = DataProvider.Instance.ExcuteQuery(query);
            dgv_Order.DataSource = a;
            dgv_Order.Columns[0].HeaderText = "Tên món";
            dgv_Order.Columns[1].HeaderText = "Sl";
        }

        void loadCboTable()
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
    }
}