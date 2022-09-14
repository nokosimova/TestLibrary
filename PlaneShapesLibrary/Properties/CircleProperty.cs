public class CircleProperty
{
    public double Radius { get; set; }  
    public CircleProperty(double radius)
    {
        if (radius <= 0)
            throw new InvalidDataException("PropertyError: Radius must be positive number");
    
        Radius = radius;
    }
}