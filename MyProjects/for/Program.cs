using System;

namespace for_vs_while_vs_foreach
{
    class Program    
    {    
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            numbers[3] = 104;
            int j = 0;

            while (j < numbers.Length)     //boolean function. variables placed on >1 line
            {
                Console.WriteLine(numbers[j]);
                j++;
            }

            for (int i = 0; i < numbers.Length; i++)   //need to know how many times
            {
                Console.WriteLine(numbers[i]);
            }


            foreach (int k in numbers)     //don't need to know how many times                                           
            {                              //Mainly used with collections
                Console.WriteLine(k);
            }

        }
    }
}
