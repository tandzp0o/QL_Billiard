﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
<<<<<<< Updated upstream
            Application.Run(new fLogin());
            //Application.Run(new fTable_Manager());
            //Application.Run(new fTable_Manager_ADM());
=======
            //Application.Run(new fLogin());
            //Application.Run(new fTable_Manager());
>>>>>>> Stashed changes
            //Application.Run(new f_ThanhToan());
            Application.Run(new f_NhapHang());
        }
    }
}
