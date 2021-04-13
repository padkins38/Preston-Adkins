using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{ 
    public class Rectangle //Make sure to make it a public class as habit for next semester
    {

        //this is what the public double Lenght { get; set; } is doing in the background


        //private double _Width;
        //
        //public double GetWidth()
        //{
        //    return _Width;
        //}
        //public void SetWidth(double width)
        //{
        //    _Width = width;
        //}


        public double Length { get; set; }
        public double Width { get; set; }
        /// <summary>
        /// Overloaded constructor, where we know what values we want to start the width and length to
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Length">Set Width and Length as values</param>
        public Rectangle(double width, double length)
        {
            this.Width = width;
            Length = length;
        }

        /// <summary>
        /// Default/Empty constructor that sets this instance of a Rectanle to starting values
        /// </summary>
        public Rectangle()
        {
            Width = 5;   //creating every rectangle with a starting value of 5
            Length = 5;
        }

        //CalculateArea( w:double, l:double ) :

        /// <summary>
        /// Calculates the are of this Rectangle
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculateArea()
        {

            return Length * Width;
        }
        /// <summary>
        /// Calculated the Perimeter of this Rectangle
        /// </summary>
        /// <returns>The perimeter of this Rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
