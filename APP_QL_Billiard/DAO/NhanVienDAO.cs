using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DAO
{
    public class NhanVienDAO
    {
        private DataProvider dataProvider;

        public NhanVienDAO()
        {
            dataProvider = DataProvider.Instance;
        }

        public DataTable GetAllEmployees()
        {
            string sql = "select TaiKhoan, HoTen, SDT, TinhTrang from Account";
            return dataProvider.getDataTable(sql);
        }

        public int AddEmployee(string taiKhoan, string matkhau, string hoTen, string sdt, string tinhTrang)
        {
            string sql = $"insert into Account (TaiKhoan, MatKhau, HoTen, SDT, TinhTrang) VALUES ('{taiKhoan}', {matkhau}, N'{hoTen}', '{sdt}', N'{tinhTrang}')";
            return dataProvider.executeNonQuery(sql);
        }

        public int UpdateEmployee(string taiKhoan, string hoTen, string sdt, string tinhTrang)
        {
            string sql = $"update Account set HoTen = N'{hoTen}', SDT = '{sdt}', TinhTrang = N'{tinhTrang}' WHERE TaiKhoan = '{taiKhoan}'";
            return dataProvider.executeNonQuery(sql);
        }
    }
}
