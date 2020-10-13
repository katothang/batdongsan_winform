using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class thanhtoanDTO
    {
        private float donGia;


        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private float soLuong;




        public float SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public thanhtoanDTO(DataRow row)
        {
            this.SoLuong = float.Parse(row["soluong"].ToString());
            this.DonGia = float.Parse(row["dongia"].ToString());
        }
    }
}
