using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_2
    {
        static void Solve(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];

            double avg = (double)sum / a.Length;

            Console.WriteLine(sum + " " + avg.ToString("0.00"));
        }
    }
}
