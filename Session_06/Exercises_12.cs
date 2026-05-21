using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_12
    {
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CelsiusToFahrenheit(25));
        }
    }
}
