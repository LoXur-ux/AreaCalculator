using AreaCalculatorLibrary.Interfases;

namespace AreaCalculatorLibrary.Shapes;

/// <summary>
/// Класс, определяющий круг
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Констурктор класса
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <inheritdoc />
    public double Calculate()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
