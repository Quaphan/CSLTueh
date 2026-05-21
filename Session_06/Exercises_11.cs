using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_11
    {
        public static bool KiemTraDoiXung(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);

            string daoNguoc = new string(arr);

            return s == daoNguoc;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(KiemTraDoiXung("radar"));
        }
    }
}
