using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Circle
    {
        public double Radius { get; set; }
        
        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
