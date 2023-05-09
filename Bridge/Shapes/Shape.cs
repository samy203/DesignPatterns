using Bridge.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public abstract class Shape
    {
        public IDrawingFormatter formatter;

        public Shape(IDrawingFormatter formatter)
        {
            this.formatter = formatter;
        }

        public abstract void Draw();
    }
}
