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
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        //private string conStr = "Data Source=TRUONG;Initial Catalog=Ql_Billiard;Integrated Security=True";
    
        // lấy datatable
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach( string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }    
                    }    
                }    
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }    
            return data;
        }

        // lấy số dòng thành công
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        // lấy ô đầu tiên trong dòng kết quả
        public T ExcuteScalar<T>(string query, object[] parameter = null)
        {
            object data;
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(env.conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return (T)Convert.ChangeType(data, typeof(T));
        }

       
    }
}