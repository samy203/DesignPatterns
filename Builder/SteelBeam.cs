using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SteelBeam :ISteelBeam
    {
        private string color;
        private string webCoating;
        private string flangeCoating;

        public void ApplyColor(string color)
        {
            this.color = color;
        }

        public void ApplyFlangeCoating(string flangeCoating)
        {
            this.flangeCoating = flangeCoating;
        }

        public void ApplyWebCoating(string webCoating)
        {
            this.webCoating = webCoating;
        }

        public override string ToString()
        {
            return $"This is a beam with Web Coating : {webCoating} , Flange Coating : {flangeCoating} And Painted with {color}";
        }
    }
}
