using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P1Exercises_8
    {
        public static int[] RemoveDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int count = 0;

            foreach (int num in arr)
            {
                bool exists = false;

                for (int i = 0; i < count; i++)
                {
                    if (temp[i] == num)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[count] = num;
                    count++;
                }
            }

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 1 };

            int[] result = RemoveDuplicates(arr);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}
