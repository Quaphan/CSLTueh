using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_2
    {
        static int StringLength(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Length: " + StringLength(str));
        }
    }
}
