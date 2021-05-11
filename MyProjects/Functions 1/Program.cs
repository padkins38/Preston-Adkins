using System;

namespace Functions_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("", "", "");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("hello");

            string answer;
            double val1;
            double val2 = 0;
            double final = 0;

            do
            {
                Console.WriteLine("What type of application do you want to run? (Add, Subtract, Multiply, Divide)");
                string calcask = Console.ReadLine().ToLower();
                Console.WriteLine("Do you want to use the result of their previous calculation as the first value? (Y/N)");
                string response = Console.ReadLine();

                if (response[0] == 'y')
                {
                    val1 = final;
                }
                else
                {
                    Console.WriteLine("What is your first number?");
                    val1 = Convert.ToDouble(Console.ReadLine());
                }
             
                Console.WriteLine("What is your second number?");
                val2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (calcask[0])
                {
                    case 'a':
                        result = Add(val1, val2);
                        final += result;
                        Console.WriteLine($"{val1} + {val2} = {result.ToString()}");
                        break;
                    case 's':
                        result = Subtract(val1, val2);
                        final += result;
                        Console.WriteLine($"{val1} - {val2} = {result.ToString()}");
                        break;
                    case 'm':
                        result = Multiply(val1, val2);
                        final += result;
                        Console.WriteLine($"{val1} * {val2} = {result.ToString()}");
                        break;
                    case 'd':
                        result = Divide(val1, val2);
                        final += result;
                        Console.WriteLine($"{val1} / {val2} = {result.ToString()}");
                        break;
                }
                Console.WriteLine("Do you want a new calulation?");
                answer = Console.ReadLine();
            } while (answer[0] == 'y');
            Console.WriteLine("You don't like math?");


        }  
        static double Add(double val1, double val2)
        {
            double output;
            output = val1 + val2;
            return output;
        }
        static double Subtract(double val1, double val2)
        {
            double output;
            output = val1 - val2;
            return output;
        }
        static double Multiply(double val1, double val2)
        {
            double output;
            output = val1 * val2;
            return output;
        }
        static double Divide(double val1, double val2)
        {
            double output;
            output = val1 / val2;
            return output;
        }
        static void DeveloperInformation(string devname, string classname, string date)
        {
            devname = "Preston Adkins";
            classname = "MIS 3303";
            date = "May 11, 2021";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{devname},\n{classname},\n{date}");
            Console.WriteLine();
            return;
        }
    }
}
