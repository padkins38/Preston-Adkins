using System;

namespace SumOf3
{
    class Program
    {
        public static bool Number1AsString { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # >>");
            string answer = Console.ReadLine();
            int luckyNbr;

            if(int.TryParse(answer, out luckyNbr) == false)
            {
                Console.WriteLine("Sorry you entered an invalid integer, please try again. Please enter another number");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Yay now you know how to enter an integer!");
        }
    }
}
