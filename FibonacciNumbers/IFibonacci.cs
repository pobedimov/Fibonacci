namespace FibonacciNumbers;

/// <summary>
/// Описывает интерфейс для поиска чисел Фибоначчи по условию.
/// </summary>
internal interface IFibonacci
{
    /// <summary>
    /// Производит поиск чисел Фибоначчи с заданными условиями.
    /// </summary>
    /// <param name="startNumber">Число после, которого необходим поиск чисел Финобаччи.</param>
    /// <param name="limitNumber">Количество чисел Фибоначчи.</param>
    /// <returns>Коллекция чисел Фибоначчи.</returns>
    IEnumerable<long> FibonacciMethod(int startNumber, int limitNumber);
}
