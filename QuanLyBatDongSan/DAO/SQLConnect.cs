using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DAO
{
    class SQLconnect
    {
        private static SQLconnect instance;

        public static SQLconnect Instance
        {
            get { if (instance == null) instance = new SQLconnect(); return SQLconnect.instance; }
            private set { SQLconnect.instance = value; }
        }
        private SQLconnect()
        {

        }
        private static String strSQL = @"Data Source=DESKTOP-TNK6D3G;Initial Catalog=QLBATDONGSAN;Integrated Security=True";

        public DataTable ExecuteQuery(String query)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(strSQL))
            {
                con.Open();
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                adapter.Fill(table);
                con.Close();
            }
            return table;
        }
        public int ExecuteNonQuery(String query)
        {
            int kq=0;
            using (SqlConnection con = new SqlConnection(strSQL))
            {
                con.Open();
                SqlCommand cm = new SqlCommand(query, con);
                kq = cm.ExecuteNonQuery();
                con.Close();
            }
            return kq;

        }

        public int ExecuteSaveFileBDS(String query, byte[] file)
        {
            int kq = 0;
            using (SqlConnection con = new SqlConnection(strSQL))
            {
                con.Open();
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.Add("@File", SqlDbType.Binary, file.Length).Value = file;
                kq = cm.ExecuteNonQuery();
                con.Close();
            }
            return kq;

        }
    }
}
