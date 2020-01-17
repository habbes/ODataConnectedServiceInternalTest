using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.OData.Service.Sample.TrippinInMemory.Models;

namespace Lib1
{
    public class Lib1Service
    {
        private static Uri serviceRoot = new Uri("https://services.odata.org/TripPinRESTierService/(S(gabb3bb1u2dnbb1pot5wgyyx))/");
        private Container container = new Container(serviceRoot);

        public async Task<IEnumerable<string>> GetPeople()
        {
            var people = await container.People.ExecuteAsync();
            return people.Select(p => $"{p.FirstName} {p.LastName}");
        }
    }
}
