using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_14
    {
        public static int TongCacChuSo(int n)
        {
            int tong = 0;

            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }

            return tong;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TongCacChuSo(1234));
        }
    }
}
