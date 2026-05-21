using System;
using System.Collections.Generic;
using System.Text;

namespace CSLTueh.Session_06
{
    internal class Exercises_16
    {
        public static string XoaTrungLap(string s)
        {
            string ketQua = "";

            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }

            return ketQua;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(XoaTrungLap("programming"));
        }
    }
}
