using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_8
    {
        static void CountVowelsConsonants(string str)
        {
            int vowels = 0;
            int consonants = 0;

            str = str.ToLower();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            CountVowelsConsonants(str);
        }
    }
}
