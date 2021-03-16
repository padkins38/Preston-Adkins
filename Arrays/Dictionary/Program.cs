using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        private static object studentID;

        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
                       //("KEY", VALUE);
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.7);

            foreach (var student in students.Keys)
            {
                Console.Write($"\t {studentID}");
            }
            Console.WriteLine("\nWhose GPA do you want to see?>> ");
            string idToLookFor = Console.ReadLine();

            if (students.ContainsKey(idToLookFor) == true)
            {
                Console.WriteLine(  $"{idToLookFor} has a {students[idToLookFor].ToString("N2")}");

            }
            else
            {
                Console.WriteLine($"{idToLookFor} is not a valid student. Be more careful next time");
                Environment.Exit(-1);
            }
        }
    }
}
