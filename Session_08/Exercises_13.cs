using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_13
    {
        static string InsertSubstring(string str, string word, string insertStr)
        {
            int position = str.IndexOf(word);

            if (position != -1)
            {
                return str.Insert(position, insertStr + " ");
            }

            return "Word not found";
        }

        static void Main(string[] args)
        {
            Console.Write("Enter main string: ");
            string str = Console.ReadLine();

            Console.Write("Enter word to find: ");
            string word = Console.ReadLine();

            Console.Write("Enter substring to insert: ");
            string insertStr = Console.ReadLine();

            Console.WriteLine(InsertSubstring(str, word, insertStr));
        }
    }
}
