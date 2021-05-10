using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtraCredit
{
    public class Game
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public double GlobalSales { get; set; }

        public Game()
        {
            Name = "";
            Platform = "";
            Year = 0;
            Genre = "";
            Publisher = "";
            GlobalSales = 0;
        }
        public override string ToString()
        {
            string output = $"{Name}. {Platform}. {Year}. {Genre}. {Publisher}. {GlobalSales.ToString("N0")}.";

            return output;
        }
        /*public Game(int year, double salesNum)
        {
            Name = string.Empty;
            Platform = string.Empty;
            Year = year;
            Genre = string.Empty;
            Publisher = string.Empty;
            GlobalSales = salesNum;
        }*/
        /*public Game(double salesNum)
        {
            Name = string.Empty;
            Platform = string.Empty;
            Year = 0;
            Genre = string.Empty;
            Publisher = string.Empty;
            GlobalSales = salesNum;
        }*/
        /*public Game(string name, string platform, string genre, string publisher)
        {
            Name = name;
            Platform = platform;
            Year = 0;
            Genre = genre;
            Publisher = publisher;
            GlobalSales = 0;
        }*/
    }
}
