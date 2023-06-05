using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class NullEletric : IElectric
    {
        private static NullEletric _instance;
        private NullEletric()
        { }

        public static NullEletric Instance
        {
            get
            {
                if (_instance == null)
                    return new NullEletric();
                return _instance;
            }
        }

        public void TurnOff()
        {
            Console.WriteLine("\nNull Object, no need for null checks!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nNull Object, no need for null checks!");
        }
    }
}
