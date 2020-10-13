using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class nhacungcapDTO
    {
        private String maNCC;

        public String MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        private String tenNCC;

        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        private String diachi;

        public String Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private String sDT;

        public String SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public nhacungcapDTO(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.tenNCC = row["tenncc"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Email = row["email"].ToString();
            this.SDT = row["soDT"].ToString();
        }
    }
}
