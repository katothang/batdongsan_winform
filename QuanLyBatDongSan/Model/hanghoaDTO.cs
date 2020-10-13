using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyBatDongSan.DTO
{
    class hanghoaDTO
    {
        private String mahh;
        private String tenhh;
        private String mancc;
        private String loaihang;
        private String nhanhieu;
        private float dongia;
        
        private int soluong;
        private String mota;

        public string Mahh
        {
            get
            {
                return mahh;
            }

            set
            {
                mahh = value;
            }
        }

        public string Tenhh
        {
            get
            {
                return tenhh;
            }

            set
            {
                tenhh = value;
            }
        }

        public string Mancc
        {
            get
            {
                return mancc;
            }

            set
            {
                mancc = value;
            }
        }

        public string Loaihang
        {
            get
            {
                return loaihang;
            }

            set
            {
                loaihang = value;
            }
        }

        public string Nhanhieu
        {
            get
            {
                return nhanhieu;
            }

            set
            {
                nhanhieu = value;
            }
        }

        public float Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }


        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Mota
        {
            get
            {
                return mota;
            }

            set
            {
                mota = value;
            }
        }

        public hanghoaDTO(DataRow row)
        {
            
            
            this.Soluong = Int32.Parse(row["soluongcon"].ToString());
        }
    }
}
