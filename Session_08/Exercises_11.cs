using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_08
{
    internal class Exercises_11
    {
        static void CheckCharacter(char c)
        {
            if (char.IsLetter(c))
            {
                Console.WriteLine("It is an alphabet");

                if (char.IsUpper(c))
                    Console.WriteLine("Uppercase");
                else
                    Console.WriteLine("Lowercase");
            }
            else
            {
                Console.WriteLine("Not an alphabet");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char c = char.Parse(Console.ReadLine());

            CheckCharacter(c);
        }
    }
}
