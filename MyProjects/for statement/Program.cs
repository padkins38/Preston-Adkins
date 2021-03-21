using System;

namespace for_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int j = 0;
            while (j < numbers.Length)
            {
                Console.WriteLine(numbers[j]);
                j++;

            }

        }
    }
}
