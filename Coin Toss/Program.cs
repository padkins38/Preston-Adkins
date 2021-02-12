using System;

namespace Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask heads or tails
            Console.WriteLine("Chose heads or tails! You lose, you DIE. >>");
            string response = Console.ReadLine();
                                    
            //generate the rand num
            Random rand = new Random();
            int randomNbr = rand.Next(1, 3); //generated 2 options
            int Guess = 0;
            int coin = 0;

            if (response == "heads") //heads = 1
            {
                Guess = 1;
            }
            else if (response == "tails") //tails = 2
            {
                Guess = 2;
            }
            if (randomNbr == 1)
            {
                coin = 1;
                Console.WriteLine("The answer has landed on Heads"); //testing purposes
            }
            else if (randomNbr == 2)
            {
                coin = 2;
                Console.WriteLine("The answer has landed on Tails"); //testing purposes
            }
            if (Guess == coin)
            {
                Console.WriteLine("YOU HAVE WON! CONRATS!");
            }
            else
                Console.WriteLine("booo you are a loser");

         



         


         

         

        }
    }
}
