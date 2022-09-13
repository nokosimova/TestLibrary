using PlaneShapesLibrary;

public class PlaneShapeFactory
{
    public PlaneShapeFactory()
    {   
    }
    public IShape Create(CircleProperty property)
    {
        var shape = new Circle(property);
        return shape;
    }

    public IShape Create(TriangleProperty property)
    {
        var shape = new Triangle(property);
        return shape;
    }
}



//for checking

// var factory = new PlaneShapeFactory();
// var property = new CircleProperty();

// var myShape = factory.Create(property);