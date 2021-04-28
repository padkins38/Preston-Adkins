using System;
using System.Collections.Generic;
using System.IO;

namespace _P__Classes___Cereal__read_in_a_File_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cereal> bowls = new List<Cereal>();
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //[0] = "name\manufacturer\calories\cups"
            //[1] = "100% Bran|Nabisco|70|0.33"
            //[..] = ".."

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                //line = "100% Bran|Nabisco|70|.33"

                string[] pieces = line.Split('|');
                //pieces = { "100% Bran", "Nabisco", "70", ".33"}
                Cereal c = new Cereal();
                c.Name = pieces[0];
                c.Manufacturer = pieces[1];
                c.Calories = Convert.ToDouble(pieces[2]);
                c.Cups = Convert.ToDouble(pieces[3]);

                bowls.Add(c);
            }
            //Go through bowls and output the desired cereals          
            foreach (Cereal brand in bowls)
            {
                if (brand.Cups >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{brand.Name} has {brand.Cups} cups per serving which is >= 1.");
                    Console.WriteLine();
                }
                if (brand.Calories <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{brand.Name} has {brand.Calories} calroies per serving which is <= 100!");
                    Console.WriteLine();
                }
            }            
            //Final Exam Problem Outlook
            //First problem is a meathod maybe with UML
            //Second similar to this participation -- Read in && UML
        }
    }
}
