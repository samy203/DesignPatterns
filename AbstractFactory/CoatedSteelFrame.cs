using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CoatedSteelFrame : IFrame
    {
        public void Construct()
        {
            Console.WriteLine("Coated Steel Frame has been constructed");
        }
    }
}
