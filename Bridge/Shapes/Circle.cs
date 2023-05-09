using Bridge.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Circle : Shape
    {
        public Circle(IDrawingFormatter formatter) : base(formatter)
        {

        }
        public override void Draw()
        {
            formatter.Format("This is a circle");
        }
    }
}
