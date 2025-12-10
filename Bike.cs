using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Bike:Vehicle
    {
        public string Type { get; set; }

        public Bike(string manufacturer, string type) : base(manufacturer)
        {
            Type = type;
        }
    }
}
