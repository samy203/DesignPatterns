using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Person : StackHolder
    {
        public Person(string name)
        {
            Name = name;
            Networth = 0;
        }
    }
}
