using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_3
    {
        static void Solve(int[] a)
        {
            int max = a[0], min = a[0];

            foreach (int x in a)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }

            Console.WriteLine(max + " " + min);
        }
    }
}
