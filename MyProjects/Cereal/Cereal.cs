using System;
using System.Collections.Generic;
using System.Text;

namespace Cereal
{
    public class Cereal
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer}|{Name}|{Calories.ToString("C0")}|{Cups.ToString("C0")}";
        }
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }














    }
}
