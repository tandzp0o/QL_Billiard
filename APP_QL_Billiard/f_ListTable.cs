﻿using APP_QL_Billiard.DAO;
using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_QL_Billiard
{
    public partial class f_ListTable : Form
    {
        public f_ListTable()
        {
            InitializeComponent();
            LoadBan();
        }

        #region Method
        void LoadBan()
        {
            List<Ban> banList = BanDAO.Instance.LoadTableList();
            foreach (Ban item in banList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Type;
                btn.Margin = new Padding(50);
                switch (item.Status)
                {
                    case "1":
                        btn.BackColor = Color.White;
                        break;
                    case "2":
                        btn.BackColor = Color.Aqua;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }
        #endregion
    }
}
