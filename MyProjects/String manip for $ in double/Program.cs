using System;

namespace String_manip_for___in_double
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "$200";
            Console.WriteLine(text.Replace("$", ""));

            /*if (text.Substring(0, 1) == "$")
            {

                string newtext = text.Substring(1, text.Length - 1);
                int NEWNUM = Convert.ToInt32(newtext);




                NEWNUM += 60;
                Console.WriteLine(NEWNUM.ToString());

            }
            else
            {
                Console.WriteLine("Continue to write sentences");
            }*/
        }
    }
}
