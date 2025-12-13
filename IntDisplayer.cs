using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class IntDisplayer : IDisplay<int>
    {
        public void Display(int value)
        {
            Console.WriteLine(value);
        }
    }
}
