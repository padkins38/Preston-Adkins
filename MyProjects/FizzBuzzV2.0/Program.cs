using System;
using System.Collections.Generic;

namespace FizzBuzzV2._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> iterations = new Dictionary<int, string>();
            Console.ForegroundColor = ConsoleColor.White;
            string a;
            int aAsDouble;
            string trial;

            Console.WriteLine("How many iterations do you want to go through? (e.g. 100, 1000, 10000?)");
            aAsDouble = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < aAsDouble+1; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    trial = "FizzBuzz";
                    Console.WriteLine(trial);
                    iterations.Add(i, trial);
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    trial = "Fizz";
                    Console.WriteLine(trial);
                    iterations.Add(i,trial);
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    trial = "Buzz";
                    Console.WriteLine(trial);
                    iterations.Add(i,trial);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    trial = i.ToString();
                    Console.WriteLine(trial);
                    iterations.Add(i,trial);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Looking for a specific iteration? (e.g. Yes or No)");
            a = Console.ReadLine().ToLower();
            while (a[0] == 'y')
            {
                Console.WriteLine("Which iteration would you like to look at?");
                a = Console.ReadLine();
                foreach (KeyValuePair<int, string> item in iterations)
                {
                    if (Convert.ToDouble(a) == item.Key)
                    {
                        switch (item.Value)
                        {
                            case "Fizz" :
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(item.Value);
                                break;
                            case "Buzz":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(item.Value);
                                break;
                            case "FizzBuzz":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(item.Value);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(item.Value);
                                break;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Would you like to continue?");
                a = Console.ReadLine().ToLower();
            }
            //Outside the While Loop
            Console.WriteLine("Would you like to list all Fizz numbers?");
            a = Console.ReadLine().ToLower();
            if (a[0] == 'y')
            {
                foreach (KeyValuePair<int,string> item in iterations)
                {
                    if (item.Value.ToString() == "Fizz")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(item.Key);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.WriteLine("Would you like to list all Buzz numbers?");
            a = Console.ReadLine().ToLower();
            if (a[0] == 'y')
            {
                foreach (KeyValuePair<int, string> item in iterations)
                {
                    if (item.Value.ToString() == "Buzz")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(item.Key);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.WriteLine("Would you like to list all FizzBuzz numbers?");
            a = Console.ReadLine().ToLower();
            if (a[0] == 'y')
            {
                foreach (KeyValuePair<int, string> item in iterations)
                {
                    if (item.Value.ToString() == "FizzBuzz")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(item.Key);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
