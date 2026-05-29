using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_12
    {
        static int CountSubstring(string str, string sub)
        {
            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count++;
                index += sub.Length;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            Console.WriteLine("Occurrences: " + CountSubstring(str, sub));
        }
    }
}
