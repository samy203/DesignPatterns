using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SteelFrame : IFrame
    {
        public void Construct()
        {
            Console.WriteLine("Steel Frame has been constructed");
        }
    }
}
