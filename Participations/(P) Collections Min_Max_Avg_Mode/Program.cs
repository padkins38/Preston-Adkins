﻿using System;
using System.Collections.Generic;

namespace _P__Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> examGrades = new List<double>();
            string response;
            double answer;
            do
            {   
                // 0     1      2
                //90     80     78
                Console.WriteLine("Enter one exam grade");
                answer = Convert.ToDouble(Console.ReadLine());
                              
                examGrades.Add(answer);

                Console.WriteLine("Do you have anything else to add? (Yes / No)");
                response = Console.ReadLine();
            } while (response.ToLower()[0] == 'y');

           
            double[] arrayOfGrades = examGrades.ToArray();
                
            double minValue;
            double maxValue;
            /*double arraySize = examGrades.Count;*/

            minValue = maxValue = arrayOfGrades[0];

            for (int i = 0; i < arrayOfGrades.Length; i++)
                {
                if (minValue > arrayOfGrades[i])
                {
                    minValue = arrayOfGrades[i];
                }
                else if (maxValue < arrayOfGrades[i])
                {
                    maxValue = arrayOfGrades[i];
                }
            }
            double sum = 0;
            double average = 0;
            for (int i = 0; i < arrayOfGrades.Length; i++)
            {
                sum += arrayOfGrades[i];
                average = sum / arrayOfGrades.Length;
            }





            Console.WriteLine($"Your minimum is {minValue.ToString("n2")}.");
            Console.WriteLine($"Your maximum is {maxValue.ToString("n2")}.");
            Console.WriteLine($"your average is {average.ToString("n2")}.");
            /*Console.WriteLine($"your mode is {mode}.");*/



        }
    }
}