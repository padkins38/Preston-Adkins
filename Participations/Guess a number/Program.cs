using System;

namespace Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinNbr;
            int MaxNbr;
            int RanNbr;

            Console.WriteLine("Pick an integer that will be used as a minimum boundary >>>");
            string answer1 = Console.ReadLine();

            while (int.TryParse(answer1, out MinNbr) == false)
            {
                Console.WriteLine($"Sorry, {answer1} is an incorrect response.");

            }

            Console.WriteLine("Pick an integer that will be used as a Maximum boundary >>>");
            string answer2 = Console.ReadLine();

            while (int.TryParse(answer2, out MaxNbr) == false)
            {
                Console.WriteLine($"Sorry, {answer2} is an incorrect response. Answer with an Integer.");

            }

            //This section is so the user doesn't pick a max lower than the min
            while (MinNbr >= MaxNbr)
            {
                Console.WriteLine("Your Minimum number is greater than your maximum number! Please try again");
                answer2 = Console.ReadLine();

                while (int.TryParse(answer2, out MaxNbr) == false)
                {
                    Console.WriteLine($"Sorry, {answer2} is an incorrect response. Answer with an Integer.");
                }
            }

            //Generate randNbr
            Random rand = new Random();
            RanNbr = rand.Next(MinNbr, MaxNbr + 1);

            Console.WriteLine($"Now you have to Guess until you get the random number correct between {answer1} and {answer2}! MWahahahaa >:)");
            string answer3 = Console.ReadLine();
            int guess;

            //Create the loop for guessing
            while (int.TryParse(answer3, out guess) == false)
            {
                Console.WriteLine($"Sorry, {answer3} is an incorrect response. Answer with an Integer.");
                answer3 = Console.ReadLine();


            while (guess != RanNbr)
            {
                Console.WriteLine("You need to guess again");
                answer3 = Console.ReadLine();

                while (int.TryParse(answer3, out guess) == false)
                {
                    Console.WriteLine($"Sorry, {answer3} is an incorrect response. Answer with an Integer."); answer3 = Console.ReadLine();
                }
            }
            Console.WriteLine("Congratulations!! WOOO! You have guessed the correct numebr!**>> :):)  ");

            }
        }
    }
}
