using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyBatDongSan.Utils
{
    class chuanhoa
    {
        private static chuanhoa instance;

        internal static chuanhoa Instance
        {
            get { if (instance == null) instance = new chuanhoa(); return instance; }
            set { instance = value; }
        }
        // chuaarn hóa mã hàng hóa 
        public bool chuanhoamaHH(String mahh)
        {
            String patter = @"^[H]{2}[0-9]{1,}$";
            Regex kt = new Regex(patter);
            if (kt.IsMatch(mahh))
            {
                return true;
            }
            return false;
        }
        // chẩn hóa mã nhà cung cấp
        public bool chuanhoamancc(String mancc)
        {
            String patter = @"^[NCC]{3}[0-9]{1,}$";
            Regex kt = new Regex(patter);
            if (kt.IsMatch(mancc))
            {
                return true;
            }
            return false;
        }

        // chuẩn hóa mã khách hàng (tương đương SCm)
        public bool checkSCM(String SCM)
        {
            String patter = @"^[0-9]{9,10}$";
            Regex kt = new Regex(patter);
            if (kt.IsMatch(SCM))
            {
                return true;
            }
            return false;
        }
    }
}
