using Bridge;
using Bridge.Shapes;

var standardFormatter = new StandardFormatter();
var fancyFormatter = new FancyFormatter();

var circle = new Circle(standardFormatter);
circle.Draw();

var rectangle = new Rectangle(fancyFormatter);
rectangle.Draw();

Console.ReadLine();