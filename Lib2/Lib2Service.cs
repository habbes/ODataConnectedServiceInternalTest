using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.OData.Service.Sample.TrippinInMemory.Models;

namespace Lib2
{
    public class Lib2Service
    {
        private static Uri uri = new Uri("https://services.odata.org/TripPinRESTierService/(S(gabb3bb1u2dnbb1pot5wgyyx))");
        private Container container = new Container(uri);

        public Task<IEnumerable<Airline>> GetAirlines()
        {
            return container.Airlines.ExecuteAsync();
        }
    }
}
