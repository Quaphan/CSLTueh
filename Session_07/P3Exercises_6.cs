using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_6
    {
        static void Solve(int[] a)
        {
            int l = 0, r = a.Length - 1;

            while (l < r)
            {
                int tmp = a[l];
                a[l] = a[r];
                a[r] = tmp;

                l++; r--;
            }

            foreach (int x in a)
                Console.Write(x + " ");
        }
    }
}
