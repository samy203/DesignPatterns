using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SteelEvaluator : MaterialEvaluator
    {
        public override string Evaluate(int load)
        {
            return load < 500 ? "Can be Built using Steel" : _next.Evaluate(load);
        }
    }
}
