using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class WoodEvaluator :MaterialEvaluator
    {
        public override string Evaluate(int load)
        {
            return load < 200 ? "Can be Built using Wood" : _next.Evaluate(load);
        }
    }
}
