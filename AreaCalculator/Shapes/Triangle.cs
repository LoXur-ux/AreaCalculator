using AreaCalculatorLibrary.Interfases;

namespace AreaCalculatorLibrary.Shapes;

/// <summary>
/// Класс фигуры Треугольник.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    /// Сторона A.
    /// </summary>
    public double A { get; set; }
    /// <summary>
    /// Сторона B.
    /// </summary>
    public double B { get; set; }
    /// <summary>
    /// Сторона C.
    /// </summary>
    public double C { get; set; }

    /// <summary>
    /// Констуктор класса Треугольник.
    /// </summary>
    /// <param name="a">Сторона A.</param>
    /// <param name="b">Сторона B.</param>
    /// <param name="c">Сторона C.</param>
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double Calculate()
    {
        // Получение площади с попмщью формулы Герона.
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    /// <summary>
    /// Является ли треугольник прямоугольным.
    /// </summary>
    /// <param name="eps">Точность определения (погрешность).</param>
    /// <returns>true - треугольник является прямоугольным; false - в противном случае.</returns>
    public bool IsRightTriangle(double eps = 0.0001)
    {
        double[] sides = [A, B, C];
        // Сортировка. Гипатенуза прямоугольного треугольника всегда больше его катетов, т.е. она будет последним элементом.
        Array.Sort(sides);

        // Определение типа треугольника с помощью теаремы Пифагора с погрешностью вычислений значений с плавающей точкой.
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < eps;
    }
}
