
using AppBuilderPattern.Builder;

var car = new CarBuilder().Build();

car.Color = "red";
car.Make = "aaa";
car.Model = "000000";
car.Year = 2010;

Console.WriteLine("Hello, World!");
