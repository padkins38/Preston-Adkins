using System;

namespace Testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                //if
                Console.WriteLine($"{i}");
            }
            for (int i = 3; i < 1001; i += 3)
            {
                //if (i % 3 == 0)
                //{
                Console.WriteLine(i);
                //}
            }

            Console.WriteLine();
            for (int i = 10; i < 0; i--)
            {
                //use the subtract sign above in order to not stay in infinite loop or..
                if (i == 0)
                    Console.WriteLine("Blast OFF!");
                else
                {
                    Console.WriteLine(i);

                }


            }
        }
    }
}
