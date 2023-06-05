using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HiringContractorState : ContractorState
    {
        public override void Handle(ContractorContext context)
        {
            context.State = new FiringContractorState();
        }
    }
}
