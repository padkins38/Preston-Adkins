using System;
using System.Collections.Generic;

namespace _P__Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE THE LIST
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
            //PULL THE LIST OUT INTO AN ARRAY
            double[] arrayOfGrades = examGrades.ToArray();//didn't need to convert to array --> could have just used foreach
                
            double minValue;
            double maxValue;
            /*double arraySize = examGrades.Count;*/
            

            //Alternative solution for min
        /*    double min = examGrades[0];
            foreach (double grade in examGrades)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }                                   */

            //FIND THE MIN && MAX 
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
            //FIND THE AVERAGE
            double sum = 0;
            double average = 0;
            for (int i = 0; i < arrayOfGrades.Length; i++)
            {
                sum += arrayOfGrades[i];
                average = sum / arrayOfGrades.Length;
            }

            Console.WriteLine("Please enter your exam grade >>");
            double grade = Convert.ToDouble(Console.ReadLine());
            examGrades.Add(grade);

            /*Trying to get alternate Mode solution but im too slow lol
            do
            {
                if (examGrades.ContainsKey(examGrades) == false))
                {
                    examGrades.Add(examGrades, 1);
                }
                else
                {   
                Console.WriteLine("Do you have another exam grade to enter? yes no?");
                answer = Console.ReadLine();
                }
            } while (answer.ToLower()[0] == 'y');


            double min = examGrades[0];
            int max0ccurrences = 0;        */

            //NOW FIND THE MODE HERE
            //Create a DICTIONARY with a Key & Value
            Dictionary<double, double> counts = new Dictionary<double, double>();
            
            foreach (int newVar in examGrades)//basically if the dictionary contains the variable it will track if it is repeated
            {                                 //This ALLOWS the CODE to TRACK WHICH double in the list is REPEATED the MOST.
                if (counts.ContainsKey(newVar))
                    counts[newVar] = counts[newVar] + 1;
                else
                    counts[newVar] = 1;
            }
            double mode = double.MinValue;
            double max = double.MinValue;

            foreach (int key in counts.Keys) //this loop just DETERMINES the outcome between the difference of a count of 1
            {                                // vs a count > 1. This loop DETERMINES the mode and OUTPUTS it.
                if (counts[key] > max)
                {
                    max = counts[key];
                    mode = key;
                }
            }
            Console.WriteLine($"Your minimum is {minValue.ToString("n2")}.");
            Console.WriteLine($"Your maximum is {maxValue.ToString("n2")}.");
            Console.WriteLine($"your average is {average.ToString("n2")}.");
            Console.WriteLine($"your mode is {mode.ToString("n2")}.");

            //This participation took a solid 4 hours out of the day lol! #WTL#WorthToLearn

        }
    }
}
