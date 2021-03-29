using System;

namespace parallel_arrays_problem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input a course subject that you are taking. (ex. MATH or MIS)");
            string sub0ne = Console.ReadLine().ToUpper();

            Console.WriteLine("what is your second subject");
            string subTwo = Console.ReadLine().ToUpper();

            Console.WriteLine("What is your third subject");
            string subThree = Console.ReadLine().ToUpper();

            string[] subjects = { sub0ne, subTwo, subThree };

            Console.WriteLine($"What is the course number for {subjects[0]}?");
            string courseNumOne = Console.ReadLine();
            double courseOne = Convert.ToDouble(courseNumOne);
            
            Console.WriteLine($"What is the course number for {subjects[1]}?");
            string courseNumTwo = Console.ReadLine();
            double courseTwo = Convert.ToDouble(courseNumTwo);

            Console.WriteLine($"What is the course number for {subjects[2]}?");
            string courseNumThree = Console.ReadLine();
            double courseThree = Convert.ToDouble(courseNumThree);

            double[] courseNumbers = { courseOne, courseTwo, courseThree };

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"Your course is {subjects[i]}{courseNumbers[i]}");
            }











            Console.WriteLine("input the course ID used next to the course subject. (ex. 3313 or 3033)");
            string secondSubject = Console.ReadLine();

        }
    }
}
