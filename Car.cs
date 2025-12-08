using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Car
    {
        private short speed;

        public short Speed
        {
            get { return speed; }
            set 
            {
                if (value >= 0) speed = value;
            }
        }

    }
}
