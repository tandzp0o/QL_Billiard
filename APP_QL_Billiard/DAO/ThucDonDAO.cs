using System.Collections.Generic;
using System.Data;
using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DAO
{
    public class ThucDonDAO
    {
        private static ThucDonDAO instance;
        public static ThucDonDAO Instance
        {
            get { if (instance == null) instance = new ThucDonDAO(); return ThucDonDAO.instance; }
            private set { ThucDonDAO.instance = value; }
        }

        public static int MenuWidth = 110;
        public static int MenuHeight = 150;

        public List<ThucDon> LoadMenuList()
        {
            List<ThucDon> list = new List<ThucDon>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from ThucDon");

            foreach (DataRow item in data.Rows)
            {
                ThucDon thucDon = new ThucDon(item);
                list.Add(thucDon);
            }
            return list;
        }

        public List<ThucDon> GetListMenuByTable(string id)
        {
            List<ThucDon> listMenu = new List<ThucDon>();
            DataTable data = DataProvider.Instance.ExcuteQuery(" SELECT f.TenThucDon, f.DonViTinh, bi.SoLuongDat , f.Gia, f.Gia*bi.SoLuongDat AS totalPrice FROM dbo.ChiTietHoaDon AS bi, dbo.HoaDon AS b, dbo.ThucDon AS f WHERE bi.MaHoaDon = b.MaHoaDon AND bi.MaThucDon = f.MaThucDon AND b.MaBan = '" + id + "'");

            foreach (DataRow item in data.Rows)
            {
                ThucDon menu = new ThucDon(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}