using System;
using System.Collections.Generic;
using System.IO;

namespace Read_in
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap (2).csv");
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();

            for (int i = 3; i < lines.Length; i++)
            {
                //Region/state, SOCCER, AMERICAN FOOTBALL
                //Alabama,16%,84%
                string line = lines[i];


                //SOLUTION FOR STATE
                //    0     ,  1  ,  2
                //{"Alabama","16%","84%"}
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);


                //SOLUTION FOR SOCCERSCORES
                string soccerScoreAsString = pieces[1].Replace('%',' '); //Or pieces[1].Remove(pieces[1].Length-1)
                double soccerScore = Convert.ToDouble(soccerScoreAsString) / 100;
                soccerScores.Add(soccerScore);//Need to take away the percent sign

                //SOLUTION FOR FOOTBALL
                string footballScoreAsString = pieces[2].Replace('%', ' '); //Or pieces[1].Remove(pieces[1].Length-1)
                double footballScore = Convert.ToDouble(footballScoreAsString) / 100;
                footballScores.Add(footballScore);//Need to take away the percent sign
               
            }

            for (int i = 0; i < footballScores.Count; i++)
            {
                string state = states[i];
                double soccer = soccerScores[i];
                double football = footballScores[i];

                if (soccer < football)
                {
                    Console.WriteLine(state);
                }               
            }
        }
    }
}
