using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal static class Calculator
    {
        public static int Max(int Num)
        {
            if (Num > 9 && Num < 100)
            {

            }
            else throw new Exception("Number does not have 2 digits");

            int d1 = Num / 10;
            int d2 = Num % 10;
            return Math.Max(d1, d2);
        }
    }
}
