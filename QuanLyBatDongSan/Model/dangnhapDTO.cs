using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class dangnhapDTO
    {
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private String quyentruycap;

        public String Quyentruycap
        {
            get { return quyentruycap; }
            set { quyentruycap = value; }
        }
        private String tenNV;

        public String TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private String sdt;

        public String Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private String diaChi;

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string gioitinh;
        private String matkhau;

        public String Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public dangnhapDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.Quyentruycap = row["quyentruycap"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.Ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.DiaChi = row["DiaChi"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Matkhau = row["MatKhau"].ToString();

        }
    }
}
