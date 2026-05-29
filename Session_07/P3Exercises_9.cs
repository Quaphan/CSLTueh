using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P3Exercises_9
    {
        static void Solve(int[] a)
        {
            foreach (int x in a)
                if (x % 2 == 0) Console.Write(x + " ");

            Console.WriteLine();

            foreach (int x in a)
                if (x % 2 != 0) Console.Write(x + " ");
        }
    }
}
