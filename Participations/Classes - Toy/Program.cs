using System;

namespace Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance 1 for toy
            Toy t1 = new Toy();

            t1.Manufacturer = "Beulah's Candyland";
            t1.Name = "Milk Chocolate Peanut Clusters 2 pounds";
            t1.Price = 23.00;
            t1.GetAisle();
            t1.AddNotes("I had these once when my MIS professor brought them to class and I ended up eating 6 because they were so yummy!");
            Console.WriteLine($"Manufacturer : {t1.Manufacturer} \nProduct Name : {t1.Name} \nPrice : {t1.Price.ToString("c2")} \nExtra Notes : {t1.GetNotes()}");
            Console.WriteLine($"Aisle Identification : {t1.GetAisle()}");
            Console.WriteLine();

            //instance 2 for toy
            Toy t2 = new Toy();

            t2.Manufacturer = "BESTAR";
            t2.Name = "construction worker duck (rubber ducky)";
            t2.Price = 2.80;
            t2.GetAisle();
            t2.AddNotes("Great quality and massive quantity");
            Console.WriteLine($"Manufacturer : {t2.Manufacturer} \nProduct Name : {t2.Name} \nPrice : {t2.Price.ToString("c2")} \nExtra Notes : {t2.GetNotes()}");
            Console.WriteLine($"Aisle Identification : {t2.GetAisle()}");
            Console.WriteLine();










        }
    }
}
