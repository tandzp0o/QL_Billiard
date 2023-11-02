﻿using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetBillIDByTableID(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM HOADON WHERE MaBan = " + id + " ");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

    }
}
