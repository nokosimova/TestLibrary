using PlaneShapesLibrary;

public class Triangle : IShape
{
    private double _side1;
    private double _side2;
    private double _side3;

    public double GetTheArea()
    {
        throw new NotImplementedException();
    }

    public bool IsRectangular()
    {
        return true;
    }
}
