using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_4
    {
        public static int[] RemoveElement(int[] arr, int value)
        {
            int count = 0;

            foreach (int num in arr)
            {
                if (num != value)
                    count++;
            }

            int[] result = new int[count];
            int index = 0;

            foreach (int num in arr)
            {
                if (num != value)
                {
                    result[index] = num;
                    index++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 10, 20 };

            int[] result = RemoveElement(arr, 10);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}
