using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_9
    {
        static bool CheckSubstring(string str, string sub)
        {
            return str.Contains(sub);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            Console.WriteLine(CheckSubstring(str, sub));
        }
    }
}
