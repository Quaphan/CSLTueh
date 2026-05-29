using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_7
    {
        static void Solve(int[] a)
        {
            int l = 0, r = a.Length - 1;

            while (l < r)
            {
                if (a[l] != a[r])
                {
                    Console.WriteLine("NO");
                    return;
                }
                l++; r--;
            }

            Console.WriteLine("YES");
        }
    }
}
