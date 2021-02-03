using System;

namespace Testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            double gpa;

            Console.WriteLine("Enter your first name or else >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name or else >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your gpa");
            string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; //idk why but we want to bump everyone's gpa by .5

            string output = "Hello" + firstName + " " + lastName + "! " +
                " we boosted your gpa to " + gpa.ToString("N3");
            //output = $"Hello {firstName} {lastName}! we boosted your gpa to {gpa.ToString("N3")}

            Console.WriteLine(output);


         


        }
    }
}
