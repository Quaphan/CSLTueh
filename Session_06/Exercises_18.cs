using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_18
    {
        public static string DecimalToBinary(int n)
        {
            string binary = "";

            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            return binary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToBinary(10));
        }
    }
}
