using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocactor
{
    public class LoggingService : IService
    {
        public void ExecuteService()
        {
            Console.WriteLine("Executing Log Service");
        }
    }
}
