using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class StringDisplayer : IDisplay<string>
    {
        public void Display(string value)
        {
            Console.WriteLine(value);
        }
    }
}
