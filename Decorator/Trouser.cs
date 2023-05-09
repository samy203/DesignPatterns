using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Trouser : ICloth
    {
        private ICloth _cloth;
        public Trouser(ICloth cloth)
        {
            _cloth = cloth;
        }

        public double CalculatePrice()
        {
            return _cloth.CalculatePrice() + 75;
        }
    }
}
