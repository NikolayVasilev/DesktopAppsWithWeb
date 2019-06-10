using SWAPIRestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientTestProject
{
    class TestSWAPIRestClient : ISWAPIRestClient
    {
        public IEnumerable<string> GetFilmNames()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SharpTrooper.Entities.Planet> GetInhabitedPlanets()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetPlanetNames()
        {
            return new List<string>()
            {
                "Alderaan",
                "Yavin IV",
                "Hoth",
                "Dagobah",
                "Bespin",
                "Endor",
                "Naboo",
                "Coruscant",
                "Kamino",
                "Geonosis"
            };
        }
    }
}
