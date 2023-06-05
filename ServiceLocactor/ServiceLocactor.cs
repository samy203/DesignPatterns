using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocactor
{
    public static class ServiceLocator
    {
        public static IService service;

        public static IService SetLocation(IService tmpService)
        {
            if (service == null) return new LoggingService();
            return service;
        }

        //Execute service  
        public static void ExecuteService()
        {
            service.ExecuteService();
        }
    }
}
