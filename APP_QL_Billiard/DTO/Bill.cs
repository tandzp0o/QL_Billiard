using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? gioBD, DateTime? gioKT)
        {
            this.ID = id;
            this.GioBD = gioBD;
            this.GioKT = gioKT;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["MaHoaDon"];
            this.GioBD = (DateTime?)row["GioBatDau"];
            var gioKTTemp = row["GioKetThuc"];
            if (gioKTTemp.ToString() != "")
                this.GioKT = (DateTime?)gioKTTemp;
        }
    
        private DateTime? gioKT;

        public DateTime? GioKT
        {
            get { return gioKT; }
            set { gioKT = value; }
        }

        private DateTime? gioBD;

        public DateTime? GioBD
        {
            get { return gioBD; }
            set { gioBD = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
