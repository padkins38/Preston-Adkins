﻿using System;

namespace Functions_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("please enter your grade>>");
                answer = Console.ReadLine();
                string lg = ConverGradeToLetterGrade(Convert.ToDouble(answer));
                Console.WriteLine($"Congrats, you have a {lg}!");

                Console.WriteLine("do you want to convert another grade? yes or no?");
                answer = Console.ReadLine().ToLower();
            } while (answer[0] == 'y');
        }
        static string ConverGradeToLetterGrade(double grade)
        {
            string letter = "" ;
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else if (grade >= 0)
            {
                letter = "F";
            }
            else 
            {
                letter = "N/A";
            }

            return letter;
        }
    }
}
