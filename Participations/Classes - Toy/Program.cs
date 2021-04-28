using System;
using System.Collections.Generic;

namespace Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();

            //instance 1 for toy
            Toy t1 = new Toy();

            t1.Manufacturer = "Beulah's Candyland";
            t1.Name = "Milk Chocolate Peanut Clusters 2 pounds";
            t1.Price = 23.00;
            t1.GetAisle();
            t1.AddNotes("I had these once when my MIS professor brought them to class and I ended up eating 6 because they were so yummy!");

            toys.Add(t1);

            //Console.WriteLine($"Manufacturer : {t1.Manufacturer} \nProduct Name : {t1.Name} \nPrice : {t1.Price.ToString("c2")} \nExtra Notes : {t1.GetNotes()} and can be found on Aisle {t1.GetAisle()}");
            /*Console.WriteLine(t1);*/

            //instance 2 for toy
            Toy t2 = new Toy();

            t2.Manufacturer = "BESTAR";
            t2.Name = "construction worker duck (rubber ducky)";
            t2.Price = 2.80;
            t2.GetAisle();
            t2.AddNotes("Great quality and massive quantity");

            toys.Add(t2);

            //Console.WriteLine($"Manufacturer : {t2.Manufacturer} \nProduct Name : {t2.Name} \nPrice : {t2.Price.ToString("c2")} \nExtra Notes : {t2.GetNotes()} and can be found on Aisle {t2.GetAisle()}");
            /*Console.WriteLine(t2);*/

            foreach (var item in toys)
            {
                Console.WriteLine(item);
            }
            










        }
    }
}
