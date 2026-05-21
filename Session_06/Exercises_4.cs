using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_4
    {
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TinhGiaiThua(5));
        }
    }
}
