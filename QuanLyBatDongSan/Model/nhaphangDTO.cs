using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class nhaphangDTO
    {
        private int sTT;
        public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngaynhap;

        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        private String maHH;

        public String MaHH
        {
            get { return maHH; }
            set { maHH = value; }
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
        private float dongia;

        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private float thanhtien;

        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        public nhaphangDTO(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.Ngaynhap = (DateTime)row["ngaynhap"];
            this.MaHH = row["MaHH"].ToString();
            this.TenHH = row["TenHH"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Dongia = float.Parse(row["DonGia"].ToString());
            this.Thanhtien = float.Parse(row["ThanhTien"].ToString());
            this.STT = (int)row["STT"];
        }
    }
}
