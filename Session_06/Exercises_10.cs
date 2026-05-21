using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_10
    {
        public static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;

            foreach (int item in arr)
            {
                tong += item;
            }

            return (double)tong / arr.Length;
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7 };

            Console.WriteLine(TinhTrungBinh(arr));
        }
    }
}
