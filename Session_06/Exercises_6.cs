using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_6
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(KiemTraNguyenTo(7));
        }
    }
}
