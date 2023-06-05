using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public class Samsung : IElectric
    {
        public void TurnOff()
        {
            Console.WriteLine("\nSamsung Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nSamsung Turned ON!");
        }
    }
}
