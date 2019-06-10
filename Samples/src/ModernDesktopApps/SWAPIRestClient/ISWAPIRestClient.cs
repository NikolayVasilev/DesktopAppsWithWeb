using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPIRestClient
{
    public interface ISWAPIRestClient
    {
        IEnumerable<string> GetPlanetNames();
        IEnumerable<string> GetFilmNames();

        IEnumerable<Planet> GetInhabitedPlanets();
    }
}
