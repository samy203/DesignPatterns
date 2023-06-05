using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class ConcreteMixer
    {
        public abstract void Mix();
        public abstract void Pour();
        public abstract void Add(int top);
        public abstract void Clean();
        // The 'Template Method' 
        public void Run(int addonsPercentage)
        {
            Mix();
            Pour();
            Add(addonsPercentage);
            Clean();
        }
    }

}
