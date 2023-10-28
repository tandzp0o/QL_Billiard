using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_QL_Billiard.DTO
{
    class ListThucDon
    {

        private static List<ThucDon> lstTD;
        public static List<ThucDon> LstTD
        {
            get
            {
                if (lstTD == null)
                    lstTD = new List<ThucDon>();
                return ListThucDon.lstTD;
            }
            private set
            {
                ListThucDon.lstTD = value;
            }
        }


        private ListThucDon() { }

    }
}
