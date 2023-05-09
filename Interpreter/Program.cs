using Interpreter;

var steelExpression = new TerminalExpression("steel");
var beamExpression = new TerminalExpression("beam");
var steelBeamExpression = new AndExpression(steelExpression, beamExpression);

Console.WriteLine(steelBeamExpression.Interpret("This Is steel beam"));
Console.WriteLine(steelBeamExpression.Interpret("This Is concrete beam"));