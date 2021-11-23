using System;
using System.Collections.Generic;
using System.Text;

namespace Cereal
{
    public class Cereal
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Cups { get; set; }
        private double Calories;
        public Cereal(double calories)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = calories;
            Cups = 0;
        }
        public double GetCalories()
        {
            return Calories;
        }
        public void SetCalories(double calorie)
        {
            Calories += calorie;
        }
        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }
        public override string ToString()
        {
            return $"{Manufacturer}|{Name}|{Calories.ToString("C0")}|{Cups.ToString("C0")}";
        }
        /*//for private
        private double Calories;
        private double Cups;
        public Cereal(double cups, double calories)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = calories;
            Cups = cups;
        }            
        //private cups
        public double GetCups()
        {
            return Cups;
        }
        public void SetCups(double cup)
        {
            Cups += cup;
        }
        //private calories
        public double GetCalories()
        {
            return Calories;
        }
        public void SetCalories(double calorie)
        {
            Calories += calorie;
        }*/














    }
}
