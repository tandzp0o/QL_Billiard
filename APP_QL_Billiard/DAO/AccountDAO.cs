using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace APP_QL_Billiard.DAO
{
    public class AccountDAO
    {
        // tạo 1 thể hiện(instance)
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get 
            { 
                if (instance == null) 
                    instance = new AccountDAO();
                return instance;
            }            
            private set
            {
                instance = value;
            }
        }

        private AccountDAO()
        {

        }

        public bool Login(string tk, string mk)
        {
            string query = "select * from Account where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool CheckADM(string tk)
        {
            string query = "select QuanLy from Account where TaiKhoan = '" + tk + "'";
            int result = DataProvider.Instance.ExcuteScalar<int>(query);
            return result>0;

        }
    }
}
