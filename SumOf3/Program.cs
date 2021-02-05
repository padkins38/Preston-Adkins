using System;

namespace SumOf3
{
    class Program
    {
        public static bool Number1AsString { get; private set; }

        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; //local constant variable
                                               //MAGIC_NUMBER = 8;

            double Number1;            
            Console.WriteLine("Enter a number between 1 and 5.5>");
            String Number1AsString = Console.ReadLine();
            Number1 = Convert.ToDouble(Number1AsString);

            double Number2;
            Console.WriteLine("Enter a second number between 1 and 5.5>>");
            String Number2AsString = Console.ReadLine();
            Number2 = Convert.ToDouble(Number2AsString);

            double Number3;
            Console.WriteLine("Enter a third number between 1 and 5.5>>>");
            String Number3AsString = Console.ReadLine();
            Number3 = Convert.ToDouble(Number3AsString);

            double Total = Number1 + Number2 + Number3;
            double Answer = Total * MAGIC_NUMBER;
            string Final = Answer.ToString("F3");
            Console.WriteLine(Final);


         



        }
    }
}
