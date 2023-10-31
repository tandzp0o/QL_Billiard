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
    }
}