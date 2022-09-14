using System;
using System.IO;
using Xunit;

namespace PlaneShapesLibrary.Test;

public class ShapePropertiesTest
{

    [Fact]
    public void CircleProperty_Success_Result()
    {
        var r = 5;
        CircleProperty? propr;
        
        propr = new CircleProperty(r);
        
        Assert.NotNull(propr);
    }

    [Fact]
    public void CircleProperty_InvalidData_Result()
    {
        var r = -5;
        CircleProperty? propr;

        Action init = () => propr = new CircleProperty(r);
        var exception = Record.Exception(init);

        Assert.NotNull(exception);
        Assert.IsType<InvalidDataException>(exception);
    }

    [Fact]
    public void TriangleProperty_Success_Result()
    {
        var a = 5;
        var b = 12.8;
        var c = 10;
        TriangleProperty? propr;
        
        propr = new TriangleProperty(a, b, c);
        
        Assert.NotNull(propr);

    }

    [Fact]
    public void TriangleProperty_InvalidData_Result()
    {
        var a = 5;
        var b = -12.8;
        var c = 10;
        TriangleProperty? propr;
        
        Action init = () => propr = new TriangleProperty(a, b, c);
        var exception = Record.Exception(init);

        Assert.NotNull(exception);
        Assert.IsType<InvalidDataException>(exception); 
    }

    [Fact]
    public void TriangleProperty_InvalidData2_Result()
    {
        var a = 5;
        var b = 12.8;
        var c = 20;
        TriangleProperty? propr;
        
        Action init = () => propr = new TriangleProperty(a, b, c);
        var exception = Record.Exception(init);

        Assert.NotNull(exception);
        Assert.IsType<InvalidDataException>(exception);    
    }

    
}