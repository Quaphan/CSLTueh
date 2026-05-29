using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_4
    {
        static void Solve(int[] a)
        {
            int even = 0, odd = 0;

            foreach (int x in a)
            {
                if (x % 2 == 0) even++;
                else odd++;
            }

            Console.WriteLine(even + " " + odd);
        }
    }
}
