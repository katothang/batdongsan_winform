using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class xuathangDTO
    {
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
        private String maKH;

        public String MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayban;

        public DateTime Ngayban
        {
            get { return ngayban; }
            set { ngayban = value; }
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

        public xuathangDTO(DataRow row)
        {
            this.MaHH = row["maHH"].ToString();
            this.MaNV = row["manv"].ToString();
            this.MaKH = row["makh"].ToString();
            this.Ngayban = (DateTime)row["ngayban"];
            this.TenHH = row["tenHH"].ToString();
            Int32.TryParse(row["soluong"].ToString(), out this.soluong);
            float.TryParse(row["dongia"].ToString(),out this.dongia);
            this.Thanhtien = float.Parse(row["thanhtien"].ToString());

        }
    }
}
