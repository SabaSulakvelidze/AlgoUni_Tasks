using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Employee
    {
        public string Name { get; private set; }
        public string Position { get; private set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}
