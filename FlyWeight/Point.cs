using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class PointDrawer : IDrawable
    {
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Point Inserted at {x},{y}");
        }
    }
}
