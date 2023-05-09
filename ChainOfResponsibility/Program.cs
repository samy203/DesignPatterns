using ChainOfResponsibility;

var woodEval = new WoodEvaluator();
var steelEval = new SteelEvaluator();
var concEval = new ConcreteEvaluator();

woodEval.RegisterNextEvaluator(steelEval);
steelEval.RegisterNextEvaluator(concEval);

Console.WriteLine(woodEval.Evaluate(150));
Console.WriteLine(woodEval.Evaluate(350));
Console.WriteLine(woodEval.Evaluate(750));
Console.WriteLine(woodEval.Evaluate(2000));