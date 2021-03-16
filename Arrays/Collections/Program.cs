using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] studentIDs = new string[3];
            for (int i = 0; i < studentIDs.Length; i++)
            {
                studentIDs[i] = rand.Next(130000, 140000).ToString();

            }

            double[] studentGPAs = { 3.0, 4.0, 2.7 };

            //Display the IDs

            foreach (string id in studentIDs) //This is the same thing as the comment below.
            {
                Console.Write($"\t {id}");
            }
            /*for (int i = 0; i < studentIDs.Length; i++)
            {
                string id = studentIDs[i];
                Console.WriteLine($"\t { id}");

            }*/

            Console.WriteLine("Whose GPA do you want to see? >>");
            string idToLookFor = Console.ReadLine();

            for (int i = 0; i < studentIDs.Length; i++)
            {
                if (studentIDs [i] == idToLookFor)
                {
                    double gpa = studentGPAs[i];
                    Console.WriteLine($"{idToLookFor} has a gpa of {gpa}");


                }
            }
        }
    }
}
