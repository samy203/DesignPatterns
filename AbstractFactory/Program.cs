using AbstractFactory;

var factory = FactoryProvider.GetFactory(500);
var frame =factory.GetFrame(true);
frame.Construct();

factory = FactoryProvider.GetFactory(2000);
frame = factory.GetFrame(false);
frame.Construct();
