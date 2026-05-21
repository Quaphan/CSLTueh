using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_1
    {
        public static double CalculateAverage(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }

            return (double)sum / arr.Length;
        }

        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 100);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Average: " + CalculateAverage(arr));
        }
    }
}
