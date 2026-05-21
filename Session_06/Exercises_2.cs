using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_2
    {
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(KiemTraChan(8));
        }
    }
}
