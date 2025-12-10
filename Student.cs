using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Student:Person
    { 
        public string Name{ private set; get; }
        public string Grade{ private set; get; }

        public Student() { }

        public Student(int age,string name,string grade):base(age)
        {
            Name = name;
        }
    }
}
