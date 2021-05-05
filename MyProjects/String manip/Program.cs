using System;

namespace String_manip
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Hello World!";
            if (text.Substring(text.Length - 1) == "!")
            {

                string newtext = text.Substring(0, text.Length - 1);
                Console.WriteLine(newtext);

            }
            else
            {
                Console.WriteLine("Continue to write sentences");
            }

        }
    }
}
