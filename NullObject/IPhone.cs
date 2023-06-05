using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class IPhone :IElectric
    {
        public void TurnOff()
        {
            Console.WriteLine("\nIPhone Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nIPhone Turned ON!");
        }
    }
}
