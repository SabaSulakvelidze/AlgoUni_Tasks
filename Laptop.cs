using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Laptop
    {
        public string Model { private set; get; }
        public int RAMSize { private set; get; }

        public Laptop(string model, int ramSize)
        {
            Model = model;
            RAMSize = ramSize;
        }
    }
}
