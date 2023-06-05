using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcreteMixer
    {
        private Dictionary<string, ConcreteMixPrototype> mixes =
            new Dictionary<string, ConcreteMixPrototype>();
        // Indexer
        public ConcreteMixPrototype this[string key]
        {
            get { return mixes[key]; }
            set { mixes.Add(key, value); }
        }
    }
}
