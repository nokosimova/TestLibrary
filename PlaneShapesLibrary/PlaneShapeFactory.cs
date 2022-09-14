using PlaneShapesLibrary;

public class PlaneShapeFactory
{
    public PlaneShapeFactory()
    {   
    }
    public Circle CreateShape(CircleProperty property)
    {
        var shape = new Circle(property);
        return shape;
    }

    public Triangle CreateShape(TriangleProperty property)
    {
        var shape = new Triangle(property);
        return shape;
    }
}



