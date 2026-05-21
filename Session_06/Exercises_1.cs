using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_1
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int tong = TinhTong(5, 3);
            Console.WriteLine("Tong = " + tong);
        }
    }
}
