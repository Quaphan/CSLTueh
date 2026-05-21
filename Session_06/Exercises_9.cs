using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_9
    {
        public static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;

            for (int i = 0; i < y; i++)
            {
                ketQua *= x;
            }

            return ketQua;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TinhLuyThua(2, 3));
        }
    }
}
