using SharpTrooper.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIRestClient
{
    public interface ISWAPIRestClient
    {
        IEnumerable<string> GetPlanetNames();
        Task<IEnumerable<string>> GetFilmNames();

        IEnumerable<Planet> GetInhabitedPlanets();
    }
}
