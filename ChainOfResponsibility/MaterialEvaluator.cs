using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class MaterialEvaluator
    {
        protected MaterialEvaluator _next;
        public abstract string Evaluate(int load);
        public void RegisterNextEvaluator(MaterialEvaluator next)
        {
            _next = next;
        }
    }
}
