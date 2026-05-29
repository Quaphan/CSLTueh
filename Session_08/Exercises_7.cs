using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_7
    {
        static void CountCharacters(string str)
        {
            int alphabet = 0;
            int digit = 0;
            int special = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    alphabet++;
                else if (char.IsDigit(c))
                    digit++;
                else
                    special++;
            }

            Console.WriteLine("Alphabets: " + alphabet);
            Console.WriteLine("Digits: " + digit);
            Console.WriteLine("Special characters: " + special);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            CountCharacters(str);
        }
    }
}
