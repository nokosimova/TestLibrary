public class TriangleProperty
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public TriangleProperty(double s1, double s2, double s3)
    {
        if (s1 <= 0 || s2 <= 0 || s3 <= 0)
            throw new InvalidDataException("PropertyError: Triangle sides must be positive!");
        
        // the main condition of correct triangle is that the "sum of two sides is always bigger than the third one":
        if (s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1)
            throw new InvalidDataException("PropertyError: Incorrect triangle sides!");
        
        Side1 = s1;
        Side2 = s2;
        Side3 = s3;
    }
}