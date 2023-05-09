using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ISteelFactory
    {
        void ApplyWebCoating();
        void ApplyFlangeCoating();
        void ApplyColor();
        ISteelBeam GetBeam();
    }
}
