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

           
            if (Ban1 != null)
            {
                lbl_NV.Text = "Nguyễn Văn A";
                txt_TenBan.Text = Ban1.Name; 
            }

            //var date1 = DateTime.Now;
            //txtTimeStart.Text = date1.ToString("HH:mm   dd/MM/yyyy");

            //if (ban.Status == 2) //1hd 2 trong 3 dat truoc
            //{
            //    btnEnd.Enabled = false;
            //    btnStart.Enabled = true;
            //    btnChange.Enabled = false;
            //    if (string.Compare(ban.Type, "Loai 1") == 0)
            //    {
            //        //picBan.Image = global::Bida.Properties.Resources.; // kHUC NAY SE CHEN PIC CUA LOAI BAN BIDA
            //    }
            //    else if (string.Compare(ban.Type, "Loai 2") == 0)
            //    {
            //        //picBan.Image = global::Bida.Properties.Resources.;
            //    }
            //    else
            //    {
            //        //picBan.Image = global::Bida.Properties.Resources.;
            //    }
            //}
            //else
            //{
            //    btnChange.Enabled = true;
            //    var date = ban.GioBD;
            //    int h = date.Hour;
            //    int m = date.Minute;
            //    txtTimeStart.Text = h + ":" + m;
            //    txtTimeStart.Enabled = false;
            //    btnStart.Enabled = false;
            //    btnEnd.Enabled = true;
            //    if (string.Compare(ban.Type, "Loai 2") == 0)
            //    {
            //        //picBan.Image = global::Bida.Properties.Resources.;
            //    }
            //    else
            //    {
            //        //picBan.Image = global::Bida.Properties.Resources.;
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txt_Time.Text = currentTime.ToString("HH:mm:ss");
        }
    }
}
