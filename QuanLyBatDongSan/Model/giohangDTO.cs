using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class giohangDTO
    {
        private String maHH;

        public String MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private String tenHH;

        public String TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private float thanhtien;

        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }


        public giohangDTO(DataRow row)
        {
            this.MaHH = row["MaHH"].ToString();
            this.TenHH = row["TenHH"].ToString();
            this.MaHH = row["MaHH"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.Soluong = Int32.Parse(row["SoLuong"].ToString());
            this.DonGia = float.Parse(row["DonGia"].ToString());
            this.Thanhtien = float.Parse((float.Parse(row["SoLuong"].ToString()) * this.DonGia).ToString());
        }
    }
}
