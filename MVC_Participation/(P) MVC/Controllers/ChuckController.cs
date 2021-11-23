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
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            RandomChuckJokeAPI joke;

            using (var Client = new HttpClient())
            {
                var json = Client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                joke = JsonConvert.DeserializeObject<RandomChuckJokeAPI>(json);
            }

            return View(joke);
        }
    }
}