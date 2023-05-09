using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public static class ShapeFactory
    {
        private static List<IDrawable> shapesDrawers = new List<IDrawable>();

        public static IDrawable GetPointDrawer()
        {
            var pointDrawer = shapesDrawers.FirstOrDefault(x => x is PointDrawer);
            if (pointDrawer == null)
            {
                pointDrawer = new PointDrawer();
                shapesDrawers.Add(pointDrawer);
            }

            return pointDrawer;
        }
    }
}
