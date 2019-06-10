using Newtonsoft.Json;
using SharpTrooper.Core;
using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpWebRequestResponse
{
    class Program
    {
        private static string baseUrl = @"https://swapi.co/api/";

        static void Main(string[] args)
        {
            PrintPlanetsSharpTrooper();

            Console.WriteLine();

            PrintPlanetLocal(1);
        }

        public static void PrintPlanetsSharpTrooper()
        {
            SharpTrooperCore core = new SharpTrooperCore();

            var planetsResult = core.GetAllPlanets();

            foreach (var planet in planetsResult.results)
            {
                Console.WriteLine(planet.name);
            }
        }

        public static void PrintPlanetLocal(int planetId)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + "planets/" + planetId);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            var planet = JsonConvert.DeserializeObject<Planet>(content);

            Console.WriteLine(planet.name);
        }
    }
}
