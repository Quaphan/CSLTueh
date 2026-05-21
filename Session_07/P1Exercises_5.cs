using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_5
    {
        public static void FindMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            foreach (int num in arr)
            {
                if (num > max)
                    max = num;

                if (num < min)
                    min = num;
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 9, 1, 5 };

            FindMaxMin(arr);
        }
    }
}
