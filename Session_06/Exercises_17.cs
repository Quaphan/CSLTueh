using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_17
    {
        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(UCLN(12, 18));
        }
    }
}
