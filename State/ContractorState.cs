using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class ContractorState
    {
        public abstract void Handle(ContractorContext context);
    }
}
