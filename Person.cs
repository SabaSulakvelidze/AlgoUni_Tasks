using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace AlgoUni_Tasks
{
    internal class Person
    {
        private int age;

        public int Age
        {
            set 
            {
                if (value > 0) age = value;
            }
            get
            {
                return age;
            }
        }

        public void AddBalance()
        { 
            
        }
    }
}
