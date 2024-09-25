using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Interfases;
using AreaCalculatorLibrary.Shapes;

namespace UnitTests;

public class ShapeTests
{
    [Fact]
    public void CalculateCircleArea_ReturnsCorrectResult()
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        double expected = Math.PI * 25;
        double actual = circle.Calculate();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateTriangleArea_ReturnsCorrectResult()
    {
        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        double expected = 6;
        double actual = triangle.Calculate();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void IsRightTriangle_ReturnsFalseForNonRightTriangle()
    {
        var triangle = new Triangle(2, 2, 3);
        Assert.False(triangle.IsRightTriangle());
    }
}