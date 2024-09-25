using AreaCalculatorLibrary.Interfases;
using AreaCalculatorLibrary.Shapes;

namespace AreaCalculatorLibrary;

/// <summary>
/// Фабрика для создания фигур.
/// </summary>
public static class ShapeFactory
{
    /// <summary>
    /// Создание круга.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Новый экземпляр класса <see cref="Circle" /> в интерфейсе <see cref="IShape" />.</returns>
    public static IShape CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    /// <summary>
    /// Создание треугольника.
    /// </summary>
    /// <param name="a">Сторона A.</param>
    /// <param name="b">Сторона B.</param>
    /// <param name="c">Сторона C.</param>
    /// <returns>Новый экземпляр класса <see cref="Circle" /> в интерфейсе <see cref="IShape" />.</returns>
    public static IShape CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }
}
