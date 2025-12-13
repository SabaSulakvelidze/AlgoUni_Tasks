using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace AlgoUni_Tasks
{
    internal static class TemperatureConverter
    {
        public static double ToFarenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double ToCelsius(double farenheit)
        {
            return (farenheit - 32) / 1.8 ;
        }
    }
}
