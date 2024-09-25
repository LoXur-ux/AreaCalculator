namespace AreaCalculatorLibrary.Interfases;

/// <summary>
/// Интерфейс, определяющий фигуры.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double Calculate();
}
