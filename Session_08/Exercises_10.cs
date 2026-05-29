using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_10
    {
        static int FindPosition(string str, string sub)
        {
            return str.IndexOf(sub);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter substring: ");
            string sub = Console.ReadLine();

            Console.WriteLine("Position: " + FindPosition(str, sub));
        }
    }
}
