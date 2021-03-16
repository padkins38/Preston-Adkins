using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 101); //Generates a random number between 1 and 100
            int divisibleby3Remainder = randomNbr % 3;
            bool isDivisbleBy3 = divisibleby3Remainder % 3 == 0;
            randomNbr = 20;

            if (randomNbr % 3 == 0
               && randomNbr % 5 == 0)// == (true)
            {
                Console.WriteLine("Fizz");
            }
            else if (randomNbr % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNbr % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine(randomNbr);
            }
        }
    }
}