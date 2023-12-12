using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DTO
{
    public class ChiTietBill
    {
         public ChiTietBill(int id, int billID, string foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public ChiTietBill(DataRow row)
        {
            this.ID = (int)row["MaChiTietHoaDon"];
            this.BillID = (int)row["MaHoaDon"];
            this.FoodID = row["MaThucDon"].ToString();
            this.Count = (int)row["SoLuongDat"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private string foodID;

        public string FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
