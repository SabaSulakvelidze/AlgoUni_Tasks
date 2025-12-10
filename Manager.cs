using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, string position, int teamSize) : base(name, position)
        {
            TeamSize = teamSize;
        }
    }
}
