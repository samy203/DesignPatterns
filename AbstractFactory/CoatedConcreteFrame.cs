using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CoatedConcreteFrame : IFrame
    {
        public void Construct()
        {
            Console.WriteLine("Coated Concrete Frame has been constructed");
        }
    }
}
