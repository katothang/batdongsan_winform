using QuanLyBatDongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DAO
{
    class nhomKHDAO
    {
        private static nhomKHDAO instance;

        internal static nhomKHDAO Instance
        {
            get { if (instance == null) instance = new nhomKHDAO(); return nhomKHDAO.instance; }
            private set { nhomKHDAO.instance = value; }
        }

        public DataTable showNhom()
        {
            String query = "select * from nhomKH";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            return data;
        }

        //thêm sửa xóa dl nhà cung cấp

        public int ThemDL(string maNhom, string tenNhom)
        {
            String query = String.Format("insert into nhomKH values('{0}', N'{1}')",maNhom, tenNhom);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }
        /////
        public int SuaDL(string maNhom, string tenNhom)
        {
            String query = String.Format("update nhomKH set TenNhom=N'{1}' where MaNhom='{0}'", maNhom, tenNhom);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }

        ////
        public int xoaDL(string maNhom)
        {
            String query = String.Format("delete nhomKH where MaNhom='{0}'", maNhom);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }


        public DataTable timkiem(String noidung)
        {
            String query = String.Format("select * from nhomKH where TenNhom like '%{0}%'", noidung);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
