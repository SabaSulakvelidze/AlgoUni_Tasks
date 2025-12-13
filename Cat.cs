using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating!");
        }

        public void Speak()
        {
            Console.WriteLine("Meaw!");
        }
    }
}
