using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_3
    {
        static void SeparateCharacters(string str)
        {
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            SeparateCharacters(str);
        }
    }
}
