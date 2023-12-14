//using System.Collections.Generic;
//using System.Data;
//using APP_QL_Billiard.DTO;
//using System;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace APP_QL_Billiard.DBconnect
//{
//    public class ThucDonDAO
//    {
//        private static ThucDonDAO instance;
//        public static ThucDonDAO Instance
//        {
//            get { if (instance == null) instance = new ThucDonDAO(); return ThucDonDAO.instance; }
//            private set { ThucDonDAO.instance = value; }
//        }

//        public static int MenuWidth = 110;
//        public static int MenuHeight = 150;

//        //Load cho tung ban
       

//        //Load cho trang order
//        public List<ListThucDon> LoadMenuListForOrder()
//        {
//            List<ListThucDon> list = new List<ListThucDon>();
//            DataTable data = DBConnect.Instance.ExcuteQuery("Select * from ThucDon");

//            foreach (DataRow item in data.Rows)
//            {
//                ListThucDon thucDon = new ListThucDon(item);
//                list.Add(thucDon);
//            }
//            return list;
//        }
//        public List<ThucDon> GetListMenuByTable(string id)
//        {
//            List<ThucDon> listMenu = new List<ThucDon>();
//            DataTable data = DBConnect.Instance.ExcuteQuery(" SELECT f.TenThucDon, f.DonViTinh, bi.SoLuongDat , f.Gia, f.Gia*bi.SoLuongDat AS totalPrice FROM dbo.ChiTietHoaDon AS bi, dbo.HoaDon AS b, dbo.ThucDon AS f WHERE bi.MaHoaDon = b.MaHoaDon AND bi.MaThucDon = f.MaThucDon AND b.MaBan = '" + id + "'");

//            foreach (DataRow item in data.Rows)
//            {
//                ThucDon menu = new ThucDon(item);
//                listMenu.Add(menu);
//            }

//            return listMenu;
//        }
//    }
//}