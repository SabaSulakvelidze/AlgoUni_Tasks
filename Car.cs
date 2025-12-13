using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Car : Vehicle, IRaceVehicle
    {
        public void ActivateTurbo()
        {
            Console.WriteLine("Car Turbo Activated!");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Car engine started!");
        }
    }
}
