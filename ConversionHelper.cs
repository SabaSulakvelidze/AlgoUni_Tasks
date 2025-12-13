using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal static class ConversionHelper
    {
        private const double Factor = 1.609344;

        public static double ToMile(double kmValue)
        {
            return kmValue / Factor;
        }

        public static double ToKm(double mileValue)
        {
            return mileValue * Factor;
        }
    }
}
