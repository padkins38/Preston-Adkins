using System;
using System.Collections.Generic;

namespace list_of_grades_problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<double> grades = new List<double>();
            double gradeAsDouble;
            do
            {
                Console.WriteLine("Enter one exam grade");
                string gradeAsString = Console.ReadLine();
                while (double.TryParse(gradeAsString, out gradeAsDouble) == false)
                {
                    Console.WriteLine("please write numbers. Try again>>"); 
                }
                grades.Add(gradeAsDouble);

                Console.WriteLine("Do you have anything else to add? (Yes / No)");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');

            double sum = 0;

            foreach (double grade in grades)
            {
                sum = sum + grade / grades.Count;
            }
            Console.WriteLine($"Your average grade is {sum.ToString()}");
        }
    }
}
