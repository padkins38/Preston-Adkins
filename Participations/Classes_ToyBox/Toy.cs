using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        //get set for a private method
        private string Notes;
        public override string ToString()
        {
            Console.WriteLine();
            return $"Manufacturer : {Manufacturer} \nProduct Name : {Name} \nPrice : {Price.ToString("c2")} \nExtra Notes : {GetNotes()}";
        }
        public void AddNotes(string notes)
        {
            Notes += notes;
        }
        public string GetNotes()
        {
            return Notes;
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
    } 
}
