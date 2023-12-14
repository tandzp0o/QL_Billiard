﻿using APP_QL_Billiard.DBconnect;
using APP_QL_Billiard.DTO;
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
    public partial class f_ListTable : Form
    {
        public f_ListTable()
        {
            InitializeComponent();
            LoadBan();
        }

        public fFunction_Ban F { get; set; }

        public f_ListTable(fFunction_Ban f)
        {
            F = f;
            InitializeComponent();
            LoadBan();
        }

        #region Method
        void LoadBan()
        {
            List<Ban> banList = BanDAO.Instance.LoadTableList();
            foreach (Ban item in banList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Type;
                btn.Margin = new Padding(18);
                btn.Tag= item;
                btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 2;

                switch (item.Status)
                {
                    case 1:
                        btn.BackColor = Color.FromArgb(115, 184, 161);
                        break;
                    case 2:
                        btn.BackColor = Color.White;
                        break;
                    case 3:
                        btn.BackColor = Color.FromArgb(242, 226, 176);
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }

       
        #endregion
    
        private void Btn_Click(object sender, EventArgs e)
        {
            string query = "select TrangThai from Ban where MaBan ='"+ ((sender as Button).Tag as Ban).ID + "'";
            int a = DBConnect.Instance.ExcuteScalar<int>(query);
            if(a == 3)
            {
                DialogResult r = MessageBox.Show("Bàn đã đặt trước, bạn có muốn bỏ qua đặt trước?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(r == DialogResult.No)
                    this.Close();
            }    
            Button btn = (Button)sender;
            fFunction_Ban fSent = F;
            string tableID = ((sender as Button).Tag as Ban).ID;
            fSent.ShowBill(tableID);
            fSent.Ban1= (Ban)btn.Tag;
            fSent.Activate();
            fSent.reLoad();
        }
        private void flpTable_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics g = this.flpTable.CreateGraphics();
            Pen p = new Pen(Color.Black,3);
            PointF pf1 = new PointF(465f,0f);
            PointF pf2 = new PointF(465f,flpTable.Height*60f/9);
            e.Graphics.DrawLine(p, pf1, pf2);*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            f_TaoBan f = new f_TaoBan();
            f.Show();
        }

        private void f_ListTable_Load(object sender, EventArgs e)
        {
            if (Account.Instance.IsQuanLy)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
