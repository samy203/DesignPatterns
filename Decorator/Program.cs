using Decorator;

var underGarment = new Undergarment();
Console.WriteLine($"Undergarment price is {underGarment.CalculatePrice()}");
var underGarmentWithShirt = new Shirt(underGarment);
Console.WriteLine($"Undergarment with shirt price is {underGarmentWithShirt.CalculatePrice()}");
var underGarementWithShirtWithTrousder = new Trouser(underGarmentWithShirt);
Console.WriteLine($"Undergarment with shirt and Trouser price is {underGarementWithShirtWithTrousder.CalculatePrice()}");

