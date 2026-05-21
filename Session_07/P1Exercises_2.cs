using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_2
    {
        public static bool ContainsValue(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value)
                    return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20 };

            Console.WriteLine(ContainsValue(arr, 10));
        }
    }
}
