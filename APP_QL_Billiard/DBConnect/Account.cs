﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace APP_QL_Billiard.DBconnect
{
    public class Account
    {
        // tạo 1 thể hiện(instance)
        private static Account instance;
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string TinhTrang { get; set; }
        public bool IsQuanLy { get; set; }
        public static Account Instance
        {
            get 
            { 
                if (instance == null) 
                    instance = new Account();
                return instance;
            }            
            private set
            {
                instance = value;
            }
        }

        private Account()
        {

        }

        public bool Login(string tk, string mk)
        {
            string query = "select * from Account where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
            DataTable result = DBConnect.Instance.ExcuteQuery(query);
            if(result.Rows.Count > 0)
            {
                TaiKhoan = tk;
                MatKhau = mk;
                HoTen = result.Rows[0].Field<string>("HoTen");
                SDT = result.Rows[0].Field<string>("SDT");
                TinhTrang = result.Rows[0].Field<string>("TinhTrang");
                IsQuanLy = result.Rows[0].Field<bool>("QuanLy");
            }    
            return result.Rows.Count > 0;
        }

    }
}
