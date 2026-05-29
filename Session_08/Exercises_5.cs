using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_5
    {
        static int CountWords(string str)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();

            Console.WriteLine("Total words: " + CountWords(str));
        }
    }
}
