using FlyWeight;

for (int i = 0; i < 20; i++)
{
    var pointDrawer = ShapeFactory.GetPointDrawer();
    var random = new Random();
    pointDrawer.Draw(random.Next(100), random.Next(100));
}