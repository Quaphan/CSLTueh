using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_3
    {
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TimMax(10, 20, 15));
        }
    }
}
