using System;
using System.Collections.Generic;

namespace Dictionary_multiple_Values_problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());   //first way
            courseGrades["MIS3013"].Add(90);
            courseGrades["MIS3013"].Add(100);
            courseGrades["MIS3013"].Add(99);

            courseGrades.Add("MIS3033", new List<double>());   //first way
            courseGrades["MIS3033"].Add(80);
            courseGrades["MIS3033"].Add(77);
            courseGrades["MIS3033"].Add(97);

            courseGrades.Add("MIS1111", new List<double>());   //first way
            courseGrades["MIS1111"].Add(85);
            courseGrades["MIS1111"].Add(97);
            courseGrades["MIS1111"].Add(99);


            /*List<double> mis3033Grades = new List<double>();   //second way
            mis3033Grades.Add(100);
            mis3033Grades.Add(89);
            mis3033Grades.Add(69);
            courseGrades.Add("MIS3033", mis3033Grades);*/
            double average = 0;
            double use = 0;
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];          
                double sum = 0;
                Console.WriteLine(courseCode);
                foreach  (double grade in grades)
                {
                    use = grade;
                    sum = sum + grade;
                    average = (sum / grades.Count) / 100;
                    Console.WriteLine(grade.ToString("n0"));
                }
                Console.WriteLine($"The average for the {courseCode} course is {average.ToString("P2")}");
                Console.WriteLine("=========================================================================");
                #endregion

            }

        }
    }
}

            /*string answer;
            double grade;
            string subject;
            do
            {
                Console.WriteLine("What is the course code you want to enter. E.x. MIS2123");
                subject = Console.ReadLine().ToUpper();

                if (totals.ContainsKey(subject) == false)
                {
                    totals.Add(subject, 1);
                }
                else
                {
                    totals[subject] = totals[subject] + 1;
                }

                Console.WriteLine("Do you have another course to input");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');*/