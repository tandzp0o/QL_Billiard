using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DTO
{
    internal class CTPN
    {
        public string MaThucDon { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public CTPN() { }
        public CTPN(string maThucDon, int soLuong, int donGia)
        {
            MaThucDon = maThucDon;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
