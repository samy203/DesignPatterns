using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class StackHolder
    {
        public string Name { get; set; }
        public virtual double Networth { get; set; }

        public virtual void GetNetworth()
        {
            Console.WriteLine($"{Name} has {Networth}.");
        }
    }
}
