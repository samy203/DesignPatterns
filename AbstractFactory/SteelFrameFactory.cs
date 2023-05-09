using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SteelFrameFactory : IAbstractFrameFactory
    {
        public IFrame GetFrame(bool isCoated)
        {
            return isCoated ? new CoatedSteelFrame() : new SteelFrame();
        }
    }
}
