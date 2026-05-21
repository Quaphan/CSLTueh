using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_7
    {
        public static void FindDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1 };

            FindDuplicates(arr);
        }
    }
}
