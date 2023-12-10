﻿using System;
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
        public string MaThucDon { get; set; }
        public string TenThucDon { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public string Hinh { get; set; }
        public string GhiChu { get; set; }

        public ThucDon(string id, string name, string unit, int amount,double price, string pic, string note)
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
            
            this.Name = row["TenThucDon"].ToString();
            this.Unit = row["DonViTinh"].ToString();
            this.Amount = (int)row["SoLuongDat"];
            this.Price = (double)row["Gia"];
            this.TotalPrice = (double)row["TotalPrice"];
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

        private double totalPrice;
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

    }
}