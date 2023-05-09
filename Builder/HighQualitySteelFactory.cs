using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HighQualitySteelFactory : ISteelFactory
    {
        private SteelBeam beam;
        public HighQualitySteelFactory()
        {
            beam = new SteelBeam();
        }
        public void ApplyColor()
        {
            beam.ApplyColor("Red");
        }

        public void ApplyFlangeCoating()
        {
            beam.ApplyFlangeCoating("High Quality Coating");
        }

        public void ApplyWebCoating()
        {
            beam.ApplyWebCoating("High Quality Coating");
        }

        public ISteelBeam GetBeam()
        {
            return beam;
        }
    }
}
