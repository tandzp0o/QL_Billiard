﻿using APP_QL_Billiard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace APP_QL_Billiard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new f_ThanhToan());
            //Application.Run(new f_NhapHang());
            //Application.Run(new f_NhapHang());
            //Application.Run(new fTable_Manager());
            Application.Run(new fTable_Manager_ADM());
            //Application.Run(new fLogin());
            //Application.Run(new f_ListTable());
            //Application.Run(new fFunction_Ban());
            //Application.Run(new f_ThongKe());
            //Application.Run(new fDatTruoc());
            //Application.Run(new fCreateMember());
        }
    }
}
