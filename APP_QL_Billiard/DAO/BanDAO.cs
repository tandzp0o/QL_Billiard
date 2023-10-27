using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DAO
{
    public class BanDAO
    {
       
        private static BanDAO instance;
        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }
        }

        public static int TableWidth = 110;
        public static int TableHeight = 150;
       
        public List<Ban> LoadTableList()
        {
            List<Ban> list = new List<Ban>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);
            }
            return list;
        }
        private BanDAO() { }
       
        //public void updateBan(Ban b)
        //{
        //    string bd = b.GioBD.ToString("yyyy-MM-dd HH:mm:ss");
        //    string kt = b.GioKT.ToString("yyyy-MM-dd HH:mm:ss");
        //    DataProvider.Connect();

        //    int loaiban = b.Statu ? 1 : 0;
        //    int tinhtrang = b.TinhTrang1 ? 1 : 0;

        //    string sql = "update ban set LOAIBAN = " + loaiban + ", KHUVUC = " + b.KhuVuc1 + ", TINHTRANG = " + tinhtrang + ", GIOBD= '" + bd + "',GIOKT = '" + kt + "' where MABAN = " + b.Maban1;
        //    provider.ExcuteNonQuery(sql);
        //}

    }
}
