using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DBconnect
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
            DataTable data = DBConnect.Instance.ExcuteQuery("Select * from Ban");

            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);
            }
            return list;
        }
        private BanDAO() { }


        //public int AddEmployee(string taiKhoan, string matkhau, string hoTen, string sdt, string tinhTrang)
        //{
        //    string sql = $"insert into Account (TaiKhoan, MatKhau, HoTen, SDT, TinhTrang) VALUES ('{taiKhoan}', {matkhau}, N'{hoTen}', '{sdt}', N'{tinhTrang}')";
        //    return dataProvider.executeNonQuery(sql);
        //}

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
