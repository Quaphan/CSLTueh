using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_20
    {
        public static int DemSoTu(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DemSoTu("Hoc lap trinh C# rat thu vi"));
        }
    }
}
