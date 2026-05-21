using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_7
    {
        public static void InFibonacci(int n)
        {
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        static void Main(string[] args)
        {
            InFibonacci(6);
        }
    }
}
