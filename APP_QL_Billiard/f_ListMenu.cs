using APP_QL_Billiard.DAO;
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
    public partial class f_ListMenu : Form
    {
        public f_ListMenu()
        {
            InitializeComponent();
            LoadMenu();
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

         
                btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 2;
                flpMenu.Controls.Add(btn);
            }
        }

        public void loaddgv(string query)
        {
            DataTable a = DataProvider.Instance.ExcuteQuery(query);
            dgv_Order.DataSource = a;
            dgv_Order.Columns[0].HeaderText = "Tên món";
            dgv_Order.Columns[1].HeaderText = "Sl";
            dgv_Order.Columns[2].HeaderText = "Ngày Đặt";
        }
        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            fFunction_Ban fSent = F;
            //Chèn ảnh
            
            
            fSent.Ban1 = (Ban)btn.Tag;
            fSent.Activate();
            fSent.reLoad();
        }
        private void flpTable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.flpMenu.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            PointF pf1 = new PointF(465f, 0f);
            PointF pf2 = new PointF(465f, flpMenu.Height * 60f / 9);
            e.Graphics.DrawLine(p, pf1, pf2);
        }
    }
}
