using System;
using System.Collections.Generic;

namespace Functions_Example1
{
    class Program
    {
        static void Main(string[]   args)
        {
            List<double> gpas = new List<double>();
            List<double> itemPrices = new List<double>();
            string response = "";
            bool shouldLoopAgain = false;
            while (shouldLoopAgain) //response != "no"
            {
                double gpa = ValidateInputAsDouble("Please enter a GPA>>");  //ValidateInputAsDDouble is stored as "string message" line 26
                gpas.Add(gpa);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                /*Console.WriteLine("Do you want to enter another gpa? Yes or no?");
                response = Console.ReadLine();*/
            }

            while (shouldLoopAgain) //response != "no"
            {
                double itemPrice = ValidateInputAsDouble("Please enter the price of an item");
                itemPrices.Add(itemPrice);


               shouldLoopAgain = DoesTheUserWantToGoAgain();
                /*Console.WriteLine("Do you want to enter another item? Yes or no?");
                response = Console.ReadLine();*/
            }

        }
        private static bool DoesTheUserWantToGoAgain()
        {
            string answer;
            bool shouldContinue;
            Console.WriteLine("Do you want to enter another value? Yes or No?");
            answer = Console.ReadLine();

            while (answer.ToLower() != "no"
                && answer.ToLower() != "yes")
            {
                Console.WriteLine("You must answer the word 'yes' or 'no'.");
                Console.WriteLine("Do you want to enter another value? yes or no>>");
                answer = Console.ReadLine();
            }
           
            if (answer.ToLower() == "no")
            {
                shouldContinue = false;
            }
            else
            {
                shouldContinue = true;
            }
            return shouldContinue;
        }

        /// <summary>
        /// Validates the user gives a valid double response for the question
        /// </summary>
        /// <param name="message">The question to ask the user</param>
        /// <returns>A valid double response</returns>
        static double ValidateInputAsDouble(string message)   //make sure to do a return back to the dataTYPE (ex. 0 for a double)
        {
            double value;
            string answer;
            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();

                //bool isDouble = double.TryParse(answer, out value); OR use in While

            } while (double.TryParse(answer, out value) == false);
             
            return value;
        }

        
    }
}
