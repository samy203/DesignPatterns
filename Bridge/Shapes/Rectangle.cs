using Bridge.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(IDrawingFormatter formatter) : base(formatter)
        {

        }
        public override void Draw()
        {
            formatter.Format("This is a rectangle");
        }
    }
}
