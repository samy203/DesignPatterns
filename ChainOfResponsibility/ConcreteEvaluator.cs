using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ConcreteEvaluator : MaterialEvaluator
    {
        public override string Evaluate(int load)
        {
            return load < 1000 ? "Can be Built using Concrete" : "Please Find a better material";
        }
    }
}
