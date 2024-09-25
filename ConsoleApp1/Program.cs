using AreaCalculatorLibrary;
using AreaCalculatorLibrary.Shapes;

var shape = ShapeFactory.CreateTriangle(3, 4, 5);
Console.WriteLine(shape.Calculate());
Console.WriteLine(shape is Triangle triangle && triangle.IsRightTriangle());

shape = ShapeFactory.CreateCircle(4.5);
Console.WriteLine(shape.Calculate());