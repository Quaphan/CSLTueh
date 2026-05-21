using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P2Exercises_1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array:");

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
