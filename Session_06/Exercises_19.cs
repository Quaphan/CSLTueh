using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_19
    {
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(KiemTraNamNhuan(2024));
        }
    }
}
