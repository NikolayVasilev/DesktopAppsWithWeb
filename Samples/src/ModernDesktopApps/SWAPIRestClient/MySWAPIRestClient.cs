using SharpTrooper.Core;
using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWAPIRestClient
{
    public class MySWAPIRestClient : ISWAPIRestClient
    {
        private SharpTrooperCore serviceConsumerCore = new SharpTrooperCore();

        public IEnumerable<string> GetFilmNames()
        {
            var films = serviceConsumerCore.GetAllFilms();

            return films.results.Select(f => f.title).ToList();
        }

        public IEnumerable<Planet> GetInhabitedPlanets()
        {
            var planets = serviceConsumerCore.GetAllPlanets();

            return planets.results.Where(p => (int.Parse(p.population)) > 0).ToList();

        }

        public IEnumerable<string> GetPlanetNames()
        {
            var planets = serviceConsumerCore.GetAllPlanets();

            return planets.results.Select(p => p.name).ToList();
        }
    }
}
