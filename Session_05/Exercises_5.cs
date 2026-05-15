using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_05
{
    internal class Exercises_5
    {
        static bool IsPerfect(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Perfect numbers less than 1000:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
