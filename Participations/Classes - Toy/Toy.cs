using System;
using System.Collections.Generic;
using System.Text;

namespace Classes___Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        //get set for a private method
        private string Notes;
        public string GetNotes()
        {
            return Notes;
        }
        public void SetNotes(string notes)
        {
            Notes = notes;
        }
        //get set for a public method
        public Toy(string manufacturer, string name, double price)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
        }
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";

        }
        public string GetAisle()
        {
            Random rand = new Random();
            int randNum;

            randNum = rand.Next(1, 25);
            string Aisle = Manufacturer[0].ToString().ToUpper() + randNum;
            return Aisle;
        }
    }



}
