using System;
using System.Drawing;

namespace Classes_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //first instance or the Rectangle
            Rectangle r1 = new Rectangle();
            r1.Length = 8
            r1.Width = 8;

            double area = r1.CalculateArea();

            Console.WriteLine($"Rectangle 1 - L:{r1.Length}, W:{r1.Width}, A:{area}, P:{r1.CalculatePerimeter()}")
            
            //second instance of the Rectangle
            Rectangle r2 = new Rectangle(15, 11);
            Console.WriteLine($"Rectangle 2 - L:{r2.Length}, W:{r2.Width}, A:{r2.CalculateArea()}, P:{r2.CalculatePerimeter()}")
            r2.Width = 10;
            Console.WriteLine("Changed the width to 10");
            Console.WriteLine($"Rectangle 2 - L:{r2.Length}, W:{r2.Width}, A:{r2.CalculateArea()}, P:{r2.CalculatePerimeter()}")

        }
    }
}
