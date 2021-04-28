using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Cereal__read_in_a_File_
{
    public class Cereal
    {
        public string Manufacturer { get; set;}
        public string Name { get; set;}
        public double Calories { get; set;}
        public double Cups { get; set; }

        public Cereal()
        {
            Manufacturer = string.Empty;    
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }
    }
}
