using Builder;

var highQualityFactory = new HighQualitySteelFactory();
var lowQualityFactory = new LowQualitySteelFactory();

var highCostOperator = new Operator(highQualityFactory);
highCostOperator.ConstructBeam();
Console.WriteLine(highCostOperator.GetBeam().ToString()); 

var lowCostOperator = new Operator(lowQualityFactory);
lowCostOperator.ConstructBeam();
Console.WriteLine(lowCostOperator.GetBeam().ToString());