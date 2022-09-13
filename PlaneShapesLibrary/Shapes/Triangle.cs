using PlaneShapesLibrary;

public class Triangle : IShape
{
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(TriangleProperty property)
    {
        _side1 = property.Side1;
        _side2 = property.Side2;
        _side3 = property.Side3;
    }

    public double GetTheArea()
    {
        double p = (_side1 + _side2 + _side3) / 2;
        double s = Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        
        return s;
    }

    public double GetThePerimeter()
    {
        return _side1 + _side2 + _side3;
    }

    public bool IsRectangular()
    {
        bool condition1 = Math.Pow(_side1, 2) == Math.Pow(_side2, 2) + Math.Pow(_side3, 2);
        bool condition2 = Math.Pow(_side2, 2) == Math.Pow(_side1, 2) + Math.Pow(_side3, 2);
        bool condition3 = Math.Pow(_side3, 2) == Math.Pow(_side1, 2) + Math.Pow(_side2, 2);

        return condition1 || condition2 || condition3;
    }
}
