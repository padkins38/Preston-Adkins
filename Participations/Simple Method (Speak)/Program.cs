using System;

namespace Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Enter an animal (e.g. cow, giraffe, turkey)");
                string animal = Console.ReadLine().ToLower();

                string A_Sounds = AnimalSound(animal);
                Console.WriteLine($" A {animal} makes the {A_Sounds} sound");

                Console.WriteLine("would you like to try for another animal sounds?  (Y/N)  >>");
                answer = Console.ReadLine().ToLower();
            } 
            while (answer[0] == 'y');
        }
        static string AnimalSound(string animal)
        {
            string sound;

            if (animal == "cow")
            {
                sound = "MoOOooO00oO0ooo00OOo!";
                return sound;
            }
            else if (animal == "giraffe")
            {
                sound = "HhFfff!";
                return sound;
            }
            else
            {
                sound = "GObble gObble Gobble";
                return sound;
            }
            return "sound";
        }
    }
}
