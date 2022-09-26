// See https://aka.ms/new-console-template for more information
using StaticExercise;

Console.WriteLine("Hello, World!");

var fTemp = TempConverter.FahrenheitToCelsius(32.00);
var cTemp = TempConverter.CelsiusToFahrenheit(32.00);

Console.WriteLine(fTemp);
Console.WriteLine(cTemp);
Console.ReadKey();
