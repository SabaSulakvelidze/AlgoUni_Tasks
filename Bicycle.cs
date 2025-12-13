using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bicycle is moveing");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle stoped");
        }
    }
}
