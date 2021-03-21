using System;
using System.Collections.Generic;

namespace ArrayFriendLoopFunWooo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[3];    //An array is a collection of a certain data TYPE
                                               //e.g. group of friend names || types of dogs
            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            Console.WriteLine(evenNumbers[1]);
            Console.WriteLine();


            //BREAK =================== NEW PROBLEM//


            List<string> friendslist = new List<string>();
            
            string response;
            string answer;
            do
            {          
                Console.WriteLine("Write down the name of one of your friends");
                answer = Console.ReadLine();
                friendslist.Add(answer);
                Console.WriteLine("======================================================================================");

                Console.WriteLine("Do you want to store another friend's name on the list? (Yes or No)");
                response = Console.ReadLine();
            } while (response.ToLower()[0] == 'y');

            foreach (var friendname in friendslist)
            {
                Console.WriteLine(friendname);
            }
            Console.WriteLine("would you like to have the name of your friends go into an 'infinite' loop? (Y/N)");
            response = Console.ReadLine();
            while (response.ToLower()[0] == 'y')
            {
                foreach (var friendname in friendslist)
                {
                    Console.WriteLine(friendname);                    
                }
            }
            Console.WriteLine("I am sorry that you don't like fun");
        }
    }
}
