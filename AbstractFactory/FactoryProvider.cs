using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class FactoryProvider
    {
        public static IAbstractFrameFactory GetFactory(int load)
        {
            return load > 1000 ? new SteelFrameFactory() : new ConcreteFrameFactory();
        }
    }
}
