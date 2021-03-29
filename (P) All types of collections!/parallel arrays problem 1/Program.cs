using System;

namespace parallel_arrays_problem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string courseanswer;
            string IDanswer;
            string[] courses = new string[courseanswer];
            
                Console.WriteLine("input a course subject that you are taking. (ex. MATH or MIS)");
                courseanswer = Console.ReadLine().ToUpper();

                Console.WriteLine("input the course ID used next to the course subject. (ex. 3313 or 3033)");
                IDanswer = Console.ReadLine();

        }
    }
}
