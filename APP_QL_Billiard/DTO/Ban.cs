using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DTO
{
    public class Ban
    {
        //chưa có giá
        public Ban(string id, string name, string type, int status, double gia, DateTime gioBd, DateTime gioKt)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Status = status;
            this.Gia = gia;
            this.GioBD = gioBd;
            this.GioKT = gioKt;

        }

        public Ban(DataRow row)
        {
            this.ID = row["MaBan"].ToString();
            this.Name = row["TenBan"].ToString();
            this.Type = row["LoaiBan"].ToString();
            this.Status = (int)row["TrangThai"];
            this.Gia = (double)row["Gia"];
        }

        private string iD;
        public string ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string type;
        public string Type { get => type; set => type = value; }

        private int status;
        public int Status { get => status; set => status = value; }

        private double gia;
        public double Gia { get => gia; set=> gia=value; }

        private DateTime gioBD;
        public DateTime GioBD { get => gioBD; set => gioBD = value; }

        private DateTime gioKT;
        public DateTime GioKT { get => gioKT; set => gioKT = value; }

    }
}
