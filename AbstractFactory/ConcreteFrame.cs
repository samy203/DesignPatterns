using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteFrame : IFrame
    {
        public void Construct()
        {
            Console.WriteLine("Concrete Frame has been constructed");
        }
    }
}
