using System;
using System.Collections.Generic;
using System.IO;

namespace ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            CallData();
            Console.ForegroundColor = ConsoleColor.White;
            List<Game> Games = new List<Game>();
            string[] lines = File.ReadAllLines("Game_Data.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                Game p = new Game();
                double total = 0;
                string line = lines[i];
                string[] pieces = line.Split(",");

                //Name,Platform,Year,Genre,Publisher,Global_Sales
                // 0   ,   1   ,  2  ,  3  ,   4    ,     5
                
                p.Name = pieces[0];
                p.Platform = pieces[1];
                p.Year = Convert.ToInt32(pieces[2]);
                p.Genre = pieces[3];
                p.Publisher = pieces[4];
                p.GlobalSales = Convert.ToDouble(pieces[5]);
             
                Games.Add(p);

            }
            /*Console.WriteLine("Which platform");
            string platform = Console.ReadLine().ToLower();*/
            Console.WriteLine("What year");
            string answer = Console.ReadLine().ToLower();
            foreach (Game item in Games)
            {
                /*if (item.Platform.ToLower() == platform)
                {
                    Console.WriteLine($"{item.Name}. {item.Platform}. {item.Year}. {item.Genre}. {item.Publisher}. {item.GlobalSales.ToString("N0")}.");
                }*/
                if(item.Year == Convert.ToInt32(answer))
                {
                    Console.WriteLine($"{item.Name}. {item.Platform}. {item.Year}. {item.Genre}. {item.Publisher}. {item.GlobalSales.ToString("N0")}.");
                }
            }
            static string CallData()
            {
                string[] lines = File.ReadAllLines("Game_Data.csv");
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    Console.WriteLine(line);
                }
                return "";
            }
        }
    }
}
