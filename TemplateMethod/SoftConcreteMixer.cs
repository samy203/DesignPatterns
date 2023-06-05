
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SoftConcreteMixer : ConcreteMixer
    {
        public override void Mix()
        {
            Console.WriteLine("Mixing soft conrete with 75% water, 25% cement");
        }

        public override void Pour()
        {
            Console.WriteLine("Pouring soft concrete mix");
        }

        public override void Add(int addonPercentage)
        {
            Console.WriteLine($"Adding addons with {addonPercentage}%");
        }

        public override void Clean()
        {
            Console.WriteLine("Cleaning site");
        }
    }

}
