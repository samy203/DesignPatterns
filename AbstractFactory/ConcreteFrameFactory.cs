using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteFrameFactory : IAbstractFrameFactory
    {
        public IFrame GetFrame(bool isCoated)
        {
            return isCoated ? new CoatedConcreteFrame() : new ConcreteFrame();
        }
    }
}
