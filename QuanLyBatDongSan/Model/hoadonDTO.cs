using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class hoadonDTO
    {
        private String makh;

        public String Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private String maNV;

        public String MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private String tenKH;

        public String TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private String diaChi;

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private String sDT;

        public String SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private DateTime ngayban;

        public DateTime Ngayban
        {
            get { return ngayban; }
            set { ngayban = value; }
        }
        private float thanhTien;

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public hoadonDTO(DataRow row)
        {
            this.Makh = row["makh"].ToString();
            this.MaNV = row["manv"].ToString();
            this.TenKH = row["tenKH"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Ngayban = DateTime.Parse(row["Ngayban"].ToString());
            this.ThanhTien = float.Parse(row["thanhtien"].ToString());
        }
    }
}
