using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_05
{
    internal class Exercises_4
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            int number = 12;

            if (IsPrime(number))
                Console.WriteLine(number + " is a prime number");
            else
                Console.WriteLine(number + " is not a prime number");
        }
    }
}
