using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();

            string answer;

            do
            {
                Console.WriteLine("What is one of your favorite things? >> ");
                answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have another favorite thing to add? >>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');

            Random rand = new Random();
            int randomThingIndex = rand.Next(0, favoriteThings.Count);

            string randomThing = favoriteThings[randomThingIndex];
            Console.WriteLine($"Your random favoite thing is: \n{randomThingIndex}");
        }
    }
}
