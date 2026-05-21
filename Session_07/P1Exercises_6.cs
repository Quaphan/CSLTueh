using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_6
    {
        public static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            ReverseArray(arr);
        }
    }
}
