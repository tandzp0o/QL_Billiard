using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace APP_QL_Billiard.DAO
{
    public class DataProvider
    {
        private string conStr = "Data Source=TonDZP;Initial Catalog=Ql_Billiard;Integrated Security=True";
    
        public void ExcuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(conStr);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            con.Close();
        }
    }
}