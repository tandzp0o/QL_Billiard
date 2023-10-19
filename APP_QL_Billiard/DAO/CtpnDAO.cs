using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_QL_Billiard.DTO;

namespace APP_QL_Billiard.DAO
{
    internal class CtpnDAO
    {
        public int addToCTPN(List<CTPN> ctpn)
        {
            int kq = 0;
            string sql = "insert into PhieuNhap(NgayNhap) values ('" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
            DataProvider.Instance.ExcuteNonQuery(sql);
            sql = "select top 1 mapn from PhieuNhap order by mapn desc";
            string mapn = DataProvider.Instance.ExcuteScalar<string>(sql);
            foreach(var i in ctpn)
            {
                sql = "insert into ChiTietPhieuNhap(mapn, mathucdon, soluong, dongia) values ('" + mapn + "','" + i.MaThucDon + "'," + i.SoLuong + "," + i.DonGia + ")";
                kq += DataProvider.Instance.ExcuteNonQuery(sql);
            }
            return kq;
        }
    }
}
