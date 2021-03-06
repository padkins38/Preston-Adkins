using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning";
            Console.WriteLine($"{text}");

            Console.WriteLine("What word do you want to search for in the sentence above?");
            string searchword = Console.ReadLine();

            Console.WriteLine("What word would you like to change it to?");
            string changeword = Console.ReadLine();

            if (!text.Contains(searchword))
            {
                Console.WriteLine($"I am sorry, {searchword} was not found in the sentence");

                char[] chararray = searchword.ToCharArray();
                for (int i = chararray.Length - 1; i >=0; i--)
                {
                    Console.WriteLine($"{chararray[i]}");
                }
                Console.WriteLine();
            }
            else
            {
                string textback = text.Replace(searchword, changeword);
                Console.WriteLine($"{textback}");
            }
        }
    }
}
