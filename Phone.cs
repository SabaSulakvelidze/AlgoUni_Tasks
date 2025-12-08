using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Phone
    {
        public string Model { get; private set; }
        public string Color { get; private set; }

        public Phone(string model, string color)
        {
            Model = model;
            Color = color;
        }
    }
}
