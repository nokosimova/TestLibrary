using PlaneShapesLibrary;

public class Circle : IShape
{
    private double _radius = 0;
    public Circle(CircleProperty property)
    {
        _radius = property.Radius;
    }
    public double GetTheArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetThePerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}