using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DAO
{
    class dangnhapDAO
    {
        private static dangnhapDAO dn;

        public static dangnhapDAO Dn
        {
            get { if (dn == null) dn = new dangnhapDAO(); return dangnhapDAO.dn; }
            set { dangnhapDAO.dn = value; }
        }



        public bool ktDangNhap(String username, String pass)
        {
            DataTable data = SQLconnect.Instance.ExecuteQuery("select * from nhanvien where manv='" + username + "' and matkhau='" + pass + "'");
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public string quyenADMIN(String username, String pass)
        {
            DataTable data = SQLconnect.Instance.ExecuteQuery("select * from nhanvien where manv='" + username + "' and matkhau='" + pass + "'");
            if (data.Rows.Count > 0)
			{
				foreach (DataRow item in data.Rows)
				{
					return item["quyentruycap"].ToString();
				}
			}
			return null; ;
        }
    }
}
