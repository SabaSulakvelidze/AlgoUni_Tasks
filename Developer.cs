using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Developer : IWorker
    {
        public double GetSalary()
        {
            return 5_000;
        }

        public void Work()
        {
            Console.WriteLine("Deveoper is working!");
        }
    }
}
