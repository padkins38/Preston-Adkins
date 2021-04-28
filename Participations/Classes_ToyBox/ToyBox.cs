using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }     
        public string Owner { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Owner:\n{Owner}\nLocation: {Location}";
        }
        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }
        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int random = rand.Next(0, Toys.Count);
            return Toys[random];
        }       
    }   
}       
        