// See https://aka.ms/new-console-template for more information
using PlaneShapesLibrary;

var factory = new PlaneShapeFactory(); 
var properties = new CircleProperty(10);

var newShape = factory.Create(properties);

Console.WriteLine(newShape.GetTheArea());