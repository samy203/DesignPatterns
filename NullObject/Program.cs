using NullObject;

var factory = new EletricFActory();
var samsung =factory.GetMobileByName("samsung");
samsung.TurnOff();

var onePlus = factory.GetMobileByName("one-plus");
onePlus.TurnOff();