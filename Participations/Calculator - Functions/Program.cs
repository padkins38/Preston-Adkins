using System;

namespace Calculator___Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 0;
            double val2 = 0;
            string Answer;
            double final = 0;
            DeveloperInformation("", "", "");
            
            Console.WriteLine("Would you like to Perform a new calculation? (Y/N)");
            string newCalc = Console.ReadLine().ToLower();
            
            Console.WriteLine("What is your first number?");
            v1 = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Would you like to use the results of this problem as your first variable of the next equation? (Y/N)");
                string useLastResults = Console.ReadLine().ToLower();

                if (useLastResults[0] == 'y')
                {
                    v1 = final;
                }
                else
                final = 0;

                Console.WriteLine("What Calculation do you want to want to perform? (e.g. add, subtract, divide, multiply)");
                string calculationAsk = Console.ReadLine().ToLower();


                Console.WriteLine("What is your second number?");
                val2 = Convert.ToDouble(Console.ReadLine());

                if (calculationAsk[0] == 'a')
                {
                    Console.WriteLine($"{v1} + {val2} == {Convert.ToString(Add(v1, val2))}.");
                    final = v1 + val2; //I would just have used this in the cw, but I don't want to have to rewrite lol
                }
                else if (calculationAsk[0] == 's')
                {
                    Console.WriteLine($"{v1} - {val2} == {Convert.ToString(Subtract(v1, val2))}.");
                    final = v1 + val2;
                }
                else if (calculationAsk[0] == 'm')
                {
                    Console.WriteLine($"{v1} * {val2} == {Convert.ToString(Multiply(v1, val2))}.");
                    final = v1 + val2;
                }
                else if (calculationAsk[0] == 'd')
                {
                    Console.WriteLine($"{v1} / {val2} == {Convert.ToString(Divide(v1, val2))}.");
                    final = v1 + val2;
                }
                // CAN USE A SWITCH IN THIS SITUATION TO SPEED PROCESS UP
                /* double result;
                 switch (calculationAsk)
                 {
                     case "add":
                         result = Add(v1, val2);
                         break;
                     case "subtract":
                         result = Add(v1, val2);
                         break;
                     case "multiply":
                         result = Add(v1, val2);
                         break;
                     case "divide":
                         result = Add(v1, val2);
                         break;
                 }   */

                Console.WriteLine("Would you like to Perform a new calculation? (Y/N)");
                Answer = Console.ReadLine().ToLower();
            }
            while (Answer[0] == 'y');
            static double Add(double v1, double val2)
            //static (method returned) {name(taking in (type) {var}, " same thing " )}
            {
                double sum = v1 + val2;
                return sum;

                //OR return v1 + val2;
            }
            static double Subtract(double v1, double val2)
            {
                double difference = v1 - val2;
                return difference;
            }
            static double Multiply(double v1, double val2)
            {
                double product = v1 * val2;
                return product;
            }
            static double Divide(double v1, double val2)
            {
                double quotient = v1 / val2;
                return quotient;
            }
            static void DeveloperInformation(string devname, string classname, string date)
            {
                devname = "Preston Adkins";
                classname = "MIS 3013";
                date = "APRIL FOOLS DAY";

                Console.WriteLine($"{devname}, {classname}, {date}.");
                Console.WriteLine();
                return;
            }

        }
    }
}
