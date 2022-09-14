using System;
using Xunit;

namespace PlaneShapesLibrary.Test;

public class ShapeFunctionsTest
{
    [Fact]
    public void CircleArea_Correct_Result()
    {
        // Arrange
        var factory = new PlaneShapeFactory();
        var r = 50;
        var expected_area = Math.PI * Math.Pow(r, 2);
    
        // Act
        var propr = new CircleProperty(r);
        var circleShape = factory.CreateShape(propr);
            
        // Assert
        Assert.Equal(expected_area, circleShape.GetTheArea());

    }

    [Fact]
    public void TriangleArea_Correct_Result()
    {
        // Arrange
        var a = 10;
        var b = 8;
        var c = 6;
        var expected_area = 24;    
        var factory = new PlaneShapeFactory();    
        
        // Act
        var property = new TriangleProperty(a, b, c);
        var triangleShape = factory.CreateShape(property);
            
        // Assert
        Assert.Equal(expected_area, triangleShape.GetTheArea());

    }

    [Fact]
    public void CirclePerimeter_Correct_Result()
    {
        // Arrange
        var r = 50;
        var expected_perimeter = 2 * Math.PI * r;
        var factory = new PlaneShapeFactory();
    
        // Act
        var propr = new CircleProperty(r);
        var circleShape = factory.CreateShape(propr);
            
        // Assert
        Assert.Equal(expected_perimeter, circleShape.GetThePerimeter());

    }
    
    [Fact]
    public void TrianglePerimeter_Correct_Result()
    {
        // Arrange
        var a = 10.58;
        var b = 52.74;
        var c = 62.58;
        var expected_perimeter = a + b + c;    
        var factory = new PlaneShapeFactory();    
        
        // Act
        var property = new TriangleProperty(a, b, c);
        var triangleShape = factory.CreateShape(property);
            
        // Assert
        
        Assert.Equal(expected_perimeter, triangleShape.GetThePerimeter());
    }
    
}