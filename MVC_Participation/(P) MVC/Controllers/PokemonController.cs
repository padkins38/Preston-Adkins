using _P__MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace _P__MVC.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI allpokemon;

            using (var Client = new HttpClient())
            {
                var json = Client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100").Result;

                allpokemon = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            return View(allpokemon.results);
        }
        public ActionResult Info(string id)
        {

            PokemonInfo info;

            using (var Client = new HttpClient())
            {
                var json = Client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/{id}").Result;

                info = JsonConvert.DeserializeObject<PokemonInfo>(json);
            }

            return View(info);
        }
}