using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DAO
{
    public class ChiTietBillDAO
    {
        private static ChiTietBillDAO instance;

        public static ChiTietBillDAO Instance
        {
            get { if (instance == null) instance = new ChiTietBillDAO(); return ChiTietBillDAO.instance; }
            private set { ChiTietBillDAO.instance = value; }
        }

        private ChiTietBillDAO() { }

      
        public List<ChiTietBill> GetListBillInfo(int id)
        {
            List<ChiTietBill> listBillInfo = new List<ChiTietBill>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM ChiTietHoaDon WHERE MaHoaDon = " + id);

            foreach (DataRow item in data.Rows)
            {
                ChiTietBill info = new ChiTietBill(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }

      
    }
}
