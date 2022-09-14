// See https://aka.ms/new-console-template for more information
using PlaneShapesLibrary;

IShape shape;
var factory = new PlaneShapeFactory();
while (true)
{
    Console.WriteLine("Choose action:");
    Console.WriteLine("1 - Find the Area and the Perimeter for triangle");
    Console.WriteLine("2 - Find the Area and the Perimeter for circle");
    Console.WriteLine("3 - Check if triangle is rectangular or not");
    Console.WriteLine("0 - Exit");

    var action = int.Parse(Console.ReadLine());
    if (action == 0) break;

    switch(action)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("Enter the value of the sides  a, b, c separated by a space:");
            var data = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            try
            {
                var property = new TriangleProperty(data[0], data[1], data[2]);
                shape = factory.CreateShape(property);
                Console.WriteLine("P = " + shape.GetThePerimeter().ToString());
                Console.WriteLine("S = " + shape.GetTheArea().ToString());

                Console.WriteLine("-----------------");
                Console.WriteLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case 3:
            Console.WriteLine("Enter the value of the sides  a, b, c separated by a space:");
            data = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            try
            {
                var property = new TriangleProperty(data[0], data[1], data[2]);
                var triangle = factory.CreateShape(property);
                Console.WriteLine(triangle.IsRectangular() ? "Triganle IS rectangular" : "Triganle IS NOT rectangular");

                Console.WriteLine("-----------------");
                Console.WriteLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case 2:
            Console.WriteLine("Enter the value of the radius:");
            var r = double.Parse(Console.ReadLine());
            try
            {
                var property = new CircleProperty(r);
                shape = factory.CreateShape(property);
                Console.WriteLine("P = " + shape.GetThePerimeter().ToString());
                Console.WriteLine("S = " + shape.GetTheArea().ToString());

                Console.WriteLine("-----------------");
                Console.WriteLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }

}