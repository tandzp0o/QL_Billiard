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
        public Ban(string id, string name, string type, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Status = status;
        }

        public Ban(DataRow row)
        {
            this.ID = row["MaBan"].ToString();
            this.Name = row["TenBan"].ToString();
            this.Type = row["LoaiBan"].ToString();
            this.Status = row["TrangThai"].ToString();
        }

        private string iD;
        public string ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string type;
        public string Type { get => type; set => type = value; }

        private string status;
        public string Status { get => status; set => status = value; }
    }
}
