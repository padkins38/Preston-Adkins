using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P__MVC.Models
{
    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class PokemonAPI
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Result> results { get; set; }

    }
    public class PokemonInfo
    {
        public int height { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        public Sprite sprites { get; set; }

    }
    public class Sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}