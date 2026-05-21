using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_07
{
    internal class P2Exercises_2
    {
        static void Main(string[] args)
        {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();

        string[] words = sentence.Split(' ');

        bool found = false;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Word found!");
        else
            Console.WriteLine("Word not found!");
    }
    }
}
