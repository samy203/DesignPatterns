using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ISteelBeam
    {
        void ApplyFlangeCoating(string flangeCoating);
        void ApplyWebCoating(string webCoating);
        void ApplyColor(string color);
    }
}
