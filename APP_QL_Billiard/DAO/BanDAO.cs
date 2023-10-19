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

        public static int TableWidth = 75;
        public static int TableHeight = 75;
        private BanDAO() { }

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


    }
}
