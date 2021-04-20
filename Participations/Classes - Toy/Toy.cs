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

        public void AddNotes(string notes)
        {
            Notes = notes;
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
        //couldn't get the override to work
        /*public override string ToString()
        {
            string toy = $"Manufacturer: {Manufacturer} \nProduct Name : {Name} \nPrice: {Price.ToString("c2")} \nExtra Notes : {GetNotes()} \nAisle Identification : {GetAisle()}";
            return toy;
        }*/
      /*  public string GetNotes()
        {
            return Notes;
        }
        public void AddNote(string note)
        {
            Notes += "n" + note;
        }*/
        

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
