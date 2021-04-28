using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the ToyBox Dictionary to hold everything in
            Dictionary<string, List<Toy>> boxes = new Dictionary<string, List<Toy>>();
            ToyBox toybox = new ToyBox();

            //creat the Toy List to hold each individual toy in
            Toy toy1 = new Toy();
          
            string answer;
            //first must ask info for the OuterClass (TOYBOX)
            do
            {
                Console.WriteLine("Who is the owner of this toybox?");
                toybox.Owner = Console.ReadLine();

                Console.WriteLine("What is the Location of this toybox?");
                toybox.Location = Console.ReadLine();

                boxes.Add(toybox.Owner + " " + toybox.Location, new List<Toy>());
                //then must ask info for the InnerClass (TOYS)
                do
                {
                    Console.WriteLine("What is the Name of the toy in this box?");
                    toy1.Name = Console.ReadLine();
                    Console.WriteLine("What is the Manufacturer of the toy?");
                    toy1.Manufacturer = Console.ReadLine();
                    Console.WriteLine("What is the Price of the toy?");
                    toy1.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Write a Toy description (e.g. This toy is super duper fun #wooo");
                    toy1.AddNotes(Console.ReadLine());

                    boxes[toybox.Owner + " " + toybox.Location].Add(toy1);

                    Console.WriteLine("Is there another toy in this box?? (Y/N) >>");
                    answer = Console.ReadLine().ToLower();
                    toy1 = new Toy();

                } while (answer[0] == 'y');

                Console.WriteLine("Do you have another toybox to add?? (Y/N) >>");
                answer = Console.ReadLine().ToLower();

            } while (answer[0] == 'y');

            Console.WriteLine("This box holds the following items");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in boxes)
            {
                String[] sp = item.Key.Split(" ");
                Console.WriteLine($"\n{sp[0]} is located in {sp[1]} with toys of:");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine(item.Value[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("the following are random toys from each box");

            foreach (var item in boxes)
            {
                String[] sp = item.Key.Split("");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    toybox.Toys.Add(item.Value[i]);
                }
                Console.WriteLine($"\nA random toy in {sp[0]} toy box is:");
                Console.WriteLine(toybox.GetRandomToy());
                toybox.Toys.Clear();
            }                       
        }                           
    }                               
}                                   
                                    