using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcreteMix : ConcreteMixPrototype
    {
        public int WaterPercentage { get; set; }
        public int CementPercentage { get; set; }
        public int AddonPercentage { get; set; }

        public ConcreteMix(int water, int cement, int addon)
        {
            WaterPercentage = water;
            CementPercentage = cement;
            AddonPercentage = addon;
        }
        public override ConcreteMixPrototype Clone()
        {
            Console.WriteLine(
                           $"Cloning Concrete Mix: Water = {WaterPercentage} ; Cement = {CementPercentage} ; Addon = {AddonPercentage} ;");
            return MemberwiseClone() as ConcreteMixPrototype;
        }
    }
}
