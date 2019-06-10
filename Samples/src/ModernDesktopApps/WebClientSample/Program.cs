using Newtonsoft.Json;
using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientSample
{
    class Program
    {
        private static string baseUrl = @"https://swapi.co/api/";

        static void Main(string[] args)
        {
            Console.WriteLine(GetPlanet(2).name);
        }

        public static Planet GetPlanet(int planetId)
        {
            var client = new WebClient();

            var response = client.DownloadString(baseUrl + "planets/" + planetId);

            var planet = JsonConvert.DeserializeObject<Planet>(response);

            return planet;
        }
    }
}
