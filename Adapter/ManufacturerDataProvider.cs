using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public static class ManufacturerDataProvider
    {
        public static List<Manufacturer> GetData() =>
           new List<Manufacturer>
           {
            new Manufacturer { City = "Italy", Name = "Alfa Romeo" },
            new Manufacturer { City = "UK", Name = "Aston Martin" },
            new Manufacturer { City = "USA", Name = "Ford" },
            new Manufacturer { City = "Japan", Name = "Toyota" },
            new Manufacturer { City = "Germany", Name = "BMW" }
           };
    }
}
