using PlaneShapesLibrary;

public class PlaneShapeFactory
{
    public PlaneShapeFactory()
    {   
    }
    public IShape CreateShape(CircleProperty property)
    {
        var shape = new Circle(property);
        return shape;
    }

    public IShape CreateShape(TriangleProperty property)
    {
        var shape = new Triangle(property);
        return shape;
    }
}



