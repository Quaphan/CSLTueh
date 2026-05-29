using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_10
    {
        static void Solve(int[] a)
        {
            int cur = a[0], max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                cur = Math.Max(a[i], cur + a[i]);
                max = Math.Max(max, cur);
            }

            Console.WriteLine(max);
        }
    }
}
