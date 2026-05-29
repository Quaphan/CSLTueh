using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_8
    {
        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        static void Solve(int[] a)
        {
            bool ok = false;

            foreach (int x in a)
            {
                if (IsPrime(x))
                {
                    Console.Write(x + " ");
                    ok = true;
                }
            }

            if (!ok) Console.Write("EMPTY");
        }
    }
}
