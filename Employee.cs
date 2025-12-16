using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Employee
    {
        public string Department { get; set; }
        public double Salary { get; set; }

        public string Name { get; set; }

        public Employee(string name, string department, double salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, Department: {Department}, Salary: {Salary}";
        }
    }
}
