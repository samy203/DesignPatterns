using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Formatters
{
    public class StandardFormatter : IDrawingFormatter
    {
        public void Format(string shape)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(shape);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
