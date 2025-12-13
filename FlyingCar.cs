using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class FlyingCar : IDrive, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Driving!");
        }

        public void Drive()
        {
            Console.WriteLine("Flying!");
        }
    }
}
