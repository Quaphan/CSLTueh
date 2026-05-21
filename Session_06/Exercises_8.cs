using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_8
    {
        public static int DemNguyenAm(string s)
        {
            int dem = 0;
            s = s.ToLower();

            foreach (char c in s)
            {
                if ("aeiou".Contains(c))
                {
                    dem++;
                }
            }

            return dem;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DemNguyenAm("Hello World"));
        }
    }
}
