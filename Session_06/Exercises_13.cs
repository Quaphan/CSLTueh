using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_13
    {
        public static int TimMin(int[] arr)
        {
            int min = arr[0];

            foreach (int item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 8, 2, 9 };

            Console.WriteLine(TimMin(arr));
        }
    }
}
