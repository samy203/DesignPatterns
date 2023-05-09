using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Shirt : ICloth
    {
        private ICloth _cloth;
        public Shirt(ICloth cloth)
        {
            _cloth = cloth;
        }

        public double CalculatePrice()
        {
            return _cloth.CalculatePrice() + 50;
        }
    }
}
