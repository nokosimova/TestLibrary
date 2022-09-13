public class CircleProperty
{
    public double Radius { get; set; }  
    public CircleProperty(int radius)
    {
        if (radius <= 0)
            throw new InvalidDataException("PropertyError: Radius must be positive number");
    
        Radius = radius;
    }
}