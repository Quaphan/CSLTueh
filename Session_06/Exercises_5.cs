using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_5
    {
        public static string DaoNguocChuoi(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DaoNguocChuoi("hello"));
        }
    }
}
