using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNbr = Convert.ToInt32(answer);
            //int luckyNbr = Convert.ToInt32(Console.Readline());

            bool isAnswerAnInteger = int.TryParse(answer, out luckyNbr);

            if (isAnswerAnInteger == false)
            {
                Console.WriteLine("Sorry that was invalid. Goodbye.");
                Environment.Exit(-1);
            }

            int remainder = luckyNbr % 7;

            if (remainder == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")}is really a lucky number");
            }
            else if (luckyNbr % 13 == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")}is really a unlucky number");
            }
            else
            {
                Console.WriteLine($"meh... {luckyNbr.ToString("N0")}");
            }

            Console.WriteLine("What is your first name >?");
            string name = Console.ReadLine();

            switch (name)
            {
                case "adam":
                    Console.WriteLine("YEahh buddy!");
                    break;
                case "darby":
                    Console.WriteLine("meh it could be better... now Adam is a cool name");
                    break;
                default:
                    Console.WriteLine("Yeet");
                    break;
            }

        }
    }
}
