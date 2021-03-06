using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {                 //01234567
            string artist = "tAylOr SwIFt";
            artist = artist.ToLower();  // OR string newValue = artist.ToLower();
            //then replace "artist" in the console.writline to "newValue"
            

            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1,6) +artist.ToUpper()[7] + artist.Substring(8);// OR artist[0].ToString().ToUpper();
            //Why do we need the substring again? 


            //for(int i = 0; i < artistWithProperName.Length; i++)
            //{
            //    Console.WriteLine(artistWithProperName[i]);
           // }
            
            
            
            
            
            
            
            Console.WriteLine(artistWithProperName);



        }
    }
}
