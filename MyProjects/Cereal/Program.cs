using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cereal> Cereals = new List<Cereal>();
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                //name|manufacturer|calories|cups
                //  0        1          2      3
                Cereal g = new Cereal();
                string line = lines[i];
                string[] pieces = line.Split("|");
                //pieces = { "100% Bran", "Nabisco", "70", ".33"}
                g.Manufacturer = pieces[0];
                g.Name = pieces[1];
                g.SetCalories(Convert.ToDouble(pieces[2]));
                g.Cups = Convert.ToDouble(pieces[3]);
                Cereals.Add(g);
            }
            foreach  (Cereal item in Cereals)
            {
                //Console.WriteLine($"{item.Manufacturer}|{item.Name}|{item.Calories}|{item.Cups}");
                if (item.Cups >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{item.Manufacturer}|{item.Name}|{item.GetCalories()}|{item.Cups}");
                }
                else if (item.GetCalories() <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.Manufacturer}|{item.Name}|{item.GetCalories()}|{item.Cups}");
                }
                else if (item.Cups >= 1 && item.GetCalories() <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{item.Manufacturer}|{item.Name}|{item.GetCalories()}|{item.Cups}");
                }
            }
        }
    }
}
