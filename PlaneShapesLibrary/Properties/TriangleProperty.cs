public class TriangleProperty
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public TriangleProperty(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            throw new InvalidDataException("PropertyError: Triangle sides must be positive!");
        
        // the main condition of correct triangle is that the "sum of two sides is always bigger than the third one":
        if (side1 + side2 <= side3 || 
            side1 + side3 <= side2 || 
            side2 + side3 <= side1)
            throw new InvalidDataException("PropertyError: Incorrect triangle sides!");
        
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }
}