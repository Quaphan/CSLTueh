using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_15
    {
        public static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 2 };

            SapXepMang(arr);
        }
    }
}
