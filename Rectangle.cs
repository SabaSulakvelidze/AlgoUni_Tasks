using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Rectangle
    {
        private double width;
        private double height;


        public double Width
        {
            set
            {
                if (value > 0) width = value;             
            }
            get
            {
                return width;            
            }
        }

        public double Height
        {
            set
            {
                if (value > 0) height = value;             
            }
            get
            {
                return height;            
            }
        }

        public double Area { private set; get; }

        

      
    }
}
