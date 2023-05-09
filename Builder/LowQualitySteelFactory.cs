using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LowQualitySteelFactory : ISteelFactory
    {
        private ISteelBeam beam;
        public LowQualitySteelFactory()
        {
            beam = new SteelBeam();
        }
        public void ApplyColor()
        {
            beam.ApplyColor("Blue");
        }

        public void ApplyFlangeCoating()
        {
            beam.ApplyFlangeCoating("Low Quality Coating");
        }

        public void ApplyWebCoating()
        {
            beam.ApplyWebCoating("Low Quality Coating");
        }

        public ISteelBeam GetBeam()
        {
            return beam;
        }
    }
}
