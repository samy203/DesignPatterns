using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Operator
    {
        private ISteelFactory factory;
        public Operator(ISteelFactory factory)
        {
            this.factory = factory;
        }

        public void ConstructBeam()
        {
            factory.ApplyFlangeCoating();
            factory.ApplyWebCoating();
            factory.ApplyColor();
        }
        
        public ISteelBeam GetBeam()
        {
            return factory.GetBeam();
        }
    }
}
