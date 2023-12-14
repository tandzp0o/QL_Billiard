using APP_QL_Billiard.DBconnect;
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
            //LoadMenu();
            selectedValue = string.Empty;
            cboBan.SelectedValueChanged += cboBan_SelectedValueChanged;
            loadCboTable();
            LoadMenu();
        }

        public f_ListMenu F { get; set; }
        public f_ListMenu(f_ListMenu f)
        {
            F = f;
            InitializeComponent();
            //LoadMenu();

        }

        #region Method
        public static int ButtonWidth = 110;
        public static int ButtonHeight = 150;

        DataTable lstMenu = new DataTable();
      

        void LoadMenu()
        {
            lstMenu = DBConnect.Instance.ExcuteQuery("SELECT *  FROM ThucDon");

            foreach (DataRow item in lstMenu.Rows)
            {
                Button btn = new Button() { Width = ButtonWidth, Height = ButtonHeight };
                btn.Text = item["TenThucDon"] + Environment.NewLine + item["DonViTinh"] + Environment.NewLine + item["Gia"];
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
            string tenMon = ((sender as Button).Tag as DataRow)["TenThucDon"].ToString();
            txt_Mon.Text = tenMon;
        }
        DataTable lstThucDon = new DataTable();
        public void GetListMenuByTable(string id)
        {
            lstThucDon = DBConnect.Instance.ExcuteQuery(" SELECT f.TenThucDon, f.DonViTinh, bi.SoLuongDat , f.Gia, f.Gia*bi.SoLuongDat AS TongTien FROM dbo.ChiTietHoaDon AS bi, dbo.HoaDon AS b, dbo.ThucDon AS f WHERE bi.MaHoaDon = b.MaHoaDon AND bi.MaThucDon = f.MaThucDon AND b.MaBan = '" + id + "'");
        }
        public void loaddgv_Order(string id)
        {
            DataTable menuTable = new DataTable();
            menuTable.Columns.Add("Tên món", typeof(string));
            menuTable.Columns.Add("Đơn vị tính", typeof(string));
            menuTable.Columns.Add("Giá", typeof(double));
            menuTable.Columns.Add("Số lượng", typeof(int));
            menuTable.Columns.Add("Tạm tính", typeof(double));
            GetListMenuByTable(id);
            foreach (DataRow item in lstThucDon.Rows)
            {
                menuTable.Rows.Add(item["TenThucDon"].ToString(), item["DonViTinh"].ToString(), item["Gia"].ToString(), item["SoLuongDat"].ToString(), item["TongTien"].ToString());
            }
            dgv_OrderFood.DataSource = menuTable;
            dgv_OrderFood.Columns["Tên món"].Width = 150;  // Độ rộng mong muốn
            dgv_OrderFood.Columns["Đơn vị tính"].Width = 60;
            dgv_OrderFood.Columns["Giá"].Width = 60;
            dgv_OrderFood.Columns["Số lượng"].Width = 50;
            dgv_OrderFood.Columns["Tạm tính"].Width = 120;
        }

        private void cboBan_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedValue = comboBox.SelectedValue.ToString();
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


        private void flpTable_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = this.flp_Menu.CreateGraphics();
            //Pen p = new Pen(Color.Black, 3);
            //PointF pf1 = new PointF(465f, 0f);
            //PointF pf2 = new PointF(465f, flp_Menu.Height * 60f / 9);
            //e.Graphics.DrawLine(p, pf1, pf2);
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {

        }
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

}
