using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyBatDongSan.Utils
{
    class rangbuoc
    {
        private static rangbuoc instance;

        internal static rangbuoc Instance
        {
            get { if (instance == null) instance = new rangbuoc(); return instance; }
            set { instance = value; }
        }


        public bool checkemail(String email)
        {
            String patter = @"^[a-zA-Z0-9_]{1,}@[a-zA-Z0-9_]{1,}\.[a-zA-Z]{1,}$";
            Regex test = new Regex(patter);
            if (test.IsMatch(email))
            {

                return true;
            }
            return false;

        }


        public bool checkphone(String number)
        {
            String patter = @"^0{1}[1-9]{1}[0-9]{8,9}$";
            Regex test = new Regex(patter);
            if (test.IsMatch(number))
            {

                return true;
            }
            return false;
        }


       
    }
}
