using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    
    abstract class Vehicle
    {
        public int MaxSpeed { get; protected set; }

        public abstract void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("Vehicle engine stopped");
        }
    }
}
