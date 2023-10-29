using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard.DTO
{
    public class ThucDon
    {
        public ThucDon(string id, string name, string unit, int amount, string pic, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Unit = unit;
            this.Amount = amount;
            this.Price = price;
            this.Pic = pic;
            this.Note = note;
        }

        public ThucDon(DataRow row)
        {
            this.ID = row["MaThucDon"].ToString();
            this.Name = row["TenThucDon"].ToString();
            this.Unit = row["DonViTinh"].ToString();
            this.Amount = (int)row["SoLuong"];
            this.Price = (double)row["Gia"];
            this.pic = row["Hinh"].ToString(); ;
            this.Unit = row["GhiChu"].ToString();
        }

        private string id;
        public string ID { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string unit;
        public string Unit { get => unit; set => unit = value; }

        private int amount;
        public int Amount { get => amount; set => amount = value; }

        private double price;
        public double Price { get => price; set => price = value; }

        private string pic;
        public string Pic { get => pic; set => pic = value; }

        private string note;
        public string Note { get => note; set => note = value; }

    }
}
