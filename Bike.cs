using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Bike : Vehicle, IRaceVehicle
    {
        public void ActivateTurbo()
        {
            Console.WriteLine("Bike Turbo Activated!");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started!");
        }
    }
}
