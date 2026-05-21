using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_3
    {
        public static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20 };

            Console.WriteLine(FindIndex(arr, 15));
        }
    }
}
